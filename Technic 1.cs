using System;
using System.IO;



//using Class 


class bookinfo
{
    public string BName;
    public int Price;
    public string Auther;
}
class Anon()
{
    public static void Main()
    {
        List<bookinfo> book = new List<bookinfo>();

        book.Add(new bookinfo
        {
            BName = "Ami Sohid",
            Price = 10,
            Auther = "Adnan",
        });


        book.Add(new bookinfo
        {
            BName = "Quran",
            Price = 102,
            Auther = "Abdullah",

        });


        book.Add(new bookinfo
        {
            BName = "Love",
            Price = 50,
            Auther = "Adnan",
        });

        book.Add(new bookinfo
        {
            BName = "Ami Sohid",
            Price = 10,
            Auther = "Adnan",
        });


        foreach (var x in book)
        {
            Console.WriteLine($"{x.BName} - {x.Price} - {x.Auther}");
        }

        Console.ReadKey();
    }
}
