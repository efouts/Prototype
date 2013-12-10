using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class RoomWithABomb : Room
    {
        public override Room Clone()
        {
            return new RoomWithABomb();
        }
    }
}
