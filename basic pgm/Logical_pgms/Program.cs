class goo
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 1, c;
        for(int i = 0; i < 8; i++) {

            Console.Write(  a);
            c = a + b;
            a = b;
            b=c;
        }
    }
}