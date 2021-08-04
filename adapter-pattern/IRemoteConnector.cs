using System;

namespace adapter_pattern
{
    //1
    public interface IRemoteConnector
    {
        void Connect();
    }

    //2
    public class BluetoothConnector : IRemoteConnector
    {
        public void Connect()
        {
            Console.WriteLine("Bluetooth connected successfully...");
        }
    }
    //3
    public class WirelessConnector : IRemoteConnector
    {
        public void Connect()
        {
            Console.WriteLine("Wireless connected successfully...");
        }
    }

}
