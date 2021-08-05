using System;

namespace bridge_pattern
{
    class Program
    {
        static void Main(string[] args)
        {


            WebNotification webNotification = new WebNotification(new JsonNotificationFormat());
            webNotification.SendNotificaiton();

            MobileNotification mobileNotification = new MobileNotification(new XmlNotificationFormat());
            mobileNotification.SendNotificaiton();



        }
    }
}
