namespace Astro.Features.Quests
{
    public interface IRewardProvider
    {
        bool TryProvide(IQuestPerformer performer);
    }
}
