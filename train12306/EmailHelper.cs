using System;
using System.Net.Mail;
using System.Text;
using System.Configuration;

namespace train12306
{
    public class EmailHelper
    {
        private static readonly string mailFrom = ConfigurationManager.AppSettings["mailFrom"];
        private static readonly string sendusername = ConfigurationManager.AppSettings["userName"];
        private static readonly string sendpassword = ConfigurationManager.AppSettings["userPwd"];
        private static readonly string smtpserver = ConfigurationManager.AppSettings["smtpServer"];


        /// <summary>
        /// 发送一封邮件
        /// </summary>
        /// <param name="mailto">收件人；多个人用;分割</param>
        /// <param name="title">邮件标题</param>
        /// <param name="content">邮件内容</param>
        /// <returns>true is success,false is failed</returns>
        public static bool SendMail(string mailto, string title, string content)
        {
            if (mailFrom != "" && sendusername != "" && sendpassword != "" && smtpserver != "")
            {
                try
                {
                    // 邮件服务设置
                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
                    smtpClient.Host = smtpserver; //指定SMTP服务器
                    smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, sendpassword);//用户名和密码

                    // 发送邮件设置       
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(mailFrom);
                    if (!string.IsNullOrEmpty(mailto))
                    {
                        string[] arrMailTo = mailto.Split(';');
                        foreach (string item in arrMailTo)
                            mailMessage.To.Add(item);
                    }
                    mailMessage.Subject = title;//主题
                    mailMessage.Body = content;//内容
                    mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
                    mailMessage.IsBodyHtml = true;//设置为HTML格式
                    mailMessage.Priority = MailPriority.Low;//优先级
                    smtpClient.Send(mailMessage); // 发送邮件
                    return true;

                }
                catch (Exception ex)
                {
                    Common.WriteLog(ex);
                    return false;
                }
            }
            else
                return false;
        }
    }
}
