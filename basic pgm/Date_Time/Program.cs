
class Program
{
    static void Main(string[] args)
    {


        DateTime dt = new DateTime();
        Console.WriteLine(dt);
        DateTime dt1 = new DateTime(2010, 12, 23);
        Console.WriteLine(dt1);
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("Days in Month:" + DateTime.DaysInMonth(2012, 2));
        Console.WriteLine("Leap Year:" + DateTime.IsLeapYear(2012));
        dt = DateTime.Now;
        Console.WriteLine("Day:" + dt.Day);
        Console.WriteLine("Month:" + dt.Month);
        Console.WriteLine("Year:" + dt.Year);
        Console.WriteLine("Hours:" + dt.Hour);
        Console.WriteLine("Minutes:" + dt.Minute);
        Console.WriteLine("Seconds:" + dt.Second);



        //dt = dt.AddDays(300);
        //dt = dt.AddMonths(30);
        dt = dt.AddYears(15);
        Console.WriteLine(dt);



        dt = DateTime.Now.AddDays(10);
        dt1 = DateTime.Now.AddMonths(1);
        Console.WriteLine("Compare:" + dt.CompareTo(dt1));
        TimeSpan tm = dt1.Subtract(dt);





        Console.WriteLine("Total Days:" + tm.TotalDays);
        Console.ReadLine();
    }
}