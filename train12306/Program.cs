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
                Common.WriteLog(ex);
            }

        }


        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs ex)
        {
            Common.WriteLog(ex.Exception);
        }



    }
}
