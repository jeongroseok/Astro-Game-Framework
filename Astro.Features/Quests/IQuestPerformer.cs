using System.Collections.Generic;

namespace Astro.Features.Quests
{
    public interface IQuestPerformer<TQuest, TQuestDescriptor>
        where TQuest : IQuest
        where TQuestDescriptor : IQuestDescriptor
    {
        IEnumerable<TQuestDescriptor> InProgress { get; }
        IEnumerable<TQuestDescriptor> Complated { get; }

        void Perform(TQuest quest);
    }
}
