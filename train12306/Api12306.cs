using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train12306
{
    /// <summary>
    /// 12306 api接口地址
    /// </summary>
    public static class Api12306
    {
        //域名
        public readonly static string domain = "https://kyfw.12306.cn";

        // appid
        public static string ctx = "";

        //初始化接口
        public static string init = "https://kyfw.12306.cn/otn/leftTicket/init";

        #region 12306接口会变，所有需要动态加载

        //获取验证码
        public static string passport_captcha = "";
        public static string getCaptcha()
        {
            return passport_captcha+ "64?login_site=E&module=login&rand=sjrand";
        }

        //校验验证码
        public static string passport_captcha_check = "";
        public static string getCaptchaCheck()
        {
            return passport_captcha_check + "?rand=sjrand&login_site=E";
        }

        //登录
        public static string passport_login = "";

        //获取token
        public static string passport_authuam = "";


        //授权 
        public static string passport_authclient = "";

        public static string getAuthclient()
        {
            return domain + ctx + passport_authclient;
        }

        //查询
        public static string queryTicketUrl = "";

        public static string getQuery()
        {
            return domain + ctx + queryTicketUrl;
        }

        #endregion

        // 登录状态
        public static string confUrl = "https://kyfw.12306.cn/login/conf";

        // 加载乘客信息
        public static string getPassengerUlr = "https://kyfw.12306.cn/otn/confirmPassenger/getPassengerDTOs";
        // 自动提交
        public static string autoSubmitOrderRequestUrl = "https://kyfw.12306.cn/otn/confirmPassenger/autoSubmitOrderRequest";
        // 保存队列
        public static string getQueueCountAsyncUrl = "https://kyfw.12306.cn/otn/confirmPassenger/getQueueCountAsync";
        // 确认订单
        public static string confirmSingleForQueueAsysUrl = "https://kyfw.12306.cn/otn/confirmPassenger/confirmSingleForQueueAsys";

        // 查询价格
        public static string queryTicketPrice = "https://kyfw.12306.cn/otn/leftTicket/queryTicketPrice";
        //查询停靠站
        public static string queryByTrainNo="https://kyfw.12306.cn/otn/czxx/queryByTrainNo";

    }
}
