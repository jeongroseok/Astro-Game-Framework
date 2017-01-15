namespace Astro.Networking
{
    public interface INetworkMessageHandler
    {
        short Id { get; }

        void Handle(NetworkMessage message);
    }
}
