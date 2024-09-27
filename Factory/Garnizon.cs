using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Garnizon
    {

        public static Wojownik UtworzWojownika(ProfesjaEnum profesja)
        {
            switch (profesja)
            {
                case ProfesjaEnum.Konny:
                    return new Konny();
                case ProfesjaEnum.Piechur:
                    return new Piechur();
                case ProfesjaEnum.Strzelec:
                    return new Strzelec();
                default: return null;
            }
        }
    }
}
