# Completed Projects from Foundational C# with Microsoft Course

**Student-Grading-App**

**GPA Calculator**

**Dice Prize Draw**

**Subscription Renewal Feature**

**Student Grading App - iteration**

**Student Grading App - iteration 2**

**Battle Game**

**User Entry Validation - integers**
The solution includes a do-while iteration.
Before the iteration block: the solution uses a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Inside the iteration block: The solution uses a Console.ReadLine() statement to obtain input from the user. The solution ensures that the input is a valid representation of an integer. If the integer value isn't between 5 and 10, the code uses a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10. The solution ensures that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: the solution uses a Console.WriteLine() statement to inform the user that their input value has been accepted.

**User Entry Validation - Strings**
The solution includes a do-while iteration.
Before the iteration block, the solution uses a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.
Inside the iteration block, the solution uses a Console.Readline() statement to obtain input from the user. The solution ensures that the value enteres matches one of the three role options. The solution uses the Trim() and ToLower() methods on the input value to ignore leading and trailing space characters and also ignore case. If the value entered isn't a match for one of the role options, the code uses Console.WriteLine() statement to prompt the user for a valid entry.
Below/after the iteration code block, the solution uses Console.WriteLine() statement to inform the user that their input value has been accepted.

**Contoso Pets Application**
This is a console application that helps place pets in new homes.
I cloned the inital version from the Microsoft C# course. The initial version included:
- variable declarations to hold the values of the pet characteristics; to use to generate sample data, read user input and establish exit criteria for the main program loop; and a two dimensional string array instantiated using the 'new' operator
- for loop containing an if-elseif-else selection construct. The values of the animal characterisitcs are assigned to the two-dimensional array
- Console.WriteLine/ReadLine statements used to display the menu options and read the user selection and assigns the user inout to the menuSelection variable

*First Iteration*

The goal for this iteration was to develop the features that implement the first two menu options. To achieve this, I completed the following:

- I reviewed and updated the code to improve readability. I did this by changing the if-elseif-else construct to a switch case construct.
- I then constructed a do...while loop aound the main menu and created a selection statement (switch case construct again) that establishes a code branch for each menu option.
- Finally, I put in some placeholder code for each case of the switch statement pointing to the next update
  
