using System;
using System.Collections.Generic;
using System.Text;

namespace Action.Common.Events
{
    public class User : IEvent
    {
        public string Email { get; }
        public string Name { get; }

        protected User()
        {
        }

        public User(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}
