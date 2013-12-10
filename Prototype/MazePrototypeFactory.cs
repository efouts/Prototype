using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class MazePrototypeFactory : MazeFactory
    {
        private Maze mazePrototype;
        private Wall wallPrototype;
        private Room roomPrototype;
        private Door doorPrototype;

        public MazePrototypeFactory(Maze mazePrototype, Wall wallPrototype, Room roomPrototype, Door doorPrototype)
        {
            this.mazePrototype = mazePrototype;
            this.wallPrototype = wallPrototype;
            this.roomPrototype = roomPrototype;
            this.doorPrototype = doorPrototype;
        }

        public override Maze MakeMaze()
        {
            return mazePrototype.Clone();
        }

        public override Wall MakeWall()
        {
            return wallPrototype.Clone();
        }

        public override Room MakeRoom(Int32 n)
        {
            var room = roomPrototype.Clone();
            room.Initialize(n);
            return room;
        }

        public override Door MakeDoor(Room a, Room b)
        {
            var door = doorPrototype.Clone();
            door.Initialize(a, b);
            return door;
        }
    }
}
