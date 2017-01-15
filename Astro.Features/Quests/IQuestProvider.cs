using System.Collections.Generic;

namespace Astro.Features.Quests
{
    public interface IQuestProvider<TQuest, TQuestDescriptor>
        where TQuest : IQuest
        where TQuestDescriptor : IQuestDescriptor
    {
        IEnumerable<TQuestDescriptor> Descriptors { get; }

        bool Provide(IQuestPerformer<TQuest, TQuestDescriptor> performer, TQuestDescriptor descriptor);
    }
}
