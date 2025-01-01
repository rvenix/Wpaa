
using Proxy;

Console.WriteLine("Proxy server.");

ProxyServer proxy = new ProxyServer("P@ssw0rd");


proxy.RegisterUser(new User("test1@test.pl"));
proxy.RegisterUser(new User("test2@test.pl"));
proxy.RegisterUser(new User("test2@test.pl"));
proxy.RegisterUser(new User("test3@test.pl"));

proxy.ConfirmUser("test1@test.pl");

proxy.GetUser("test2@test.pl");
proxy.SendEmail("test2@test.pl", "test body");


proxy = new ProxyServer("BadPassword");

proxy.RegisterUser(new User("test1@test.pl"));
proxy.RegisterUser(new User("test2@test.pl"));
proxy.RegisterUser(new User("test2@test.pl"));
proxy.RegisterUser(new User("test3@test.pl"));

proxy.ConfirmUser("test1@test.pl");

proxy.GetUser("test2@test.pl");
proxy.SendEmail("test2@test.pl", "test body");


