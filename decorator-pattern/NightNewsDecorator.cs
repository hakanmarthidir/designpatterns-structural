using System;

namespace decorator_pattern
{
    public class NightNewsDecorator : BasicNewsDecorator
    {
        public NightNewsDecorator(INews news) : base(news)
        {

        }

        private void SendToNightSlider()
        {
            Console.WriteLine("News was moved to night slider");
        }


        public override void Publish()
        {
            base.Publish();
            this.SendToNightSlider();

        }
    }
}
