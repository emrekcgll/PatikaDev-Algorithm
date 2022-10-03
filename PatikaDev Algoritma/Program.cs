using System.Collections;



//List oluşturma
List<int> DenemeListesi = new List<int>();







//Array oluşturma

string yazi = "Bugün hava çok güzel değil gibi görünüyor.";
string yazi2 = yazi.Substring(0, yazi.Length - 1);
Console.WriteLine(yazi2);

string[] kelimeler = yazi2.Split(' ');
for (int i = 0; i < kelimeler.Length; i++)
{
    Console.WriteLine(kelimeler[i]);
}

Console.WriteLine("Yazı toplam {0} kelimedir.", kelimeler.Length);




//ArrayList oluşturma
ArrayList arrayList = new ArrayList();




































static void DiziEx2()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];

    if (n % 2 == 0 && m % 2 == 0)
    {
        Console.WriteLine("{0} adet sayı giriniz", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}. dizi elemanını gir : ", i + 1);
            arr[i] = Convert.ToInt16(Console.ReadLine());
        }
        foreach (var item in arr)
        {
            if (item % m == 0 || item == m)
            {
                Console.WriteLine("Dizideki {0} sayısına tam bölünen elemanlar:{1}", m, item);
            }
        }
    }
    else
    {
        Console.WriteLine("Lütfen çift sayı giriniz.");
    }
}

static void DiziEx()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];

    if (n % 2 == 0)
    {
        Console.WriteLine("{0} adet sayı giriniz.", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}. dizi elemanını gir : ", i + 1);
            arr[i] = Convert.ToInt16(Console.ReadLine());
        }
    }
    else
    {
        Console.WriteLine("Lütfen çift sayı giriniz.");
    }

    foreach (var item in arr)
    {
        if (item % 2 == 0)
        {
            Console.WriteLine("Dizinizdeki çift elemanlar: " + item);
        }
    }
}

static void ReverseString()
{
    Console.Write("cümlenin kaç kelime olacağını giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("{0} adet kelime giriniz.", n);
    string[] arr = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}. kelimeyi giriniz: ", i + 1);
        arr[i] = Console.ReadLine();
    }

    Console.WriteLine("\n Cümleniz: ");
    foreach (var item in arr)
    {
        Console.Write(item + " ");
    }

    Console.WriteLine("\n Cümlenin ters hali: ");
    for (int i = arr.Length; i > 0; i--)
    {
        Console.Write(arr[i - 1] + " ");
    }
}

static void FindTotalWorldAndLetters()
{
    Console.WriteLine("Bir cümle giriniz: ");
    string cumle = Console.ReadLine();

    string[] kelimeler = cumle.Split(' ');
    string yeniCumle = cumle.Replace(" ", "");

    Console.WriteLine("Toplam kelime sayısı: " + kelimeler.Length);
    Console.WriteLine("Toplam harf sayısı: " + yeniCumle.Length);


}