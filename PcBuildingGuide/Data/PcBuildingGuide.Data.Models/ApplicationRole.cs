﻿// ReSharper disable VirtualMemberCallInConstructor
namespace PcBuildingGuide.Data.Models
{
    using System;

    using Microsoft.AspNetCore.Identity;
    using PcBuildingGuide.Data.Common.Models;

    public class ApplicationRole : IdentityRole, IAuditInfo, IdeletableModel
    {
        public ApplicationRole()
            : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
