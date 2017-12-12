using System;
namespace Battleship
{
    public class Grid
    {
        public Point[,] GridPoints;
        public Grid()
        {
            GridPoints = new Point[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //GridPoints[i, j];
                }
            }
        }
    }
}
