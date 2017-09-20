using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B2D1_RobotStratenplan
{
    public partial class Form1 : Form
    {
        Robot robot;

        public Form1()
        {
            InitializeComponent();
            robot = new Robot();

            Graphics g = pictureBox1.CreateGraphics();
            robot.TekenAlles(g);
        }

        private void btnVoorwaarts_Click(object sender, EventArgs e)
        {
            robot.Voorwaarts();

            Graphics g = pictureBox1.CreateGraphics();
            
            robot.TekenAlles(g);
        }

        private void btnDraai_Click(object sender, EventArgs e)
        {
            robot.LinksOm();
        }
    }
}
