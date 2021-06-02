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
    public class DeleteArtController : ControllerBase
    {
        public static AtistContext context = new AtistContext();
        public Art DeleteArt(int IdArt)
        {
            
        Art ArtDelete = context.Arts.Find(IdArt);
            if (ArtDelete != null)
            {
                context.Arts.Remove(ArtDelete);
                context.SaveChangesAsync();
            }
            
            return  ArtDelete;
        }

    }
}
