class goo
{
    static void Main(string[] args)
    {
        int fact = 1;
        for (int i = 1; i <= 5; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine(fact);
    }
}