using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class GameObject
    {
        public string Name { get; set; }
        List<Texture> TextureList { get; set; }

        public GameObject(string name)
        {
            Name = name;
            TextureList = new List<Texture>();
        }

        public void AddTexture(Texture texture)
        {
            TextureList.Add(texture);
        }

        public void RenderObject()
        {
            Console.WriteLine("Renderowany obiekt: " + Name);
            foreach (var item in TextureList)
            {
                item.Display();
            }
        }
    }
}
