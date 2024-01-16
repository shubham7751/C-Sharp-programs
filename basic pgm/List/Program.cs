using System.ComponentModel;

class goo
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();


        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        foreach (int h in list)
        { Console.Write(h); }
        Console.WriteLine();
        //
        list.Remove(2);
        foreach (int h in list)
        { Console.Write(h); }
        //
        Console.WriteLine();
        bool b = list.Contains(3);
        Console.Write(b);
        Console.WriteLine();
        //
        Console.WriteLine();
        list.Reverse();
        foreach (int f in list)
        { Console.Write(f); }
        Console.WriteLine();
        //
        list.Sort();
        foreach (int k in list)
        { Console.Write(k); }
        Console.WriteLine();
        //


        //
        Console.ReadLine();

    }


}