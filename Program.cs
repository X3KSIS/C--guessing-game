Console.WriteLine();
Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("=====================================");
Console.WriteLine();
Console.Write("What is your name: ");
string name = Console.ReadLine() ?? "";
Console.WriteLine($"Hello, {name}! Let's start the game.");
Console.WriteLine();

Random random = new Random();
int secretNumber = random.Next(1, 11);

//Console.Write("Guess a number between 1 and 10: ");
//int guess = int.Parse(Console.ReadLine() ?? "0");


int attempts = 0;
bool guessedCorrectly = false;
while (!guessedCorrectly)
{
    Console.Write("Guess: ");
    int guess = int.Parse(Console.ReadLine() ?? "0");
    attempts++;
    if (guess == secretNumber)
    {
        guessedCorrectly = true;
        Console.WriteLine("Congratulations! You guessed the correct number!");
        Console.WriteLine($"Random Nymber generated was: {secretNumber}");
        Console.WriteLine($"It took you {attempts} attempts to guess the number.");
        guessedCorrectly = true;
    }
    else if (guess < secretNumber)
    {
        Console.WriteLine("Your guess is too low.");
    }
    else if (guess > secretNumber)
    {
        Console.WriteLine("Your guess is too high.");
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 10.");
    }
}

Console.WriteLine();