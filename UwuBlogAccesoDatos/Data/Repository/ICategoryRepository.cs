using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using UwuBlog.Models;

namespace UwuBlogAccesoDatos.Data.Repository
{
   public interface ICategoryRepository :  IRepository<Category>
    {
        IEnumerable<SelectListItem> GetListCategory();

        void Update(Category category);


        
    }
}
