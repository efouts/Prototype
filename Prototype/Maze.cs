using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Maze
    {
        private List<Room> rooms;

        public Maze()
        {
            rooms = new List<Room>();
        }

        public void AddRoom(Room someRoom)
        {
            rooms.Add(someRoom);
        }

        public virtual Maze Clone()
        {
            return new Maze();
        }
    }
}
