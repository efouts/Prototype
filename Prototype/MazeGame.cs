using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeFactory factory)
        {
            var aMaze = factory.MakeMaze();

            var someRoom = factory.MakeRoom(1);
            var anotherRoom = factory.MakeRoom(2);
            var theDoor = factory.MakeDoor(someRoom, anotherRoom);

            aMaze.AddRoom(someRoom);
            aMaze.AddRoom(anotherRoom);

            someRoom.SetSide(Room.Side.North, factory.MakeWall());
            someRoom.SetSide(Room.Side.East, theDoor);
            someRoom.SetSide(Room.Side.South, factory.MakeWall());
            someRoom.SetSide(Room.Side.North, factory.MakeWall());

            anotherRoom.SetSide(Room.Side.North, factory.MakeWall());
            anotherRoom.SetSide(Room.Side.East, factory.MakeWall());
            anotherRoom.SetSide(Room.Side.South, factory.MakeWall());
            anotherRoom.SetSide(Room.Side.North, theDoor);

            return aMaze;
        }
    }
}
