﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Flex_TEST.Models
{
    public partial class CustomizedOrders
    {
        public int Customized_Id { get; set; }
        public string Customized_number { get; set; }
        public int? Customized_Shoes_Id { get; set; }
        public int? Fk_ForMemberCustomized_Id { get; set; }
        public int? Customized_Eyelet { get; set; }
        public int? Customized_EdgeProtection { get; set; }
        public int? Customized_Rear { get; set; }
        public int? Customized_Tongue { get; set; }
        public int? Customized_Toe { get; set; }
        public string Remark { get; set; }
        public DateTime? OrderCreateTime { get; set; }
        public DateTime? OrderEditTime { get; set; }

        public virtual Customized_materials Customized_EdgeProtectionNavigation { get; set; }
        public virtual Customized_materials Customized_EyeletNavigation { get; set; }
        public virtual Customized_materials Customized_RearNavigation { get; set; }
        public virtual CustomizedShoesPo Customized_Shoes { get; set; }
        public virtual Customized_materials Customized_ToeNavigation { get; set; }
        public virtual Customized_materials Customized_TongueNavigation { get; set; }
        public virtual Members Fk_ForMemberCustomized { get; set; }
    }
}