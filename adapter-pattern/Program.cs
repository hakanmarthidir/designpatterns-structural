using System;

namespace adapter_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IRemoteConnector bluetoothConnector = new BluetoothConnector();
            IRemoteConnector wirelessConnector = new WirelessConnector();
            IRemoteConnector thirpartyConnector = new ThirdPartyAdapter(new ThirdPartyConnectonService());

            ConnectionManager connectionManager = new ConnectionManager();
            connectionManager.CreateConnection(bluetoothConnector);
            connectionManager.CreateConnection(wirelessConnector);
            connectionManager.CreateConnection(thirpartyConnector);
        }
    }
}
