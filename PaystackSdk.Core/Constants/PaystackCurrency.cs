using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaystackSdk.Core.Constants
{
    public static class PaystackCurrency
    {
        public const string NGN = "NGN";
        public const string GHS = "GHS";
        public const string ZAR = "ZAR";
        public const string USD = "USD";
    }

    public static class PaystackChannels
    {
        public const string Card = "card";
        public const string Bank = "bank";
        public const string USSD = "ussd";
        public const string QR = "qr";
        public const string MobileMoney = "mobile_money";
        public const string BankTransfer = "bank_transfer";
        public const string EFT = "eft";
    }
}
