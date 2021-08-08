using System;

namespace facade_pattern
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void CheckProductAvailability()
        {
            Console.WriteLine("Product is valid...");
        }

    }
}
