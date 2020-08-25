using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef1
{
    public class Bedrijf
    {
        public string BedrijfNaam { get; set; }
        public string BtwNummer { get; set; }
        public List<Werknemers> WerknemersLijst { get; set; }

        public Bedrijf(string bedrijfNaam, string btwNummer)
        {
            BedrijfNaam = bedrijfNaam;
            BtwNummer = btwNummer;
            WerknemersLijst = new List<Werknemers>();
        }
        public void WerknemerRemove(Werknemers nieuwewerknemer)
        {
            WerknemersLijst.Remove(nieuwewerknemer);
        }
        public void WerknemerAdd(Werknemers nieuwewerknemer)
        {
            WerknemersLijst.Add(nieuwewerknemer);

        }
        public override string ToString()
        {
            return BedrijfNaam;
        }

        //public void WerknemerToevoegen(string naam, double salaris, string land)
        //{
        //    Werknemers nieuwewerknemer = new Werknemers(naam, salaris, land);
        //    WerknemersLijst.Add(nieuwewerknemer);
        //}
        //public string WerknemerBekijken(int index)
        //{
        //    string beschrijving;
        //    beschrijving = $"SALARIS{ WerknemersLijst[index].Salaris}" + "\n"
        //        + $"LAND{WerknemersLijst[index].Land}";
        //    return beschrijving;
        //}
       

        
    }
}
