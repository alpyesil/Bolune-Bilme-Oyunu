using System;

namespace _1_den_25_e_kadar_olan_sayıların_kareleri_toplamını_bulan
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int tbt = 0;
            int giris = 0;
            int giris2 = 0;
            int tahmin = 0;

            Console.Write("1. Sayıyı girin: ");
            giris = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı girin: ");
            giris2 = int.Parse(Console.ReadLine());

            if (giris % 3 == 0 && giris2 % 3 == 0)
            {
                tahmin = 2;
                toplam = toplam + giris + giris2;
                toplam = toplam / 2;
            }
            else if (giris %3 == 0)
            {
                tahmin = 1;
                toplam = toplam + giris;
                toplam = toplam / 1;
            }
            else if (giris2 %3 == 0)
            {
                tahmin = 1;
                toplam = toplam + giris2;
                toplam = toplam / 1;
            }
            if (giris2 % 3 != 0)
            {
                tbt++;
            }
            if (giris % 3 != 0)
            {
                tbt++;
            }
            Console.WriteLine("3 ile tam bölünen sayıların ortalaması: " + toplam + " " + "Bu sayılardan: " + tahmin + " tanesi tam bölen" + "\nTam bölmeyenlerin sayısı: " + tbt + " Bu sayılar şunlardır: " + giris + " ve " + giris2);
            Console.ReadKey();        
        }
    }
}
