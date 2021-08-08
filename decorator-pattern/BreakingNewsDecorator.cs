using System;

namespace decorator_pattern
{
    public class BreakingNewsDecorator : BasicNewsDecorator
    {
        public BreakingNewsDecorator(INews news) : base(news)
        {

        }

        private void SendToMainSlider()
        {
            Console.WriteLine("News was moved to main slider");
        }


        public override void Publish()
        {
            base.Publish();
            this.SendToMainSlider();

        }
    }
}
