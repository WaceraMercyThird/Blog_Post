using System;
using Microsoft.EntityFrameworkCore;


namespace BlogPost.Data.Models.Domain
{
	public class BlogPostDbContext: DbContext
	{
		public BlogPostDbContext(DbContextOptions options): base(options)
		{

		}

		public DbSet<BlogPostEntity> BlogPosts { get; set; }

		public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           base.OnModelCreating(builder);
        }

    }
}

