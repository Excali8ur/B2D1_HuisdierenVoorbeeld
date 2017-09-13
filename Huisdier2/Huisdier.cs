using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huisdier2
{
    public class Huisdier
    {
        //Structuur van eigenschappen:
        //<public/private> <type> <naam>;
        protected bool heeftHonger;
        protected string naam;
        protected int leeftijd;

        protected int x;
        protected int y;
        protected int grote;

        public string Naam
        {
            get => naam;
            //set => naam = value;
        }
        public int Leeftijd
        {
            get => leeftijd;
            set
            {
                if (value >= 0)
                {
                    leeftijd = value;
                }
            }
        }

        //Constructor:
        public Huisdier(string naam)
        {
            this.naam = naam;
            this.leeftijd = 0;
            this.heeftHonger = false;
        }

        public Huisdier(string naam, int x, int y)
        {
            this.naam = naam;
            this.leeftijd = 0;
            this.heeftHonger = false;
            this.x = x;
            this.y = y;
            grote = 50;
        }

        //Structuur van gedrag (methode):
        //<public/private> <returntype> <Naam>(<evt. parameters>)
        //{
        //}

        public virtual void Eten(Graphics papier)
        {
            grote += 10;
            papier.DrawEllipse(new Pen(Color.Blue), x, y, grote, grote);
        }

        public void BehoefteDoen()
        {

        }
    }
}
