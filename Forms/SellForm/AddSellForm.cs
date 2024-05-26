using Microsoft.EntityFrameworkCore;
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

namespace Zhuravlev_34.Forms.SellForm
{
    public partial class AddSellForm : Form
    {
        private ApplicationContext _context; // Database context instance

        public AddSellForm()
        {
            InitializeComponent();
            _context = new ApplicationContext();
            LoadClients();
            LoadProducts();
        }

        private void LoadClients()
        {
            try
            {
                var clients = _context.Clients.ToList();
                clientCombobox.DataSource = clients;
                clientCombobox.DisplayMember = "Name"; // Assuming the Client model has a Name property
                clientCombobox.ValueMember = "Id"; // Assuming the Client model has an Id property
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading clients: {ex.Message}");
            }
        }

        private void LoadProducts()
        {
            try
            {
                var products = _context.Products.ToList();
                productCombobox.DataSource = products;
                productCombobox.DisplayMember = "Name"; // Assuming the Product model has a Name property
                productCombobox.ValueMember = "Id"; // Assuming the Product model has an Id property
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }
        private void taxInput_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(taxInput.Text, out int tax) || tax < 0 || tax > 100)
            {
                MessageBox.Show("НДС должен быть целым числом от 0 до 100");
                taxInput.Text = ""; // Очищаем поле ввода
            }
        }
        private void sellDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = sellDatePicker.Value;

            // Пример проверки: дата не может быть в будущем
            if (selectedDate > DateTime.Now)
            {
                MessageBox.Show("Дата продажи не может быть в будущем");
                sellDatePicker.Value = DateTime.Now; // Сброс даты на текущую
            }
        }
        private void addSell_Click(object sender, EventArgs e)
        {
            // Получение выбранных значений из комбобоксов и текстового поля
            int clientId = (int)clientCombobox.SelectedValue;
            int productId = (int)productCombobox.SelectedValue;
            int tax = 0;

            if (!int.TryParse(taxInput.Text, out tax))
            {
                MessageBox.Show("Введите корректное значение для НДС");
                return;
            }

            DateTime invoiceDate = sellDatePicker.Value.ToUniversalTime(); // Конвертируем в UTC
            DateTime dueDate = invoiceDate.AddDays(20).ToUniversalTime(); // Конвертируем в UTC

            // Получение цены продукта
            var product = _context.Products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
            {
                MessageBox.Show("Продукт не найден.");
                return;
            }

            try
            {
                // Создание нового объекта Sell
                Sell newSell = new Sell
                {
                    ClientId = clientId,
                    ProductId = productId,
                    Tax = tax,
                    InvoiceDate = invoiceDate,
                    DueDate = dueDate,
                    RemainingAmount = (int)product.Price // Установка оставшейся суммы как цена продукта
                };

                // Добавление в базу данных и сохранение изменений
                _context.SellOrders.Add(newSell);
                _context.SaveChanges();

                // Закрытие формы после успешного добавления
                this.Close();
            }
            catch (DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                while (innerException != null)
                {
                    MessageBox.Show($"Inner exception: {innerException.Message}");
                    innerException = innerException.InnerException;
                }
                MessageBox.Show($"Error adding sell: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding sell: {ex.Message}");
            }
        }



        private void cancelSell_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


