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



        public void SetShip(String _shipName, Point[] _coords) 
        {
            for (int i = 0; i < _coords.Length; i++) {
				Fleet[_shipName].Coords[i] = _coords[i];
                PlayerGrid.GridLocations[_coords[i].Location].Occupier = Fleet[_shipName];
				//Console.WriteLine(Fleet[_shipName].Coords[i]);
            }
            /* View Ship Placement */
            //foreach (KeyValuePair<string, Point> kvp in PlayerGrid.GridLocations)
            //{
            //    if (kvp.Value.Occupier != null)
            //    {
            //        Console.WriteLine($"Occupier:  {kvp.Value.Occupier.Name}", kvp.Value.Occupier.Name);
            //    } else {
            //        Console.WriteLine("Occupier is null");
            //    }
            //}
        }

        public void Fire(Point _target, Grid OpponentGrid)
        {
            Console.WriteLine(OpponentGrid.GridLocations[_target.Location]);
            //for (int i = 0; i < _target.Occupier.Coords.Length; i++)
            //{
            //    PlayerGrid.GridLocations[_coords[i].Location].Occupier = Fleet[_shipName];
            //    //Console.WriteLine(Fleet[_shipName].Coords[i]);
            //}


            //Console.WriteLine($"{0}", _target.Location);
            //if (_target.Occupier == null)
            //{
            //    Console.WriteLine("Miss");
            //} else {
                //if (_target.Occupier != null)
                //{
                //    Console.WriteLine($"Target: {_target.Occupier.Name}", _target.Occupier.Name);
                //}
     //             for (int k = 0; k < kvp.Value.Coords.Length; k++)
     //             {           
					//Console.WriteLine(kvp.Value.Name);
        //          //}
        //        Console.WriteLine("Check for hit");
        //    }
        }
    }
}
