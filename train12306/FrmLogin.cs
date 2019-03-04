using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;




namespace train12306
{
    public partial class FrmLogin : Form
    {
        // 获取验证码
        readonly string getValidateUrl = "https://kyfw.12306.cn/passport/captcha/captcha-image64?login_site=E&module=login&rand=sjrand&1544537823136&callback=jQuery19108971268305393201_1544537730528";

        // 登录url
        readonly string loginUrl = "https://kyfw.12306.cn/passport/web/login";
        // 获取token 
        readonly string authUrl = "https://kyfw.12306.cn/passport/web/auth/uamtk";
        // 授权
        readonly string authClientUrl = "https://kyfw.12306.cn/otn/uamauthclient";

        RequestHelper _requestHelper = new RequestHelper();

        Brush bush = new SolidBrush(Color.Red);//填充的颜色

        string answer = "";

        public FrmLogin()
        {
            InitializeComponent();


            //加载广告
            this.Hide();
            FrmAdver adver = new FrmAdver();
            adver.Show();


            Thread.Sleep(3000);
            adver.Close();
            this.Show();


            GetValidateCode();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (username == "")
            {
                MessageBox.Show("账号不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (password == "")
            {
                MessageBox.Show("密码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (answer == "")
            {
                MessageBox.Show("验证码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckValidateCode())
            {
                return;
            }

            string json = _requestHelper.GetData("post", loginUrl, $"username={username}&password={password }&appid=otn&answer={answer}");
            if (Convert.ToInt32(JObject.Parse(json)["result_code"]) == 0)
            {
                json = _requestHelper.GetData("post", authUrl, "appid=otn");

                if (Convert.ToInt32(JObject.Parse(json)["result_code"]) == 0)
                {
                    json = _requestHelper.GetData("post", authClientUrl, "tk=" + JObject.Parse(json)["newapptk"]);
                    if (Convert.ToInt32(JObject.Parse(json)["result_code"]) == 0)
                    {
                        this.Hide();
                        FrmMain main = new FrmMain();
                        main.Show();
                    }

                }

            }
            lblError.Text = JObject.Parse(json)["result_message"].ToString();
            GetValidateCode();
        }

        void GetValidateCode()
        {
            answer = "";
            string json = _requestHelper.GetData("get", getValidateUrl);
            if (json != null)
            {
                var obj = JObject.Parse(json.Replace("/**/jQuery19108971268305393201_1544537730528(", "").Replace(");", ""));
                if (obj["result_code"].ToString() == "0")
                {
                    picValidate.Image = Image.FromStream(GetImageFromBase64(obj["image"].ToString()));
                }
                else
                    MessageBox.Show(obj["result_message"].ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("加载验证码失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        bool CheckValidateCode()
        {
            string url = "https://kyfw.12306.cn/passport/captcha/captcha-check?callback=jQuery19108008943653920897_1544618479368&answer=" + answer + "&rand=sjrand&login_site=E";
            string json = _requestHelper.GetData("get", url);
            json = json.Replace("/**/jQuery19108008943653920897_1544618479368(", "").Replace(");", "");
            if (JObject.Parse(json)["result_code"].ToString() == "4")
                return true;
            else
            {
                MessageBox.Show(JObject.Parse(json)["result_message"].ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetValidateCode();
                return false;
            }
        }

        public Stream GetImageFromBase64(string base64string)
        {
            byte[] b = Convert.FromBase64String(base64string);
            MemoryStream ms = new MemoryStream(b);
            return ms;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            GetValidateCode();
        }

        private void picValidate_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (answer == "")
                    answer += e.X.ToString() + "," + (e.Y - 40).ToString();
                else
                    answer += "," + e.X.ToString() + "," + (e.Y - 40).ToString();

                Graphics g = picValidate.CreateGraphics();
                g.FillEllipse(bush, e.X - 10, e.Y - 10, 20, 20);
            }
        }


    }
}
