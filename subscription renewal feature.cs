// You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software. Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Rule 1: Your code should only display one message.
// The message that your code displays will depend on the other five rules. For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.

// Rule 2: If the user's subscription will expire in 10 days or less, display the message:
// Your subscription will expire soon. Renew now!

// Rule 3: If the user's subscription will expire in five days or less, display the messages:
// Your subscription expires in _ days.
// Renew now and save 10%!

// Rule 4: If the user's subscription will expire in one day, display the messages:
// Your subscription expires within a day!
// Renew now and save 20%!

// Rule 5: If the user's subscription has expired, display the message:
// Your subscription has expired.

// Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration <= 10)
{
    if (daysUntilExpiration <= 5)
    {
        if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
        }
        else
        {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
        }
    }
    else
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
}
