namespace OddNumbers
{
    class Program
    {
        public static void Main(string [] args)
        {
            int n = 100;
            for (int i = 1; i <=n ; i++)
            {
                if(i % 2 != 0 )
                {
                    Console.WriteLine (i);
                }
            }
        }
    }
}