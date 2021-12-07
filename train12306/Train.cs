using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace train12306
{
    public class Train
    {
        private readonly string _fromStation = ConfigurationManager.AppSettings["fromStation"];

        private readonly string _toStation = ConfigurationManager.AppSettings["toStation"];

        private readonly string _date = ConfigurationManager.AppSettings["date"];

        private readonly string[] _trainNos;

        private readonly string[] _passengerNames;

        private readonly (int, string)[] _seatTypes;

        private readonly int _refreshTimes = int.Parse(ConfigurationManager.AppSettings["refreshTimes"]);

        private readonly bool _headless = bool.Parse(ConfigurationManager.AppSettings["Headless"]);

        private IPage _page;

        // 座位td单元格起始位置
        private const int _startTdNumber = 2;

        private readonly Dictionary<string, (int, string)> _seatDict = new Dictionary<string, (int, string)>
        {
            {"business_seat",(_startTdNumber,"9") },
            {"first_class_seat",(_startTdNumber+1,"M") },
            {"second_class_seat",(_startTdNumber+2,"O") },
            {"senior_soft_sleeper",(_startTdNumber+3,"6") },
            {"soft_sleeper",(_startTdNumber+4,"4") },
            {"move_sleeper",(_startTdNumber+5,"F") },
            {"hard_sleeper",(_startTdNumber+6,"3") },
            {"soft_seat",(_startTdNumber+7,"2") },
            {"hard_seat",(_startTdNumber+8,"1") },
            {"no_seat",(_startTdNumber+9,"1") }
        };

        private const char _separator = ',';

        public Train()
        {
            _trainNos = ConfigurationManager.AppSettings["trainNo"].Split(_separator);

            _passengerNames = ConfigurationManager.AppSettings["passengerName"].Split(_separator);

            var seatTypes = ConfigurationManager.AppSettings["seatType"].Split(_separator);
            _seatTypes = new (int, string)[seatTypes.Length];
            for (int i = 0; i < seatTypes.Length; i++)
            {
                _seatTypes[i] = _seatDict[seatTypes[i]];
            }
        }

        /// <summary>
        /// 开始
        /// </summary>
        /// <returns></returns>
        public async Task StartAsync()
        {
            try
            {
                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  初始化浏览器。");
                using var playwright = await Playwright.CreateAsync();
                await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
                {
                    Headless = _headless
                });

                // 设置默认窗口大小
                var context = await browser.NewContextAsync(new BrowserNewContextOptions
                {
                    ViewportSize = new ViewportSize() { Width = 1920, Height = 1080 }
                });

                _page = await context.NewPageAsync();
                await LoginAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  ${ex.Message}");
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        private async Task LoginAsync()
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  打开登录页面，等待扫码。");
            await _page.GotoAsync("https://kyfw.12306.cn/otn/resources/login.html");

            // 等待用户登录
            await _page.WaitForURLAsync("**/otn/view/index.html", new PageWaitForURLOptions
            {
                Timeout = 60 * 1000
            });

            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  扫码登录成功。");

            // 用户登陆后直接跳转买票界面
            await _page.GotoAsync("https://kyfw.12306.cn/otn/leftTicket/init?linktypeid=dc");

            await SetTicketFormAsync();
        }

        /// <summary>
        ///  设置买票的表单
        /// </summary>
        /// <returns></returns>
        private async Task SetTicketFormAsync()
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  开始设置抢票表单。");
            // 关闭弹窗
            await _page.ClickAsync("#gb_closeDefaultWarningWindowDialog_id");

            // 1、清除出发站输入框，设置焦点
            var fromStationDom = await _page.QuerySelectorAsync("#fromStationText");
            await fromStationDom.FillAsync("");
            await fromStationDom.HoverAsync();
            await fromStationDom.FocusAsync();

            // 输入出发站
            await _page.Keyboard.TypeAsync(_fromStation, new KeyboardTypeOptions { Delay = 100 });
            await _page.ClickAsync($"#panel_cities span.ralign:text-is('{_fromStation}')");

            // 2、清除目的地输入框，设置焦点
            var toStationDom = await _page.QuerySelectorAsync("#toStationText");
            await toStationDom.FillAsync("");
            await toStationDom.HoverAsync();
            await toStationDom.FocusAsync();

            // 输入目的地
            await _page.Keyboard.TypeAsync(_toStation, new KeyboardTypeOptions { Delay = 100 });
            await _page.ClickAsync($"#panel_cities span.ralign:text-is('{_toStation}')");

            // 3、输入日期
            var trainDateDom = await _page.QuerySelectorAsync("#train_date");
            await trainDateDom.FillAsync("");
            await trainDateDom.HoverAsync();
            await trainDateDom.FocusAsync();

            // 输入目的地
            await _page.Keyboard.TypeAsync(_date, new KeyboardTypeOptions { Delay = 100 });
            await _page.Keyboard.PressAsync("Enter");

            await QueryTicketAsync();
        }

        /// <summary>
        /// 查票
        /// </summary>
        /// <returns></returns>
        private async Task QueryTicketAsync()
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  开始查询余票。");

            await _page.ClickAsync("#query_ticket");

            // 等待ajax请求
            await _page.WaitForRequestFinishedAsync();

            var queryLeftTrDoms = await _page.QuerySelectorAllAsync("#queryLeftTable tr:visible");

            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  一共搜索到{queryLeftTrDoms.Count}条信息。");

            foreach (var tr in queryLeftTrDoms)
            {
                var trainNoDom = await tr.QuerySelectorAsync("td:nth-child(1) a.number");
                var trainNo = await trainNoDom.InnerTextAsync();

                if (_trainNos.Contains(trainNo))
                {
                    // 校验座位有没有票
                    foreach (var seatType in _seatTypes)
                    {
                        // var test = await tr.QuerySelectorAsync("td:nth-child(2)");

                        var seatTypeDom = await tr.QuerySelectorAsync($"td:nth-child({seatType.Item1})");

                        var ticketText = await seatTypeDom.InnerTextAsync();
                        if (HasTicket(ticketText))
                        {
                            var result = await BuyTicketAsync(tr, seatType.Item2);
                            if (result) return;
                        }
                    }
                }
            }

            Thread.Sleep(_refreshTimes);
            await QueryTicketAsync();
        }

        private async Task<bool> BuyTicketAsync(IElementHandle tr, string seatType)
        {
            Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  开始买票。");
            var buyTicketDom = await tr.QuerySelectorAsync("a.btn72");
            if (buyTicketDom != null)
            {
                await buyTicketDom.ClickAsync();

                // 等待跳转待确认界面
                await _page.WaitForURLAsync("**/otn/confirmPassenger/initDc", new PageWaitForURLOptions
                {
                    Timeout = 60 * 1000
                });


                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  加载乘客信息成功！。");

                // 选择乘车人
                foreach (var passengerName in _passengerNames)
                {
                    await _page.CheckAsync($"#normal_passenger_id label:text-is('{passengerName}')");
                }

                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  选择乘客成功！。");

                // 选择座位类型
                var ticketInfoDoms = await _page.QuerySelectorAllAsync("#ticketInfo_id tr:visible");
                int index = 1;
                foreach (var ticketInfo in ticketInfoDoms)
                {
                    var seatTypeDom = await ticketInfo.QuerySelectorAsync($"#seatType_{index}");
                    await seatTypeDom.SelectOptionAsync(seatType);
                    index++;
                }

                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  选择座位成功！。");

                // 提交订单
                await _page.ClickAsync("#submitOrder_id");

                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  提交订单成功！。");

                // 确认订单
                var submitDom = await _page.WaitForSelectorAsync("#qr_submit_id");

                // 延迟5s再点
                await submitDom.ClickAsync(new ElementHandleClickOptions { Delay = 5 * 1000 });

                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  确认订单成功！。");

                // 等待出票、支付
                await _page.WaitForURLAsync("**/otn//payOrder/init", new PageWaitForURLOptions
                {
                    Timeout = 60 * 1000
                });

                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} ---->  出票成功。恭喜你，抢票成功，请在30分钟登录12306支付。！。");

                return true;
            }
            else
                return false;
        }

        private bool HasTicket(string ticketText)
        {
            if (string.IsNullOrEmpty(ticketText))
                return false;
            else if (ticketText == "有")
                return true;
            else if (int.TryParse(ticketText, out int number))
                return number > _passengerNames.Length;
            else
                return false;
        }
    }
}