using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using PaystackSdk.Core.Constants;
using PaystackSdk.Core.Exceptions;

namespace PaystackSdk.Core.Transactions.Requests
{
    public class InitializeTransactionRequest
    {
        private readonly string[] ALLOWED_CHANNELS = new[] {
            PaystackChannels.Card,
            PaystackChannels.Bank,
            PaystackChannels.USSD,
            PaystackChannels.QR,
            PaystackChannels.MobileMoney,
            PaystackChannels.BankTransfer,
            PaystackChannels.EFT
        };

        private HashSet<string> _channels;
        private string _email;

        public InitializeTransactionRequest()
        {
            _channels = new();
            _email = string.Empty;
        }

        public string Amount { get; internal set; } = default!;
        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException(nameof(Email));
                }

                _email = value;
            }
        }
        public string Currency { get; set; } = PaystackCurrency.NGN;
        public string? Reference { get; set; }

        [JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }
        public string? Plan { get; set; }
        public int? InvoiceLimit { get; set; }
        public object? MetaData { get; set; }
        public HashSet<string> Channels
        {
            get => _channels;
            set
            {
                foreach (var item in value)
                {
                    if (!ALLOWED_CHANNELS.Contains(item))
                    {
                        throw new InvalidChannelException(item);
                    }
                }
                _channels = value;
            }
        }

        [JsonProperty("split_code")]
        public string? SplitCode { get; set; }

        public string? Subaccount { get; set; }

        [JsonProperty("transaction_charge")]
        public int TransactionCharge { get; set; }
        public string? Bearer { get; set; }

        public void SetAmount(decimal amount)
        {
            Amount = (amount * 100).ToString("n0");
        }
    }
}
