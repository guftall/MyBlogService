using System.Data.Entity;
using System;
using System.ComponentModel.DataAnnotations;


namespace MyBlogService.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [Display(Name="تاریخ ارسال")]
        public DateTime CreatedDate { get; set; }

        public User Author { get; set; }
    }

    public class BlogServiceDbContext : DbContext
    {

        public DbSet<Post> Posts { get; set; }


        public BlogServiceDbContext()
            : base("BlogServiceDB")
        {

        }
    }
}
