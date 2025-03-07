namespace WordCounter;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter word or letter.");
        string input = Console.ReadLine();
        char[] arr = new char[input.Length];
        
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = input[i];
        }
        //input[0} -> 'h'
        //input[1] -> 'e'
        //input[2] -> 'l'
        //input[3] -> 'l' 
        foreach (char c in arr)
        {
            Console.Write(c + " ");
        }
        {
            
        }
    }
}