class Luggage : Person{
    public int numberOfBags { get; set; }
    public float totalWeight { get; set; }

    public float bagsAverageWeight;

    // function to calculate average weight
    public float averageWeight(int numberOfBags, float totalWeight){
        bagsAverageWeight = totalWeight / numberOfBags; 
        return bagsAverageWeight;
    }
}