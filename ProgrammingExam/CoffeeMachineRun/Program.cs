using System;
using Household;

namespace CoffeeMachineRun
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee_Machine = new CoffeeMachine("ZhanCoffee");

            coffee_Machine.AddCoffee(50);
            coffee_Machine.AddWater(100);

            try
            {
                coffee_Machine.MakeEspresso();
                Console.WriteLine("Espresso made successfully");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }




            Console.WriteLine("Water level: " + coffee_Machine.water_Amount);
            Console.WriteLine("Coffee level: " + coffee_Machine.coffee_Amount);
            Console.WriteLine("Grounds level: " + coffee_Machine.grounds_Amount);


            coffee_Machine.MakeEspresso();


            Console.WriteLine("Water level: " + coffee_Machine.water_Amount);
            Console.WriteLine("Coffee level: " + coffee_Machine.coffee_Amount);
            Console.WriteLine("Grounds level: " + coffee_Machine.grounds_Amount);

            coffee_Machine.EmptyGrounds();
            coffee_Machine.MakeEspresso();


            Console.WriteLine("Water level: " + coffee_Machine.water_Amount);
            Console.WriteLine("Coffee level: " + coffee_Machine.coffee_Amount);
            Console.WriteLine("Grounds level: " + coffee_Machine.grounds_Amount);

        }
    }
}