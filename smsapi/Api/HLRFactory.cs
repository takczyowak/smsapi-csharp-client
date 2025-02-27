﻿using SMSApi.Api.Action;

namespace SMSApi.Api
{
    public class HLRFactory : Factory
    {
        public HLRFactory(ProxyAddress address = ProxyAddress.SmsApiIo)
            : base(address)
        { }

        public HLRFactory(IClient client, ProxyAddress address = ProxyAddress.SmsApiIo)
            : base(client, address)
        { }

        public HLRFactory(IClient client, Proxy proxy)
            : base(client, proxy)
        { }

        public HLRCheckNumber ActionCheckNumber(string number = null)
        {
            var action = new HLRCheckNumber();
            action.Proxy(proxy);
            action.SetNumber(number);
            return action;
        }
    }
}
