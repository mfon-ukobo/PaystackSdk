using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaystackSdk.Core.Transactions.Requests;
using PaystackSdk.Core.Transactions.Responses;

namespace PaystackSdk.Core.Transactions
{
    internal class Transaction : ITransaction
    {
        private readonly HttpService _httpService;

        public Transaction(HttpService httpService)
        {
            _httpService = httpService;
        }

        /// <summary>
        /// Initialize a paystack transaction
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task Initialize(InitializeTransactionRequest request)
        {
            var response = await _httpService.Post<InitializeTransactionRequest, Response<InitializeTransactionResponse>>("transaction/initialize", request);
        }
    }
}
