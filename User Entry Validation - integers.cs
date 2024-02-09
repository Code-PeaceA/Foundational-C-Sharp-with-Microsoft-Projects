// Prompt user for an integer value between 5 and 10
string? readInput;
int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Enter an integer value between 5 and 10:");

do
{
    readInput = Console.ReadLine();
    if (readInput != null)
    {
        validNumber = int.TryParse(readInput, out numericValue);
        if (validNumber == false)
        {
            Console.WriteLine("Sorry, you entered an invalid number. Please enter an integer value between 5 and 10");
        }
        else if (numericValue < 5 || numericValue > 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numericValue}. Please enter an integer value between 5 and 10");
        }
    }
} while (validNumber == false);

Console.WriteLine($"The input value ({numericValue}) has been accepted.");

