using System.ComponentModel;

namespace Astro.Features.Economic.Banking
{
    public interface IBankAccount : INotifyPropertyChanged
    {
        decimal Balance { get; }

        bool Deposit(decimal amount);
        bool Withdraw(decimal amount);
    }
}