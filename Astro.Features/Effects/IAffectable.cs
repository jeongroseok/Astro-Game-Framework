using System;

namespace Astro.Features.Effects
{
    /// <summary>
    /// IEffector에게 Modifier를 제공해준다.
    /// </summary>
    /// <typeparam name="TModifier">내부 변수를 수정할 수 있는 객체가 된다.</typeparam>
    public interface IAffectable<TModifier> where TModifier : class
    {
        event EventHandler<AffectedEventArgs<TModifier>> Affected;

        void TakeEffect(IEffector<TModifier> effector);
    }
}
