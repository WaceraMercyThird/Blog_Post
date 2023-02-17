using System;
using System.ComponentModel.DataAnnotations;

namespace BlogPost.Data.Models.Domain
{ 
	public class BlogPost
	{
		public Guid Id { get; set; }
		public string Heading { get; set; }
		public string PageTitle { get; set; }
		public string Context { get; set; }
		public string ShortDescripttion { get; set; }
		public string FeaturedImageUrl { get; set; }
		public string UrlHandle { get; set; }
		public DateTime Published { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }
}
}

