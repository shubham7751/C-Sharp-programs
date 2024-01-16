class doo
{
    static void Main(string[] args)
    {
        Queue<string> q = new Queue<string>();

        q.Enqueue("a");
        q.Enqueue("b");
        q.Enqueue("c");
        q.Enqueue("d");
        q.Enqueue("e");

        foreach (string s in q)
        {
            Console.Write(s);
        }
        Console.WriteLine();
        //
        q.Dequeue();
        foreach (string s in q)
        {
            Console.Write(s);
        }
        Console.WriteLine();
        //
        Console.WriteLine(q.Contains("\na"));
        //
        Console.WriteLine(q.Count);

    }
}