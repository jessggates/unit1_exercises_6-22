// exercise 6 

using System.ComponentModel.Design;

bool playAgain = true;

do
{
    Console.WriteLine("Hello World");
    Console.WriteLine("Would you like to continue? (y/n)");
    string userAnswer = Console.ReadLine();
    if (userAnswer == "y")
    {
        playAgain = true;
    }
    else playAgain = false;
} while (playAgain == true);
Console.WriteLine("Goodbye!");

//exercise 7

bool keepPlaying = true;
do
{
    Console.Write("Enter some text: ");
    string display = Console.ReadLine();
    Console.WriteLine(display);
    Console.WriteLine("Would you like to continue? (y/n)");
    string userInput = Console.ReadLine();
    if (userInput == "y")
    {
        keepPlaying = true;
    }
    else keepPlaying = false;
} while (keepPlaying == true);
Console.WriteLine("Goodbye!");

//exercise 8

//exercise 9 

bool continuePlaying = true;

while (continuePlaying == true)
{
    Console.WriteLine("Enter a language: ");
    string userLanguage = Console.ReadLine();
    
    switch (userLanguage.ToLower().Trim())
    {
        case "english": 
            Console.WriteLine("Hello World");
            break;
        case "spanish":
            Console.WriteLine("Hola Mundo");
            break;
        case "dutch":
            Console.WriteLine("hallo wereld");
            break;
    } 
    Console.WriteLine("Would you like to continue? (y/n)");
    string userAnswer = Console.ReadLine();
    if (userAnswer == "y")
    {
        continuePlaying = true;
    }
    else continuePlaying = false;
} Console.WriteLine("Goodbye!");