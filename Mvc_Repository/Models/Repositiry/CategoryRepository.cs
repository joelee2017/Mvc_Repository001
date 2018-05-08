using Mvc_Repository.Models.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_Repository.Models.Repositiry
{
    public class CategoryRepository : GenericRepository<Categories>, ICategoryRepository
    {
        public Categories GetByID(int categoryID)
        {
            return this.Get(x => x.CategoryID == categoryID);
        }
    }
}