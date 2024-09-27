// See https://aka.ms/new-console-template for more information
using Factory;

Console.WriteLine("Garnizon");

List<Wojownik> wojownicy = new List<Wojownik>();


for (int i = 0; i < 3; i++)
{
    wojownicy.Add(Garnizon.UtworzWojownika(ProfesjaEnum.Piechur));
}

for (int i = 0; i < 3; i++)
{
    wojownicy.Add(Garnizon.UtworzWojownika(ProfesjaEnum.Konny));
}

for (int i = 0; i < 4; i++)
{
    wojownicy.Add(Garnizon.UtworzWojownika(ProfesjaEnum.Strzelec));
}

foreach (var wojownik in wojownicy)
{
    Console.WriteLine(wojownik.GetType());
}

Console.ReadKey();