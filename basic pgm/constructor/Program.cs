using System.Security.Cryptography.X509Certificates;

class fun
{
   public fun(int x,int y)
    {

        Console.WriteLine("{0} "+x,y);


    }
    fun(int a)
    {
        int x = a;
        Console.WriteLine(x);
    }
    static fun()
    {
        Console.WriteLine("static constructor");
    }


    static void Main(string[] args)
    {
        fun f = new fun(10);
        fun fi = new fun(10,80);


    }
}