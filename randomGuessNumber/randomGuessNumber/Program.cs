namespace randomGuessNumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Guess number Game");
        Console.WriteLine("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Random rand = new Random();
        int guess=rand.Next(1, 15);;
        while (true)
        {
            guess =rand.Next(1, 100);
            if (number == guess)
            {
                Console.WriteLine($"guessed number is {guess}");
                break;
            }

            Console.WriteLine("searching..");
        }
    }
}