class Sport : Person {

public String sportName;
public String teamName;
public int playerNumber;


    // overriding ToString
    public override string ToString()
    {

        return $"Name: {firstName} {lastName}\nAge: {age}\nBirth Date: {birthDate}\nSport: {sportName}\nCountry: {country}\nPlayer Number: {playerNumber}\nTeam: {teamName}";
    
    }

}

