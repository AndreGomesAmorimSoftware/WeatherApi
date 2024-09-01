namespace WeatherApi.Model
{
    public class Weather
    {
        public double Kelvin { get; set; }
        public double Celsio => (double)(Kelvin - 273);
        public double Fahrenheit => (double)(((Kelvin - 273) * 1.8) + 32);

        public Weather(double kelvin)
        {
            Kelvin = kelvin;
        }
    }
}
