using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Door : ICanBeTheSideOfARoom
    {
        private Room a;
        private Room b;

        public Door()
        { }

        public virtual Door Clone()
        {
            return new Door();
        }

        public virtual void Initialize(Room a, Room b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
