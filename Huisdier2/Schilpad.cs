using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huisdier2
{
    public class Schildpad : Huisdier
    {
        private int aantalPoten;
        private int schildgrote;

        //Constructor:
        public Schildpad(string naam) : base(naam)
        {
            aantalPoten = 4;
            schildgrote = 10;
            leeftijd = 100;
        }

        public Schildpad(string naam, int x, int y) : base(naam, x, y)
        {
            aantalPoten = 4;
            schildgrote = 10;
            leeftijd = 100;
        }

        public override void Eten(Graphics papier)
        {
            grote += 10;
            //papier.DrawEllipse(new Pen(Color.Blue), x, y, grote, grote);
            papier.DrawRectangle(new Pen(Color.Green), x, y, grote, grote);
        }

        public void Zwemmen()
        {

        }

        public void Blazen()
        {

        }
    }
}
