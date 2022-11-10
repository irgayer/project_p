using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProjectP.Domain.Entities;
using ProjectP.Domain.Repositories;
using ProjectP.WebAPI.DTO.Posts;

using System.Linq;
using System.Security.Claims;

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
        [AllowAnonymous]
        public IActionResult GetAllPosts()
        {
            var posts = postRepository.GetAll();
            var result = new List<PostDTO>();
            foreach (var post in posts)
            {
                result.Add(PostAdapter.Singleton.Adapt(post));
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("my")]
        [Authorize]
        public IActionResult GetMyPosts()
        {
            var userId = GetCurrentUser().Id;
            var posts = postRepository.GetAll().Where(x => x.UserId == userId);
            var result = new List<PostDTO>();
            foreach (var post in posts)
            {
                result.Add(PostAdapter.Singleton.Adapt(post));
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        [Authorize]
        public IActionResult CreatePost(PostCreateDTO dto)
        {
            var userId = GetCurrentUser().Id;
            var post = new Post
            {
                Content = dto.Content,
                UserId = userId
            };

            postRepository.Insert(post);

            return Ok();
        }

        [HttpDelete]
        [Route("{postId}")]
        [Authorize]
        public async Task<IActionResult> DeletePost(int postId)
        {
            var post = await postRepository.GetById(postId);
            if (post == null)
            {
                return NotFound();
            }
            var userId = GetCurrentUser().Id;
            if (userId != post.UserId)
            {
                return NotFound();
            }
            postRepository.Remove(post);
            return Ok();
        }

        private User GetCurrentUser()
        {
            var claims = HttpContext.User.Identity as ClaimsIdentity;
            var userId = int.Parse(claims.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value);

            return new User
            {
                Id = userId
            };
        }
    }
}
