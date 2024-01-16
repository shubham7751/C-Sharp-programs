using System.Collections;

class doo
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add("a", 1);
        ht.Add("b", 2);
        ht.Add("c", 3);
        ht.Add("d", 4);

        Console.WriteLine(ht.Count);
        Console.WriteLine(ht.ToString());
        Console.WriteLine(ht.ContainsValue(5));
        Console.WriteLine(ht.ContainsKey("d"));
        Console.WriteLine(ht.Contains("a"));
        ht.Remove("a");

        foreach (string s in ht.Keys)
        {
            Console.Write(s);
        }
        Console.WriteLine();
        foreach (int s in ht.Values)
        {
            Console.Write(s);
        }



    }
}