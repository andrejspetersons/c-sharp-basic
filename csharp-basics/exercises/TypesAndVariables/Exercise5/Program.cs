namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] subjects={
                "English III",
                "Precalculus",
                "Music Theory",
                "Biotechnology",
                "Principles of Technology I",
                "Latin II",
                "AP US History",
                "Business Computer Information Systems"
            };

            string[] principles =
            {
                "Ms. Lapan",
                "Mrs. Gideon",
                "Mr. Davis",
                "Mr. Palmer",
                "Ms. Garcia",
                "Mrs. Barnett",
                "Ms. Johannessen",
                "Mr. James"
            };


            Console.WriteLine("+----------------------------------------------------------+");
            for (int i = 0,j = 0; i < subjects.Length && j < principles.Length; i++,j++)
            {
                Console.WriteLine($"|{i+1}"+String.Format("|{0,40}|{1,15}|", subjects[i], principles[j]));
            }
            Console.WriteLine("+----------------------------------------------------------+");

        }
    }
}