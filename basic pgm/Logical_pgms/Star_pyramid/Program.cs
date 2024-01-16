class doo
{
    static void Main(string[] args)
    {
        for(int i = 1; i <=5; i++)
        {

            for (int j = i; j < 5; j++)
            {
                Console.Write(" ");
            }
                for (int k = 1; k < i; k++)
                {
                    Console.Write("*");
                }
                    for (int l = 1; l <=i; l++)
                    {
                        Console.Write(  "*");
                    }
                
            
            Console.WriteLine();
        }
    }
}