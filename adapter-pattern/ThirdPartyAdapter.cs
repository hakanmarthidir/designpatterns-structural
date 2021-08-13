using System;

namespace adapter_pattern
{
    //6 Creating Adapter for ThirdPartyConnectionService 
    public class ThirdPartyAdapter : IRemoteConnector
    {
        private readonly ThirdPartyConnectonService _thirdPartyConnectonService;

        public ThirdPartyAdapter(ThirdPartyConnectonService thirdPartyConnectonService)
        {
            this._thirdPartyConnectonService = thirdPartyConnectonService;
        }
        public void Connect()
        {           
            var machineName = Environment.MachineName;
            this._thirdPartyConnectonService.Bind(machineName);
        }
    }

}
