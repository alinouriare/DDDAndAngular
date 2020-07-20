﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
  public  class AuditLogEntry:AggregateRoot<Guid>
    {

        public Guid UserId { get; set; }

        public string Action { get; set; }

        public string ObjectId { get; set; }

        public string Log { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}