namespace PhoneKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sequence="";
            Console.WriteLine("Input text");
            string input = Console.ReadLine();

            foreach(char ch in input.ToLower().ToString())
            {
                switch (ch)
                {
                    case 'a': case 'b': case 'c':
                        sequence += "2";
                        break;
                    case 'd': case 'e': case 'f':
                        sequence += "3";
                        break;
                    case 'g': case 'h': case 'i':
                        sequence += "4";
                        break;
                    case 'j': case 'k': case 'l':
                        sequence += "5";
                        break;
                    case 'm': case 'n': case 'o':
                        sequence += "6";
                        break;
                    case 'p': case 'q': case 'r': case 's':
                        sequence += "7";
                        break;
                    case 't': case 'u': case 'v':
                        sequence += "8";
                        break;
                    case 'w': case 'x': case 'y': case 'z':
                        sequence += "8";
                        break;
                    case ' ':
                        sequence += "0";
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sequence);
        }
    }
}