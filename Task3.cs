namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Integer( 2, 3, 4, 5, 6, 8, 9,1);
        }
        public static void Integer( params int[] array)
        {
            bool sort = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i-1])
                {
                    sort = true;
                }
                else
                {
                    sort = false;
                    break;
                }
            }
            if (sort == true)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}