using System.Security.Cryptography.X509Certificates;

class sum
{
    public static void sub()
    {
        int a = 10;
        int b = 20;
        int c = 30;
        Console.WriteLine(  a+b+c);
    }
    static void Main(string[] args)
       
    {
        add s = new add();
        s.sub(5);
        sum.sub();
    }
}
class add
{
    public void sub(int a)
    {
        Console.WriteLine(  a);
    }
}