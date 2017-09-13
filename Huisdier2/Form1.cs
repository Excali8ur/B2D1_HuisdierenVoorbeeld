using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huisdier2
{
    public partial class Form1 : Form
    {
        private List<Huisdier> huisdieren;
        private Schildpad padje;
        private Cavia ceeviejee;

        public Form1()
        {
            InitializeComponent();
            huisdieren = new List<Huisdier>();
        }

        private void btnSchildpad_Click(object sender, EventArgs e)
        {
            string n = tbNaam.Text;
            int x = Convert.ToInt32(tbX.Text);
            int y = Convert.ToInt32(tbY.Text);
            padje = new Schildpad(n, x, y);
            huisdieren.Add(padje);
            UpdateLabel();
        }

        private void btnCavia_Click(object sender, EventArgs e)
        {
            string n = tbNaam.Text;
            int x = Convert.ToInt32(tbX.Text);
            int y = Convert.ToInt32(tbY.Text);
            ceeviejee = new Cavia(n, x, y);
            huisdieren.Add(ceeviejee);
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            string hTekst = "";
            for (int i = 0; i < huisdieren.Count; i++)
            {
                hTekst += huisdieren[i].Naam + "\n";
            }
            lblHuisdieren.Text = hTekst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEten_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            for (int i = 0; i < huisdieren.Count; i++)
            {
                huisdieren[i].Eten(g);
            }
        }
    }
}
