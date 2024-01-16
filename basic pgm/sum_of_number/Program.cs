class goo
{
    static void Main(string[] args)
    {
        int n = 126, r, sum = 0;
        while (n != 0)
        {
            r = n % 10;
            sum = sum + r;
            n = n / 10;
        }
        Console.WriteLine(sum);
    }
}