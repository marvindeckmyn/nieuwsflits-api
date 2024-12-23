using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NieuwsFlits.API.Data;
using NieuwsFlits.API.Models;

namespace NieuwsFlits.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly NewsContext _context;

        public NewsController(NewsContext context)
        {
            _context = context;
        }

        [HttpGet("latest")]
        public async Task<ActionResult<IEnumerable<NewsArticle>>> GetLatestNews()
        {
            return await _context.NewsArticles
                .OrderByDescending(n => n.PublishDate)
                .Take(10)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NewsArticle>> GetArticle(int id)
        {
            var article = await _context.NewsArticles.FindAsync(id);

            if (article == null)
            {
                return NotFound();
            }

            return article;
        }

        [HttpGet("category/{category}")]
        public async Task<ActionResult<IEnumerable<NewsArticle>>> GetNewsByCategory(string category)
        {
            return await _context.NewsArticles
                .Where(n => n.Category.ToLower() == category.ToLower())
                .OrderByDescending(n => n.PublishDate)
                .ToListAsync();
        }
    }
}