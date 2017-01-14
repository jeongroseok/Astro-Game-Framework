using System.Collections.Generic;

namespace Astro.Features.Quests
{
    public interface IQuestProposer
    {
        IEnumerable<IQuestProposal> Proposals { get; }
    }
}
