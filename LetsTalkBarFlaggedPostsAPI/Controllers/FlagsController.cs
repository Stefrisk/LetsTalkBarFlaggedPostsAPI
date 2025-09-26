using LetsTalkBarFlaggedPostsAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LetsTalkBarFlaggedPostsAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class FlagsController : Controller
    {
        private readonly LetsTalkBarDb _context;

        public FlagsController(LetsTalkBarDb context)
        {
            _context = context;
        }


  
        [HttpGet("posts")]
        public async Task<JsonResult> GetPosts()
        {
            var posts = await _context.Posts
                .Select(p => new
                {
                    PostId = p.Id,
                    PostContent = p.Content,
                    UserId = p.UserId,
                    CreatedAt = p.CreatedAt
                }).ToListAsync();

            return new JsonResult(posts);
        }

    }
}
