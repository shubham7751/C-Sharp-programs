class A
{

    public void sum()
    {
        Console.WriteLine("hiiii");
    }
}
class main
{

    public delegate void Del(int a);
    //public void sum()
    //{
    //    Console.WriteLine("hi");
    //}
    static void Main(string[] args)
    {
        Del obj =(a)=>
        {
            a -= 5;
            Console.WriteLine("hi{0}",a);

        };
        obj.Invoke(2);
        A obj1 =new A();
        obj1.sum();
        
    }
}