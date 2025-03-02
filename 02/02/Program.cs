namespace _02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ters çevirilecek metni giriniz.");
        string word = Console.ReadLine();
        char[] ters = new char[word.Length];//Ters çevirilecek karakterler için boş
        //dizi oluştur.
        for (int i = 0; i < word.Length; i++)
        {
            ters[i] = word[word.Length - 1 - i];
            // Sondan başa doğru karakterleri atıyoruz.
            //-1: bize son indeks değerini verir.(indeks 0 dan başlar)
            //-i diziyi tersten yazdırma.
        }
        string sonuc = new string(ters);
        Console.WriteLine("Ters çevirlmiş metin: " + sonuc);
    }
}