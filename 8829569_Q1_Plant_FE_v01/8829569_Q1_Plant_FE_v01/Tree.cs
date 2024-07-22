// Name: 
// Section: 1
// Version: Final
// Student Number: 8829569


public class Tree : Plant{
    public int age;

    public Tree(){
        this.plantType = "Tree";
    }

    public override string ToString()
    {
        try{
            Console.WriteLine(" Tree Name: " + this.plantName + " Tree Type: " + this.plantType + " Tree Age: " + this.age);

            return $"Tree Name: {plantName}, Tree Type: {plantType}, Tree age: {age}";
        }
        catch(Exception ex){
            Console.WriteLine(ex);
            return "Error";
        }
        
    }
}