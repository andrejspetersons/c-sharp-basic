namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product("Logitech mouse",70.00,14),
                new Product("iPhone5s",999.99,3),
                new Product("Epson EB-U05",440.46,1),
            };
           
            for (int i = 0; i < products.Length; i++)
            {
                products[i].PrintProduct();   
            }

            products[0].ChangePrice(110.00);
            products[0].ChangeQuantity(50);
            Console.WriteLine("\nChanged price and quantity:");
            products[0].PrintProduct();       
        }
    }
}