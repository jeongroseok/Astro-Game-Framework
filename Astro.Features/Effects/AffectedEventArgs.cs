using System;

namespace Astro.Features.Effects
{
    public class AffectedEventArgs<TModifier> : EventArgs
        where TModifier : class
    {
        public IEffector<TModifier> Effector { get; private set; }

        public AffectedEventArgs(IEffector<TModifier> effector)
        {
            Effector = effector;
        }
    }
}
