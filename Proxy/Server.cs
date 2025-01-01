using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IServer
    {
        void SendEmail(string email, string body);
        void ConfirmUser(string userName);
        User RegisterUser(User user);
        User GetUser(string userName);
    }

    class Server : IServer
    {
        private Dictionary<string, User> Users;

        public Server()
        {
            Users = new Dictionary<string, User>();
        }

        public void ConfirmUser(string userName)
        {
            if (Users.ContainsKey(userName))
            {
                Users[userName].IsConfirmed = true;
                Console.WriteLine("Użytkownik potwierdzony.");
            }
        }

        public User RegisterUser(User user)
        {
            if (Users.ContainsKey(user.UserName))
            {
                Console.WriteLine("Użytkownik istnieje");
                return Users[user.UserName];
            }
            else
            {
                Users.Add(user.UserName, user);
                Console.WriteLine("Użytkownik zarejestrowany");
                return user;
            }
        }

        public void SendEmail(string email, string body)
        {
            Console.WriteLine("Sending email...");
            Console.WriteLine("Email send");
        }

        public User GetUser(string userName)
        {
            if (Users.ContainsKey(userName))
            {
                Console.WriteLine("Użytkownik znaleziony.");
                return Users[userName];
            }
                
            Console.WriteLine("Brak użytkownika w bazie.");
            return null;
        }
    }

    class ProxyServer : IServer
    {
        private string Password = "P@ssw0rd";
        private string UserPassword;
        private Server _server = new Server();

        public ProxyServer(string userPassword)
        {
            UserPassword = userPassword;
        }

        public void ConfirmUser(string userName)
        {
            if (Password.Equals(UserPassword))
            {
                _server.ConfirmUser(userName);
            }
            else
            {
                Console.WriteLine("Brak uprawnień.");
            }
        }

        public User GetUser(string userName)
        {
            if (Password.Equals(UserPassword))
            {
                return _server.GetUser(userName);
            }
            else
            {
                Console.WriteLine("Brak uprawnień.");
                return null;
            }
        }

        public User RegisterUser(User user)
        {
            if (Password.Equals(UserPassword))
            {
                return _server.RegisterUser(user);
            }
            else
            {
                Console.WriteLine("Brak uprawnień.");
                return null;
            }
        }

        public void SendEmail(string email, string body)
        {
            if (Password.Equals(UserPassword))
            {
                _server.SendEmail(email, body);
            }
            else
            {
                Console.WriteLine("Brak uprawnień.");
            }
        }
    }

    public class User
    {
        public User(string userName)
        {
            UserName = userName;
        }
        public string UserName { get; set; }

        public bool IsConfirmed { get; set; }

    }
}
