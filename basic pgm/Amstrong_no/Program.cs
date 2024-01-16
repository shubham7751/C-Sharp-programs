class goo
{
    static void Main(string[] args)
    {
        int n, c, r, s = 0;
        Console.WriteLine("enter number : ");
        n = Convert.ToInt32(Console.ReadLine());
        c = n;
        while (n > 0)
        {
            r = n % 10;
            s = (r*r*r)+s;
            n = n / 10;
        }
        if (c == s)
        {
            Console.WriteLine("is amstrong number ");
        }
        else
        {
            Console.WriteLine("not amstrong number ");
        }
    }
}