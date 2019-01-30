using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPatternAPP.Data.Repository;
using MVCPatternAPP.Entity.Models;

namespace MVCPatternAPP.Service.Service
{
    public class CategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService()
        {
            _categoryRepository=new CategoryRepository();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.GetAllCategory();
        }


    }
}
