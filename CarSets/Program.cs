using System;
using System.Collections.Generic;

namespace CarSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Impreza");
            Showroom.Add("Outback");
            Showroom.Add("Justy");
            Showroom.Add("Forester");

            HashSet<string> UsedLot = new HashSet<string>
            {
                { "Brat" },
                { "SVX" }
            };

            // Combines 2 cars from UsedLot with existing Showroom hashset
            Showroom.UnionWith(UsedLot);

            Showroom.Remove("Impreza");

            HashSet<string> Junkyard = new HashSet<string> {
                { "Model 3" },
                { "Explorer" },
                { "Impreza" },
                { "Brat" },
                { "Justy" },
            };

            // This HashSet will contain cars in both the Showroom and Junkyard
            HashSet<string> MatchingCars = new HashSet<string>();
            MatchingCars.UnionWith(Showroom);

            // Find cars that are in the Showroom AND the Junkyard
            MatchingCars.IntersectWith(Junkyard);

            // Combine Showroom and Junkyard, no duplicates allowed
            Showroom.UnionWith(Junkyard);


            Junkyard.IntersectWith(MatchingCars);

            Console.ReadLine();
        }
    }
}
