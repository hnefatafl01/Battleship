using System;
using System.Collections.Generic;

namespace Battleship
{
    public class Player
    {
        private String _name { get; }
        private int _number;
        public IDictionary<string, Ship> Fleet = new Dictionary<string, Ship>();
        public Grid PlayerGrid = new Grid();

        public Player(String _name, int _number)
        {
            this._name = _name;
            this._number = _number;

            Ship carrier = new Ship("carrier", 5);
            Ship battleship = new Ship("battleship", 4);
            Ship cruiser = new Ship("cruiser", 3);
            Ship submarine = new Ship("submarine", 3);
            Ship destroyer = new Ship("destroyer", 2);

			Fleet.Add("carrier", carrier);
			Fleet.Add("battleship", battleship);
			Fleet.Add("cruiser", cruiser);
            Fleet.Add("submarine", submarine);
            Fleet.Add("destroyer", destroyer);
            /* Test lookup */
            //foreach (KeyValuePair<string, Ship> kvp in Fleet)
            //{
            //    Console.WriteLine(kvp.Value.Name);
            //}
        }

        public void SetShip(String _shipName, String[] _coords) 
        {
            for (int i = 0; i < _coords.Length; i++) {
				Fleet[_shipName].Coords[i] = _coords[i];
				Console.WriteLine(Fleet[_shipName].Coords[i]);
            }
        }
    }
}
