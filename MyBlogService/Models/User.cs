using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlogService.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int NumberOfPosts { get; set; }

    }
}