namespace Monopoly.LiqPay.Exceptions
{
    using Monopoly.Core.Exceptions;
    using Monopoly.LiqPay.Enums;
    using Monopoly.LiqPay.Resources;

    public class WrongSignatureException : BaseAppException
    {
        public WrongSignatureException()
            : base(LiqPayErrorMessages.WrongSignatureException)
        {
        }

        public WrongSignatureException(string message)
            : base(message)
        {
        }

        public override int Code => (int)LiqPayErrorCodesEnum.WrongSignature;
    }
}