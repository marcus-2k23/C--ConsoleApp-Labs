// See https://aka.ms/new-console-template for more information

Console.WriteLine(", 8829569, 9569@conestogac.on.ca");
Console.WriteLine("============================================================");
Console.WriteLine("");

int itemPurchased;
float quantityPurchased;
float cost;
int loyaltyInput;
string loyaltyOutput;
float loyalDiscount = 0;
float individDiscount = 0;
float tax;

try
{
    // asking and taking input about what item user wants
    Console.WriteLine("What Pet Item do you want to purchase (type the corresponding number): \n 1) Fish  -  $5.00 \n 2) Cat Food  -  $10.00\n 3) Dog Food  -  $15.00\n 4) bird food  -  $10");
    itemPurchased = int.Parse(Console.ReadLine());

    // asking and taking input about if user has loyalty card or not
    Console.WriteLine("Do You Have a loyalty Card: \n 1) YES \n 2) NO");
    loyaltyInput = int.Parse(Console.ReadLine());
    if(loyaltyInput == 1){
        loyaltyOutput = "Yes";
    }
    else{
        loyaltyOutput = "No";
    }


    if(itemPurchased == 1){

        // asking and taking input about what quantity user wants
        Console.WriteLine("Type How much quantity do you want: ");
        quantityPurchased = float.Parse(Console.ReadLine());

        

        // displaying what user selected
        Console.WriteLine("Item: "+ itemPurchased);
        Console.WriteLine("Qty: "+ quantityPurchased);
        Console.WriteLine("Base: $5");
        Console.WriteLine("Loyalty Card: " + loyaltyOutput);
        Console.WriteLine("\n -------------------------------");

        // calculating and displaying sub total cost
        cost = (float)(quantityPurchased * 5.0);
        Console.WriteLine("Sub total :" + cost);
        Console.WriteLine("--");

        // checking how much individual discount is applicable 
        Console.WriteLine("Discounts");
        if(quantityPurchased >= 3){
            individDiscount = (float)(cost - (quantityPurchased*4.5));
            Console.WriteLine("Individual: " + individDiscount);  
        }
        else{
            Console.WriteLine("Individual: 0$");
        }

        // calculating cost after individual discount
        cost = cost - individDiscount;


        // checking if loyalty discount is applicable and how much
        if (loyaltyInput == 1){
            loyalDiscount = (float)(cost - (0.95*cost));
            Console.WriteLine("Loyalty: " + loyalDiscount );
        }
        else{
            Console.WriteLine("Loyalty: $0");
        }

        Console.WriteLine("--");

        // calculating cost after loyalty discount
        cost = cost - loyalDiscount;
        Console.WriteLine("Sub Total: " + cost );

        // calculating tax
        tax = (float)(0.13 * cost);
        Console.WriteLine("Tax: " + tax);

        // adding tax to cost
        cost = cost + tax;
        Console.WriteLine("=========================================");
        Console.WriteLine("TOTAL: " + cost);
            
        
    }
    if(itemPurchased == 2){

        // asking and taking input about what quantity user wants
        Console.WriteLine("Type How much quantity do you want: ");
        quantityPurchased = float.Parse(Console.ReadLine());

        // asking and taking input about if user has loyalty card or not
        Console.WriteLine("Do You Have a loyalty Card: \n 1) YES \n 2) NO");
        loyaltyInput = int.Parse(Console.ReadLine());

        // displaying what user selected
        Console.WriteLine("Item: "+ itemPurchased);
        Console.WriteLine("Qty: "+ quantityPurchased);
        Console.WriteLine("Base: $10");
        Console.WriteLine("Loyalty Card: " + loyaltyOutput);
        Console.WriteLine("\n -------------------------------");

        // calculating and displaying sub total cost
        cost = (float)(quantityPurchased * 10.0);
        Console.WriteLine("Sub total :" + cost);
        Console.WriteLine("--");

        // checking how much individual discount is applicable
        Console.WriteLine("Discounts");
        if(quantityPurchased >= 5){
            individDiscount = 10;
            Console.WriteLine("Individual: " + individDiscount);  
        }
        else{
            Console.WriteLine("Individual: 0$");
        }

        // calculating cost after individual discount
        cost = cost - individDiscount;


        // checking if loyalty discount is applicable and how much    
        if (loyaltyInput == 1){
            loyalDiscount = (float)(cost - (0.95*cost));
            Console.WriteLine("Loyalty: " + loyalDiscount );
        }
        else{
            Console.WriteLine("Loyalty: $0");
        }

        Console.WriteLine("--");

        // calculating cost after loyalty discount
        cost = cost - loyalDiscount;
        Console.WriteLine("Sub Total: " + cost );

        // calculating tax
        tax = (float)(0.13 * cost);
        Console.WriteLine("Tax: " + tax);

        // adding tax to cost
        cost = cost + tax;
        Console.WriteLine("=========================================");
        Console.WriteLine("TOTAL: " + cost);
            
        
    }
    if(itemPurchased == 3){

        // asking and taking input about what quantity user wants
        Console.WriteLine("Type How much quantity do you want: ");
        quantityPurchased = float.Parse(Console.ReadLine());

        // asking and taking input about if user has loyalty card or not
        Console.WriteLine("Do You Have a loyalty Card: \n 1) YES \n 2) NO");
        loyaltyInput = int.Parse(Console.ReadLine());

        // displaying what user selected
        Console.WriteLine("Item: "+ itemPurchased);
        Console.WriteLine("Qty: "+ quantityPurchased);
        Console.WriteLine("Base: $15");
        Console.WriteLine("Loyalty Card: " + loyaltyOutput);
        Console.WriteLine("\n -------------------------------");

        // calculating and displaying sub total cost
        cost = (float)(quantityPurchased * 15.0);
        Console.WriteLine("Sub total :" + cost);
        Console.WriteLine("--");

        // checking how much individual discount is applicable
        Console.WriteLine("Discounts");
        if(quantityPurchased >= 3){
            individDiscount = (float)(7.5);
            Console.WriteLine("Individual: " + individDiscount);  
        }
        else{
            Console.WriteLine("Individual: 0$");
        }

        // calculating cost after individual discount
        cost = cost - individDiscount;

        // checking if loyalty discount is applicable and how much    
        if (loyaltyInput == 1){
            loyalDiscount = (float)(cost - (0.95*cost));
            Console.WriteLine("Loyalty: " + loyalDiscount );
        }
        else{
            Console.WriteLine("Loyalty: $0");
        }

        Console.WriteLine("--");

        // calculating cost after loyalty discount
        cost = cost - loyalDiscount;
        Console.WriteLine("Sub Total: " + cost );

        // calculating tax
        tax = (float)(0.13 * cost);
        Console.WriteLine("Tax: " + tax);

        // adding tax to cost
        cost = cost + tax;
        Console.WriteLine("=========================================");
        Console.WriteLine("TOTAL: " + cost);
            
        
    }
    if(itemPurchased == 4){

        // asking and taking input about what quantity user wants
        Console.WriteLine("Type How much quantity do you want: ");
        quantityPurchased = float.Parse(Console.ReadLine());

        

        // displaying what user selected
        Console.WriteLine("Item: "+ itemPurchased);
        Console.WriteLine("Qty: "+ quantityPurchased);
        Console.WriteLine("Base: $10");
        Console.WriteLine("Loyalty Card: " + loyaltyOutput);
        Console.WriteLine("\n -------------------------------");

        // calculating and displaying sub total cost
        cost = (float)(quantityPurchased * 10.0);
        Console.WriteLine("Sub total :" + cost);
        Console.WriteLine("--");

        // checking how much individual discount is applicable 
        Console.WriteLine("Discounts");
        if(quantityPurchased >= 2){
            individDiscount = (float)(cost - (quantityPurchased*9.5));
            Console.WriteLine("Individual: " + individDiscount);  
        }
        else{
            Console.WriteLine("Individual: 0$");
        }

        // calculating cost after individual discount
        cost = cost - individDiscount;


        // checking if loyalty discount is applicable and how much
        if (loyaltyInput == 1){
            loyalDiscount = (float)(cost - (0.95*cost));
            Console.WriteLine("Loyalty: " + loyalDiscount );
        }
        else{
            Console.WriteLine("Loyalty: $0");
        }

        Console.WriteLine("--");

        // calculating cost after loyalty discount
        cost = cost - loyalDiscount;
        Console.WriteLine("Sub Total: " + cost );

        // calculating tax
        tax = (float)(0.13 * cost);
        Console.WriteLine("Tax: " + tax);

        // adding tax to cost
        cost = cost + tax;
        Console.WriteLine("=========================================");
        Console.WriteLine("TOTAL: " + cost);
            
        
    }
}
catch (System.Exception)
{
    
    Console.WriteLine("some erroe occured");
}
