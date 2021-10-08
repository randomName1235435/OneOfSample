using System;
using System.Diagnostics.Contracts;

namespace OneOfSample.GenericStruct
{
    public readonly struct BetterResult<TSucces, TFailed>
    {
        internal readonly BetterResultState State;
        internal readonly TSucces SuccessValue;
        internal readonly TFailed FailValue;

        public BetterResult(TSucces successValue)
        {
            State = BetterResultState.Success;
            SuccessValue = successValue;
            FailValue = default;
        }

        public BetterResult(TFailed failValue)
        {
            State = BetterResultState.Fail;
            FailValue = failValue;
            SuccessValue = default;
        }

        [Pure]
        public bool IsFail =>
                State == BetterResultState.Fail;

        [Pure]
        public bool IsSuccess =>
            State == BetterResultState.Success;

        public R Match<R>(Func<TSucces, R> Succ, Func<TFailed, R> Fail) =>
            IsSuccess ? Succ(this.SuccessValue) : Fail(this.FailValue);
    }
}
