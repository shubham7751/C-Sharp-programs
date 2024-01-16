 partial class geeks
{
    private string name;
    private int no;
    public void foo(string a,int i)
    {
        this.name = a; this.no = i; 
    }
    //Extension method print
    public  void too()
    {
        Console.WriteLine("methode goo prints");
    }
}