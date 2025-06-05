using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DychaApp.Resources.Class
{
    public class StockSymbolLoader
    {
        public string Symbol { get; set; }
        public string Name { get; set; }

        public static List<StockSymbolLoader> list = new List<StockSymbolLoader>();

        public async Task Search(string key)
        {
            byte[] jsonBytes = Properties.Resources.nasdaq;
            string jsonString = Encoding.UTF8.GetString(jsonBytes);
            List<StockSymbolLoader> loadedList = JsonConvert.DeserializeObject<List<StockSymbolLoader>>(jsonString);

            list.Clear();
            foreach (StockSymbolLoader item in loadedList)
                if (item.Symbol.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0 || item.Name.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                    list.Add(item);
        }
    }
}
