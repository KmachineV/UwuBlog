using System;
using System.Collections.Generic;
using System.Text;
using UwuBlogAccesoDatos.Data.Repository;

namespace UwuBlogAccesoDatos.Data
{
    public class ContainerWork : IContainerWork
    {
        private readonly ApplicationDbContext _db;

        public ContainerWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }
        public ICategoryRepository Category { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
