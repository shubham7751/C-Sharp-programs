class goo
{

    static void Main(string[] args)
    {
        int a = 10;
        Console.WriteLine(Convert.ToByte(a));
        byte b = (byte)a;
        Console.WriteLine(b);
        Console.WriteLine(  "enter no:");
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("your no is:{0}",c);

    }
}