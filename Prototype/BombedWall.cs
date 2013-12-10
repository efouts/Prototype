using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class BombedWall : Wall
    {
        public override Wall Clone()
        {
            return new BombedWall();
        }
    }
}
