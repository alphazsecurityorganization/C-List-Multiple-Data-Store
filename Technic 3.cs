using System;
using System.IO;

class Anon
{
    public static void Main()
    {
        List<(string name, string number,int age)> list = new List<(string name, string number, int age)> ();

        list.Add(("Adnan", "01313244442", 10));
        list.Add(("Dev", "013143534442", 17));
        list.Add(("Tom", "01435442", 14));
        list.Add(("Jerry", "0454354442", 12));
        list.Add(("Fox", "0134353442", 18));

        foreach (var x in list)
        {
            Console.WriteLine($"{x.name} , {x.number} , {x.age}");
        }
    }
}
