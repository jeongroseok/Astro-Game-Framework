using System;
using System.Collections.Generic;

namespace Astro.Features.Quests
{
    public interface IQuestPerformer
	{
        event EventHandler Accepted;

        IEnumerable<IQuest> Progressing { get; }

        bool Accept(IQuest quest);
	}
}
