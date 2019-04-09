using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Globalization;
using System.Web;
using System.Text;
using System.Media;

namespace train12306
{
    public partial class FrmMain : Form
    {


        //线程休眠时间（单位：秒）
        int timer_time = 0;
        // 默认排队等待时间
        int wait_time = 3;


        // 参数字典
        Dictionary<string, string> paramsData = new Dictionary<string, string>();
        // http请求
        RequestHelper _requestHelper = new RequestHelper();
        // 出发站、终点站 数据源
        DataTable dtStation = new DataTable();

        public FrmMain()
        {
            InitializeComponent();

            #region 初始化座位
            List<ListItem> seatList = new List<ListItem>();
            seatList.Add(new ListItem { Text = "商务座/特等座", Value = "9", ColumnName = "business_seat" });
            seatList.Add(new ListItem { Text = "一等座", Value = "M", ColumnName = "first_class_seat" });
            seatList.Add(new ListItem { Text = "二等座", Value = "O", ColumnName = "second_class_seat" });
            seatList.Add(new ListItem { Text = "高级软卧", Value = "6", ColumnName = "senior_soft_sleeper" });
            seatList.Add(new ListItem { Text = "软卧", Value = "4", ColumnName = "soft_sleeper" });
            seatList.Add(new ListItem { Text = "硬卧", Value = "3", ColumnName = "hard_sleeper" });
            seatList.Add(new ListItem { Text = "动卧", Value = "F", ColumnName = "move_sleeper" });
            seatList.Add(new ListItem { Text = "软座", Value = "2", ColumnName = "soft_seat" });
            seatList.Add(new ListItem { Text = "硬座", Value = "1", ColumnName = "hard_seat" });
            seatList.Add(new ListItem { Text = "无座", Value = "1", ColumnName = "no_seat" });

            chkSeat.DataSource = seatList;
            chkSeat.DisplayMember = "Text";
            chkSeat.ValueMember = "Value";

            #endregion

            // 默认选中普通
            radNormal.Checked = true;

            #region 加载站点
            var stations = File.ReadAllText("data/station_name.js");
            dtStation = JsonConvert.DeserializeObject<DataTable>(stations);
            cmbFromStation.DataSource = dtStation;
            cmbFromStation.DisplayMember = "cityName";
            cmbFromStation.ValueMember = "value";
            cmbFromStation.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbFromStation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cmbToStation.DataSource = dtStation.Copy();
            cmbToStation.DisplayMember = "cityName";
            cmbToStation.ValueMember = "value";
            cmbToStation.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbToStation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            #endregion


            // 加载刷新频率
            List<ListItem> timeList = new List<ListItem>();
            timeList.Add(new ListItem { Text = "1秒", Value = "1" });
            timeList.Add(new ListItem { Text = "2秒", Value = "2" });
            timeList.Add(new ListItem { Text = "3秒", Value = "3" });
            timeList.Add(new ListItem { Text = "4秒", Value = "4" });
            timeList.Add(new ListItem { Text = "5秒", Value = "5" });
            cmbTime.DataSource = timeList;
            cmbTime.DisplayMember = "Text";
            cmbTime.ValueMember = "Value";


            //设置日期范围
            trainDate.MinDate = DateTime.Now;
            trainDate.MaxDate = DateTime.Now.AddDays(29);

        }
        //查询
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string train_date = trainDate.Value.ToString("yyyy-MM-dd");
            string from_station = cmbFromStation.SelectedValue.ToString();
            if (from_station == "")
            {
                MessageBox.Show("出发站不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string to_station = cmbToStation.SelectedValue.ToString();
            if (to_station == "")
            {
                MessageBox.Show("目的站不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string purpose_codes = "ADULT";
            if (radStudent.Checked)
                purpose_codes = "0X00";

            string url = Api12306.getQuery() + $"?leftTicketDTO.train_date={ train_date }&leftTicketDTO.from_station={from_station }&leftTicketDTO.to_station={to_station }&purpose_codes={ purpose_codes}";

            string json = _requestHelper.GetData("get", url);
            if (json == null || !Common.IsJson(json))
            {
                txtMessage.AppendText("查询车票失败，网络异常！\r\n");
                return;
            }
            else
            {
                JObject obj = JObject.Parse(json);


                if (bool.Parse(obj["status"].ToString()))
                {
                    List<string> listResult = JsonConvert.DeserializeObject<List<string>>(obj["data"]["result"].ToString());
                    if (listResult != null && listResult.Count > 0)
                    {
                        List<dynamic> searchResult = new List<dynamic>();
                        foreach (var item in listResult)
                        {
                            var arr = item.Split('|');
                            if (chbG.Checked)
                            {
                                if (arr[3].IndexOf("G") == -1 && arr[3].IndexOf("D") == -1)
                                    continue;
                            }


                            searchResult.Add(new
                            {
                                train_name = arr[3], // 车次
                                from_station = arr[6], //始发、终点站
                                from_station_name = searchStationName(arr[6]),
                                to_station = arr[7],
                                to_station_name = searchStationName(arr[7]),
                                from_time = arr[8], //出发时间、到达时间
                                to_time = arr[9],
                                total_time = arr[10], //历时
                                business_seat = arr[32], //商务座   
                                first_class_seat = arr[31], //一等座
                                second_class_seat = arr[30],//二等座
                                senior_soft_sleeper = arr[21], //高级软卧
                                soft_sleeper = arr[23],//软卧
                                move_sleeper = arr[33],//动卧
                                hard_sleeper = arr[28], //硬卧
                                soft_seat = arr[24], //软座
                                hard_seat = arr[29], //硬座
                                no_seat = arr[26], //无座
                                other = arr[22], //其他

                                mark = arr[1], //备注


                                train_no = arr[2], //列车编号
                                seat_type = arr[35], //座位类型
                                from_station_no = arr[16], //当前站的编号
                                to_station_no = arr[17], //终点站的编号
                                secretStr = arr[0]
                            });
                        }
                        dgvResult.DataSource = searchResult;
                        dgvResult.AllowUserToOrderColumns = true;


                        chkTrainNo.DataSource = searchResult;
                        chkTrainNo.ValueMember = "train_no";
                        chkTrainNo.DisplayMember = "train_name";



                        dgvResult.Columns["train_name"].HeaderText = "车次";
                        dgvResult.Columns["train_name"].ToolTipText = "双击查看价格";
                        dgvResult.Columns["from_station_name"].HeaderText = "始发站";
                        dgvResult.Columns["from_station_name"].ToolTipText = "双击查看停靠站";
                        dgvResult.Columns["to_station_name"].HeaderText = "终点站";
                        dgvResult.Columns["from_time"].HeaderText = "出发时间";
                        dgvResult.Columns["to_time"].HeaderText = "到达时间";
                        dgvResult.Columns["total_time"].HeaderText = "历时";
                        dgvResult.Columns["business_seat"].HeaderText = "商务座";
                        dgvResult.Columns["first_class_seat"].HeaderText = "一等座";
                        dgvResult.Columns["second_class_seat"].HeaderText = "二等座";
                        dgvResult.Columns["senior_soft_sleeper"].HeaderText = "高级软卧";
                        dgvResult.Columns["soft_sleeper"].HeaderText = "软卧";
                        dgvResult.Columns["move_sleeper"].HeaderText = "动卧";
                        dgvResult.Columns["hard_sleeper"].HeaderText = "硬卧";
                        dgvResult.Columns["soft_seat"].HeaderText = "软座";
                        dgvResult.Columns["hard_seat"].HeaderText = "硬座";
                        dgvResult.Columns["no_seat"].HeaderText = "无座";
                        dgvResult.Columns["other"].HeaderText = "其他";
                        dgvResult.Columns["mark"].HeaderText = "备注";


                        dgvResult.Columns["from_station"].Visible = false;
                        dgvResult.Columns["to_station"].Visible = false;
                        dgvResult.Columns["train_no"].Visible = false;
                        dgvResult.Columns["seat_type"].Visible = false;
                        dgvResult.Columns["from_station_no"].Visible = false;
                        dgvResult.Columns["to_station_no"].Visible = false;
                        dgvResult.Columns["secretStr"].Visible = false;

                        dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


                    }

                }
                else
                    txtMessage.AppendText("查询车票失败，" + obj["message"].ToString() + "！\r\n");

            }
        }

        // 根据站点代号查找站点名称
        string searchStationName(string station_code)
        {
            var query = dtStation.Select($" value='{station_code}'");
            if (query != null && query.Length > 0)
            {
                return query[0]["cityName"].ToString();
            }
            else
                return "";
        }

        // 切换出发站和终点站
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string from_station = cmbFromStation.SelectedValue.ToString();
            string to_station = cmbToStation.SelectedValue.ToString();
            cmbToStation.SelectedValue = from_station;
            cmbFromStation.SelectedValue = to_station;
        }


        //刷票 1.先选乘客，2.查票,3自动提交。每一步之间隔3s左右
        // 否则出票失败
        private void btnAutoSubmit_Click(object sender, EventArgs e)
        {
            if (chkPassenger.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择乘车人！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (chkTrainNo.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择车次！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if (chkSeat.CheckedItems.Count == 0)
            {
                MessageBox.Show("请选择座位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }



            disabledForm();

            searchTimer.Interval = Convert.ToInt32(cmbTime.SelectedValue) * 1000;

            searchTimer.Start();

            BuyTicket();
        }

        private void getPassenger()
        {
            string json = _requestHelper.GetData("post", Api12306.getPassengerUlr);
            if (json != null && Common.IsJson(json))
            {
                if (bool.Parse(JObject.Parse(json)["status"].ToString()))
                {
                    List<dynamic> list = JsonConvert.DeserializeObject<List<dynamic>>(JObject.Parse(json)["data"]["normal_passengers"].ToString());
                    chkPassenger.DataSource = list;
                    chkPassenger.ValueMember = "passenger_id_no";
                    chkPassenger.DisplayMember = "passenger_name";

                    // 防止出票失败！
                    btnSearch_Click(null, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("加载联系人失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // 买票
        private void BuyTicket()
        {
            string json = _requestHelper.GetData("post", Api12306.confUrl);
            if (json != null && Common.IsJson(json))
            {
                var obj = JObject.Parse(json);

                if (obj["httpstatus"].ToString() == "200" && bool.Parse(obj["status"].ToString()))
                {
                    if (obj["data"]["is_login"].ToString() == "N")
                    {
                        MessageBox.Show("登录超时！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        searchTimer.Stop();
                        FrmLogin login = new FrmLogin();
                        login.Show();
                        this.Close();
                        return;
                    }
                }
            }
            Thread.Sleep(timer_time * 1000);
            btnSearch_Click(null, new EventArgs());
            Thread.Sleep(timer_time * 1000);


            string purpose_codes = "ADULT";
            if (radStudent.Checked)
                purpose_codes = "0X00";

            paramsData.Clear();

            foreach (var t in chkTrainNo.CheckedItems)
            {
                var train = JObject.FromObject(t);
                foreach (var s in chkSeat.CheckedItems)
                {
                    var seat = JObject.FromObject(s);
                    string ticketNum = train[seat["ColumnName"].ToString()].ToString();
                    int result = 0;
                    if (int.TryParse(ticketNum, out result) || ticketNum == "有")
                    {
                        if (ticketNum == "有" || result >= chkPassenger.CheckedItems.Count)
                        {
                            // 自动提交信息

                            txtMessage.AppendText($"查询到{ train["from_station_name"].ToString()}" +
                $"到{train["to_station_name"].ToString()}的{train["train_name"].ToString()}列车。正在为您提交。。。\r\n");
                            paramsData.Add("secretStr", train["secretStr"].ToString());
                            paramsData.Add("train_date", trainDate.Value.ToString("yyyy-MM-dd"));
                            paramsData.Add("tour_flag", "dc");
                            paramsData.Add("purpose_codes", purpose_codes);
                            paramsData.Add("query_from_station_name", cmbFromStation.Text.ToString());
                            paramsData.Add("query_to_station_name", cmbToStation.Text.ToString());
                            paramsData.Add("cancel_flag", "2");
                            paramsData.Add("bed_level_order_num", "000000000000000000000000000000");

                            string passengerTicketStr = "";
                            string oldPassengerStr = "";

                            foreach (var p in chkPassenger.CheckedItems)
                            {
                                var passenger = JObject.FromObject(p);
                                passengerTicketStr += seat["Value"].ToString() + "," + passenger["passenger_flag"].ToString() + "," + passenger["passenger_type"].ToString()
                                    + "," + passenger["passenger_name"].ToString() + "," + passenger["passenger_id_type_code"].ToString() + "," + passenger["passenger_id_no"].ToString()
                                    + "," + passenger["mobile_no"].ToString() + ",N_";
                                oldPassengerStr += passenger["passenger_name"].ToString() + "," + passenger["passenger_type"].ToString() + "," + passenger["passenger_id_no"].ToString()
                                    + "," + passenger["passenger_id_type_code"].ToString() + "_";
                            }

                            if (passengerTicketStr != "")
                                passengerTicketStr = passengerTicketStr.Substring(0, passengerTicketStr.Length - 1);

                            paramsData.Add("passengerTicketStr", passengerTicketStr);
                            paramsData.Add("oldPassengerStr", oldPassengerStr);

                            json = _requestHelper.GetData("post", Api12306.autoSubmitOrderRequestUrl, parseDicToParams(paramsData));
                            Thread.Sleep(timer_time * 1000);

                            if (json != null && Common.IsJson(json))
                            {
                                var obj = JObject.Parse(json);

                                if (obj["httpstatus"].ToString() == "200" && bool.Parse(obj["status"].ToString()))
                                {

                                    string[] resultList = obj["data"]["result"].ToString().Split('#');


                                    #region 保存到队列中
                                    paramsData.Clear();

                                    if (obj["data"]["ifShowPassCode"].ToString() == "Y")
                                    {
                                        int ifShowPassCodeTime = Convert.ToInt32(obj["data"]["ifShowPassCodeTime"]);
                                        int intervalTime = ifShowPassCodeTime / wait_time;
                                        while (wait_time != 0)
                                        {
                                            wait_time--;
                                            Thread.Sleep(intervalTime);
                                        }
                                    }



                                    paramsData.Add("train_date", getStandardTime());
                                    paramsData.Add("train_no", train["train_no"].ToString());

                                    paramsData.Add("stationTrainCode", train["train_name"].ToString());

                                    paramsData.Add("seatType", seat["Value"].ToString());

                                    paramsData.Add("fromStationTelecode", train["from_station"].ToString());
                                    paramsData.Add("toStationTelecode", train["to_station"].ToString());
                                    paramsData.Add("leftTicket", resultList[2]);
                                    paramsData.Add("purpose_codes", purpose_codes);
                                    paramsData.Add("_json_att", "");


                                    json = _requestHelper.GetData("post", Api12306.getQueueCountAsyncUrl, parseDicToParams(paramsData));
                                    Thread.Sleep(timer_time * 1000);
                                    if (json != null && Common.IsJson(json))
                                    {
                                        obj = JObject.Parse(json);
                                        if (obj["httpstatus"].ToString() == "200" && bool.Parse(obj["status"].ToString()))
                                        {

                                            #region 确认订单

                                            paramsData.Clear();
                                            paramsData.Add("passengerTicketStr", HttpUtility.UrlEncode(passengerTicketStr, Encoding.UTF8).ToUpper());
                                            paramsData.Add("oldPassengerStr", HttpUtility.UrlEncode(oldPassengerStr, Encoding.UTF8).ToUpper());
                                            paramsData.Add("randCode", "");
                                            paramsData.Add("purpose_codes", purpose_codes);
                                            paramsData.Add("key_check_isChange", resultList[1]);
                                            paramsData.Add("leftTicketStr", resultList[2]);
                                            paramsData.Add("train_location", resultList[0]);
                                            paramsData.Add("choose_seats", "");
                                            paramsData.Add("seatDetailType", "");
                                            paramsData.Add("_json_att", "");

                                            json = _requestHelper.GetData("post", Api12306.confirmSingleForQueueAsysUrl, parseDicToParams(paramsData));
                                            if (json != null && Common.IsJson(json))
                                            {
                                                obj = JObject.Parse(json);

                                                if (obj["httpstatus"].ToString() == "200" && bool.Parse(obj["status"].ToString()))
                                                {

                                                    if (bool.Parse(obj["data"]["submitStatus"].ToString()))
                                                    {
                                                        txtMessage.AppendText("刷票成功，请在30分钟去12306官网支付订单。\r\n");
                                                        btnStop_Click(null, null);
                                                        #region 发送邮件和播放背景音乐
                                                        playMusic();
                                                        if (txtEmail.Text != "")
                                                        {
                                                            EmailHelper.SendMail(txtEmail.Text, "抢票成功！",
                                                                $"【归途】提醒您，您成功抢到{train["from_station_name"].ToString()}" +
                                                                $"到{train["to_station_name"].ToString()}的{train["train_name"].ToString()}列车。出发时间为：{train["from_time"].ToString()}" +
                                                                $",到达时间为：{train["to_time"].ToString()}。请您在30分钟内登录12306去支付订单，为期作废！");
                                                        }
                                                        #endregion
                                                    }
                                                    else
                                                        txtMessage.AppendText(obj["data"]["errMsg"].ToString() + "\r\n");




                                                }
                                                else
                                                    txtMessage.AppendText(JArray.Parse(obj["messages"].ToString())[0].ToString() + "\r\n");

                                            }

                                            #endregion
                                        }
                                        else
                                            txtMessage.AppendText(JArray.Parse(obj["messages"].ToString())[0].ToString() + "\r\n");
                                    }

                                    #endregion
                                }
                                else
                                    txtMessage.AppendText(JArray.Parse(obj["messages"].ToString())[0].ToString() + "\r\n");
                            }


                        }
                        else
                            txtMessage.AppendText($"未查询到{ train["from_station_name"].ToString()}" +
                                            $"到{train["to_station_name"].ToString()}的{train["train_name"].ToString()}列车。\r\n");
                    }


                }

            }


        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
                e.Cancel = true;

        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmLogin login = new FrmLogin();
            login.Show();

            this.Close();
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.Show();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            chkPassenger.Enabled = true;
            chkSeat.Enabled = true;
            chkTrainNo.Enabled = true;
            cmbTime.Enabled = true;
            btnAutoSubmit.Enabled = true;
            btnStop.Enabled = false;

            cmbFromStation.Enabled = true;
            cmbToStation.Enabled = true;
            pictureBox1.Enabled = true;
            trainDate.Enabled = true;
            chbG.Enabled = true;
            radNormal.Enabled = true;
            radStudent.Enabled = true;
            btnSearch.Enabled = true;
            searchTimer.Stop();
        }

        void disabledForm()
        {
            chkPassenger.Enabled = false;
            chkSeat.Enabled = false;
            chkTrainNo.Enabled = false;
            cmbTime.Enabled = false;
            btnAutoSubmit.Enabled = false;
            btnStop.Enabled = true;

            cmbFromStation.Enabled = false;
            cmbToStation.Enabled = false;
            pictureBox1.Enabled = false;
            trainDate.Enabled = false;
            chbG.Enabled = false;
            radNormal.Enabled = false;
            radStudent.Enabled = false;
            btnSearch.Enabled = false;
        }

        // 将字典转化为string
        string parseDicToParams(Dictionary<string, string> dic)
        {
            string result = "";
            foreach (var item in dic)
            {
                result += item.Key + "=" + item.Value + "&";
            }

            if (result != "")
                result = result.Substring(0, result.Length - 1);

            return result;

        }


        string getStandardTime()
        {
            return (trainDate.Value.ToString("ddd MMM dd yyy ", DateTimeFormatInfo.InvariantInfo) +
                DateTime.Now.ToString("HH:mm:ss").Replace(":", "%3A") +
                " GMT%2B0800 (%E4%B8%AD%E5%9B%BD%E6%A0%87%E5%87%86%E6%97%B6%E9%97%B4)").Replace(' ', '+');
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            BuyTicket();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //加载乘客
            getPassenger();
            Thread.Sleep(timer_time * 1000);
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                // 查看票价
                string train_no = dgvResult.Rows[e.RowIndex].Cells["train_no"].Value.ToString();
                string from_station_no = dgvResult.Rows[e.RowIndex].Cells["from_station_no"].Value.ToString();
                string to_station_no = dgvResult.Rows[e.RowIndex].Cells["to_station_no"].Value.ToString();
                string date = trainDate.Value.ToString("yyyy-MM-dd");
                string seat_types = dgvResult.Rows[e.RowIndex].Cells["seat_type"].Value.ToString();
                FrmPrice price = new FrmPrice(train_no, from_station_no, to_station_no, date, seat_types);
                price.Show();

            }
            else if (e.ColumnIndex == 2 && e.RowIndex > -1)
            {
                // 查看站点
                string train_no = dgvResult.Rows[e.RowIndex].Cells["train_no"].Value.ToString();
                string from_station_no = dgvResult.Rows[e.RowIndex].Cells["from_station"].Value.ToString();
                string to_station_no = dgvResult.Rows[e.RowIndex].Cells["to_station"].Value.ToString();
                string date = trainDate.Value.ToString("yyyy-MM-dd");
                FrmStation station = new FrmStation(train_no, from_station_no, to_station_no, date);
                station.Show();
            }
        }

        //播放背景音乐
        public void playMusic()
        {
            string bgmPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bgm", "message.wav");
            if (File.Exists(bgmPath))
            {
                // 设置背景音乐循环播放五秒
                int seconds = DateTime.Now.Second + 5;
                SoundPlayer player = new SoundPlayer(bgmPath);
                player.PlayLooping();

                while (DateTime.Now.Second < seconds)
                {

                }

                player.Stop();
                player.Dispose();
            }
        }
    }






    public class ListItem
    {

        public string Text { get; set; }
        public string Value { get; set; }

        public string ColumnName { get; set; }
    }


}
