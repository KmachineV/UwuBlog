using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UwuBlogAccesoDatos.Data.Repository;

namespace UwuBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly IContainerWork _containerWork;

        public CategoriesController(IContainerWork containerWork)
        {
            _containerWork = containerWork;     
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }






        #region Called Api

        [HttpGet]

        public IActionResult GetAll()
        {
            return Json(new { data = _containerWork.Category.GetAll() });
        }

        #endregion
    }
}
