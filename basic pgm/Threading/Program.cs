using System.Threading;
using System.Threading.Channels;

class doo
{
    public static void fun1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("111111");
        }

    }
}
class goo
{
    public static void fun2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("2222222");
            // Thread.Sleep(1000);
        }


    }
}
class foo
{
    public static void fun3()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("333333333");
        }

    }

}
class main
{
    static void Main(string[] args)
    {
        //doo d=new doo();
        //goo g=new goo();    
        //foo foo=new foo();
        Thread t1 = new Thread(doo.fun1);
        Thread t2 = new Thread(goo.fun2);
        Thread t3 = new Thread(foo.fun3);
        t1.Start();
        t2.Start();
        t3.Start();

    }
}