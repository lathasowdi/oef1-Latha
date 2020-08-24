using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oef1
{
    public partial class oef3 : Form
    {
        public oef3()
        {
            InitializeComponent();
        }
        public List<Bedrijf> BedrivenLijst = new List<Bedrijf>();
        private void oef3_Load(object sender, EventArgs e)
        {
            Bedrijf nieuwebedrijf1 = new Bedrijf("KIABI", "5223.312.344");
            BedrivenLijst.Add(nieuwebedrijf1);
            Bedrijf nieuwebedrijf2 = new Bedrijf("C&A", "6223.312.344");
            BedrivenLijst.Add(nieuwebedrijf2);
            Bedrijf nieuwebedrijf3 = new Bedrijf("H&M", "3223.312.344");
            BedrivenLijst.Add(nieuwebedrijf3);
            comboBox1.DataSource = null;
            comboBox1.DataSource = BedrivenLijst;
           
            nieuwebedrijf1.WerknemersLijst.Add(new Werknemers("Latha", new Salaris(typContract: "Week"), "Nederlands"));
            nieuwebedrijf1.WerknemersLijst.Add(new Werknemers("Atchaya", new Salaris(brutto: 4500.52), "Duitsland"));
            nieuwebedrijf1.WerknemersLijst.Add(new Werknemers("Bhavana", new Salaris(typContract: "Week")));

            nieuwebedrijf2.WerknemersLijst.Add(new Werknemers("Vishnu", new Salaris(typContract: "Week")));
            nieuwebedrijf2.WerknemersLijst.Add(new Werknemers("Vasuki", new Salaris(brutto: 3500.52), "Duitsland"));
            nieuwebedrijf2.WerknemersLijst.Add(new Werknemers("Jeyan", new Salaris(typContract: "Week")));

            nieuwebedrijf3.WerknemersLijst.Add(new Werknemers("Filip", new Salaris(typContract: "Week"), "Nederlands"));
            nieuwebedrijf3.WerknemersLijst.Add(new Werknemers("Saravana", new Salaris(brutto: 2500.52), "Duitsland"));
            nieuwebedrijf3.WerknemersLijst.Add(new Werknemers("Kamala", new Salaris(typContract: "Week")));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                comboBox2.DataSource = null;
                comboBox2.DataSource = BedrivenLijst[comboBox1.SelectedIndex].WerknemersLijst;
                label1.Text = $"BTWNUM{ BedrivenLijst[comboBox1.SelectedIndex].BtwNummer}";
            
        }
    }
    }

