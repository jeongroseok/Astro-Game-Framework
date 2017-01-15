using System.Collections.Generic;
using System.ComponentModel;

namespace Astro.Features.Quests
{
    public interface IQuest : INotifyPropertyChanged
    {
        IEnumerable<IQuestObjective> Objectives { get; }
        bool CanProvide { get; }

        bool ProvideReward();
    }
}
