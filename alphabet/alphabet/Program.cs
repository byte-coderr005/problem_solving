namespace alphabet;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("lower letters");
        for (int i = 97; i <= 122; i++)
        {
            Console.Write((char)i+ " ");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Upper letters");
        for (int i = 65; i <= 90; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}