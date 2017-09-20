using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2D1_RobotStratenplan
{
    public class Robot
    {
        private int xPlaats;
        private int yPlaats;
        private int xRichting;
        private int yRichting;
        private Stratenplan plan;

        public Robot()
        {
            xPlaats = 5;
            yPlaats = 10;
            xRichting = -1;
            yRichting = 0;

            plan = new Stratenplan();
        }

        public void Voorwaarts()
        {
            if (kanVoorwaarts())
            {
                xPlaats += xRichting;
                yPlaats += yRichting;
            }
        }

        public bool kanVoorwaarts()
        {
            int nieuweX = xPlaats + xRichting;
            int nieuweY = yPlaats + yRichting;

            return plan.Bevat(nieuweX, nieuweY);
        }

        public void LinksOm()
        {
            if (xRichting == -1 && yRichting == 0)
            {
                xRichting = 0;
                yRichting = -1;
            }
            else if (xRichting == 0 && yRichting == -1)
            {
                xRichting = 1;
                yRichting = 0;
            }
            else if (xRichting == 1 && yRichting == 0)
            {
                xRichting = 0;
                yRichting = 1;
            }
            else if (xRichting == 0 && yRichting == 1)
            {
                xRichting = -1;
                yRichting = 0;
            }
        }

        public int[] Toon()
        {
            return new int[2] { xPlaats, yPlaats };
        }

        public void TekenRobot(Graphics papier, int scale)
        {
            papier.FillPie(new SolidBrush(Color.LightGreen), xPlaats * scale, yPlaats * scale, scale, scale, 90, 180);

            //papier.FillPolygon

        }

        public void TekenAlles(Graphics papier)
        {
            int scale = 30;
            int maxY = 11 * scale;

            papier.Clear(Color.White);
            plan.TekenStratenplan(papier, scale);

            TekenRobot(papier, scale);

        }
    }
}
