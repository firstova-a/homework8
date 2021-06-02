using hwork8.EF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hwork8.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GetPostsController
	{
        public static AtistContext context = new AtistContext();

        [HttpGet]
        public List<Post> Get()
        {
            IQueryable<Post> posts = (from post in context.Posts
                                    select post).Take(10);
            List<Post> result = new List<Post>();
            if (posts != null)
            {
                foreach (Post post in posts)
                {
                    result.Add(new Post()
                    {
                        TitlePost = post.TitlePost,
                        TextContentPost = post.TextContentPost,
                        DateTimePostPublished = post.DateTimePostPublished
                    });
                }
            }
            return result;
        }
    }
}
