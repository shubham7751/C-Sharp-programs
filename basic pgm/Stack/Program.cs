class goo
{
    static void Main(string[] args)

    {
        //Queue<string> g = new Queue<string>();
        Stack<string> g = new Stack<string>();
        g.Push("a");
        g.Push("b");
        g.Push("c");
        g.Push("d");
        g.Push("e");
        g.Push("f");
        foreach (string h in g)
        {
            Console.Write(h);
        }
        Console.WriteLine();
        //
        g.Pop();
        foreach (string h in g)
        {
            Console.Write(h);
        }
        Console.WriteLine();
        //
        Console.WriteLine(g.Peek());
        Console.WriteLine();
        //
        Console.WriteLine(g.Count);
        //
        Console.WriteLine(g.Contains("e"));

    }
}