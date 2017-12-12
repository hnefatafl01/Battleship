using System;
namespace Battleship
{
    public abstract class Ship
    {
        private int Hits { get; set; } = 0;
        private Boolean Sunk { get; set; } = false;
    }

    public class Carrier : Ship
    {
        public int Hits { get; set; } = 0;
        public Boolean Sunk { get; set; } = false;
        public String[] Coords { get; set; }
        public Carrier() => Coords = new String[5];
    }

    public class BattleShip : Ship
    {
        public int Hits { get; set; } = 0;
        public Boolean Sunk { get; set; } = false;
        public String[] Coords { get; set; }
        public BattleShip() => Coords = new String[4];
    }

    public class Cruiser : Ship
    {
        public int Hits { get; set; } = 0;
        public Boolean Sunk { get; set; } = false;
        public String[] Coords { get; set; }
        public Cruiser() => Coords = new String[3];
    }

    public class Submarine : Ship
    {
        public int Hits { get; set; } = 0;
        public Boolean Sunk { get; set; } = false;
        public String[] Coords { get; set; }
        public Submarine() => Coords = new String[3];
    }

    public class Destroyer : Ship
    {
        public int Hits { get; set; } = 0;
        public Boolean Sunk { get; set; } = false;
        public String[] Coords { get; set; }
        public Destroyer() => Coords = new String[2];
    }
}
