// See https://aka.ms/new-console-template for more information

using Prototype;

Ork ork = new Ork("Stefan", 100);

List<Ork> orks = new List<Ork>();

Random random = new Random();

for (int i = 0; i < 100; i++)
{ 
    Ork klonOrka = ork.Clone();

    klonOrka.Sila = random.Next(1, 1000);
    klonOrka.Nazwa = "Stefan" + (i + 1).ToString();

    orks.Add(klonOrka);
}


foreach (var orkItem in orks)
{
    Console.WriteLine($"Nazwa: {orkItem.Nazwa}, Siła: {orkItem.Sila}");
}

Console.ReadKey();