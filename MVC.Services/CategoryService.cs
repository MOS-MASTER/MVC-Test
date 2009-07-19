using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS.Data;

namespace CS.Services
{
    public class CategoryService :ICategoryService
    {
        private ICategoryRepository _repository = null;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
            if(_repository == null)
                throw new InvalidOperationException("Category Repository cannot be null");
        }

        public IList<Category> GetCategories()
        {
            return _repository.GetCategories().ToList();
        }

        public Category GetCategory(int id)
        {
            return _repository.GetCategories()
                .WithCategoryId(id).SingleOrDefault();
        }

        public Category GetCategory(string categoryname)
        {
            return _repository.GetCategories()
                .WithCategoryName(categoryname).SingleOrDefault();
        }

        public bool Add(Category category)
        {
            return _repository.Add(category);
        }

        public bool Delete(Category category)
        {
            return _repository.Delete(category);
        }
    }
}
