namespace _8829569_LAB3;
class Program
{
    static void Main(string[] args)
    {

        bool programRunning;
        int userInput;

        // creating instance from luggage class
        Luggage list1 = new Luggage();

        // creating a list for storing inputs
        List<String> passengerList = new List<string>();

        // hardcoaded student info
        passengerList.Add(", (555) 555-5555, 2 Bags, 50.6 Average Weight");

        // initiating a menu loop for user to interact with
        do{

            // printing menu contents
            Console.WriteLine("Select an option (type the corresponding number): \n1) Add a new Passneger \n2) Display Passenger list \n3) Exit");
            // taking user input
            userInput = int.Parse(Console.ReadLine());

            // condition for adding passenger info selected
            if(userInput == 1){

                programRunning = true;

                // taking passenger info input
                Console.WriteLine("Type the First Name: ");
                list1.firstName = Console.ReadLine();

                Console.WriteLine("Type the Last Name: ");
                list1.lastName = Console.ReadLine();

                do{
                Console.WriteLine("Type the phone Number in the format (XXX) XXX-XXXX: ");
                list1.phoneNumber = Console.ReadLine();
                // checking if phone number is written in correct format or not
                list1.phoneNumberValidator(list1.phoneNumber);

                if (list1.validFormat == false){
                    Console.WriteLine("Invalid phone number format. Please try again.");
                }

                }while(list1.validFormat == false);

                Console.WriteLine("Type Number of Bags: ");
                list1.numberOfBags = int.Parse(Console.ReadLine());

                Console.WriteLine("Type Total Weight of Bags: ");
                list1.totalWeight = float.Parse(Console.ReadLine());



                
                if(list1.validFormat == true){
                passengerList.Add(list1.firstName + " " + list1.lastName + ", " + list1.phoneNumberOutput + ", " + list1.numberOfBags+ " Bags, " + list1.averageWeight(list1.numberOfBags, list1.totalWeight) + " lbs Average Weight");
                }
                else{
                    Console.WriteLine("invalid input");
                }
            }

            // condition for displaying passenger list
            if(userInput == 2){
                programRunning = true;
                foreach(String passenger in passengerList){
                    Console.WriteLine(passenger);
                }

            }

            // condition to exit
            if(userInput == 3){
                programRunning = false;
            }
            else{
                programRunning = true;
                Console.WriteLine("");
            }
        }while(programRunning == true);

    }
}
