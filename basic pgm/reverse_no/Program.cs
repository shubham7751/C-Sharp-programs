class goo
{
    static void Main(string[] args)
    {
        int n = 67453, r, s = 0;
        while(n!=0) {
            r = n % 10;
            s = s * 10 + r;
            n = n / 10;
        }
        Console.WriteLine(  s);
    }
}