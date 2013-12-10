using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class MazeFactory
    {
        public abstract Maze MakeMaze();
        public abstract Wall MakeWall();
        public abstract Room MakeRoom(Int32 n);
        public abstract Door MakeDoor(Room a, Room b);
    }
}
