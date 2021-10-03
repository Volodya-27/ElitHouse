using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using WebApplication17.Data.Models;
using WebApplication17.Interfaces;

namespace WebApplication17.Data
{
    public class HouseDataApi : IHouseData
    {
        private HttpClient httpClient {  get; set; }
        string urlAPI;

        public HouseDataApi()
        {
            httpClient = new HttpClient();
        }

        public void AddHouse(House house)
        {
            urlAPI = @"https://localhost:44385/api/values";

            var r = httpClient.PostAsync(
                    requestUri: urlAPI,
                    content: new StringContent(JsonConvert.SerializeObject(house), Encoding.UTF8,
                    mediaType:"application/json")               
                ).Result;
        }

        public IEnumerable<House> GetHouse()
        {
            urlAPI = @"https://localhost:44385/api/values";
            string json = httpClient.GetStringAsync(urlAPI).Result;
            return JsonConvert.DeserializeObject<IEnumerable<House>>(json);
        }

        public void RemoveHouse(int houseId)
        {
            throw new System.NotImplementedException();
        }
    }
}
