

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace practic1
{
    internal class Practic
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 3, 6, 83, 94 };

            //Console.WriteLine("Enter number :");
            //int num=Convert.ToInt32(Console.ReadLine());

            ////String name=Console.ReadLine();
            ////int num=Convert.ToInt32(name);
            //Console.WriteLine("your name is :"+num);
            //root r=new root();
            //String h=r.sum();
            //Console.WriteLine(h);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("aaaaaaaaa");
                Console.WriteLine("bbbbbbbbbbb");
                goto sd;
                Console.WriteLine("ddddddddd");
            }
        sd:
            Console.WriteLine("ccccccccccccc");


            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = i + 1; j <= 5; j++)
            //    {
            //        if (a[i] > a[j])
            //        {
            //            int temp = a[i];
            //            a[i] = a[j];
            //            a[j] = temp;
            //        }
            //    }


            //}
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write(" " + a[i]);
            //}
            Console.ReadKey();

        }
    }
}
