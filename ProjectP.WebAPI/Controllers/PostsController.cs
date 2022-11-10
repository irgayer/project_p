using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProjectP.Domain.Repositories;
using ProjectP.WebAPI.DTO.Posts;

namespace ProjectP.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IPostRepository postRepository;

        public PostsController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        [HttpGet]
        public IActionResult GetAllPosts()
        {
            return Ok(postRepository.GetAll());
        }

        [HttpGet]
        [Route("my")]
        public IActionResult GetMyPosts()
        {
            return Ok();
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreatePost(PostCreateDTO dto)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeletePost(int postId)
        {
            var post = await postRepository.GetById(postId);
            if (post == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
