class goo
{
    static void Main(string[] args)
    {
        //Creat File
        string p = @"C:\Users\NTS-ShubhamJawale\Desktop\img\\vsfile.txt";
        string q = @"C:\Users\NTS-ShubhamJawale\Desktop\img\\copyfile.txt";
        // FileStream fs =File.Create(p);

        //if (File.Exists(p))
        //{
        //    Console.WriteLine("File is created.");
        //}
        //else
        //{
        //    Console.WriteLine("File is not created.");
        //}


        //Write
        File.WriteAllText(p, "ganpati bappa morya....");
        //Read
        string readText = File.ReadAllText(p);
        Console.WriteLine(readText);
        //copy
        File.Copy(p, q); Console.WriteLine();



    }
}