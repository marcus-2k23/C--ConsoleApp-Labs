    class Program
    {
        static void Main(string[] args)
        {
            // creating an object for product purchased
            Grocery cart1 = new Grocery();

            Console.WriteLine("how many items did you purchase ");

            // storing the item quantity in an temperory variable to check for valid input
            string itemInfoHolder = Console.ReadLine();
            if (!int.TryParse(itemInfoHolder, out int i) || string.IsNullOrEmpty(itemInfoHolder)){
                Console.WriteLine("invalid input");
                return;
            }

            // storing the valid input in class member
            cart1.numberOfItems = int.Parse(itemInfoHolder);


            Console.WriteLine("what item did you purchase ");

            // checking if the input string is null or empty 
            cart1.itemName = Console.ReadLine();
            if(string.IsNullOrEmpty(cart1.itemName)){
                Console.WriteLine("invalid input");
                return;
            }

            Console.WriteLine("what was the total weight of the items ");

            // storing the item quantity in an temperory variable to check for valid input
            itemInfoHolder = Console.ReadLine();
            if (!float.TryParse(itemInfoHolder, out float p) || string.IsNullOrEmpty(itemInfoHolder)){
                Console.WriteLine("invalid input");
                return;
            }

            // storing the valid input in class member
            cart1.itemWeight = float.Parse(itemInfoHolder);

            // printing the final required output
            cart1.output(); Console.Write(" with average weight of "); cart1.averageWeight(); 
            
           
            
        }
    }

    
