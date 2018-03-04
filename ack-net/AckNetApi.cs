using System;
using ArkNet;
using ArkNet.Utils.Enum;

namespace AckNet
{
    public class AckNetApi
    {
        public AckNetApi()
        {
            ArkNetApi.Instance.Start(NetworkType.MainNet).Wait();
        }
    }
}
