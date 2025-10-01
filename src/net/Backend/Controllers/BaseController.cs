using Microsoft.AspNetCore.Mvc;
using MyApp.Backend.Datas.Entities;
using MyApp.Backend.Repo.Base;

namespace MyApp.Backend.Controllers
{
    public class BaseController<TEntity> : ControllerBase where TEntity : class, IDbEntity<TEntity>, new()
    {
        protected readonly IBaseRepo<TEntity> _repo;
        public BaseController(IBaseRepo<TEntity> repo)
        {
            _repo = repo;
        }
    }
}
