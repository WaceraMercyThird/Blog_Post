using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogPost.Pages.Admin.Blogs
{
	public class BlogModel : PageModel
    {
       
        public void OnGet()
        {

        }

        public void onPost()
        {
            var heading = Request.Form["heading"];
            var pageTitle = Request.Form["pageTitle"];
            var shortDescription = Request.Form["shortDescription"];
            var featuredImageUrl = Request.Form["featuredImageUrl"];
        }
    }
}
