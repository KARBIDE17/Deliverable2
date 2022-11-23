//Ask user for guest count, and inform of resaurant rules.
Console.WriteLine("Hi. Welcome to our Buffet. " +
    "All you can eat for $9.99! We only charge extra for coke. " +
    "How many people are in your group? " +
    "Please, parties of 6 or lower.");

// Initialize guest variable and assin it user iput as value
int guests = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

//Display guest count and instruct to take a seat,
if (guests <= 6)
{
    Console.WriteLine("A table for " + guests + "! Please follow me and take a seat.");
    Console.WriteLine("Let's get everyone started with some drinks. We have water or coke...");
    Console.WriteLine();
} else 
{
    Console.WriteLine("Sorry, but our policy states we can only accept parties of 6 or fewer...");
    Environment.Exit(0);
}
//create a for loop to figure out which drink each guest wants

int waters = 0;
int cokes = 0;

for (int i = 1; i <= guests; i++)
{
    Console.WriteLine("Alright, Guest " + i + ", water or coke?");
    string g1 = Console.ReadLine();
    if (g1 == "water")
    {
        Console.WriteLine();
        Console.WriteLine("Okay, Water it is.");
        Console.WriteLine();
        waters++;
    }
    else if (g1 == "coke")
    {
        Console.WriteLine();
        Console.WriteLine("Okay, Coke it is.");
        Console.WriteLine();
        cokes++;
    }
    else 
    {
        Console.WriteLine();
        Console.WriteLine("Sorry we dont carry that drink, ill bring you a free water for now.");
        Console.WriteLine();
        waters++;
    }
}

//display how many of each drink was ordered
Console.WriteLine("Perfect, I have " + waters + " waters, and " + cokes + " cokes. " +
    "I'll be right back. Feel free to grab your food!");
Console.WriteLine();

//calculate the total bill
decimal cokesPrice = (decimal)(cokes * 2.00);
decimal billTotal = (decimal)(guests * 9.99) + cokesPrice;

//Display total bill to user
Console.WriteLine("Here's your bill! Total price: $" + billTotal);





