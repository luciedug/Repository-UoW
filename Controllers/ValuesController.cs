using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiFinal.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DBnews _context;
        public ValuesController(DBnews context)
        {
            _context = context;
        }
        /// <summary>
        /// Get all news from database
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<New>>> GetStudents()
        {
            return await _context.NewsInfo.ToListAsync();
        }

        /// <summary>
        /// Get a news from database
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id}", Name = "GetByID")]
        public IActionResult Get(int id)
        {
            var news = _context.NewsInfo
        .Where(a => a.ID == id)
        .FirstOrDefault();
            if (news == null)
            { return NotFound(); }
            return new ObjectResult(news);
        }

        /// <summary>
        /// Add a news to database
        /// </summary>
        /// <param name="id"></param>

        [HttpPost]
        public void Post([FromBody]New news)
        {
            _context.Add(news);
            _context.SaveChanges();

        }

        /// <summary>
        /// Modify description from a news
        /// </summary>
        /// <param name="id"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            var news = _context.NewsInfo
        .Where(a => a.ID == id)
        .FirstOrDefault();

            news.Description = value;
            _context.SaveChanges();
        }

        /// <summary>
        /// Deletes a news from database
        /// </summary>
        /// <param name="id"></param>   
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var news = _context.NewsInfo
        .Where(a => a.ID == id)
        .FirstOrDefault();

            _context.NewsInfo.Remove(news);
            _context.SaveChanges();
        }
    }
}
