﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Flex_TEST.Models
{
    public partial class order_statuses
    {
        public order_statuses()
        {
            orders = new HashSet<orders>();
        }

        public int Id { get; set; }
        public string order_status { get; set; }

        public virtual ICollection<orders> orders { get; set; }
    }
}