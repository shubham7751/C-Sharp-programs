class goo
{
    public void doo()
    {
        Console.WriteLine("hiii");
    }
}
//Extension ()
static class goo1
{
    public static void doo1(this goo g)
    {
        Console.WriteLine("hello");
    }
}
class main
{
    static void Main(string[] args)
    {
        goo g = new goo();
        g.doo();
        g.doo1();
    }
}