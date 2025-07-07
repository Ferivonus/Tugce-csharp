using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string karakter_isim;
        long karakter_yaş;

        Console.WriteLine("Fahrettin ve tuğçenin oyun hikayesi:");
        Console.WriteLine("karakterin ismini yaz:");
        karakter_isim = Console.ReadLine();

        if(karakter_isim == "tuğçe")
        {
            Console.WriteLine("Tuğçe hoş geldin");
        }
        else if (karakter_isim != "tuğçe" )
        {
            Console.WriteLine("Hoş geldin");
        }

        Console.WriteLine("karakterin yaşını yaz:");
        if (!long.TryParse(Console.ReadLine(), out karakter_yaş))
        {
            Console.WriteLine("Geçersiz bir yaş girdiniz.");
            return;
        }

        Console.WriteLine("bizim karakterimizin adı: " + karakter_isim + " ve onun yaşı: " + karakter_yaş);

        Console.WriteLine("Karakterimizin karşısına bi yol çıktı:");
        Console.WriteLine("karşıdaki yolda soldan mı gitmek istersin, sağdan mı?");
        Console.WriteLine("sağ ya da sol yaz.");

        string seçilen_yol = Console.ReadLine();

        if(seçilen_yol == "sağ")
        {
            Console.WriteLine("Seni bir teste sokacağım.");
            Console.WriteLine("aşağıdaki örnekteki gibi yazıyı yazın.");
            Console.WriteLine("Yazmanız gereken yazı: tuğçe.");
            Console.WriteLine("tuğçe yaz:");

            string TestSorusuCevabı = Console.ReadLine();

            if (TestSorusuCevabı == "tuğçe")
            {
                Console.WriteLine("Doğru bildin.");

            }
            else
            {
                Console.WriteLine("Yanlış yazdın, Oyun bitti.");
            }
        
        }
        else if (seçilen_yol == "sol")
        {
            Console.WriteLine("oyun bitti.");
        }
        else { Console.WriteLine("farklı bir şey yazdın."); }

        Console.ReadLine();
    }
}
