using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Qunaer.HttpRequest
{
    public class HttpRequest
    {
        private const string qunaer_tourlist_api = "http://apis.baidu.com/qunartravel/travellist/travellist?query={0}&page={1}";
        public static async Task<string> MainPageRequest(int page, string keyword)
        {
            HttpClient httpclient = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            string result = null;
            string api = qunaer_tourlist_api.Replace("{0}", keyword);
            api = api.Replace("{1}", page.ToString());
            httpclient.DefaultRequestHeaders.Add("apikey", "9a84555d8b243d4afa83cac9855b60e7");

            response = await httpclient.GetAsync(api);
            result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }
}
