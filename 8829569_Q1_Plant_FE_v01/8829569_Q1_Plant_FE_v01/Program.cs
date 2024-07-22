// Name: 
// Section: 1
// Version: Final
// Student Number: 8829569



// Inheritance: In interface one class adds all the properties of the class it is inheriting from. For example if a class A have properties like age, first name, last name and another class B needs those properties also, then that class B doesnt need to add those properties in that class file, those properties can be inherited from class A.

// Interface: The basic structure of a class is given by an interface. If multiple members are working on a project an interface will tell every member what the basic structure is and each member can add different functionality parallely and merge at the end.




namespace _8829569_Q1_Plant_FE_v01;
class Program
{
    static void Main(string[] args)
    {
        Flower f = new Flower();
        Tree t = new Tree();

        int menuInput;

        f.plantName = "Random flower name 1";
        f.plantType = "Random flower type 2";

        t.plantName = "Random Tree name 1";
        t.age = 12;
        do{
            Console.WriteLine("Select a menu option:");
            Console.WriteLine("type 1 to Add Flower");
            Console.WriteLine("type 2 to Add Tree");
            Console.WriteLine("type 3 to View Flower and Tree");
            Console.WriteLine("type 4 to exit");
            menuInput = int.Parse(Console.ReadLine());



            if (menuInput == 1){
                Console.WriteLine("Type Flower Name");
                f.plantName = Console.ReadLine();
                Console.WriteLine("Type Flower Height");
                f.height = int.Parse(Console.ReadLine());
            }
            if (menuInput == 2){
                Console.WriteLine("Type Tree Name");
                t.plantName = Console.ReadLine();
                Console.WriteLine("Type Tree age");
                t.age = int.Parse(Console.ReadLine());
            }
            if(menuInput == 3){
                f.ToString();
                t.ToString();
            }

        }while(menuInput != 4);

    }
}
