namespace BlazorApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly IConfiguration _config;

        public WeatherForecastService(IConfiguration config)
        {
            _config = config;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            int maxDays = _config.GetValue<int>("WeatherForecast:ForecastDays");
            return Task.FromResult(Enumerable.Range(1, maxDays).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}