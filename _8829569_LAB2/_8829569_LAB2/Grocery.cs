class Grocery{

public int numberOfItems;
public String itemName;
public float itemWeight;

// function for calculating average weight and printing the output    
public void averageWeight(){

    float avgWeight = itemWeight / numberOfItems;
    Console.Write(avgWeight + " lbs");
}

// function for creating output
public void output(){
    Console.Write(numberOfItems + " " + itemName);
}

}
