using System;
using System.Collections.Generic;

namespace Astro.Features.Quests
{
    public interface IQuest
    {
        event EventHandler Accomplished;

        IRewardDescriptor RewardDescription { get; }
        IEnumerable<IRequirement> Requirements { get; }
        IRewardProvider RewardProvider { get; }
    }
}
