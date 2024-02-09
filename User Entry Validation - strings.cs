string? readInput;
bool validInput = false;
Console.WriteLine("Enter your role name:\n(Administrator / Manager / User)");

do
{
    readInput = Console.ReadLine();

    if (readInput != null)
    {
        string role = readInput.Trim().ToLower();
        if (role == "administrator" || role == "manager" || role == "user")
        {
            validInput = true;
        }
        else {
            Console.WriteLine($"The role that you entered, \"{readInput}\" is not valid\nEnter your role name:\n(Administrator / Manager / User)");
        }
    }
} while (validInput == false);

Console.WriteLine($"Your input value ({readInput.Trim()}) has been accepted.");

