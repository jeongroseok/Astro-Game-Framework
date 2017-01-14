using Astro.Features.Services;

namespace Astro.Features.Economics
{
    /// <summary>
    /// Buyer와 Seller는 거래시에 서로 내부 데이터를 참조 할 상황이 발생한다.
    /// 하지만 내부 데이터를 public으로 설정하는것은 좋지 않으며,
    /// private으로 설정한다면 접근이 불가능하다.
    /// 이 문제를 해결하기 위해 ISeller.BeginTransaction 호출시
    /// Seller의 private 참조를 포함한 ITransaction 객체를 리턴하고
    /// IBuyer.Approve함수를 통해 Transaction에 Buyer의 내부 참조를 넣어준다.
    /// 두 거래자의 내부 데이터 참조를 모두 가지게된 Transaction객체는 Commit명령을 통해 최종적으로 거래를 완성한다.
    /// </summary>
    public interface ISeller<TTransaction> : ITransactor<TTransaction>
        where TTransaction : ITransaction
    {
    }
}
