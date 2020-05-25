using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace _38.FacebookApi
{
    public class FacebookApi
    {
        private string fb_token;
        private const string fb_address = "https://graph.facebook.com/";

        public FacebookApi(string fbtoken) => (fb_token)=(fbtoken);

        public async Task<string> ObtenerInfo(string fields){
            using (var httpclient = new HttpClient()){
                httpclient.BaseAddress = new Uri(fb_address);
                var result = await httpclient.GetAsync($"me?fields={fields}&access_token={fb_token}");
                var msg = result.EnsureSuccessStatusCode();
                return await msg.Content.ReadAsStringAsync();
            }
        }
    }

}
