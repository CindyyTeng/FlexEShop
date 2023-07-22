﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Flex_TEST.Models
{
    public partial class Activities
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public int fk_ActivityCategoryId { get; set; }
        public DateTime ActivityDate { get; set; }
        public int fk_SpeakerId { get; set; }
        public string ActivityPlace { get; set; }
        public string ActivityImage { get; set; }
        public DateTime ActivityBookStartTime { get; set; }
        public DateTime ActivityBookEndTime { get; set; }
        public byte ActivityAge { get; set; }
        public int ActivitySalePrice { get; set; }
        public int ActivityOriginalPrice { get; set; }
        public string ActivityDescription { get; set; }
        public int fk_ActivityStatusId { get; set; }

        public virtual ActivityCategories fk_ActivityCategory { get; set; }
        public virtual ActivityStatuses fk_ActivityStatus { get; set; }
        public virtual Speakers fk_Speaker { get; set; }
    }
}