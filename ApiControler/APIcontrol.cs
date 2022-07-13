using System;
using System.Net.Http;
using Newtonsoft.Json;


namespace ApiControler
{
    
    public class APIcontrol
    {
        private static readonly HttpClient Client = new HttpClient();
        public Root objectRes { get; set; }
        public Root objectRes2 { get; set; }

        
        public  async void GetCity(string lat, string lon)
        {
            var responseBody = Client.GetAsync("https://api.openweathermap.org/data/2.5/weather?lat="+lat+"&lon="+lon+"&appid=0c03b0394447a4ebbec89ae06b3f3c02&units=metric").Result;
            var res = await responseBody.Content.ReadAsStringAsync();
            objectRes = JsonConvert.DeserializeObject<Root>(res);

            
        }
        public  async void GetInfo2(string city)
        {
            Console.WriteLine(city);

            var responseBody = Client.GetAsync("https://api.openweathermap.org/data/2.5/weather?q="+city+"&appid=0c03b0394447a4ebbec89ae06b3f3c02&units=metric").Result;
            var res = await responseBody.Content.ReadAsStringAsync();
            Console.WriteLine(res);
            if (res == "{\"code\":\"404\",\"message\":\"city not found\"}")
            {
                city = "Toulouse";
                responseBody = Client.GetAsync("https://api.openweathermap.org/data/2.5/weather?q="+city+"&appid=0c03b0394447a4ebbec89ae06b3f3c02&units=metric").Result;
                res = await responseBody.Content.ReadAsStringAsync();
            }
            objectRes = JsonConvert.DeserializeObject<Root>(res);
            
            
            
            responseBody = Client.GetAsync("https://api.openweathermap.org/data/2.5/forecast?q="+city+"&appid=0c03b0394447a4ebbec89ae06b3f3c02&units=metric").Result;
            res = await responseBody.Content.ReadAsStringAsync();
            objectRes2 = JsonConvert.DeserializeObject<Root>(res);
        }
        
    }
}