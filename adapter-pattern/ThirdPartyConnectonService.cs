using System;

namespace adapter_pattern
{
    //4 i would like to implement a new 3rd party connector. 
    public class ThirdPartyConnectonService
    {
        public void Bind(string machineName)
        {
            Console.WriteLine($"{machineName} connected.");
        }
    }    

}
