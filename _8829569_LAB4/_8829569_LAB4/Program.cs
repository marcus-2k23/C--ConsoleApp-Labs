namespace _8829569_LAB4;
class Program
{
    static void Main(string[] args)
    {

        // new object
        Sport favoriteSpotrsPlayer = new Sport
        {


            firstName = "",
            lastName = "",
            age = 25,
            birthDate = 25011999,
            country = "INDIA",
            sportName = "Football",
            teamName = "Section01",
            playerNumber = 8829569
        };


        // using ToString to print
        Console.WriteLine(favoriteSpotrsPlayer.ToString());
    }
}
