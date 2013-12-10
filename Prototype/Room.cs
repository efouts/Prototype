using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Room
    {
        public enum Side { North, East, South, West }

        private Int32 n;
        private Dictionary<Side, ICanBeTheSideOfARoom> sides;

        public Room()
        { }

        public void SetSide(Side side, ICanBeTheSideOfARoom @object)
        {
            sides[side] = @object;
        }

        public virtual Room Clone()
        {
            return new Room();
        }

        public virtual void Initialize(Int32 n)
        {
            this.n = n;
        }
    }
}
