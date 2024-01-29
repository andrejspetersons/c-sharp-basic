using System;

namespace VideoStore
{

    class Program
    {
        private static VideoStore _videostore=new VideoStore();
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            Console.WriteLine(string.Join(Environment.NewLine,_videostore.ListInventory()));
        }

        private static void FillVideoStore()
        {
            _videostore.AddVideo("Avengers");
            _videostore.AddVideo("Home Alone");
            _videostore.AddVideo("Titanic");
            _videostore.AddVideo("Inception");
            _videostore.AddVideo("Die Hard");
        }

        private static void RentVideo()
        {
            _videostore.CheckOutVideo("Her");
        }

        private static void ReturnVideo()
        {
            _videostore.ReturnVideo("Avengers");
            _videostore.ReturnVideo("Home Alone");
            _videostore.ReceiveRating("Avengers", 8);
            _videostore.ReceiveRating("Avengers", 9);
            _videostore.ReceiveRating("Home Alone", 10);
            _videostore.ReceiveRating("Home Alone", 8.5);
            _videostore.ReceiveRating("Inception", 8.5);
            _videostore.ReceiveRating("Inception", 9.5);
        }  
    }
}
