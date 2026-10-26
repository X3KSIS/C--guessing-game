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

Console.Write("Guess a number between 1 and 10: ");
int guess = int.Parse(Console.ReadLine() ?? "0");


int attempts = 0;
bool guessedCorrectly = false;
while (!guessedCorrectly)
{
    
}