using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Build.Framework.XamlTypes;

namespace _1811063611_NguyenHoangVinh_BigSchool.Models
{
    public class Category
    {
        
            public byte Id { get; set; }
            [Required]
            [StringLength(250)]
            public string Name { get; set; }
        
    }
}