// See https://aka.ms/new-console-template for more information
using SingletonVault;

Console.WriteLine("Hello, World!");

Vault accesKey = Vault.Instance;


Console.WriteLine(accesKey.GetAccessKey());

accesKey = Vault.Instance;

Console.WriteLine(accesKey.GetAccessKey());

Console.ReadKey();
