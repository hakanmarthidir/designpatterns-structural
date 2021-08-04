namespace adapter_pattern
{
    //5 in this manager, i could not use the ThirdPartyConnectonService because it is not suitable, manager is expecting a class which was implemented IRemoteConnector
    public class ConnectionManager
    {
        public void CreateConnection(IRemoteConnector remoteConnector)
        {
            remoteConnector.Connect();
        }

    }

    //IRemoteConnector bluetoothConnector = new BluetoothConnector();
    //IRemoteConnector wirelessConnector = new WirelessConnector();
    //IRemoteConnector thirpartyConnector = new ThirdPartyAdapter(new ThirdPartyConnectonService());

    //ConnectionManager connectionManager = new ConnectionManager();
    //connectionManager.CreateConnection(bluetoothConnector);
    //connectionManager.CreateConnection(wirelessConnector);
    //connectionManager.CreateConnection(thirpartyConnector);

}
