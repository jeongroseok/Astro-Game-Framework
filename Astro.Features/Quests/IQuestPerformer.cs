using System.Collections.Generic;

namespace Astro.Features.Quests
{
    public interface IQuestPerformer<TQuest, TQuestDescriptor>
        where TQuest : IQuest<TQuestDescriptor>
        where TQuestDescriptor : IQuestDescriptor
    {
        IEnumerable<TQuest> Quests { get; }

        void Perform(TQuest quest);
    }
}
