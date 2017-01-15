namespace Astro.Services
{
    public interface IMessageBus
    {
        void Subscribe<TMessageType>(MessageHandler<TMessageType> handler);
        void Unsubscribe<TMessageType>(MessageHandler<TMessageType> handler);
        void Publish<TMessageType>(TMessageType message);
    }
}
