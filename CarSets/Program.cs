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

            Console.WriteLine($"There are {Showroom.Count} cars in your showroom.");

            Showroom.Add("Impreza");

            Console.WriteLine($"There are {Showroom.Count} cars in your showroom.");

            Console.ReadLine();
        // Instructions
            //Create an empty HashSet named Showroom that will contain strings.
            //Add four of your favorite car model names to the set.
            //Print to the console how many cars are in your show room.
            //Pick one of the items in your show room and add it to the set again.
            //Print your showroom again, and notice how there's still only one representation
            // of that model in there.
        //Create another set named UsedLot and add two more car model strings to it.
        //Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
        //You've sold one of your cars. Remove it from the set with the Remove() method.
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
