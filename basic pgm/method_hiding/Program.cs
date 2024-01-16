class me
{
    public static void me1()
    {
        Console.WriteLine("hi");
    }
}
class mee :me
{
    public static void me1()
    {
        Console.WriteLine("hello");
    }
}
class main
{
    static void Main(string[] args)
    {
        
        mee.me1();
    }
}