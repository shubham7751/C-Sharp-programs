class student
{


    public int rollno { get; set; }


    public string name { set; get; }
}
class main
{
    static void Main(string[] args)
    {
        student s = new student();
        int a = s.rollno = 1;
        string b = s.name = "shubham";

        Console.WriteLine("rollno is :{0}", a);
        Console.WriteLine("name is :{0}", b);
    }
}

//class student
//{


//    public string id { get; set; }
//    public string name { get; set; }
//    public string email { get; set; }


//    static void Main(string[] args)
//    {
//        student student = new student();

//        student.id = "101";
//        student.name = "shubham";
//        student.email = "shubhamj7751.com";

//        Console.WriteLine("id = " + student.id);
//        Console.WriteLine("name = " + student.name);
//        Console.WriteLine("email = " + student.email);
//    }
//}