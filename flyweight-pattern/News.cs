using System;
using System.Collections.Generic;

namespace flyweight_pattern
{
    public abstract class News
    {

        protected string Category { get; set; }
        protected DateTime Date { get; set; }

        public abstract void Publish();
    }

    public enum NewsType
    {
        Sport,
        Economic
    }

    public class SportNews : News
    {
        public SportNews()
        {
            this.Category = "Sport";
            this.Date = DateTime.UtcNow;
        }

        public override void Publish()
        {
            Console.WriteLine("Published on second page");
        }
    }

    public class EconomicNews : News
    {
        public EconomicNews()
        {
            this.Category = "Economic";
            this.Date = DateTime.UtcNow;
        }
        public override void Publish()
        {
            Console.WriteLine("Published on first page");
        }
    }

    public class NewsFactory
    {
        private Dictionary<NewsType, News> newsDictionary;
        public NewsFactory()
        {
            this.newsDictionary = new Dictionary<NewsType, News>();
        }

        public News GetNews(NewsType type)
        {
            News news = null;
            if (this.newsDictionary.ContainsKey(type))
            {
                news = this.newsDictionary[type];
            }
            else
            {
                switch (type)
                {
                    case NewsType.Sport:
                        news = new SportNews();
                        break;
                    case NewsType.Economic:
                        news = new EconomicNews();
                        break;
                    default:
                        break;
                }
            }

            return news;
        }
    }

}
