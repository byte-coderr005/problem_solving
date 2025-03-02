namespace palindrom;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        bool palindromMu = true;

        for (int i = 0; i < input.Length / 2; i++) // kelimenin yarısına kadar git.
        {
            if (input[i] != input[input.Length - 1 - i])
            {
                palindromMu = false;
                break;
            }
        }
        
        if(palindromMu)
            Console.WriteLine("Bu bir palindromdur.");
        else
        {
            Console.WriteLine("Palindrom değildir.");
        }
    }
}