class goo
{
    static void Main(string[] args)
    {
        int sum = 0;
        for(int i = 1; i <= 100; i++)
        {
            for(int j = 2; j <= i - 1; j++)
            {
                if(i%j == 0)
                {
                    sum = sum + 1;
                }
                if (sum == 0)
                {
                    Console.WriteLine(  i);
                }
                
            }
        }
    }
}