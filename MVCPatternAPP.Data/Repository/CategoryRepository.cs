using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPatternAPP.Data.DatabaseContext;
using MVCPatternAPP.Data.Repository.Interface;
using MVCPatternAPP.Entity.Models;

namespace MVCPatternAPP.Data.Repository
{
    public class CategoryRepository:ICategory
    {
        private readonly MvcPatternDbContext _context;
        private bool _disposed = false;
        
        public CategoryRepository()
        {
            _context=new MvcPatternDbContext();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this._disposed = true;
        }

        public IQueryable<Category> ShowCategories(string search)
        {
            try
            {
                var quarableCategory = from c in _context.Categories select c;

                if (!string.IsNullOrEmpty(search))
                {
                    quarableCategory = quarableCategory.Where(c => c.CategoryName.Contains(search));
                }

                return quarableCategory;
            }
            catch (Exception)
            {
              throw;
            }
        }


        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        public IEnumerable<Category> GetAllCategory()
        {
            try
            {
               return _context.Categories.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
