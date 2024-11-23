using _8.week_3_PRATIK_BlogProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace _8.week_3_PRATIK_BlogProject.Controllers
{
    public class BlogController : Controller
    {
        private static int _NextID = 1;
        private static List<BlogPost> _posts = new List<BlogPost>();

        public IActionResult Index()
        {
            ViewBag.TotalPosts = _posts.Count;
            ViewData["PageTitle"] = "Blog Gönderileri";
            return View(_posts);
        }

        public IActionResult Create()
        {
            ViewBag.CurrentTime = DateTime.Now;

            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogPost blogPost)
        {
            if(ModelState.IsValid)
            {
                blogPost.PostID = _NextID++;
                _posts.Add(blogPost);
                TempData["SuccessMessage"] = "Blog gönderisi başarı ile oluşturuldu";

                return RedirectToAction(nameof(Index));

            }

            ViewBag.CurrentTime = DateTime.Now;

            return View(blogPost);

        }

        public IActionResult Details(int id)
        {
            var post = _posts.FirstOrDefault(x => x.PostID == id);
            if(post is null)
            {

            }
            ViewData["CreatedAgo"] = $"{(DateTime.Now - post.CreatedDateTime).TotalMinutes} dakika önce";


            return View(post);

        }


    }
}
