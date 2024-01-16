class sum
{
    public void add()
    {
        int a = 10;
        int b = 20;
       int c = a + b;
        Console.WriteLine("answer is :"+c);
    }
}
class sum1 : sum
{
    public void add()
    {
        //int c = 30;
        //int d = 40;
        //int e = c + d;
        //Console.WriteLine(e);
        base.add(); 
    }
}
class main
{
    static void Main(string[] args)
    {
        sum1 s = new sum1();
        s.add();
    }
}