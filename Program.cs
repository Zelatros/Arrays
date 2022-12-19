class Program
{
    static void Main(string[] args)
    {
        // dizi tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"kedi", "köpek", "kuş", "maymun"};

        int[] dizi;
        dizi = new int[5];

        //dizilere değer atama ve erişim
        renkler[0] = "mavi";
        dizi[3] = 10;
        
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //döngülerle dizi kullanımı
        //klavyeden girilen n tane sayının ortalaması

        Console.Write("Lüften dizinin eleman sayısını giriniz: ");
        int arrlength = int.Parse(Console.ReadLine());
        int[] intArr = new int[arrlength];
        int sum = 0;

        for (int i = 0; i < arrlength; i++)
        {
            Console.Write("Lütfen {0}. elemanı giriniz: ", i+1);
            intArr[i] = int.Parse(Console.ReadLine());
        }

        foreach (var number in intArr)
        {
            sum += number;
        }

        Console.WriteLine(sum/arrlength);

    }
}