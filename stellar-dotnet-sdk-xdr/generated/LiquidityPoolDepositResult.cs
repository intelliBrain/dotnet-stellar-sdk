// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  union LiquidityPoolDepositResult switch (
    //      LiquidityPoolDepositResultCode code)
    //  {
    //  case LIQUIDITY_POOL_DEPOSIT_SUCCESS:
    //      void;
    //  default:
    //      void;
    //  };

    //  ===========================================================================
    public class LiquidityPoolDepositResult
    {
        public LiquidityPoolDepositResult() { }

        public LiquidityPoolDepositResultCode Discriminant { get; set; } = new LiquidityPoolDepositResultCode();

        public static void Encode(XdrDataOutputStream stream, LiquidityPoolDepositResult encodedLiquidityPoolDepositResult)
        {
            stream.WriteInt((int)encodedLiquidityPoolDepositResult.Discriminant.InnerValue);
            switch (encodedLiquidityPoolDepositResult.Discriminant.InnerValue)
            {
                case LiquidityPoolDepositResultCode.LiquidityPoolDepositResultCodeEnum.LIQUIDITY_POOL_DEPOSIT_SUCCESS:
                    break;
                default:
                    break;
            }
        }
        public static LiquidityPoolDepositResult Decode(XdrDataInputStream stream)
        {
            LiquidityPoolDepositResult decodedLiquidityPoolDepositResult = new LiquidityPoolDepositResult();
            LiquidityPoolDepositResultCode discriminant = LiquidityPoolDepositResultCode.Decode(stream);
            decodedLiquidityPoolDepositResult.Discriminant = discriminant;
            switch (decodedLiquidityPoolDepositResult.Discriminant.InnerValue)
            {
                case LiquidityPoolDepositResultCode.LiquidityPoolDepositResultCodeEnum.LIQUIDITY_POOL_DEPOSIT_SUCCESS:
                    break;
                default:
                    break;
            }
            return decodedLiquidityPoolDepositResult;
        }
    }
}
