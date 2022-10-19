// Andrew Nilsson
// 09-08-2022
// Mini Challenge #4 - Greater Than or Less Than
// This is a console project that will ask the user to input 2 numbers then compare the 2 numbers and print
//      out whether the first number is greater than, less than, or equal to the second number
// Peer Review by Freddy A - " Program ran as intended. Gave outputs according to user input :) "


Console.Clear();

int num1, num2;
string symbol1, symbol2;
bool validnum1, validnum2;

bool play = true;
while (play)
{
    num1 = 0;
    num2 = 0;
    validnum1 = false;
    validnum2 = false;
    Console.Write("Please enter a number: ");

    while (!validnum1)
    {
        validnum1 = Int32.TryParse(Console.ReadLine(), out num1);

        if (!validnum1)
        {
            Console.WriteLine("Invalid number, enter a number.");
        }
    }


    Console.Write("Enter a second number: ");

    while (!validnum2)
    {
        validnum2 = Int32.TryParse(Console.ReadLine(), out num2);

        if (!validnum2)
        {
            Console.WriteLine("Invalid number, enter a number.");
        }
    }


    if (num1 > num2)
    {
        symbol1 = " > ";
        symbol2 = " < ";
    }
    else if (num1 < num2)
    {
        symbol1 = " < ";
        symbol2 = " > ";
    }
    else
    {
        symbol1 = " = ";
        symbol2 = " = ";
    }

    Console.WriteLine(num1 + symbol1 + num2);
    Console.WriteLine(num2 + symbol2 + num1);


    Console.WriteLine("Would you like to compare 2 more numbers? (yes or no)");

    bool validPlay = false;
    while (!validPlay)
    {

        string playInput = Console.ReadLine().ToLower();

        switch (playInput)
        {
            case "yes":
                validPlay = true;
                break;
            case "no":
                Console.WriteLine("Have a great day");
                validPlay = true;
                play = false;
                break;
            default:
                Console.WriteLine("INVALID INPUT");
                Console.WriteLine("Input yes or no");
                break;
        }
    }
}