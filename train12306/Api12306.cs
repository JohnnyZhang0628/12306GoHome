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

        //二维码获取、校验
        public readonly static string url_create_qr64 = "https://kyfw.12306.cn/passport/web/create-qr64";
        public readonly static string url_checkqr = "https://kyfw.12306.cn/passport/web/checkqr";
        public readonly static string url_uamtk = "https://kyfw.12306.cn/passport/web/auth/uamtk";
        public readonly static string url_uamauthclient = "https://kyfw.12306.cn/otn/uamauthclient";
        //获取当前登陆人员信息
        public readonly static string initMy12306Api = "https://kyfw.12306.cn/otn/index/initMy12306Api";

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

        //加载设备JS
        public static string logDeviceUrl = @"https://kyfw.12306.cn/otn/HttpZF/logdevice?algID=z0nwCFNNFy&hashCode=ktoXtboV1N1b7QLOJ2jBT4oxbE813DLWRvHNs4HAuaw&FMQw=0&q4f3=zh-CN&VySQ=FGFEedI78GMFypKcUwlURrMDyqSjLXpK&VPIf=1&custID=133&VEek=unspecified&dzuS=0&yD16=0&EOQP=485390435c136bdc557f204512e80047&lEnu=3232267155&jp76=d41d8cd98f00b204e9800998ecf8427e&hAqN=Win32&platform=WEB&ks0Q=d41d8cd98f00b204e9800998ecf8427e&TeRS=1040x1920&tOHY=24xx1080x1920&Fvje=i1l1s1&q5aJ=-8&wNLf=99115dfb07133750ba677d055874de87&0aew=Mozilla/5.0%20(Windows%20NT%2010.0;%20Win64;%20x64;%20rv:66.0)%20Gecko/20100101%20Firefox/66.0&E3gR=15635e28984169d484d8807a861c9ff7&timestamp=";
        //"https://kyfw.12306.cn/otn/HttpZF/logdevice?algID=knqqubQnpP&hashCode=aN0uwGDjxJX998iyuBcBqE2W-_3Qh1HSBYxRZwLw0go&FMQw=0&q4f3=zh-CN&VPIf=1" +
        //"&custID=133&VEek=unknown&dzuS=0&yD16=0&EOQP=49a9fbfe2beb0490836324ceb234fef4&lEnu=3232240615&jp76=52d67b2a5aa5e031084733d5006cc664&hAqN=Win32&platform=WEB" +
        //"&ks0Q=d22ca0b81584fbea62237b14bd04c866&TeRS=1040x1920&tOHY=24xx1080x1920&Fvje=i1l1o1s1&q5aJ=-8&wNLf=99115dfb07133750ba677d055874de87" +
        //"&0aew=Mozilla/5.0%20(Windows%20NT%206.1;%20Win64;%20x64)%20AppleWebKit/537.36%20(KHTML,%20like%20Gecko)%20Chrome/71.0.3578.98%20Safari/537.36&E3gR=1049bff4842ef8737bcc956bed24dadb" +
        //"&timestamp=";



    }
}
