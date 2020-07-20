﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public  class UserToken:Entity<Guid>
    {
        public Guid UserId { get; set; }

        public string LoginProvider { get; set; }

        public string TokenName { get; set; }

        public string TokenValue { get; set; }
    }
}
