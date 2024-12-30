using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarriorFactory;

namespace Builder
{
    public class Garnizon
    {
        public static IWarrior UtworzWojownika(ProfesjaEnum profesja, string nazwa)
        {
            switch (profesja)
            {
                case ProfesjaEnum.Konny:
                    return new Konny(nazwa);
                case ProfesjaEnum.Piechur:
                    return new Piechur(nazwa);
                case ProfesjaEnum.Strzelec:
                    return new Strzelec(nazwa);
                default: return null;
            }
        }
    }
}
