namespace Dog
{
    internal class Program
    {
        /* public static void DogTest()
         {

         }*/

        static void Main(string[] args)
        {         
           
            Dog sparky = new Dog("Sparky", Sex.male);  
            Dog sam = new Dog("Sam", Sex.male);
            Dog lady = new Dog("Lady", Sex.male);
            Dog molly = new Dog("Molly", Sex.male);
            
            Dog buster = new Dog("Buster", Sex.male,lady,sparky);
            Dog rocky = new Dog("Rocky", Sex.male,molly,sam);
            Dog coco = new Dog("Coco", Sex.male,molly,buster);
            Dog max = new Dog("Max", Sex.male, lady,rocky);

            string cocosFather=coco.fathersName();
            string sparkyFather = sparky.fathersName();
            bool isSiblings = coco.HasSameMotherAs(rocky);

            Console.WriteLine(cocosFather);
            Console.WriteLine(sparkyFather);
            Console.WriteLine(isSiblings);
        }
    }
}