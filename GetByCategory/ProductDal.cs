using GetByCategory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetByCategory
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {   // products tablosundaki verileri result nesnesine atar 
            using(NorthwindContext context = new NorthwindContext())
            {
                var result = context.Products.ToList();
                return result;
            }
        }

        public List<Product> GetByCategoryId(int categoryId)
        {   // products tablosundaki verileri kategori combobox ında seçili olan kategoriye göre listeler  
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.Products.Where(p=>p.CategoryID==categoryId).ToList();
                return result;
            }
        }

        public List<Product> GetByProductName(string productName)
        {   // products tablosundaki verileri arama kurucuğuna yazdılan parametreye göre arar  
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = context.Products.Where(p => p.ProductName.Contains(productName)).ToList();
                return result;
            }
        }
    }
}
