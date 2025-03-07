namespace randomprime;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int randnum = rand.Next(1, 100);
        if (isPrime(randnum))
        {
            Console.WriteLine($"{randnum} bir asal sayidir.");
        }
        else
        {
            Console.WriteLine($"{randnum} bir asal sayi değildir.");
        }

        static bool isPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
        
    }
}