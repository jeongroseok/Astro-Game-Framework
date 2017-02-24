using System;

namespace Astro.Features.Quests
{
    public interface IQuest<TQuestDescriptor>
    {
        event EventHandler Completed;

        TQuestDescriptor Descriptor { get; }
        bool IsComplete { get; }
    }
}
