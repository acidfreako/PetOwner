using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace PetOwnerDataService.Service
{
    public class BaseService<T>
    {
        public string Url { get; set; }

        public async Task<List<T>> ReadAsAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://agl-developer-test.azurewebsites.net/");//TODO : move to config
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(Url).Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<List<T>>();
            }
            return null;
        }
    }
}