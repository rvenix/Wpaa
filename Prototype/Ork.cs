using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Ork
    {
        public string Nazwa { get; set; }

        public int Sila { get; set; }

        public Ork(string nazwa, int sila)
        {
            Nazwa = nazwa;
            Sila = sila;
        }

        public Ork Clone()
        {
            string json = JsonConvert.SerializeObject(this);

            // Deserializacja z JSON (nowy obiekt)
            return JsonConvert.DeserializeObject<Ork>(json);
        }
    }
}
