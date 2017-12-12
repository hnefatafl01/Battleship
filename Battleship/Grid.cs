using System;
namespace Battleship
{
    public class Grid
    {
        public Point[,] GridPoints;
        private readonly String[] Column = { "1","2","3","4","5","6","7","8","9","10" };
        private readonly String[] Row = { "a","b","c","d","e","f","g","h","i","j" };
        public Grid()
        {
            GridPoints = new Point[10, 10];
            for (int i = 0; i < Row.Length; i++)
            {
                for (int j = 0; j < Column.Length; j++)
                {
                    GridPoints[i, j] = new Point(i, j)
                    {
                        Location = Row[i] + Column[j]
                    };
					//Console.WriteLine(GridPoints[i, j]);
                    //Console.WriteLine(GridPoints[i, j].Location);
                }
            }
        }
    }
}
