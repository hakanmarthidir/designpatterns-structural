using System;

namespace decorator_pattern
{
    public class News : INews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public void Publish()
        {
            Console.WriteLine($"{this.Id} successfully published.");
        }      
    }

}
