namespace Capitalize
{
    internal class Program
    {
        public static string CapMe(string[] names){

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Substring(0, 1).ToUpper() + names[i].Substring(1).ToLower();
            }

            return "[" + string.Join(",", names) + "]";                
        }

        static void Main(string[] args)
        {
            string[] names1 = { "mavis", "senaida", "letty" };
            string[] names2 = { "samuel", "MABELLE", "letitia", "meridith" };
            string[] names3 = { "Slyvia", "Kristal", "Sharilyn", "Calista" };
            Console.WriteLine(CapMe(names1));
            Console.WriteLine(CapMe(names2));
            Console.WriteLine(CapMe(names3));
        }
    }
}