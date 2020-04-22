using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiFinal.Models;
using WebApiFinal.Repositories;
namespace WebApiFinal.Controllers
{
    public class NewsController : ControllerBase
    {
        private IRepository<New> newsRepository;
        private IUnitOfWork _UoW;
        public NewsController(IUnitOfWork _UoW)
        {
            this.newsRepository = _UoW.NewsRepository;
            this._UoW = _UoW;
        }

        /// <summary>
        /// Get all news from database
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        [Route("")]
        public IEnumerable<New> GetAllNews() => newsRepository.GetAll();

        /// <summary>
        /// Get a news from database
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        [Route("{Id}")]
        public New GetById(int Id) => newsRepository.GetById(Id);

        /// <summary>
        /// Add a news to database
        /// </summary>
        /// <param name="id"></param>
        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public void Add([FromBody] New news)
        {
            newsRepository.Insert(news);
            _UoW.Commit();
        }

      

        /// <summary>
        /// Deletes a news from database
        /// </summary>
        /// <param name="id"></param>  
        [HttpDelete]
        [Route("{Id}")]
        [AllowAnonymous]
        public void Delete(int Id) {
            newsRepository.Delete(Id);
            _UoW.Commit();
        }


    }
}
