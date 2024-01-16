class goo
{
    static void Main(string[] args)
    {
        Dictionary<string, int> d = new Dictionary<string, int>();

        d.Add("aa", 1);
        d.Add("bb", 2);
        d.Add("cc", 3);
        d.Add("dd", 4);
        d.Add("ee", 5);


        foreach (KeyValuePair<string, int> s in d)
        {
            Console.WriteLine("{0} -> {1}", s.Key, s.Value);
        }

        d.Remove("cc");
        Console.WriteLine(d.Remove("bb"));

        foreach (KeyValuePair<string, int> s in d)
        {
            Console.WriteLine("{0} -> {1}", s.Key, s.Value);
        }
        bool b = d.ContainsKey("ee"); Console.WriteLine(b);


    }
}