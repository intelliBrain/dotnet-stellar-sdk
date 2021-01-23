// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  enum CreateClaimableBalanceResultCode
    //  {
    //      CREATE_CLAIMABLE_BALANCE_SUCCESS = 0,
    //      CREATE_CLAIMABLE_BALANCE_MALFORMED = -1,
    //      CREATE_CLAIMABLE_BALANCE_LOW_RESERVE = -2,
    //      CREATE_CLAIMABLE_BALANCE_NO_TRUST = -3,
    //      CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED = -4,
    //      CREATE_CLAIMABLE_BALANCE_UNDERFUNDED = -5
    //  };
    //  ===========================================================================
    public class CreateClaimableBalanceResultCode
    {
        public enum CreateClaimableBalanceResultCodeEnum
        {
            CREATE_CLAIMABLE_BALANCE_SUCCESS = 0,
            CREATE_CLAIMABLE_BALANCE_MALFORMED = -1,
            CREATE_CLAIMABLE_BALANCE_LOW_RESERVE = -2,
            CREATE_CLAIMABLE_BALANCE_NO_TRUST = -3,
            CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED = -4,
            CREATE_CLAIMABLE_BALANCE_UNDERFUNDED = -5,
        }
        public CreateClaimableBalanceResultCodeEnum InnerValue { get; set; } = default(CreateClaimableBalanceResultCodeEnum);
        public static CreateClaimableBalanceResultCode Create(CreateClaimableBalanceResultCodeEnum v)
        {
            return new CreateClaimableBalanceResultCode
            {
                InnerValue = v
            };
        }
        public static CreateClaimableBalanceResultCode Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(CreateClaimableBalanceResultCodeEnum.CREATE_CLAIMABLE_BALANCE_SUCCESS);
                case -1: return Create(CreateClaimableBalanceResultCodeEnum.CREATE_CLAIMABLE_BALANCE_MALFORMED);
                case -2: return Create(CreateClaimableBalanceResultCodeEnum.CREATE_CLAIMABLE_BALANCE_LOW_RESERVE);
                case -3: return Create(CreateClaimableBalanceResultCodeEnum.CREATE_CLAIMABLE_BALANCE_NO_TRUST);
                case -4: return Create(CreateClaimableBalanceResultCodeEnum.CREATE_CLAIMABLE_BALANCE_NOT_AUTHORIZED);
                case -5: return Create(CreateClaimableBalanceResultCodeEnum.CREATE_CLAIMABLE_BALANCE_UNDERFUNDED);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }
        public static void Encode(XdrDataOutputStream stream, CreateClaimableBalanceResultCode value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
