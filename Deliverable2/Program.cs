// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");

        Console.Write("What is your name? ");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Player";
        }

        Console.Write($"Welcome to The Winners Circle, {name}. Do you want to do the COIN FLIP CHALLENGE? Yes/No ");
        string? response = Console.ReadLine()?.Trim().ToLower();

        if (response == "yes")
        {
            int score = 0;
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                int flipResult = random.Next(0, 2);

                Console.Write("Heads or Tails? ");
                string? guess = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(guess) || (guess != "heads" && guess != "tails"))
                {
                    Console.WriteLine("Invalid input! Please enter 'Heads' or 'Tails'.");
                    i--;
                    continue;
                }

                int guessNumber = (guess == "heads") ? 0 : 1;

                if (flipResult == guessNumber)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }
            Console.WriteLine($"Thank you, {name}. You got a score of {score}!");
        }
        else
        {
            Console.WriteLine($"You are a coward, {name}.");
        }
    }
}
