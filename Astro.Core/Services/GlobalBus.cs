namespace Astro.Services
{
    public static class GlobalBus
    {
        private static InternalBus instance;
        private static InternalBus Instance
        {
            get
            {
                if (instance == null)
                    instance = new InternalBus();
                return instance;
            }
        }

        public static void Publish<TMessageType>(TMessageType message)
        {
            Instance.Publish(message);
        }

        public static void Subscribe<TMessageType>(MessageHandler<TMessageType> handler)
        {
            Instance.Subscribe(handler);
        }

        public static void Unsubscribe<TMessageType>(MessageHandler<TMessageType> handler)
        {
            Instance.Unsubscribe(handler);
        }

        private class InternalBus : IMessageBus
        {
            public void Publish<TMessageType>(TMessageType message)
            {
                Handler<TMessageType>.Invoke(message);
            }

            public void Subscribe<TMessageType>(MessageHandler<TMessageType> handler)
            {
                Handler<TMessageType>.Published += handler;
            }

            public void Unsubscribe<TMessageType>(MessageHandler<TMessageType> handler)
            {
                Handler<TMessageType>.Published -= handler;
            }
        }

        private static class Handler<TMessageType>
        {
            public static event MessageHandler<TMessageType> Published;

            public static void Invoke(TMessageType message)
            {
                if (Published != null)
                    Published.Invoke(message);
            }
        }

    }
}
