using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetByCategory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        CategoryDal _categoryDal = new CategoryDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();
            ListCategory();
         
        }

        public void ListProducts()
        {   //ProductDal sınıfından verileri gride taşır
            dgwProducts.DataSource = _productDal.GetAll();
        }

        public void ListCategory()
        {   //Kategorileri combobox a çeker 
            cbxCategory.DataSource = _categoryDal.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryID";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //kategoriye göre ürün listelicek
            try
            {
               dgwProducts.DataSource = _productDal.GetByCategoryId(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

            }
            
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {   //Arama kutusunda yazılan veriye göre filtreleme yapıp gride veri getir
            dgwProducts.DataSource = _productDal.GetByProductName(tbxSearch.Text);
        }
    }
}
