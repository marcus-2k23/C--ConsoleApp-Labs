class Person{

    public string firstName { get; set; }
    public string lastName { get; set; }
    public string phoneNumber { get; set; }

    public bool validFormat = false;

    public string phoneNumberOutput {get; set;}

    // function to check if phone number is in correct format or not
    public void phoneNumberValidator(string phoneNumber){
         
            if (phoneNumber.Length == 14)
            {
                if (phoneNumber[0] == '(' && phoneNumber[4] == ')' && phoneNumber[5] == ' ' && phoneNumber[9] == '-')
                {
                    validFormat = true;
                    for (int i = 1; i < 4; i++)
                    {
                        if (!Char.IsDigit(phoneNumber[i]))
                        {
                            validFormat = false;
                            break;
                        }
                    }
                    for (int i = 6; i < 9; i++)
                    {
                        if (!Char.IsDigit(phoneNumber[i]))
                        {
                            validFormat = false;
                            break;
                        }
                    }
                    for (int i = 10; i < 14; i++)
                    {
                        if (!Char.IsDigit(phoneNumber[i]))
                        {
                            validFormat = false;
                            break;
                        }
                    }
                }
            }


        if(validFormat == true){
            phoneNumberOutput = phoneNumber;
        }

    }

    
}

