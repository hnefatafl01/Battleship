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

            //Console.Write(p1.Fleet);
    //        Ship value;
    //        bool findShip = p1.Fleet.TryGetValue("carrier", out value);
    //        if (findShip) {
				//Ship carrier1 = value;
            //    Console.WriteLine(carrier1);
            //} else {
            //    Console.WriteLine("Not Found");
            //}

            p1.SetShip("destroyer", new String[] {"a1", "a2"});
            //Console.WriteLine(p1.Fleet["destroyer"].Coords);
        }
    }
}
