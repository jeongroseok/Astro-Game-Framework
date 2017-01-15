namespace Astro.Services
{
    public interface ITransactor<TTransaction> where TTransaction : ITransaction
    {
        TTransaction BeginTransaction();
    }
}
