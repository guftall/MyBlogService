using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyBlogService.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name="نام")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        public string Family { get; set; }

        [Display(Name = "تعداد پست ارسالی")]
        public int NumberOfPosts { get; set; }

    }
}