using Newtonsoft.Json;
using WeatherApi.Interfaces;
using WeatherApi.Model;

namespace WeatherApi.Service
{
    public class WeatherService : IWeatherService
    {
        public async Task<Weather> GetTemperaturesAsync(string city, string country)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync($"http://api.openweathermap.org/data/2.5/weather?q={city},{country}&appid=8eec19de0e1bbea1decfc7428868b7ab");

            if (!responseMessage.IsSuccessStatusCode)
                return null;

            var result = await responseMessage.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<dynamic>(result);


            return new Weather(Convert.ToDouble(obj.main.temp));
        }
    }
}
