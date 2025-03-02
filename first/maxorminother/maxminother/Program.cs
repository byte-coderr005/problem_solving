namespace first;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 1, 2, 3, 5, 6, 7 };
        int enBuyuk = int.MinValue;
        int enKucuk = int.MaxValue;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >enBuyuk)
            {
                enBuyuk = arr[i];
            }

            if (arr[i] < enKucuk)
            {
                enKucuk = arr[i];
            }
        }

        Console.WriteLine("En büyük eleman: " + enBuyuk);
        Console.WriteLine("En kucuk eleman: " + enKucuk);
    }
}