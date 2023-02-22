using System;
using System.ComponentModel.DataAnnotations;

namespace BlogPost.Data.Models.Domain
{ 
	public class BlogPostEntity
	{
		public Guid Id { get; set; }
		public string Heading { get; set; }
		public string PageTitle { get; set; }
		public string Context { get; set; }
		public string ShortDescription { get; set; }
		public string FeaturedImageUrl { get; set; }
		public string UrlHandle { get; set; }
		public DateTime PublishedDate { get; set; } = DateTime.Now;
		public string Author { get; set; }
        public bool IsVisible { get; set; }

    }
}

