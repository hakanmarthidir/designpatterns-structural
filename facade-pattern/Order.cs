using System;

namespace facade_pattern
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public void Create()
        {
            Console.WriteLine("Order was created successfully...");
        }

    }
}
