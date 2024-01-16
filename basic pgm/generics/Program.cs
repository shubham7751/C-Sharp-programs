class example
{
    public static void show<T>(T[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {

            Console.Write(arr[i]);
        }
    }
}
class main
{
    static void Main(string[] args)
    {
        // Convert.ToInt32(int a[] =  { 1, 3, 6, 4, 8 };);
        int[] a = new int[] { 1, 3, 6, 4, 8 };



        example.show(a);
    }
}