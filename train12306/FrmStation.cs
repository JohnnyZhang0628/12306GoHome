using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace train12306
{
    public partial class FrmStation : Form
    {
        public FrmStation(string train_no, string from_station_no, string to_station_no, string date)
        {
            InitializeComponent();
            string url = "https://kyfw.12306.cn/otn/czxx/queryByTrainNo?train_no=" + train_no
                + "&from_station_telecode=" + from_station_no + "&to_station_telecode=" + to_station_no
                + "&depart_date=" + date;

            RequestHelper helper = new RequestHelper();
            string json = helper.GetData("get", url);
            if (json != null)
            {
                var obj = JObject.Parse(json);
                if (bool.Parse(obj["status"].ToString()))
                {
                    List<dynamic> listResult = JsonConvert.DeserializeObject<List<dynamic>>(obj["data"]["data"].ToString());
                    dgvStation.DataSource = listResult;
                    dgvStation.Columns["isEnabled"].Visible = false;
                    dgvStation.Columns["service_type"].Visible = false;
                    dgvStation.Columns["start_station_name"].Visible = false;
                    dgvStation.Columns["end_station_name"].Visible = false;
                    dgvStation.Columns["train_class_name"].Visible = false;
                    dgvStation.Columns["station_train_code"].Visible = false;


                    dgvStation.Columns["station_no"].HeaderText = "站序";
                    dgvStation.Columns["station_no"].DisplayIndex = 0;


                    dgvStation.Columns["station_name"].HeaderText = "站名";
                    dgvStation.Columns["station_name"].DisplayIndex = 1;


                    dgvStation.Columns["arrive_time"].HeaderText = "到站时间";
                    dgvStation.Columns["arrive_time"].DisplayIndex = 2;


                    dgvStation.Columns["start_time"].HeaderText = "出发时间";
                    dgvStation.Columns["start_time"].DisplayIndex = 3;


                    dgvStation.Columns["stopover_time"].HeaderText = "停留时间";
                    dgvStation.Columns["stopover_time"].DisplayIndex = 4;


                }
            }
        }
    }
}
