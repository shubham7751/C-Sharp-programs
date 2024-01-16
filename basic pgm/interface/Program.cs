interface sum1
{
    public void add();
}
class sum : sum1
{
    //Explicite implimentation of interface method
    //void sum1.add()
    //{
    //    throw new NotImplementedException();
    //}

    public void add()//implicite implimentation of interface method
    {
        Console.WriteLine(  "hii");
    }
    public sum(int a,int b)//constructor
    {
        int c = a + b;
        Console.WriteLine(  "hello {0}",c);

    }
}
class main
{
    static void Main(string[] args)
    {
        sum s = new sum(10,20);
        s.add();
    }
}