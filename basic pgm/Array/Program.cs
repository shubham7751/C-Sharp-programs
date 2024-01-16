class arr
{
    public void ar()

    {
        int []  array={ 1, 3, 2, 2, 2 };
        foreach(int h in array)
        {
            Console.Write(h);
        }
        Console.WriteLine();

        for (int i=0;i<array.Length; i++)
        {
            Console.Write(array[i]);   
        }
        
    }
}
class main
{
    static void Main(string[] args)
    {
        arr r=new arr();
        r.ar();
    }
}