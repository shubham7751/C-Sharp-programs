using System.Threading.Channels;

using System;

namespace new_coading;

class Example
{
    interface run
    {
        public void run();
    }
     class Animal
    {
       public string a = "comes under animal class";
       

    }
    class Dog : Animal,run
    {
        string b = "dog";

        public void run()
        {
            Console.WriteLine("dog can run{0} {1}", b,a);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.run();
            

        }
    }
}
