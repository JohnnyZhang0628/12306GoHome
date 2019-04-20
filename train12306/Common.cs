using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Reflection;

namespace train12306
{
    public static class Common
    {
        public static void WriteLog(Exception ex)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine($"日期:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
                sw.WriteLine($"错误信息：{ex.Message}");
                sw.WriteLine($"错误来源：{ex.Source}");
                sw.WriteLine($"错误栈堆：{ex.StackTrace}");
            }
        }

        /// <summary>
        /// 判断字符串是否为json格式
        /// </summary>
        /// <param name="json">字符串</param>
        /// <returns></returns>
        public static bool IsJson(string json)
        {
            try
            {
                JObject.Parse(json);
                return true;
            }
            catch (Exception ex)
            {
                WriteLog(ex);
                return false;
            }
        }
        /// <summary>
        /// 获取相对于日期的时间戳
        /// </summary>
        /// <param name="date">日期</param>
        /// <returns></returns>
        public static string GetTimeSpan(DateTime date)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            return ((date.Ticks - startTime.Ticks) / 10000).ToString();
        }

        /// <summary>
        /// 执行js
        /// </summary>
        /// <param name="js">例子 function time(a, b, msg){ var sum = a + b; return new Date().getTime() + ': ' + msg + ' = ' + sum }</param>
        /// <param name="method">例子 time(a, b, 'a + b')</param>
        /// <returns></returns>
        public static string ExecJS(string js, string method)
        {
            Type obj = Type.GetTypeFromProgID("ScriptControl");
            if (obj == null) return null;
            object ScriptControl = Activator.CreateInstance(obj);
            obj.InvokeMember("Language", BindingFlags.SetProperty, null, ScriptControl, new object[] { "JavaScript" });
            obj.InvokeMember("AddCode", BindingFlags.InvokeMethod, null, ScriptControl, new object[] { js });
            return obj.InvokeMember("Eval", BindingFlags.InvokeMethod, null, ScriptControl, new object[] { method }).ToString();
        }
        public static Stream GetImageFromBase64(string base64string)
        {
            byte[] b = Convert.FromBase64String(base64string);
            MemoryStream ms = new MemoryStream(b);
            return ms;
        }

    }
}
