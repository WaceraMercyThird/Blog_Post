using System;
using Microsoft.EntityFrameworkCore;

namespace BlogPost.Data.Models.Domain
{
	public class BlogPostDbContext: DbContext
	{
		public BlogPostDbContext(DbContextOptions options): base(options)
		{
		}

		public DbSet<BlogPost> BlogPosts { get; set; }
		public DbSet<Tag> Tags { get; set; }
	}
}

