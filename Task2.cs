//Bir metod yaradin.2 dene eded qebul elesin.1ci eded 2ci ededin quvveti olub olmadigini tapsin
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PowerOfNumber(1024,2);
        }
        public static void PowerOfNumber(int num1 , int num2)
        {
            int power = 0;
            while (num1 >= num2)
            {
                if (num1 % num2 == 0)
                {
                    num1 /= num2;
                    power++;
                }
                else
                {
                    power *= 0;
                    break;
                }
            }
            if (power == 0)
            {
                Console.WriteLine("Number 1 is not a power of number 2");
            }
            else
            {
                Console.WriteLine("Number 1 is a power of number 2");
            }
        }
    }
}