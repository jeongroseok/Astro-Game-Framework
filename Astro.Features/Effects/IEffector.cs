namespace Astro.Features.Effects
{
    public interface IEffector<TModifier> where TModifier : class
    {
        void Affect(TModifier modifier);
    }
}
