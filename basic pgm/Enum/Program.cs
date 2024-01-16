
using System.Threading.Channels;

enum days { sun, mon, tue, wed, thur, fri, sat }

class goo
{
    static void Main(string[] args)
    {

        Console.WriteLine("sunday is : {0}", (int)days.sun);
        Console.WriteLine("monday is : {0}", (int)days.mon);
        Console.WriteLine("tuesday is : {0}", (int)days.tue);
        Console.WriteLine("wednesday is : {0}", (int)days.wed);
        Console.WriteLine("friday is : {0}", (int)days.fri);
    }

}