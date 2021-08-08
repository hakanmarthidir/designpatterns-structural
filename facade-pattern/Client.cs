using System;

namespace facade_pattern
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void CheckClientInfo()
        {
            Console.WriteLine("Client is valid...");
        }

    }
}
