namespace Astro.Features.Poolings
{
    public interface IPool
    {
        void Reserve(int reserve);
        object Pull();
        object ForcePull(object instance, bool withInitialization = true);
        void Push(object instance);
        void Clear();
    }

    public interface IPool<T> : IPool
    {
        new T Pull();
        T ForcePull(T instance, bool isInit = true);
        void Push(T instance);
    }
}
