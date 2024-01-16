
class emp
{
    private int empid;
    private string empname;

    public void take(int id, string name)
    {
        this.empid = id;
        this.empname = name;
    }
    public void print()
    {
        Console.WriteLine("emp id is :{0}", this.empid);
        Console.WriteLine("emp name is :{0}", this.empname);
    }

}
class main
{
    static void Main(string[] args)
    {
        emp e1 = new emp();
        e1.take(77, "shubham");
        e1.print();

        emp e2 = new emp();
        e2.take(88, "akshay");
        e2.print();

    }
}