namespace fibo3;

class Program
{
    static void Main(string[] args)
    {
        int a = 0, b = 1,temp;
        int input = int.Parse(Console.ReadLine());

        for (int i = 2; i < input; i++)
        {
            temp = a + b;
            Console.WriteLine(temp + " ");
            a = b;
            b = temp;
        }
        
    }
}