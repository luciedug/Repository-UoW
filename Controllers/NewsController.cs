using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiFinal.Models;
using WebApiFinal.Repositories;
namespace WebApiFinal.Controllers
{
    public class NewsController : ControllerBase
    {
        private IRepositoryNew newsRepository;
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
        public async Task<IEnumerable<New>> GetAllNews()
        {
            return await newsRepository.GetAllAsync();
        }
        

        /// <summary>
        /// Get a news from database
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        [Route("{Id}")]
        public async Task<New> GetNewsbyId(int Id)
        {
            return await newsRepository.GetbyIdAsync(Id);

        }
        //public New GetById(int Id) => newsRepository.GetById(Id);

        /// <summary>
        /// Add a news to database
        /// </summary>
        /// <param name="id"></param>
        [HttpPost]
        [Route("")]
        [AllowAnonymous]
        public async Task Add([FromBody] New news)
        {
            newsRepository.InsertNew(news);
            await _UoW.CommitAsync();
        }

      

        /// <summary>
        /// Deletes a news from database
        /// </summary>
        /// <param name="id"></param>  
        [HttpDelete]
        [Route("{Id}")]
        [AllowAnonymous]
        public async Task Delete(int Id) {
            newsRepository.DeleteNew(Id);
            await _UoW.CommitAsync();
        }


    }
}
