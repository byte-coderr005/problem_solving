namespace descendin_order;

class Program
{
    static void Main(string[] args)
    {
        Desc();
    }

    static void Desc()
    {
        for (int i = 9; i > 0; i--)
        {
            Console.Write(i);
        }
    }
}