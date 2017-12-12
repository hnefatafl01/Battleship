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
        private int Hits { get; set; } = 0;
        private Boolean Sunk { get; set; } = false;
        private String[] Coords;
        public Carrier() => Coords = new String[5];
    }

    public class BattleShip : Ship
    {
        private int Hits { get; set; } = 0;
        private Boolean Sunk { get; set; } = false;
        private readonly String[] Coords;
        public BattleShip() => Coords = new String[4];
    }

    public class Cruiser : Ship
    {
        private int Hits { get; set; } = 0;
        private Boolean Sunk { get; set; } = false;
        private String[] Coords { get; }
        public Cruiser() => Coords = new String[3];
    }

    public class Submarine : Ship
    {
        int Hits { get; set; } = 0;
        public Boolean Sunk { get; set; } = false;
        public String[] Coords;
        public Submarine() => Coords = new String[3];
    }

    public class Destroyer : Ship
    {
        public int Hits { get; set; } = 0;
        public Boolean Sunk { get; set; } = false;
        public String[] Coords { get; }
        public Destroyer() => Coords = new String[2];
    }
}
