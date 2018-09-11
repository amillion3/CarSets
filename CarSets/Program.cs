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

            HashSet<string> MatchingCars = new HashSet<string>();

            MatchingCars.UnionWith(Showroom);
            MatchingCars.IntersectWith(Junkyard);

            Console.ReadLine();

            //  Acquiring more cars
            //Now create another HashSet of cars in a variable Junkyard.Someone who owns 
            //  a junkyard full of old cars has approached you about buying the entire inventory.
            //  In the new set, add some different cars, but also add a few that are the 
            //  same as in the Showroom set.

            //Use the IntersectWith() method to see which cars exist in both the show room 
            //  and the junkyard.
            //Now you're ready to buy the cars in the junkyard. Use the UnionWith() method 
            //  to combine the junkyard into your showroom.
            //Use the Remove() method to remove any cars that you acquired from the junkyard 
            //  that you want in your showroom.
        }
    }
}
