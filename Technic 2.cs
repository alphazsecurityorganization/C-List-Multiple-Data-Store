using System;
using System.IO;



//using Tuple 

class Anon
{
    public static void Main()
    {
        List<Tuple<int,string>> list = new List<Tuple<int,string>>();

        list.Add(new Tuple<int,string>(1,"Adnqan"));
        list.Add(new Tuple<int, string>(2, "TOm"));
        list.Add(new Tuple<int, string>(3, "CAt"));
        list.Add(new Tuple<int, string>(4, "Boom"));
        list.Add(new Tuple<int, string>(5, "Bangladersh"));
        list.Add(new Tuple<int, string>(6, "Anon"));


        foreach(var item in list)
        {
            Console.WriteLine($"{item.Item1} {item.Item2}");
        }

        Console.ReadKey();
    }
}
