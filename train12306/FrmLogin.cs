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


        RequestHelper _requestHelper = new RequestHelper();

        Brush bush = new SolidBrush(Color.Red);//填充的颜色

        string answer = ""; //验证码答案

        public FrmLogin()
        {
            InitializeComponent();

            //加载广告
            this.Hide();
            FrmAdver adver = new FrmAdver();
            adver.Show();

            //加载设备id
            string json = _requestHelper.GetData("get", Api12306.logDeviceUrl + Common.GetTimeSpan(DateTime.Now));
            if (json != null)
            {
                json = json.Replace("callbackFunction('", "").Replace("')", "");
                if (Common.IsJson(json))
                {
                    // 添加设备cookie
                    var obj = JObject.Parse(json);
                    _requestHelper.AddCookie("RAIL_EXPIRATION", obj["exp"].ToString());
                    _requestHelper.AddCookie("RAIL_DEVICEID", obj["dfp"].ToString());
                }
                else
                {
                    MessageBox.Show("获取设备信息失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("获取设备信息失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //动态加载查票url
            using (StreamReader sr = new StreamReader(_requestHelper.GetStream("get", Api12306.init, "")))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (line.IndexOf("ctx") > -1)
                    {
                        Api12306.ctx = line.Split('=')[1].Replace(" ", "").Replace(";", "").Replace("'", "");
                    }

                    if (line.IndexOf("CLeftTicketUrl ") > -1)
                    {
                        Api12306.queryTicketUrl = line.Split('=')[1].Replace(" ", "").Replace(";", "").Replace("'", "");
                    }
                    if (line.IndexOf("passport_login ") > -1)
                    {
                        Api12306.passport_login = line.Split('=')[1].Replace(" ", "").Replace(";", "").Replace("'", "");
                    }
                    if (line.IndexOf("passport_captcha ") > -1)
                    {
                        Api12306.passport_captcha = line.Split('=')[1].Replace(" ", "").Replace(";", "").Replace("'", "");
                    }

                    if (line.IndexOf("passport_authuam ") > -1)
                    {
                        Api12306.passport_authuam = line.Split('=')[1].Replace(" ", "").Replace(";", "").Replace("'", "");
                    }
                    if (line.IndexOf("passport_captcha_check ") > -1)
                    {
                        Api12306.passport_captcha_check = line.Split('=')[1].Replace(" ", "").Replace(";", "").Replace("'", "");
                    }
                    if (line.IndexOf("passport_authclient ") > -1)
                    {
                        Api12306.passport_authclient = line.Split('=')[1].Replace(" ", "").Replace(";", "").Replace("'", "");
                    }

                    line = sr.ReadLine();
                }
            }

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

            //if (answer == "")
            //{
            //    MessageBox.Show("验证码不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            if (!CheckValidateCode())
            {
                return;
            }

            string json = _requestHelper.GetData("post", Api12306.passport_login, $"username={username}&password={password }&appid=otn&answer={answer}");
            if (json != null && Common.IsJson(json))
            {
                if (Convert.ToInt32(JObject.Parse(json)["result_code"]) == 0)
                {
                    json = _requestHelper.GetData("post", Api12306.passport_authuam, "appid=otn");

                    if (Convert.ToInt32(JObject.Parse(json)["result_code"]) == 0)
                    {
                        json = _requestHelper.GetData("post", Api12306.getAuthclient(), "tk=" + JObject.Parse(json)["newapptk"]);
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
            else
            {
                MessageBox.Show("登录失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetValidateCode();
            }
        }

        void GetValidateCode()
        {
            //清空选中图片
            foreach (Control c in picValidate.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    c.Controls.Clear();
                }
            }
            answer = "";
            string json = _requestHelper.GetData("get", Api12306.getCaptcha());
            if (json != null && Common.IsJson(json))
            {
                var obj = JObject.Parse(json);
                if (obj["result_code"].ToString() == "0")
                {
                    picValidate.Image = Image.FromStream(GetImageFromBase64(obj["image"].ToString()));
                }
                else
                {
                    MessageBox.Show(obj["result_message"].ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetValidateCode();
                }
            }
            else
            {
                MessageBox.Show("加载验证码失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetValidateCode();
            }

        }

        bool CheckValidateCode()
        {
            //获取选中图片坐标
            foreach (Control c in picValidate.Controls)
            {
                if (c.Controls.Count > 0)
                {
                    answer += (c.Location.X + 25).ToString() + "," + (c.Location.Y + 25).ToString() + ",";
                }
            }
            string json = _requestHelper.GetData("get", Api12306.getCaptchaCheck() + "&answer=" + answer);
            if (json != null && Common.IsJson(json))
            {
                if (JObject.Parse(json)["result_code"].ToString() == "4")
                    return true;
                else
                {
                    MessageBox.Show(JObject.Parse(json)["result_message"].ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetValidateCode();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("网络异常！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //private void picValidate_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        if (answer == "")
        //            answer += e.X.ToString() + "," + (e.Y - 40).ToString();
        //        else
        //            answer += "," + e.X.ToString() + "," + (e.Y - 40).ToString();

        //        Graphics g = picValidate.CreateGraphics();
        //        g.FillEllipse(bush, e.X - 10, e.Y - 10, 20, 20);
        //    }
        //}

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            int x = 5;
            int y = 40;
            for (int i = 1; i < 9; i++)
            {
                PictureBox pc = new PictureBox();
                pc.Name = "p" + i.ToString();
                pc.Size = new Size(68, 68);
                pc.Parent = this.picValidate;
                pc.Tag = "false";
                pc.Click += new System.EventHandler(pictureBox_Click);
                pc.BackColor = Color.Transparent;// Color.Wheat; //
                pc.Location = new Point(x, y);
                x = x + 72;
                if (i == 4)
                {
                    x = 5;
                    y = 113;
                }
            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pc = sender as PictureBox;
            if (pc.Controls.Count > 0)
            {
                pc.Controls.Clear();
            }
            else
            {
                PictureBox cp = new PictureBox();
                cp.Size = new Size(25, 25);
                cp.BackColor = Color.Transparent;
                cp.Image = Properties.Resources.chlogo;
                cp.Parent = pc;
                cp.Location = new Point(25, 25);
                cp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                cp.Click += new System.EventHandler(cp_Click);
            }
        }
        private void cp_Click(object sender, EventArgs e)
        {
            PictureBox cp = sender as PictureBox;
            cp.Parent.Controls.Clear();
        }
    }
}
