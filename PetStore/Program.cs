using PetStore.Pets;
using System;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var melba = new Dog("Melba", 60, "Medium");
            //melba.Name = "Melba";
           // melba.Size = "Medium";
           // melba.Weight = 60;
            melba.Bark();

            //property is privately settable only
            //melba.Weight -= 15;

            Console.WriteLine($"What kind of food should {melba.Name} eat");
            var typeOfFoodForMelba = Console.ReadLine();

            melba.Eat("Healthy food");

            //this won't work- can't dynamically add properties to a class in c#
            //melba.CoatType = "Short";

            var barley = new Dog("Barley", 50, "Medium");
            //barley.Name = "Barley";
            //barley.Size = "Medium";
            //barley.Weight = 50;
            barley.Bark();
            barley.Eat("Table scraps");

     
        }
    }
}
