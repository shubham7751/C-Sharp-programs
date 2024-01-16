using System.Runtime.CompilerServices;

public partial class geeks
{
    public void display()
    {
        Console.WriteLine(name);
        Console.WriteLine(no);


    }
}
//Extension method called
public static class doo
{
    public static void goo(this geeks g)
    {
        Console.WriteLine("extension method called..");
    }
}