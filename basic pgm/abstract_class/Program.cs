

    public abstract class sum
    {
        abstract public void add();
        abstract public void sub();

    }
    public class math : sum
    {
        public override void add()
        {
            int a = 29;
            int b = 44;
            int c = a + b;
            Console.WriteLine("addition is :{0}" , c);
        }

        public override void sub()
        {
            int a = 29;
            int b = 44;
            int c = a - b;
            Console.WriteLine("substraction is :{0}" ,c);
        }
    }
    class main
    {
    static void Main(string[] args)
    {
        math m = new math();
        m.sub();
        m.add();
    }
        
}
