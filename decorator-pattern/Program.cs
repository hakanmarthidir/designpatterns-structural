using System;

namespace decorator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            INews newsSystem1 = new BreakingNewsDecorator(new News() { Id = 1, Title = "AAA", Content = "AAAAAA" });
            newsSystem1.Publish();

            Console.WriteLine("---------------");

            INews newsSystem2 = new NightNewsDecorator(new News() { Id = 2, Title = "BBB", Content = "BBBBBB" });
            newsSystem2.Publish();

            Console.WriteLine("---------------");

            INews newsSystem3 = new BreakingNewsDecorator(new NightNewsDecorator(new News() { Id = 3, Title = "CCC", Content = "CCCCCC" }));
            newsSystem3.Publish();
                       
        }
    }
}
