namespace Astro.Features.Quests
{
    public interface IQuest<TQuestDescriptor>
    {
        TQuestDescriptor Descriptor { get; }
        bool CanProvide { get; }

        bool TryProvideReward();
    }
}
