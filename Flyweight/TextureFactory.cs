using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TextureFactory
    {
        private readonly Dictionary<string, Texture> _textures = new Dictionary<string, Texture>();

        public Texture GetTextureByName(string name)
        {
            if (!_textures.ContainsKey(name))
            {
                _textures.Add(name, new Texture(name));
            }

            return _textures[name];
        }
    }
}
