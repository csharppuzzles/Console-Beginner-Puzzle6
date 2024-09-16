
static void ExampleA()
{
    Console.WriteLine("\nExample A");
    Console.WriteLine("~~~~~~~~~");

    int counter = 0;

    while (true)
    {
        Console.WriteLine("Enter the word 'apple': ");
        string? input = Console.ReadLine();


        if(input.ToLower() == "apple")
        {
            // End the while loop
            break;
        }
        else
        {
            // Keep track of how many times the loop has run by incrementing the counter.
            // counter = counter + 1;
            counter++;
        }
    }

    Console.WriteLine($"Thanks for entering 'apple' after {counter} tries");

}


// Puzzle A - Knock, Knock
// Write a knock, knock joke using while loops
//  "Knock, Knock!: "
//      "who's there?"
//  "Phil.... :"
//      "phil who?"
//  "Phil Deez Nuts!"
// The user should be continually prompted until they enter "who's there" or "who is there?" and "phil who?"
// If the user enters the wrong reply 2 times, tell them to write "who is there?" or "phil who?"
static void PuzzleA()
{
    Console.WriteLine("\nPuzzle A");
    Console.WriteLine("~~~~~~~~~");

}



static void ExampleB()
{
    Console.WriteLine("\nExample B");
    Console.WriteLine("~~~~~~~~~");

    // It's common to use "i" as the counter variable.
    int i = 1;

    // Have a total variable outside the while loop
    int total = 0;

    Console.WriteLine("Please enter 3 numbers and I will add them together: ");

    while(i < 4)
    {
        Console.WriteLine($"{i}) Enter a number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        // Increase the total count
        total = total + input;

        // Increment the counter
        i++;
    }

    Console.WriteLine($"The total was: {total}");

}


// Puzzle B - While there's maths
// Write a program that asks the user for a number between 1 and 10, then display the number to the power of 2,3,4 and 5.
//  "Enter a number: "   2
//  "2 to the power of 2 is 4"
//  "2 to the power of 3 is 8"
// ...
// Continually prompt the user to enter a number between 1 and 10.
// Think of how this would be done in an IF statement, then just do it in a while loop - while(if statement expression)
// Use Math.Pow() to do the power calculation.
// Math.Pow() accepts DOUBLES not ints.

static void PuzzleB()
{
    Console.WriteLine("\nPuzzle B");
    Console.WriteLine("~~~~~~~~~");


}


static void ExampleC()
{
    Console.WriteLine("\nExample C");
    Console.WriteLine("~~~~~~~~~");

    // Boolean Values are True or False (Yes or No)
    // Often used as ON/OFF flags for loops.

    bool isActive = true;
    int counter = 0;

    // While(isActive) is shorthand for while(isActive == true)
    while (isActive)
    {
        if(counter <= 5)
        {
            Console.WriteLine($"This is loop {counter}");
            counter++;
        } else
        {
            Console.WriteLine("Ending loop");
            // Set isActive flag to false, prevents the while loop re-running
            isActive = false;
            counter = 0;                          // Reset the counter as well.

            // The while loop condition is evaluated at the beginning of each loop
            // So if there was code after the "isActive = false" it will still run.
            // It is not a break; statement.
            Console.WriteLine("This still runs as there is no break statement.");
        }
    }
    
}



// Puzzle C - Contagious Laughter
// Write a program that maniacally laughs at the user, as long as the user keeps laughing.
// The program will say "Ha ha ha ha ha... " and if the user enters a string that contains "ha" the program will laugh again.
// Hint: Look up "Contains()"
// After laughing 3 times, the program should display "Ha ha???..." and if the user enters a string containing "ha" then keep laughing!
// Use a keepLaughing boolean value to continually re-run a while loop.
static void PuzzleC()
{
    Console.WriteLine("\nPuzzle C");
    Console.WriteLine("~~~~~~~~~");

   
}




// Run the puzzles

ExampleA();
//PuzzleA();

ExampleB();
//PuzzleB();

ExampleC();
//PuzzleC();



Console.WriteLine("\n Press enter to exit the program...");
Console.ReadLine();                                         // Keeps the console app window open until you hit enter