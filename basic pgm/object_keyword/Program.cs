class doo
{
    public void sum(object a, object b)
    {
        Console.WriteLine("{0} {1}", a, b);
    }
}
class main
{
    static void Main(string[] args)
    {
        doo d = new doo();
        d.sum("string", 77);
    }
}