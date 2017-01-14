using System;
using System.Collections.Generic;

namespace Astro.Features.Quests
{
    public interface IQuestPerformer : IEnumerable<IQuest>
	{
        event EventHandler Accepted;

        bool Accept(IQuest quest);
	}
}
