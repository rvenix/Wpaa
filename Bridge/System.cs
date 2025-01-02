using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class System
    {
        public ISystemInterface SystemInterface { get; set; }

        public void DisplayMenu()
        {
            if (SystemInterface != null)
            {
                SystemInterface.DisplayMenu();
            }
        }
    }
}
