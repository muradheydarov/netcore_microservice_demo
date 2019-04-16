using System;
using System.Collections.Generic;
using System.Text;

namespace Action.Common.Events
{
    public class Auth : IEvent
    {
        public string Email { get; }

        public Auth()
        {
        }

        public Auth(string email)
        {
            Email = email;
        }
    }
}
