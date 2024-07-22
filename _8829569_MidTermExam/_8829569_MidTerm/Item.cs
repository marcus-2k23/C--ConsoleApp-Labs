public class Item : Book
{

    public string? bookName{get; set;}
    public int quantity{get; set;}
    public double price{get; set;}

    

    public Item(){
         
    }

    

    // function for printing store info
    public void StoreInfoOutput()
    {
        Console.WriteLine("Store Name: " + this.storeName + "\n" + "Owner Name: " + this.ownerFirstName + " " + this.ownerLastName + "\nStore Address: " + this.storeAddress);
        Console.WriteLine("===============================================================================");
        
    }

    /* function for printing the inventory
    public void InventoryOutput(){
        Console.WriteLine("Book Name: " + bookName + "\nBook quantity: " + quantity + "\nBook Price: " + price);
        
    }
    */

}