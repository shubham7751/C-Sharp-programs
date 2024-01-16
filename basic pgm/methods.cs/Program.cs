class sum
{
    public void add()
    {
        int a = 10;
        int b=20;
        int c=a+b;
        Console.WriteLine(c);
    }
}
class sub
{
    public int min(int x,int y)
    {
        int a = x;
        int b = y;
        int c = a+b;    
        //Console.WriteLine(c);
        return a;
    }
}
class main
{
    static void Main(string[] args)
    {
        sub sb=new sub();
        sum s=new sum();
        s.add();
        int d=sb.min(5, 7);
        Console.WriteLine(d);
    }
}