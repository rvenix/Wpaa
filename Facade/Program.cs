using System.Runtime.InteropServices;
using Facade;

string city = "";

while (city != "exit")
{
    Console.Write("Proszę podać nazwę miasta (aby zakończyć wpisz 'exit'): ");
    city = Console.ReadLine();

    if (city == "exit")
    {
        break;
    }

    string key = "ee4cdb7deac942f9ba0838bfc2579f9f";
    var facade = new FacadeApi(key);

    string result = await facade.GetWeatherByCity(city);
    Console.WriteLine(result);
}

