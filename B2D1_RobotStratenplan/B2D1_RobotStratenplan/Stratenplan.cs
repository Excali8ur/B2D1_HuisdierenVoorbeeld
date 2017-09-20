using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2D1_RobotStratenplan
{
    public class Stratenplan
    {
        private int[,] plaats;

        public Stratenplan()
        {
            plaats = new int[29, 2] { { 3, 0 }, { 3, 1 } , { 3, 2 }, { 3, 3 },
                { 3, 4 }, { 3, 5 }, { 3, 6 }, { 3, 7 }, { 3, 8 }, { 3, 9 },
                { 3, 10 }, { 1, 0 }, { 2, 0 }, { 4, 0 }, { 5, 0 }, { 0, 3 },
                { 1, 3 }, { 2, 3 }, { 4, 5 }, { 5, 5 }, { 6, 5 }, { 7, 5 },
                { 1, 8 }, { 2, 8 }, { 4, 8 }, { 5, 8 }, { 6, 8 }, { 4, 10 }, { 5, 10 } };
        }

        public bool Bevat(int x, int y)
        {
            bool gevonden = false;

            for (int i = 0; i < plaats.GetLength(0) && !gevonden; i++)
            {
                if (plaats[i,0] == x && plaats[i,1] == y)
                {
                    gevonden = true;
                }
            }
            return gevonden;
        }

        /* Extra */
        public void TekenStratenplan(Graphics papier, int scale)
        {
            int radius = 5;
            int maxY = 11 * scale;

            for (int i = 0; i < plaats.GetLength(0) ; i++)
            {
                int x = plaats[i, 0] * scale;
                int y = maxY - (plaats[i, 1] * scale);
                papier.DrawEllipse(new Pen(Color.Black), x, y, radius, radius);
            }
            
        }

    }
}
