using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhuravlev_34.Models;

namespace Zhuravlev_34.Forms.ProductForm
{
    public partial class AddNewProductForm : Form
    {
        private string name;
        private decimal price;
        private ApplicationContext _context; // Database context instance
        private List<Product> _products;

        public AddNewProductForm()
        {
            InitializeComponent();
            _context = new ApplicationContext();
            _products = _context.Products.ToList();
        }

        private void priceInputListener(object sender, EventArgs e)
        {
            if (decimal.TryParse(priceInput.Text, out decimal result))
            {
                if (result >= 0)
                {
                    price = result;
                }
                else
                {
                    MessageBox.Show("Цена не может быть отрицательной");
                    priceInput.Clear();
                }
            }
            else
            {
                MessageBox.Show("Введите корректное значение для цены");
                priceInput.Clear();
            }
        }

        private void nameInputListener(object sender, EventArgs e)
        {
            // Получение текущего значения из поля nameInput
            name = nameInput.Text;
            // Обработка значения
            if (name.Length > 50)
            {
                MessageBox.Show("Название продукта слишком длинное");
            }
        }

        private void addButtonListener(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название продукта");
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Введите корректное значение для цены");
                return;
            }

            // Создание нового продукта
            Product newProduct = new Product
            {
                Name = name,
                Price = price
            };

            // Добавление продукта в базу данных
            _context.Products.Add(newProduct);
            _context.SaveChanges();

            // Закрытие формы после добавления продукта
            this.Close();
        }

        private void cancelAddProductBtnListener(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
