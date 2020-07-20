﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public  class ConfigurationEntry:Entity<Guid>
    {
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
