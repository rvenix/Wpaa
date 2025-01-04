using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class MenuCategory : IMenuPosition
    {
        private string _menuCategoryName;
        private List<IMenuPosition> _items;

        public MenuCategory(string menuCategoryName)
        {
            _menuCategoryName = menuCategoryName;
            _items = new List<IMenuPosition>();
        }

        public void AddPosition(IMenuPosition menuPosition)
        {
            _items.Add(menuPosition);
        }

        public void Display()
        {
            Console.WriteLine(_menuCategoryName + ":");

            foreach (var item in _items)
            {
                item.Display();
            }

            Console.WriteLine();
        }
    }
}
