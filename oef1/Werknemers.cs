using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef1
{
    public class Werknemers
    {
        public string Naam { get; set; }
        public Salaris Geld{ get; set; }
        public  string Land { get; set; }

        public Werknemers(string naam, Salaris geld, string land = "Belgie")
        {
            Naam = naam;
            Geld = geld;
            Land = land;
        }
        public override string ToString()
        {
            return Naam; 
        }


    }
}
