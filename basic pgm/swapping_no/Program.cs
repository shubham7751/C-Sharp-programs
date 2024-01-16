class goo
{
    static void Main(string[] args)
    {
        int a=10,b=20;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine(  "{0} {1}",a,b);

        //temp = a;
        //a=b;
        //b=temp;
    }
}