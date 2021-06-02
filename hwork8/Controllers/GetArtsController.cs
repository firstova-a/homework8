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
    public class GetArtsController
    {
        public static AtistContext context = new AtistContext();

        [HttpGet]
        public List<Art> Get()
        {
            IQueryable<Art> arts = (from art in context.Arts
                                    select art).Take(10);
            List<Art> result = new List<Art>();
            if (arts != null)
            {
                foreach (Art artik in arts)
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
            return result;
        }
    }
}

