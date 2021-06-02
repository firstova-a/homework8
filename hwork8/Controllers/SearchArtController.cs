using hwork8.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hwork8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchArtController : ControllerBase
    {

        public static AtistContext context = new AtistContext();

        [HttpGet]
        public List<Art> SearchArt(string field, string what )
        {
            List<Art> result = new List<Art>();
            if (field == "Description")
            {
                

                IQueryable<Art> arts = (from art in context.Arts
           
                                        select art);
                
                if (arts != null)
                {
                    
                    foreach (Art artik in arts)
                    {
                        if (artik.Description.Contains(what))
                        {
                            result.Add(new Art()
                            {
                                Id = artik.Id,
                                Description = artik.Description,
                                Date = artik.Date,
                                Styles = artik.Styles,
                                Types = artik.Types
                            });
                        }
                    }
                }
                
            }
            return result;
        }
}
}
