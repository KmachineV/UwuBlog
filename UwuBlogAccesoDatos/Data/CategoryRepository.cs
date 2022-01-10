using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UwuBlog.Models;
using UwuBlogAccesoDatos.Data.Repository;

namespace UwuBlogAccesoDatos.Data
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

      

        public IEnumerable<SelectListItem> GetListCategory()
        {
            return _db.Category.Select(i => new SelectListItem() {

                Text = i.Name,
                Value = i.Id.ToString() 

                }

                ) ;
        }

        public void Update(Category category)
        {
            var objectToDb = _db.Category.FirstOrDefault(s => s.Id == category.Id);
            objectToDb.Name = category.Name;
            objectToDb.Order = category.Order;

            _db.SaveChanges();
        }
    }
}
