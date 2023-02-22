
using System.Net.Http.Json;
using BlogPost.Data.Models.Domain;
using BlogPost.Data.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace BlogPost.Pages.Admin.Blogs
{
	public class BlogModel : PageModel
    {
        private readonly BlogPostDbContext _blogPostDbContext;

        private readonly ILogger<BlogModel> _logger;

        [BindProperty]

        public AddBlogPost AddBlogPostRequest { get; set; }


        public BlogModel(BlogPostDbContext blogPostDbContext, ILogger<BlogModel> logger)
        {
            _blogPostDbContext = blogPostDbContext;

            _logger = logger;
        }


        public void OnGet()
        {

        }
        [HttpPost]
        public void OnPost()
        {
            _logger.LogError(JsonConvert.SerializeObject(AddBlogPostRequest));

            try
            {
                var blogPost = new BlogPostEntity()
                {
                    Id = Guid.NewGuid(),
                    Heading = AddBlogPostRequest.Heading,
                    PageTitle = AddBlogPostRequest.PageTitle,
                    Context = AddBlogPostRequest.Context,
                    ShortDescription = AddBlogPostRequest.ShortDescription,
                    FeaturedImageUrl = AddBlogPostRequest.FeaturedImageUrl,
                    UrlHandle = AddBlogPostRequest.UrlHandle,
                    PublishedDate = DateTime.UtcNow,
                    Author = AddBlogPostRequest.Author,
                    IsVisible = AddBlogPostRequest.IsVisible
                };

                _blogPostDbContext.BlogPosts.Add(blogPost);

                _blogPostDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(JsonConvert.SerializeObject(ex));
            }

            

            
        }
    }
}
