﻿using Domain.Entities;
using System;

namespace IdentityServer.Models.RoleModels
{
    public class ClaimModel
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public Role Role { get; set; }

        public static ClaimModel FromEntity(RoleClaim claim)
        {
            return new ClaimModel
            {
                Id = claim.id,
                Type = claim.Type,
                Value = claim.Value,
                Role = claim.Role,
            };
        }
    }
}