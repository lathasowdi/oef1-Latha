using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef1
{
   public class Salaris
    {
        public string TypContract { get; set; }
        public double Brutto { get; set; }
        public double Btw { get; set; }

        public Salaris(string typContract = "maand", double brutto = 2440.55, double btw = .21)
        {
            TypContract = typContract;
            Brutto = brutto;
            Btw = btw;
        }

        public double Netto()
        {
            double net = Brutto - (Brutto * Btw);
            if (TypContract == "week")
            {
                net /= 4;
            }
            return net;
            
        }
        public override string ToString()
        {
            return Brutto.ToString();
        }
        
    }
}
