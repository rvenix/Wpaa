using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class MenuPosition : IMenuPosition
    {
        public string _postionName { get; set; }

        public MenuPosition(string postionName)
        {
            _postionName = postionName;
        }

        public void Display()
        {
            Console.WriteLine(_postionName);
        }
    }
}
