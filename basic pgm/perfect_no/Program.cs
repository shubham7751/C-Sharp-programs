class goo
{
    static void Main(string[] args)
    {
        int n, c, r, sum = 0;
        Console.WriteLine("enter number : ");
        n = Convert.ToInt32(Console.ReadLine());
        c = n;
        for (int i = 1; i < n; i++)
        {
            if (n % i < 0)
            {
                sum = sum + i;
            }

            if (c == sum)
            {
                Console.WriteLine("is perfect number ");
            }
            else
            {
                Console.WriteLine("not perfect number ");
            }
        }
    }
}