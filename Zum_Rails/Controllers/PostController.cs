using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zum_Rails.Interfaces;
using Zum_Rails.Requests;
using Zum_Rails.Responces;

namespace Zum_Rails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostService _postService;

        public PostController(IPostService postService)
        {
            this._postService = postService;
        }

        [HttpGet]
        public ActionResult<PostResponce> Post([FromQuery] PostRequest postRequest)
        {
            this._postService.getPosts(postRequest);
            return Ok();
        }
    }
}
