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

            Werknemers nw1 = new Werknemers("Latha", new Salaris(typContract: "Week"), "Nederlands");
            Werknemers nw2 = new Werknemers("Atchaya", new Salaris(brutto: 4500.52), "Duitsland");
            Werknemers nw3 = new Werknemers("Bhavana", new Salaris(typContract: "Week"));

            nieuwebedrijf1.WerknemersLijst.Add(nw1);
            nieuwebedrijf1.WerknemersLijst.Add(nw2);
            nieuwebedrijf1.WerknemersLijst.Add(nw3);

            Werknemers nw4 = new Werknemers("Vishnu", new Salaris(typContract: "Week"));
            Werknemers nw5 = new Werknemers("Vasuki", new Salaris(brutto: 3500.52), "Duitsland");
            Werknemers nw6 = new Werknemers("Jeyan", new Salaris(typContract: "Week"));

            nieuwebedrijf2.WerknemersLijst.Add(nw4);
            nieuwebedrijf2.WerknemersLijst.Add(nw5);
            nieuwebedrijf2.WerknemersLijst.Add(nw6);

            Werknemers nw7 = new Werknemers("Filip", new Salaris(typContract: "Week"), "Nederlands");
            Werknemers nw8 = new Werknemers("Saravana", new Salaris(brutto: 2500.52), "Duitsland");
            Werknemers nw9 = new Werknemers("Kamala", new Salaris(typContract: "Week"));

            nieuwebedrijf3.WerknemersLijst.Add(nw7);
            nieuwebedrijf3.WerknemersLijst.Add(nw8);
            nieuwebedrijf3.WerknemersLijst.Add(nw9);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (comboBox1.SelectedIndex< 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        
                comboBox2.DataSource = null;
                comboBox2.DataSource = BedrivenLijst[comboBox1.SelectedIndex].WerknemersLijst;
                label1.Text = $"BTWNUM{ BedrivenLijst[comboBox1.SelectedIndex].BtwNummer}";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BedrivenLijst[comboBox1.SelectedIndex].WerknemerRemove(comboBox2.SelectedItem as Werknemers);
            comboBox2.DataSource = null;
            comboBox2.DataSource= BedrivenLijst[comboBox1.SelectedIndex].WerknemersLijst;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex < 0)
            {
                comboBox2.SelectedIndex = 0;
            }
            label2.Text= $"LAND:{ BedrivenLijst[comboBox1.SelectedIndex].WerknemersLijst[comboBox2.SelectedIndex].Land}";
            label3.Text = $"Brutto:{BedrivenLijst[comboBox1.SelectedIndex].WerknemersLijst[comboBox2.SelectedIndex].Geld.Brutto}";
            label4.Text = $"Netto:{BedrivenLijst[comboBox1.SelectedIndex].WerknemersLijst[comboBox2.SelectedIndex].Geld.Netto()}";
            label5.Text = $"TypContract:{ BedrivenLijst[comboBox1.SelectedIndex].WerknemersLijst[comboBox2.SelectedIndex].Geld.TypContract}";
            label6.Text = $"BTW:{ BedrivenLijst[comboBox1.SelectedIndex].WerknemersLijst[comboBox2.SelectedIndex].Geld.Btw}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WerknemerAdd oef = new WerknemerAdd();
            if(oef.ShowDialog() == DialogResult.OK)
            {
                string contract = "";
                foreach(var item in oef.groupBox1.Controls.OfType<RadioButton>())
                {
                    if (item.Checked)
                        contract = item.Text;
                }
                BedrivenLijst[comboBox1.SelectedIndex].WerknemerAdd(new Werknemers(oef.textBox1.Text, new Salaris(contract,(double)oef.numericUpDown1.Value, (double)oef.numericUpDown2.Value), oef.textBox2.Text));
                comboBox2.DataSource = null;
                comboBox2.DataSource = BedrivenLijst[comboBox1.SelectedIndex].WerknemersLijst;
            }
        }
    }
    }

