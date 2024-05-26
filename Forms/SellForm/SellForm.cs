using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Zhuravlev_34.Models;

namespace Zhuravlev_34.Forms.SellForm
{
    public partial class SellForm : Form
    {
        private ApplicationContext _context; // Database context instance
        private List<Sell> _sells;

        public SellForm()
        {
            InitializeComponent();
            _context = new ApplicationContext();
            LoadSells();
            UpdateSellTable();
        }

        private void LoadSells()
        {
            _sells = _context.SellOrders.Include(s => s.Client).Include(s => s.Product).ToList();
        }

        public void UpdateSellTable()
        {
            sellGridView.Rows.Clear();

            foreach (Sell sell in _sells)
            {
                string status = sell.Status.ToString();
                sellGridView.Rows.Add(sell.Id, sell.Client.Name, sell.Product.Name, sell.Tax, sell.InvoiceDate.ToString("yyyy-MM-dd"), sell.RemainingAmount, status);
            }
        }
        public void addSellListener(object sender, EventArgs e)
        {
            AddSellForm pf = new AddSellForm();
            pf.ShowDialog();

            LoadSells();
            UpdateSellTable();
        }

        private void exportInvoiceToExcel(object sender, EventArgs e)
        {
            if (sellGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите строку для экспорта.");
                return;
            }

            // Предположим, что столбец идентификатора называется "Id"
            int idColumnIndex = sellGridView.Columns["Id"].Index;
            int id = (int)sellGridView.CurrentRow.Cells[idColumnIndex].Value;

            var sell = _context.SellOrders.Include(s => s.Client).Include(s => s.Product).FirstOrDefault(p => p.Id == id);

            if (sell == null)
            {
                MessageBox.Show("Продукт не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Invoice");

                worksheet.Cells[1, 1].Value = "Invoice ID";
                worksheet.Cells[1, 2].Value = sell.Id;

                worksheet.Cells[2, 1].Value = "Client Name";
                worksheet.Cells[2, 2].Value = sell.Client.Name;

                worksheet.Cells[3, 1].Value = "Product Name";
                worksheet.Cells[3, 2].Value = sell.Product.Name;

                worksheet.Cells[4, 1].Value = "Tax";
                worksheet.Cells[4, 2].Value = sell.Tax;

                worksheet.Cells[5, 1].Value = "Invoice Date";
                worksheet.Cells[5, 2].Value = sell.InvoiceDate.ToString("yyyy-MM-dd");

                worksheet.Cells[6, 1].Value = "Due Date";
                worksheet.Cells[6, 2].Value = sell.DueDate.ToString("yyyy-MM-dd");

                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save an Excel File"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                    {
                        package.SaveAs(stream);
                    }
                    MessageBox.Show("Счет-фактура успешно экспортирована.");
                }
            }
        }

        private void removeSellListener(object sender, EventArgs e)
        {
            if (sellGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите строку для удаления.");
                return;
            }

            int id = (int)sellGridView.CurrentRow.Cells["ID"].Value;
            DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var sell = _context.SellOrders.FirstOrDefault(p => p.Id == id);
                if (sell != null)
                {
                    _context.SellOrders.Remove(sell);
                    _context.SaveChanges();

                    LoadSells();
                    UpdateSellTable();
                }
                else
                {
                    MessageBox.Show("Продукт не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void payListener(object sender, EventArgs e)
        {
            if (sellGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите строку для оплаты.");
                return;
            }

            // Предположим, что столбец идентификатора называется "id"
            int idColumnIndex = sellGridView.Columns["id"].Index;
            int sellId = (int)sellGridView.CurrentRow.Cells[idColumnIndex].Value;

            SellFormPayment pf = new SellFormPayment(sellId);
            pf.PaymentSuccessful += OnPaymentSuccessful;
            pf.ShowDialog();

            LoadSells();
            UpdateSellTable();
        }
        private void OnPaymentSuccessful()
        {
            LoadSells();
            UpdateSellTable();
        }
    }
}
