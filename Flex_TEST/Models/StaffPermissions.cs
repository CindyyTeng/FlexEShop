﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Flex_TEST.Models
{
    public partial class StaffPermissions
    {
        public StaffPermissions()
        {
            Staffs = new HashSet<Staffs>();
        }

        public int PermissionsId { get; set; }
        public string LevelName { get; set; }

        public virtual ICollection<Staffs> Staffs { get; set; }
    }
}