using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using BlogPost.Data.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogPost.Pages.Admin.Blogs
{
   

    public class ListModel : PageModel

    {
        
        private readonly BlogPostDbContext _blogPostDbContext;


        public List<BlogPostEntity> BlogPostLists { get; set; }

     

        public ListModel(BlogPostDbContext blogPostDbContext)
        {
            _blogPostDbContext = blogPostDbContext;
        }

        public void OnGet()
        {
            BlogPostLists = _blogPostDbContext.BlogPosts.ToList();
        }

       
    }
    }
      


    
