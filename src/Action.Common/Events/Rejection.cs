using System;
using System.Collections.Generic;
using System.Text;

namespace Action.Common.Events
{
    public class Reject : IRejectedEvent
    {
        public string Email { get; }
        public string Reason { get; }
        public string Code { get; }

        protected Reject()
        {

        }

        public Reject(string email, string reason, string code)
        {
            Email = email;
            Reason = reason;
            Code = code;
        }
    }
}
