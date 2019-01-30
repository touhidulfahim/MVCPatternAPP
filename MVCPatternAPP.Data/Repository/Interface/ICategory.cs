using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPatternAPP.Entity.Models;

namespace MVCPatternAPP.Data.Repository.Interface
{
    public interface ICategory
    {
        //List<Category> GetCategories();
        IEnumerable<Category> GetAllCategory();
        IQueryable<Category> ShowCategories(string search);
    }
}
