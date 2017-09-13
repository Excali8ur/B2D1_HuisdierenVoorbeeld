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
        private Schildpad padje;
        private Cavia ceeviejee;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSchildpad_Click(object sender, EventArgs e)
        {
            string n = tbNaam.Text;
            int x = Convert.ToInt32(tbX.Text);
            int y = Convert.ToInt32(tbY.Text);
            padje = new Schildpad(n, x, y);
        }

        private void btnCavia_Click(object sender, EventArgs e)
        {
            string n = tbNaam.Text;
            int x = Convert.ToInt32(tbX.Text);
            int y = Convert.ToInt32(tbY.Text);
            ceeviejee = new Cavia(n, x, y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEten_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            padje.Eten(g);
            ceeviejee.Eten(g);
        }
    }
}
