using Lesson4.Classes;

namespace Lesson4;

class Program
{
    static void Main(string[] args)
    {
        // Масъалаи 26.1
        Book tojikon = new Book("Точикон", "Бобочон Гафуров", "978-99947-0-323-4", "Илми-таърихи", "Ирфон", 1983, 976);
        tojikon.Info();

        Console.WriteLine();

        Book shohnoma = new Book("Шохнома", "Абулкосим Фурдавси", "978-99947-999-0-0", "Эпос/Хамоса", "Нашриёти муосир",
            1010, 1500);
        shohnoma.Info();
        Console.WriteLine();
        
        // Масъалаи 26.2
        Rectangle rect = new Rectangle(12, 24);
        rect.Perimeter();
        rect.Area();
        Console.WriteLine();
        
        // Масъалаи 26.3
        Fraction fraction = new Fraction(6, 8);
        Console.WriteLine("Табдилдихи ба адади хакики: " + fraction.Adad);
        fraction.Print();
        fraction.Ikhtisor();
        Fraction fraction2 = new Fraction(1, 2);
        Fraction.Compare(fraction, fraction2);
        Console.WriteLine();
        
        // Масъалаи 26.4
        Money money = new Money(25, 50);
        money.Balance();
        money.Kharid(2.75m);
        money.Balance();
        money.Daromad(20.65m);
        money.Balance();
    }
}