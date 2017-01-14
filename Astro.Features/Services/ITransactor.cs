namespace Astro.Features.Services
{
    public interface ITransactor<TTransaction> where TTransaction : ITransaction
    {
        TTransaction BeginTransaction();
    }
}
