using System.Linq;
namespace Reverse_the_Case
{
    internal class Program
    {
        static string ReverseCase(string word)
        {
            string result = new string(word.Select(
                c=>char.IsUpper(c)?char.ToLower(c):(char.IsLower(c)?char.ToUpper(c):c)).ToArray()
                );

            return result;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word:");
            string input = Console.ReadLine()!;
            Console.WriteLine(ReverseCase(input));
        }
    }
}
