using System;
namespace Battleship
{
    public class Player
    {
        private String _name;
        private int _number;
        public IDictionary _fleet = new IDictionary<string, Ship>();

        public Player(String _name, int _number)
        {
            this._name = _name;
            this._number = _number;
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
