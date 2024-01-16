class doo
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = i; j < 5; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}