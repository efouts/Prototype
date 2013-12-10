using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Wall : ICanBeTheSideOfARoom
    {
        public virtual Wall Clone()
        {
            return new Wall();
        }
    }
}
