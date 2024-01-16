class c1
{
    public void sum(int a)
    {
        Console.WriteLine(a);
    }
    public void sum(int d, int b)
    {

        Console.WriteLine("{0} {1}",d,b);
    }
    public void sum(int d, double c,int b)
    {
       

        Console.WriteLine("print sum {0}  {1}  {2}",d, c, b);
    }
}

class main
{
    static void Main(string[] args)
    {
        c1 c=new c1();
        c.sum(1);
        c.sum(55, 4,7);
        c.sum(33, 4.7,7);
    }
}