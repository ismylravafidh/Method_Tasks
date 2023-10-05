namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Min(13, 54, 75, 12, 84, 6, 2, 24, 97, 435, 65, 1335, 5375);
        }
        public static void Min(params int[] arrays)
        {
            int min = arrays[0];
            for (int i = 1; i < arrays.Length; i++)
            {
                if (arrays[i] < min)
                {
                    min = arrays[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}