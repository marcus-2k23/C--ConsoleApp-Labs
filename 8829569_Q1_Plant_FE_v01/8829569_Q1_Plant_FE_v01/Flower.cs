// Name: 
// Section: 1
// Version: Final
// Student Number: 8829569


public class Flower : Plant{
    public int height;

    public Flower(){
        this.plantType = "flower";
    }
    
    public override string ToString()
    {
        try{

            Console.WriteLine(" Flower Name: " + this.plantName + " Flower Type: " + this.plantType + " Flower Height: " + this.height );
            return $"Flower Name: {plantName}, Flower Type: {plantType}, Flower Height: {height}";

        }catch(Exception ex){
            Console.WriteLine(ex);
            return "Error";
        }

        
    }
}