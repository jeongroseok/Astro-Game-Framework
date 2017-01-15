using System.Collections.Generic;

namespace Astro.Networking
{
    public class NetworkMessenger
    {
        private IDictionary<int, INetworkMessageHandler> handlers;

        protected IConnection Connection { get; private set; }

        public NetworkMessenger(IConnection connection)
        {
            handlers = new Dictionary<int, INetworkMessageHandler>();
            Connection = connection;
        }

        public void Start()
        {

        }

        //private async void HandleReceive()
        //{
        //    while (Connection.Connected)
        //    {
        //        var msg = await Connection.Receive();
        //        if (msg != null)
        //        {
        //            handlers[msg.DestinationId].Handle(msg);
        //        }
        //    }
        //}

        public void Register(INetworkMessageHandler handler)
        {
            handlers[handler.Id] = handler;
        }

        public void Unregister(INetworkMessageHandler handler)
        {
            handlers.Remove(handler.Id);
        }
    }
}
