using System;
using System.Collections.Generic;
namespace Battleship
{
    public class Project
    {
        public static void Main(String[] args) 
        {
			Console.WriteLine("Battleship Game");

            Player p1 = new Player("Rufus", 1);
            Player p2 = new Player("Denali", 1);

            p1.SetShip("carrier", new Point[] {
                new Point("e6"),
                new Point("e7"),
                new Point("e8"),
                new Point("e9"),
                new Point("e10")
            });

            p1.SetShip("battleship", new Point[] { 
                new Point("b1"),
                new Point("c1"),
                new Point("d1"),
                new Point("e1")
            });

            p1.SetShip("cruiser", new Point[] {
                new Point("c8"),
                new Point("c9"),
                new Point("c10")
            });

            p1.SetShip("submarine", new Point[] { 
                new Point("b4"),
                new Point("b5"),
                new Point("b6")
            });

            p1.SetShip("destroyer", new Point[] {
                new Point("a1"),
                new Point("a2")
            });

            p2.Fire(new Point("a1"), p1.PlayerGrid);
            p2.Fire(new Point("a2"), p1.PlayerGrid);

            //Console.Write(p1.Fleet);
            //        Ship value;
            //        bool findShip = p1.Fleet.TryGetValue("carrier", out value);
            //        if (findShip) {
            //Ship carrier1 = value;
            //    Console.WriteLine(carrier1);
            //} else {
            //    Console.WriteLine("Not Found");
            //}
        }
    }
}
