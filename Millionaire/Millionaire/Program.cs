
using System;

class Program
{
    public static void Main(string[] args)
    {
        // her soru için cevabı doğru olduğunda counter var ını 1 arttırmasını söyledim.
        int counter = 0;

        Console.WriteLine("Kızınca tüküren hayvan hangisidir ?");
        Console.WriteLine("A) Lama   B) Deve");
        Console.Write("Cevabınızı giriniz:");
        string cevap1 = Console.ReadLine();
        string cevap1lower = cevap1.ToLower();
        if (cevap1lower == "a")
        {
            counter++;
        }
        else
        {

        }

        Console.WriteLine("Dünya'ya en yakın gezegen hangisidir ?");
        Console.WriteLine("A) Venüs   B) Mars");
        Console.Write("Cevabınızı giriniz:");

        string cevap2 = Console.ReadLine();
        string cevap2lower = cevap2.ToLower();
        if (cevap2lower == "a")
        {
            counter++;
        }
        else
        {

        }

        //İlk iki soruyu birden bilemezse eleneceği için sıfırsa kaybetti. Yoksa üçüncü soruya devam.
        if (counter == 0)
        {
            Console.WriteLine("Üzgünüz:( Kaybettiniz...");
        }
        else
        {
            Console.WriteLine("5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
            Console.WriteLine("A) 7   B) 12");
            Console.Write("Cevabınızı giriniz:");
        }


        string cevap3 = Console.ReadLine();
        string cevap3lower = cevap3.ToLower();

        //üçüncü sorunun cevabı doğru ise kesin kazanıyor. üçüncü soruyu görmek için bir doğrusu olmalı.
        if (cevap3lower == "b")
        {
            counter++;
            Console.WriteLine("Tebrlikler !! " + counter + " doğru yanıtınız var.");
            Console.WriteLine("1 Milyon TL kazandınız !!!!");
        }
        //Eğer üçüncü soruyu bilemezse ama önceki iki soruyu bilmişse.
        else if (counter >= 2)
        {
            Console.WriteLine("Tebrlikler !! " + counter + " doğru yanıtınız var.");
            Console.WriteLine("1 Milyon TL kazandınız !!!!");
        }
        //İlk iki soruda 1 doğrusu varsa ve bu soruyu da bilemediyse.
        else
        {
            Console.WriteLine("Üzgünüz:( Kaybettiniz...");
        }
    }
}
