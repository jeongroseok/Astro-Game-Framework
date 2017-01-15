namespace Astro.Features.Serialization
{
    public interface ISerializer
    {
        void Serialize(byte[] buffer, int offset, int size);
        T Deserialize<T>(byte[] buffer, int offset, int size);
    }
}
