using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Texture
    {
        public string _name { get; set; }

        public Texture(string name)
        {
            _name = name;
            Console.WriteLine("Wczytuję texturę - plik: " + _name);
        }

        public void Display()
        {
            Console.WriteLine("Wyświetlam teksturę: " + _name);
        }
    }
}
