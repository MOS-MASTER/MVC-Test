using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS.Data;

namespace CS.Services
{
    public interface ICategoryService
    {
        IList<Category> GetCategories();
        Category GetCategory(int id);
        Category GetCategory(string categoryname);
        bool Add(Category category);
        bool Delete(Category category);
    }
}
