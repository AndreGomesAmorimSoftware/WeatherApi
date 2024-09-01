using WeatherApi.Model;

namespace WeatherApi.Interfaces
{
    public interface IWeatherService
    {
        public Task<Weather> GetTemperaturesAsync(string city, string country);
    }
}
