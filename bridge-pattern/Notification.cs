namespace bridge_pattern
{
    public class Notification
    {
        private readonly INotificationFormat _notificationFormat;
        public Notification(INotificationFormat notificationFormat)
        {
            this._notificationFormat = notificationFormat;
        }

        public virtual void SendNotificaiton()
        {
            var message = this._notificationFormat.GetNotification();
            //send it...
        }
    }


    public class MobileNotification : Notification
    {
        public MobileNotification(INotificationFormat notificationFormat) : base(notificationFormat)
        {

        }

        public override void SendNotificaiton()
        {
            base.SendNotificaiton();
        }
    }

    public class WebNotification : Notification
    {
        public WebNotification(INotificationFormat notificationFormat) : base(notificationFormat)
        {

        }

        public override void SendNotificaiton()
        {
            base.SendNotificaiton();
        }
    }




}
