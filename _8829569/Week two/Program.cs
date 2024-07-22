// See https://aka.ms/new-console-template for more information

namespace WeekTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // Displaying Question about Quantity
            Console.WriteLine("How many of the item the person purchased:");

                // Taking quantity input in float variable
            float itemQuantity = float.Parse(Console.ReadLine());

                // Displaying Question about Item name
            Console.WriteLine("The name of a Fruit or Vegetable the person purchased");
                
                // Taking input of item name
            var itemName = Console.ReadLine();

                // Displaying Question about Price  
            Console.WriteLine("What was the total weight of the item was");

                // Taking total weight input in float variable 
            float itemWeight = float.Parse(Console.ReadLine());

                // Calculating average weight 
            float averageWeight = itemWeight / itemQuantity;

                // Displaying output 
            Console.WriteLine("I purchased " + itemQuantity + " " + itemName + " with average weight of " + averageWeight + " lbs");
        }
    }
}