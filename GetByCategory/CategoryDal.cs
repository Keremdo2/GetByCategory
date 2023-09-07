using GetByCategory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetByCategory
{
    public class CategoryDal
    {
        public List<Category> GetAll()
        {   //Kategori tablosundaki verileri liste halinde döndürür
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.Categories.ToList();
                return result;
            }
        }
    }
}
