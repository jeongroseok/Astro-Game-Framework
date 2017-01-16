using System.Collections.Generic;

namespace Astro.Features.Quests
{
    public interface IQuestPerformer<TQuest, TQuestDescriptor>
        where TQuest : IQuest<TQuestDescriptor>
        where TQuestDescriptor : IQuestDescriptor
    {
        IEnumerable<TQuest> InProgress { get; }
        IEnumerable<TQuest> Complated { get; }

        void Perform(TQuest quest);
    }
}
