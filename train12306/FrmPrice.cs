using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace train12306
{
    public partial class FrmPrice : Form
    {
        public FrmPrice(string train_no, string from_station_no, string to_station_no, string date,string seat_types)
        {
            InitializeComponent();
            string url = Api12306.queryTicketPrice+"?train_no="+train_no
            +"&from_station_no="+from_station_no+"&to_station_no="+to_station_no+"&seat_types="+seat_types
            +"&train_date="+date;

            RequestHelper helper = new RequestHelper();
            string json = helper.GetData("get", url);
            if (json != null&&Common.IsJson(json))
            {
                var obj = JObject.Parse(json);
                if (bool.Parse(obj["status"].ToString()))
                {
                    obj  = JObject.Parse(obj["data"].ToString());
                    List<dynamic> listResult = new List<dynamic>();
                    if (obj["A9"] != null)
                        listResult.Add(new { seat_name = "特等座", seat_price=obj["A9"] });

                    if (obj["M"] != null)
                        listResult.Add(new { seat_name = "一等座", seat_price = obj["A9"] });

                    if (obj["O"] != null)
                        listResult.Add(new { seat_name = "二等座", seat_price = obj["O"] });

                    if (obj["A6"] != null)
                        listResult.Add(new { seat_name = "高级软卧", seat_price = obj["A6"] });

                    if (obj["A4"] != null)
                        listResult.Add(new { seat_name = "软卧", seat_price = obj["A4"] });

                    if (obj["F"] != null)
                        listResult.Add(new { seat_name = "动卧", seat_price = obj["F"] });

                    if (obj["A3"] != null)
                        listResult.Add(new { seat_name = "硬卧", seat_price = obj["A3"] });

                    if (obj["A2"] != null)
                        listResult.Add(new { seat_name = "软座", seat_price = obj["A2"] });

                    if (obj["A1"] != null)
                        listResult.Add(new { seat_name = "硬座", seat_price = obj["A1"] });

                    if (obj["WZ"] != null)
                        listResult.Add(new { seat_name = "无座", seat_price = obj["WZ"] });
                    dgvPrice.DataSource = listResult;
                    dgvPrice.Columns["seat_name"].HeaderText = "座位类型";
                    dgvPrice.Columns["seat_price"].HeaderText = "价格";

                }
            }
        }
    }
}
