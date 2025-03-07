namespace Testing
{

    public class Addition
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    public class FindBig
    {
        public int FindBiggest(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            Console.WriteLine(addition.Add(1, 2));
            FindBig findBig = new FindBig();
            Console.WriteLine(findBig.FindBiggest(-222, 2));
        }
    }
}
