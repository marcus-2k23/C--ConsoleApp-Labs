public class Appointment : Person{

    public Appointment(){
        services = new List<ServiceProvided>();
    }

    public List<ServiceProvided> services {get; set;} 


    double TotalCost = 0.0;

    public void printAppointments(){


        // hardcoading 3 clients
        Console.WriteLine("Name:  \nPhone Number: 1234567890 \nClient Number: xxx1234567");
         Console.WriteLine("---------------------------------------");
        Console.WriteLine("Service: Gym access 29.99 \nTotal: 29.99");

        Console.WriteLine("=======================================");
        Console.WriteLine("=======================================");
        Console.WriteLine("Name: Jane Doe \nPhone Number: 1234533890 \nClient Number: xxx1234333");
         Console.WriteLine("---------------------------------------");
        Console.WriteLine("Service: Gym access 29.99 \nTotal: 29.99");

        Console.WriteLine("=======================================");
        Console.WriteLine("=======================================");
        Console.WriteLine("Name: John Doe \nPhone Number: 9994567890 \nClient Number: xxx1234666");
         Console.WriteLine("---------------------------------------");
        Console.WriteLine("Service: Gym access 29.99 \nTotal: 29.99");


        // printing the client info list and list for reservation
        Console.WriteLine("=======================================");
        Console.WriteLine("=======================================");
        Console.WriteLine("Name: " + this.name + "\nPhone Number: " + this.phoneNumber + "\nClient Number: " + "xxx"+this.clientNumber.Substring(3,7) );

        foreach(var se in services){
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Service: " + se.serviceName + " " + se.price);

            TotalCost = TotalCost + se.price;

            Console.WriteLine("Total:" + Convert.ToDouble(TotalCost));
        }
    }
    
}