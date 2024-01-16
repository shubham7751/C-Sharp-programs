
  
         class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] arr = new int[5];
        Console.Write("\nEnter your number:\t");

        for (i = 0; i < 5; i++)
            {              
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("you entered {0}", arr[i]);
            }
            Console.ReadLine();
        }
    }


