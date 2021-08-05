using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_pattern
{
    public interface INotificationFormat
    {
        string GetNotification();
    }

    public class JsonNotificationFormat : INotificationFormat
    {
        public string GetNotification()
        {
            throw new NotImplementedException();
        }
    }


    public class XmlNotificationFormat : INotificationFormat
    {
        public string GetNotification()
        {
            throw new NotImplementedException();
        }
    }

}
