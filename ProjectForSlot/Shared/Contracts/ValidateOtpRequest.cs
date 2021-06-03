using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectForSlot.Shared.Contracts
{
    public class ValidateOtpRequest
    {
        public string otp { get; set; }
        public string txnId { get; set; }
    }
}
