class goo
{
    static void Main(string[] args)
    {
        int n, count = 0;
        Console.WriteLine("enter number : ");
        n=Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= n; i++)
        {
            if(n%i == 0)
            {
                count++;
            }
        }
        if(count==2)
        {
            Console.WriteLine("number is prime no");
        }
        else { Console.WriteLine("not prime number"); }
    }
}