// See https://aka.ms/new-console-template for more information

using Adapter;

Console.WriteLine("Adapter");

Teenager teenager = new Teenager("John", 10);

Adult adult = new Adult();

adult.IsAdult(teenager);

FakeAdult fakeAdult = new FakeAdult();

fakeAdult.IsAdult(teenager);


