﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Flex_TEST.Models
{
    public partial class logistics_companies
    {
        public logistics_companies()
        {
            orders = new HashSet<orders>();
        }

        public int Id { get; set; }
        public string name { get; set; }
        public string tel { get; set; }
        public string logistics_description { get; set; }

        public virtual ICollection<orders> orders { get; set; }
    }
}