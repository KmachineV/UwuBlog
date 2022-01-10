using System;
using System.Collections.Generic;
using System.Text;

namespace UwuBlogAccesoDatos.Data.Repository
{
    public interface IContainerWork : IDisposable
    {
        ICategoryRepository Category { get; }
        
        void Save();
    }
}
