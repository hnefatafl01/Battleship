using System;
namespace Battleship
{
    public class Ship
    {
        //private int Hits { get; set; } = 0;
        //private Boolean Sunk { get; set; } = false;
        int _size;
        public int Hits { get; set; } = 0;
        public Boolean Sunk { get; set; } = false;
        public String Name { get; set; }
        public String[] Coords;

        public Ship(String _name, int size) {
            Name = _name;
            _size = size;
			Coords = new String[size];
        }
    }
}
//    public class Carrier : Ship
//    {
//        public int Hits { get; set; } = 0;
//        public Boolean Sunk { get; set; } = false;
//        public String[] Coords { get; set; }
//        public Carrier() => Coords = new String[5];
//    }

//    public class BattleShip : Ship
//    {
//        public int Hits { get; set; } = 0;
//        public Boolean Sunk { get; set; } = false;
//        public String[] Coords { get; set; }
//        public BattleShip() => Coords = new String[4];
//    }

//    public class Cruiser : Ship
//    {
//        public int Hits { get; set; } = 0;
//        public Boolean Sunk { get; set; } = false;
//        public String[] Coords { get; set; }
//        public Cruiser() => Coords = new String[3];
//    }

//    public class Submarine : Ship
//    {
//        public int Hits { get; set; } = 0;
//        public Boolean Sunk { get; set; } = false;
//        public String[] Coords { get; set; }
//        public Submarine() => Coords = new String[3];
//    }

//    public class Destroyer : Ship
//    {
//        public int Hits { get; set; } = 0;
//        public Boolean Sunk { get; set; } = false;
//        public String[] Coords { get; set; }
//        public Destroyer() => Coords = new String[2];
//    }
//}
