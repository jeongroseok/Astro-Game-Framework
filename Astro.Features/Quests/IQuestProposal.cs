using System.Collections.Generic;

namespace Astro.Features.Quests
{
    /// <summary>
    /// 수행 가능 조건 등 퀘스트 정보를 나타내는 객체이다.
    /// IQuest 객체는 퀘스트를 받아들렸을때 IPerformer가 가지고 있는 IQuestCollection에 참조 넣어준다.
    /// </summary>
	public interface IQuestProposal
    {
        /// <summary>
        /// 수행 가능 조건이다.
        /// 이 조건을 전부 만족해야만 수행자(IPerformer)는 퀘스트를 수락(Accept) 할 수 있다.
        /// </summary>
        IEnumerable<IRequirement> Requirements { get; }

        bool TryAccept(IQuestPerformer performer);
	}
}
