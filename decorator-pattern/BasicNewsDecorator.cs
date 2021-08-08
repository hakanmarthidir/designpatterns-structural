namespace decorator_pattern
{
    public class BasicNewsDecorator : INews
    {
        private INews _news;

        public BasicNewsDecorator(INews news)
        {
            this._news = news;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public virtual void Publish()
        {
            this._news.Publish();           
        }
    }




}
