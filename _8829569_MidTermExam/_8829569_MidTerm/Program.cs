namespace _8829569_MidTerm;
class Program
{
    static void Main(string[] args)
    {

        try
        {
            Item str = new Item();
            str.storeAddress = "123 - drfgh street, Ontario, Canada";


            // hardcoading 3 items
            var Item1 = new Item
            {
                bookName = "harry potter",
                quantity = 100,
                price = 78
            };

            var Item2 = new Item
            {
                bookName = "GOT",
                quantity = 32,
                price = 99
            };
            var Item3 = new Item
            {
                bookName = "LOTR",
                quantity = 997,
                price = 12
            };

            List<Item> items = new List<Item>();
            items.Add(Item1);
            items.Add(Item2);
            items.Add(Item3);


            // displaying the store Information
            str.StoreInfoOutput();



            int choice = 0;
            // do-while loop for user input  
            do
            {
                Console.WriteLine("Select a option");
                Console.WriteLine("==============================");
                Console.WriteLine("1) Add new item to inventory");
                Console.WriteLine("2) Display all Books");
                Console.WriteLine("3) Delete an individual item from the inventory");
                Console.WriteLine("4) clear Inventory");
                Console.WriteLine("5) Exit");

                choice = int.Parse(Console.ReadLine());

                // option for Add new item to inventory
                if (choice == 1)
                {
                    Console.WriteLine("");

                    Console.WriteLine("Type the Book name:");
                    str.bookName = Console.ReadLine();

                    Console.WriteLine("Type the Book quantity:");
                    str.quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Type the Book price:");
                    str.price = int.Parse(Console.ReadLine());


                }
                // option for Display all books
                else if (choice == 2)
                {
                    Console.WriteLine("Displaying Books:");
                    Console.WriteLine("==============================");


                    foreach (var element in items)
                    {
                        Console.WriteLine("Book Name: " + str.bookName + "quantity: " + str.quantity + "price " + str.price);
                    }


                }
                // option for delete item from inventory
                else if (choice == 3)
                {
                    Console.WriteLine("");
                    int position;

                    Console.WriteLine("type the position of the item which needs to be removed");

                    position = int.Parse(Console.ReadLine());
                    items.RemoveAt(position);
                }
                // option for clear inventory
                else if (choice == 4)
                {
                    Console.WriteLine("Clearing entire Inventory");
                    items.Clear();

                }
                // option to exit the program
                else if (choice == 5)
                {
                    Console.WriteLine("Exiting the program!!!");
                }

                Console.WriteLine("");



            } while (choice != 5);


            // adding the items to the list
            items.Add(str);






        }
        catch (Exception e)
        {
            Console.WriteLine("Some Error Occured");
        }

    }



}
