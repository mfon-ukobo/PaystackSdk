using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaystackSdk.Core.Exceptions
{
    public class InvalidChannelException : Exception
    {
        public InvalidChannelException(string? channel) : base($"Invalid channel: {channel}")
        {
        }
    }
}
