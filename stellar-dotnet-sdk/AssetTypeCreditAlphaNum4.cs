﻿using stellar_dotnet_sdk.xdr;

namespace stellar_dotnet_sdk
{
    public class AssetTypeCreditAlphaNum4 : AssetTypeCreditAlphaNum
    {
        public AssetTypeCreditAlphaNum4(string code, string issuer) : base(code, issuer)
        {
            if (code.Length < 1 || code.Length > 4)
                throw new AssetCodeLengthInvalidException();
        }

        public override string GetType()
        {
            return "credit_alphanum4";
        }

        public override xdr.Asset ToXdr()
        {
            var thisXdr = new xdr.Asset();
            thisXdr.Discriminant = AssetType.Create(AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4);
            var credit = new xdr.AlphaNum4();
            credit.AssetCode = new AssetCode4(Util.PaddedByteArray(Code, 4));
            var accountID = new AccountID();
            accountID.InnerValue = KeyPair.FromAccountId(Issuer).XdrPublicKey;
            credit.Issuer = accountID;
            thisXdr.AlphaNum4 = credit;
            return thisXdr;
        }

        public override int CompareTo(Asset asset)
        {
            if (asset.GetType() == "credit_alphanum12")
            {
                return -1;
            }
            else if (asset.GetType() == "native")
            {
                return 1;
            }

            AssetTypeCreditAlphaNum other = (AssetTypeCreditAlphaNum)asset;

            if (Code != other.Code)
            {
                return Code.CompareTo(other.Code);
            }

            return Issuer.CompareTo(other.Issuer);
        }
    }
}