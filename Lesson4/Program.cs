namespace Lesson4;

class Program
{
    static void Main(string[] args)
    {
        Matn tursun = new Matn();
        tursun.Txt = "Ҷони ширин ин қадар ҷангам макун";
        Console.WriteLine(tursun.Txt);
        Console.WriteLine(tursun.Len);
        foreach (string word in tursun.Kalima)
        {
            Console.Write(word + ",");
        }
    }
}