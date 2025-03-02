namespace maxormin;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("5 adet sayi giriniz.");
        int[] sayilar = new int[5];
        int sayac = 0;
        while (sayac < 5)
        {
            Console.WriteLine($"Sayi {sayac + 1};");
            sayilar[sayac] = Convert.ToInt32(Console.ReadLine());
            sayac++; 
            
        }

        Console.WriteLine("Girilen sayilar");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine("en büyük sayi " +sayilar.Max());
            Console.WriteLine("En kucuk sayi " + sayilar.Min());
            Console.WriteLine(sayi + " ");
        }
        
    }
}