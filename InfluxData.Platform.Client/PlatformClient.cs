using System;
using InfluxData.Platform.Client.Option;
using Platform.Common.Platform;
using Platform.Common.Platform.Rest;

namespace InfluxData.Platform.Client
{
    public class PlatformClient : AbstractClient
    {
        public PlatformClient(PlatformOptions options)
        {
            Arguments.CheckNotNull(options, "PlatformOptions");
            
            Client.HttpClient.BaseAddress = new Uri(options.Url);
            Client.HttpClient.Timeout = options.Timeout;
        }
    }
}