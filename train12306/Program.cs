using System;
using System.Windows.Forms;
using System.IO;

namespace train12306
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmLogin());
            }

            catch(Exception ex)
            {
                writeLog(ex);
            }

        }


        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs ex)
        {
            writeLog(ex.Exception);
        }

       public static void writeLog(Exception ex)
        {
            using (StreamWriter sw = new StreamWriter("../../log.txt", true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine($"日期:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
                sw.WriteLine($"错误信息：{ex.Message}");
                sw.WriteLine($"错误来源：{ex.Source}");
                sw.WriteLine($"错误栈堆：{ex.StackTrace}");
            }
        }


    }
}
