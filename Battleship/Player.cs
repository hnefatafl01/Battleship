using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Player
    {
        private String _name;
        private int _number;
        public IDictionary<string, Ship> Fleet = new Dictionary<string, Ship>();


        public Player(String _name, int _number)
        {
            this._name = _name;
            this._number = _number;
            Carrier carrier = new Carrier();
            BattleShip battleship1 = new BattleShip();
            BattleShip battleship2 = new BattleShip();
            Destroyer destroyer1 = new Destroyer();
            Destroyer destroyer2 = new Destroyer();
            Destroyer destroyer3 = new Destroyer();

        }

        public String getPlayerName()
        {
            return this._name;
        }

        public int getPlayerNumber() 
        {
            return this._number;
        }
    }
}
