﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Action.Common.Events
{
    public interface IAuthEvent : IEvent
    {
        Guid UserId { get; }
    }
}
