using System;
namespace Battleship
{
    public class Point
    {
        //public int X { get; set; }
        //public int Y { get; set; }
        public String Location { get; set; }
        public Ship Occupier { get; set; }

        public Point(String _location)
        {
            Location = _location;
            Occupier = null;
        }
        //public Point(int _x, int _y)
        //{
        //    X = _x;
        //    Y = _y;
        //}
    }
}
