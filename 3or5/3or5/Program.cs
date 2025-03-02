namespace _3or5;

class Program
{
    static void Main(string[] args)
    {
        //Even fibonacci numbers 
        // n = n-1 + n-2;
        int a = 1, b = 2, sum = 0;
        Console.WriteLine("USt deger girin.");
        int t = Convert.ToInt32(Console.ReadLine());
        while (b < t)
        {
            if (b % 2 == 0)
            {
                sum += b;
                Console.WriteLine("Çift Fibonacci SAyısı: " + b);
            }
            int temp = a + b;
            a = b;
            b = temp;
        }

        Console.WriteLine("çift fibonacci sayıların toplamı: " + sum);
    }
}