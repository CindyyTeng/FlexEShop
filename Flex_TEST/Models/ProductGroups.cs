﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Flex_TEST.Models
{
    public partial class ProductGroups
    {
        public int ProductGroupId { get; set; }
        public string fk_ProductId { get; set; }
        public int fk_ColorId { get; set; }
        public int fk_SizeId { get; set; }
        public int Qty { get; set; }

        public virtual ColorCategories fk_Color { get; set; }
        public virtual Products fk_Product { get; set; }
        public virtual SizeCategories fk_Size { get; set; }
    }
}