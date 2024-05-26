using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using Zhuravlev_34.Models;
namespace Zhuravlev_34.Forms.ProductForm
{

    public partial class ProductForm : Form
    {
        private ApplicationContext _context; // Database context instance
        private List<Product> _products;
        public void UpdateProductTable()
        {
            productGridView.Rows.Clear();

            // Add user data to the table
            foreach (Product product in _products)
            {
                productGridView.Rows.Add(product.Id, product.Name, product.Price);
            }
        }
        public ProductForm()
        {
            InitializeComponent();
            _context = new ApplicationContext();
            _products = _context.Products.ToList();
            UpdateProductTable();
        }


        public void addProductListener(object sender, EventArgs e)
        {
            AddNewProductForm pf = new AddNewProductForm();
            pf.ShowDialog();

            // Обновление списка продуктов из базы данных
            _products = _context.Products.ToList();
            UpdateProductTable();
        }
        private void removeProductListener(object sender, EventArgs e)
        {
            int id = (int)productGridView.CurrentRow.Cells["ID"].Value;
            DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // Найти продукт по ID
                var product = _context.Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    // Удалить продукт из контекста
                    _context.Products.Remove(product);

                    // Сохранить изменения в базе данных
                    _context.SaveChanges();

                    // Обновить список продуктов из базы данных
                    _products = _context.Products.ToList();
                    UpdateProductTable();
                }
                else
                {
                    MessageBox.Show("Продукт не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

    }
}
