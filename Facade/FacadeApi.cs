using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FacadeApi
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public FacadeApi(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<string> GetWeatherByCity(string city)
        {
            string url = "http://api.openweathermap.org/data/2.5/weather";
            string destinationUrl = $"{url}?q={city}&appid={_apiKey}&units=metric&lang=pl";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(destinationUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<Response>(json);

                    return $"Temperatura w mieście {city} to {result.Main.Temp}°C.";
                }
                else
                {
                    return $"Błąd: {response.StatusCode}.";
                }
            }
            catch (Exception ex)
            {
                return $"Wystąpił nieoczekiwany wyjątek, treść błędu: {ex.Message}";
            }
        }
    }
}
