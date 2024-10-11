using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageChains
{
    public class Car
    {
        public string GetCylinderSize()
        {
            Engine engine = GetEngine();
            Cylinder cylinder = engine.GetCylinder();
            return cylinder.GetSize();

        }

        public Engine GetEngine()
        {
            return new Engine();
        }
    }
}
