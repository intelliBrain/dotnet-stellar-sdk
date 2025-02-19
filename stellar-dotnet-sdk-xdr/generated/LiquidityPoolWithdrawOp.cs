// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  struct LiquidityPoolWithdrawOp
    //  {
    //      PoolID liquidityPoolID;
    //      int64 amount;         // amount of pool shares to withdraw
    //      int64 minAmountA;     // minimum amount of first asset to withdraw
    //      int64 minAmountB;     // minimum amount of second asset to withdraw
    //  };

    //  ===========================================================================
    public class LiquidityPoolWithdrawOp
    {
        public LiquidityPoolWithdrawOp() { }
        public PoolID LiquidityPoolID { get; set; }
        public Int64 Amount { get; set; }
        public Int64 MinAmountA { get; set; }
        public Int64 MinAmountB { get; set; }

        public static void Encode(XdrDataOutputStream stream, LiquidityPoolWithdrawOp encodedLiquidityPoolWithdrawOp)
        {
            PoolID.Encode(stream, encodedLiquidityPoolWithdrawOp.LiquidityPoolID);
            Int64.Encode(stream, encodedLiquidityPoolWithdrawOp.Amount);
            Int64.Encode(stream, encodedLiquidityPoolWithdrawOp.MinAmountA);
            Int64.Encode(stream, encodedLiquidityPoolWithdrawOp.MinAmountB);
        }
        public static LiquidityPoolWithdrawOp Decode(XdrDataInputStream stream)
        {
            LiquidityPoolWithdrawOp decodedLiquidityPoolWithdrawOp = new LiquidityPoolWithdrawOp();
            decodedLiquidityPoolWithdrawOp.LiquidityPoolID = PoolID.Decode(stream);
            decodedLiquidityPoolWithdrawOp.Amount = Int64.Decode(stream);
            decodedLiquidityPoolWithdrawOp.MinAmountA = Int64.Decode(stream);
            decodedLiquidityPoolWithdrawOp.MinAmountB = Int64.Decode(stream);
            return decodedLiquidityPoolWithdrawOp;
        }
    }
}
