using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public static class WeatherFacade
    {

        public static async Task<int> GetTemperatureByCity(string cityName)
        {
            string baseUrl = "https://example.com/api/resource";
            string param1 = "value1";
            string param2 = "value2";

            // Dodajemy parametry do URL
            string urlWithParams = $"{baseUrl}?param1={param1}&param2={param2}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Wysyłamy żądanie GET
                    HttpResponseMessage response = await client.GetAsync(urlWithParams);

                    // Sprawdzamy, czy odpowiedź jest pomyślna (status 200)
                    response.EnsureSuccessStatusCode();

                    // Odczytujemy zawartość odpowiedzi jako JSON
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Wyświetlamy pobrany JSON
                    Console.WriteLine("Pobrany JSON:");
                    Console.WriteLine(jsonResponse);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Wystąpił błąd przy wysyłaniu żądania:");
                    Console.WriteLine(e.Message);
                }
            }

            return 0;
        }

    }
}
