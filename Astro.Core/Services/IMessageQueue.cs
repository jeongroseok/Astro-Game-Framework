namespace Astro.Services
{
    public interface IMessageQueue<TMessageType>
    {
        void Subscribe(MessageHandler<TMessageType> handler);
        void Unsubscribe(MessageHandler<TMessageType> handler);
        void Publish(TMessageType message);
    }
}
