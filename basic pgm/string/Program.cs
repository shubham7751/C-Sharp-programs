using System.Linq;

class string_fun
{
    static void Main(string[] args)
    {
        String s = "Shubham";
        String j = "Shubham";
        String m = new String("Shubham");
        
        Console.WriteLine(  s.IndexOf("h"));
        Console.WriteLine(  s.ToUpper());
        Console.WriteLine( j.ToLower());
        Console.WriteLine( s.Trim());
        Console.WriteLine(s.Length);
        Console.WriteLine(s.LastIndexOf(s));
        Console.WriteLine(s.StartsWith("Sh"));
        Console.WriteLine( s.EndsWith("ham"));
        Console.WriteLine(s.Replace("S","a"));
        Console.WriteLine(s.Concat("Shubham"));
        Console.WriteLine("->",s,j);
        Console.WriteLine(s == j);
        Console.WriteLine(s + j);
        Console.WriteLine( s.Contains("ubh" ));
        Console.WriteLine(s.CompareTo(j));


       
    }
}