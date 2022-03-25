

namespace SzyfrCezara
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var nigga in Console.ReadLine())
            {
                Console.Write(Convert.ToChar((nigga - 'a' + 3) % ('z' - 'a' + 3) + 'a'));
            }
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
