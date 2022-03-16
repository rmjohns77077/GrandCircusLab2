// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello. Welcome to the Buffet. All you can eat for $9.99. We offer water and lemonade to drink but only charge $1.99 for Lemonade. No parties more than 6. So how many do you have in your party?");
string SizeOfParty = Console.ReadLine();
int size = int.Parse(SizeOfParty);

int water = 0;
int lemonade = 0;
if (size <= 6)
{
    Console.WriteLine($" Awesome table of " + SizeOfParty + " right this way.");
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Person {i + 1} what would you like to drink?");
        var choice = Console.ReadLine();
        Console.WriteLine(choice + " nice choice.");
        if (choice == "lemonade")
        {
             lemonade ++;
        }
        else if (choice == "water")
        {
           water ++;
        }
    }
}


else
{
    Console.WriteLine("Oh Im sorry most we can do is 6.");

}
decimal bill = (decimal)((size * 9.99) + (lemonade * 1.50));
Console.WriteLine($"Awesome so thats " + water + " water and " + lemonade + " lemonade feel free to grab your food.Your total is "+  bill);