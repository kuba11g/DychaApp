using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DychaApp.Resources
{
    class StockConnection
    {
        private static string ApiKey = "YOUR_FINNHUB_API_KEY";
        private static string BasePath = "https://finnhub.io/api/v1";

        private static readonly HttpClient client = new HttpClient();

        public async Task<List<double>> GetData(string symbol)
        {
            var url = $"{BasePath}/quote?symbol={symbol}&token={ApiKey}";
            var response = client.GetStringAsync(url).Result;
            var json = JObject.Parse(response);

            List<double> data = new List<double>
            {
                (double)json["c"],  // current price
                (double)json["h"],  // high price
                (double)json["l"],  // low price
                (double)json["o"],  // open price
                (double)json["pc"], // previous close price
                (double)json["t"]   // timestamp
            };

            return data;
        }

        public async Task SetData(string symbol, Label lblCurrent, Label lblHigh, Label lblLow, Label lblOpen)
        {
            List<double> data = await GetData(symbol);

            lblCurrent.Invoke((MethodInvoker)(() => lblCurrent.Text = $"{data[0]:F2} $"));
            lblHigh.Invoke((MethodInvoker)(() => lblHigh.Text = $"{data[1]:F2} $"));
            lblLow.Invoke((MethodInvoker)(() => lblLow.Text = $"{data[2]:F2} $"));
            lblOpen.Invoke((MethodInvoker)(() => lblOpen.Text = $"{data[3]:F2} $"));
        }
    }
}
