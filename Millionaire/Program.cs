// her soru için cevabı doğru olduğunda counter var ını 1 arttırmasını söyledim.
int counter = 0;

Console.WriteLine("Kızınca tüküren hayvan hangisidir ?");
Console.WriteLine("A) Lama   B) Deve");
Console.Write("Cevabınızı giriniz:");
string cevap1 = Console.ReadLine();
string cevap1lower = cevap1.ToLower();
if (cevap1lower == "a")
{
    counter += 1;
}
else
{
    counter += 0;
}

Console.WriteLine("Dünya'ya en yakın gezegen hangisidir ?");
Console.WriteLine("A) Venüs   B) Mars");
Console.Write("Cevabınızı giriniz:");
string cevap2 = Console.ReadLine();
string cevap2lower = cevap2.ToLower();
if (cevap2lower == "a")
{
    counter += 1;
}
else
{
    counter += 0;
}


Console.WriteLine("5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?");
Console.WriteLine("A) 7   B) 12");
Console.Write("Cevabınızı giriniz:");
string cevap3 = Console.ReadLine();
string cevap3lower = cevap3.ToLower();
if (cevap2lower == "b")
{
    counter += 1;
}
else
{
    counter += 0;
}



//Sorular bittikten sonra counter da saklanan değer 2 den büyükse veya eşitse kazanmış olur.
Console.WriteLine(counter + " adet doğru cevabınız var.");

if (counter >= 2)
{
    Console.WriteLine("Tebrikler 1 Milyon TL kazandınız !!!");
}
else
{
    Console.WriteLine("Üzgünüz :( Kaybettiniz...");
}
