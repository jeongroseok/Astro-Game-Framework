using System.ComponentModel;

namespace Astro.Features.Economics.Bankings
{
    public interface IBankAccount : INotifyPropertyChanged
    {
        decimal Balance { get; }

        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
    }
}