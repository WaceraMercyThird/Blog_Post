﻿using System;
namespace BlogPost.Data.Models.ViewModels
{
	public class AddBlogPost
	{
	

        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Context { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool IsVisible { get; set; }
      


    }
}

