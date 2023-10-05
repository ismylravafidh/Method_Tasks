//FindCharIndex methodu-parametr olaraq string ve 1 char qebul edir.Gonderilmis charin hemin string
//deyerinde necenci indexde yerlesirse hemin indexi geri qaytarir, eger tapilmasa -1 qaytarir
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindCharIndex("symbol", 'o'));
        }
        public static int FindCharIndex(string word,  char symbol)
        {
            int index = -1;
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    index = i;
                }
            }
            if(index >=0)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}