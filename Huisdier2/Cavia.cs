using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huisdier2
{
    public class Cavia: Huisdier
    {
        private int aantalPoten;

        public Cavia(string naam):base(naam)
        {

        }

        public Cavia(string naam, int x, int y) : base(naam, x, y)
        {

        }
    }
}
