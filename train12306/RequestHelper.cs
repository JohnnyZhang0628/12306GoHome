using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections.Generic;

namespace train12306
{
   public class RequestHelper
    {
        HttpWebRequest webRequest;
        HttpWebResponse webResponse;

        public static Dictionary<string, Cookie> cookies = new Dictionary<string, Cookie>();



        //回调验证证书问题
        private bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            // 总是接受    
            return true;
        }
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <param name="method">GET、POST</param>
        /// <param name="url">URL</param>
        /// <param name="data">post数据，当为get请求时,忽略</param>
        /// <returns></returns>
        public string GetData(string method, string url, string data = "")
        {
            Stream responseStream = GetStream(method, url, data);
            if (responseStream != null)
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                string result = reader.ReadToEnd();
                reader.Close();
                return result;
            }
            else
                return null;
        }
        /// <summary>
        /// 获取文件流
        /// </summary>
        /// <param name="method">GET、POST</param>
        /// <param name="url">URL</param>
        /// <param name="data">post数据，当为get请求时,忽略</param>
        public Stream GetStream(string method, string url, string data)
        {

            try
            {
                //这一句一定要写在创建连接的前面。使用回调的方法进行证书验证。
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                ServicePointManager.CheckCertificateRevocationList = true;

                webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Accept = "*/*";
                webRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
                webRequest.Referer = "https://kyfw.12306.cn/otn/leftTicket/init";
                webRequest.Headers["Origin"]= "https://kyfw.12306.cn";
                webRequest.Headers["X-Requested-With"] = "XMLHttpRequest";
                webRequest.Host = "kyfw.12306.cn";

                CookieContainer container = new CookieContainer();
                foreach (var item in cookies)
                {
                    container.Add(item.Value);
                }

                webRequest.CookieContainer = container;

                if (method.ToLower() == "get")
                {
                    webRequest.Method = "GET";
                }
                else if (method.ToLower() == "post")
                {
                    webRequest.Method = "POST";
                    webRequest.ContentType = "application/x-www-form-urlencoded";

                    byte[] buffer = Encoding.UTF8.GetBytes(data);
                    webRequest.ContentLength = buffer.Length;
                    webRequest.GetRequestStream().Write(buffer, 0, buffer.Length);
                }

                // 获取对应HTTP请求的响应
                webResponse = (HttpWebResponse)webRequest.GetResponse();
                foreach (Cookie item in webResponse.Cookies)
                {
                    if (cookies.ContainsKey(item.Name))
                        cookies[item.Name] = item;
                    else
                        cookies.Add(item.Name, item);
                }
                // 获取响应流
                return webResponse.GetResponseStream();



            }
            catch (Exception ex)
            {
                Common.WriteLog(ex);
                return null;
            }
        }

        public void AddCookie(string name,string value)
        {
            if(!cookies.ContainsKey(name))
            cookies.Add(name, new Cookie { Name = name, Value = value, Domain = "kyfw.12306.cn" });
        }
    }
}
