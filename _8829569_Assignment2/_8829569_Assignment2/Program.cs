namespace _8829569_Assignment2;
class Program
{
    static void Main(string[] args)
    {

        int clientNumberLength;

        List<Appointment> appointments = new List<Appointment>();

        ServiceProvided service1 = new ServiceProvided(){
            serviceName = "Gym access",
            price = 29.99
        };

        ServiceProvided service2 = new ServiceProvided(){
            serviceName = "Group fitness classes",
            price = 49.99
        };

        ServiceProvided service3 = new ServiceProvided(){
            serviceName = "Personal training sessions",
            price = 79.99
        };

        ServiceProvided specService1 = new ServiceProvided(){
            serviceName = "Sauna access",
            price = 9.99
        };

        ServiceProvided specService2 = new ServiceProvided(){
            serviceName = "Tanning sessions",
            price = 14.99
        };

        ServiceProvided specService3 = new ServiceProvided(){
            serviceName = "Spa access",
            price = 99.99
        };
        

        int option = 0;
        do{
            option = mainMenu();


            // creating an appointment
            if(option == 1){
                Appointment ap = new Appointment();

                Console.WriteLine("Name: ");
                ap.name = Console.ReadLine();

                Console.WriteLine("Phone Number: ");
                ap.phoneNumber = int.Parse(Console.ReadLine());
                    
                    
                // taking client number input and validating it.
                Console.WriteLine("Client Number (Enter 10 digits in the format xxxxxxxxxx): ");
                clientNumberLength = int.Parse(Console.ReadLine());
                if(clientNumberLength.ToString().Length == 10){
                    ap.clientNumber = clientNumberLength.ToString();
                }
                else{
                    Console.WriteLine("invalid input");
                    break;
                }
                
                // asking for client type
                Console.WriteLine("Client Type: 1) regular \n2) Premium \n3) VIP");
                int clientTypeInput = int.Parse(Console.ReadLine());
                if(clientTypeInput == 1){
                    ap.clientType = "regular";
                }
                else if(clientTypeInput == 2){
                    ap.clientType = "premium";
                }
                else if(clientTypeInput == 3){
                    ap.clientType = "vip";
                }



                int serviceAdd = 0;
                int serviceCount = 0;

                // taking service input for client for each client type
                do{
                    // adding services for regular client
                   if(ap.clientType == "regular"){
                        Console.WriteLine("Select your required service");
                        Console.WriteLine("=======================================");

                        Console.WriteLine("1) Gym access - $29.99/month");
                        Console.WriteLine("2) Group fitness classes - $49.99/month");
                        Console.WriteLine("3) Personal training sessions - $79.99/hour");
                        Console.WriteLine("4) Sauna access - $9.99/month");
                        Console.WriteLine("5) DONE");        

                        serviceAdd = int.Parse(Console.ReadLine());

                        if (serviceAdd == 1 && serviceCount <= 8){
                            ap.services.Add(service1);
                        }
                        else if (serviceAdd == 2 && serviceCount <= 8){
                            ap.services.Add(service2);
                        }
                        else if (serviceAdd == 3 && serviceCount <= 8){
                            ap.services.Add(service3);
                        }
                        else if (serviceAdd == 4 && serviceCount <= 8){
                            ap.services.Add(specService1);
                        }

                   } 
                   // adding services for premium client
                   else if(ap.clientType == "premium"){
                        Console.WriteLine("Select your required service");
                        Console.WriteLine("=======================================");

                        Console.WriteLine("1) Gym access - $29.99/month");
                        Console.WriteLine("2) Group fitness classes - $49.99/month");
                        Console.WriteLine("3) Personal training sessions - $79.99/hour");
                        Console.WriteLine("4) Tanning sessions - $14.99/session");
                        Console.WriteLine("5) DONE");        

                        serviceAdd = int.Parse(Console.ReadLine());

                        if (serviceAdd == 1 && serviceCount <= 8){
                            ap.services.Add(service1);
                        }
                        else if (serviceAdd == 2 && serviceCount <= 8){
                            ap.services.Add(service2);
                        }
                        else if (serviceAdd == 3 && serviceCount <= 8){
                            ap.services.Add(service3);
                        }
                        else if (serviceAdd == 4 && serviceCount <= 8){
                            ap.services.Add(specService2);
                        }

                   }
                   // adding services for vip client
                   else if(ap.clientType == "vip"){
                        Console.WriteLine("Select your required service");
                        Console.WriteLine("=======================================");

                        Console.WriteLine("1) Gym access - $29.99/month");
                        Console.WriteLine("2) Group fitness classes - $49.99/month");
                        Console.WriteLine("3) Personal training sessions - $79.99/hour");
                        Console.WriteLine("4) Spa access - $99.99/month");
                        Console.WriteLine("5) DONE");        

                        serviceAdd = int.Parse(Console.ReadLine());

                        if (serviceAdd == 1 && serviceCount <= 8){
                            ap.services.Add(service1);
                        }
                        else if (serviceAdd == 2 && serviceCount <= 8){
                            ap.services.Add(service2);
                        }
                        else if (serviceAdd == 3 && serviceCount <= 8){
                            ap.services.Add(service3);
                        }
                        else if (serviceAdd == 4 && serviceCount <= 8){
                            ap.services.Add(specService3);
                        }

                   } 

                }while(serviceAdd != 5);
                serviceCount = serviceCount +1;
                appointments.Add(ap);

            }
            // List all Reservations choice
            else if (option == 2){
                displayAppointments(appointments);
            }
            // Clear All Reservations choice
            else if (option == 3){
                appointments = new List<Appointment>();
            }

        }while(option != 4);
    }

    // starting menu options print,input function
    public static int mainMenu(){
        Console.WriteLine("1: Create a Reservations");
        Console.WriteLine("2: List all Reservations");
        Console.WriteLine("3: Clear all Reservations");
        Console.WriteLine("4: Exit the program");

        return int.Parse(Console.ReadLine());
    }

    // List all appointments function
    public static void displayAppointments(List<Appointment> appointments){
        foreach(var ap in appointments){
            ap.printAppointments();
        }
    }
}
