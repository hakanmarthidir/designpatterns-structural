using System;
using System.Collections.Generic;

namespace flyweight_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sample 1 - News Creator
            List<NewsType> newsList = new List<NewsType>() { NewsType.Economic, NewsType.Sport, NewsType.Economic };
            NewsFactory newsFactory = new NewsFactory();

            foreach (var newsType in newsList)
            {
                News myNews = newsFactory.GetNews(newsType);
                myNews.Publish();
            }

            //Sample 2 - TShirt Creator
            var sizes = new TshirtSize[] { TshirtSize.XL, TshirtSize.XS, TshirtSize.XS, TshirtSize.XS, TshirtSize.XXL };
            TShirtFactory tshirtFactory = new TShirtFactory();

            foreach (var tsize in sizes)
            {
                TShirt newTShirt = tshirtFactory.CreateTshirt(tsize);
                newTShirt.CreateTshirt();
            }



        }
    }

}
