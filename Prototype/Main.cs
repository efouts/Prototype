using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Main
    {
        public void Run()
        {
            var mazeGame = new MazeGame();
            var plainMazeFactory = new MazePrototypeFactory(new Maze(), new Wall(), new Room(), new Door());
            var plainMaze = mazeGame.CreateMaze(plainMazeFactory);

            var bombedMazeFactory = new MazePrototypeFactory(new Maze(), new BombedWall(), new RoomWithABomb(), new Door());
            var bombedMaze = mazeGame.CreateMaze(bombedMazeFactory);
        }
    }
}
