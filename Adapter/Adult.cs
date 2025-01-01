using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adult : IAdult
    {
        public virtual bool IsAdult(Teenager teenager)
        {
            if (teenager.Age >= 18)
            {
                Console.WriteLine(teenager.Name + " to osoba pełnoletnia.");
                return true;
            }

            Console.WriteLine(teenager.Name + " to osoba niepełnoletnia.");
            return false;
        }
    }
}
