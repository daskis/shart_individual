using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using Zhuravlev_34.Models;

namespace Zhuravlev_34.Forms.SellForm
{
    public partial class SellFormPayment : Form
    {
        private int _sellId;
        private ApplicationContext _context;
        public event Action PaymentSuccessful;
        public SellFormPayment(int sellId)
        {
            InitializeComponent();
            _sellId = sellId;
            _context = new ApplicationContext();
            LoadSellData();
        }

        private void LoadSellData()
        {
            var sell = _context.SellOrders.Include(s => s.Client).Include(s => s.Product).FirstOrDefault(p => p.Id == _sellId);
            if (sell != null)
            {
                // Заполните поля формы данными из sell, если нужно
                // Например:
                // labelClientName.Text = sell.Client.Name;
                // labelProductName.Text = sell.Product.Name;
                // labelRemainingAmount.Text = sell.RemainingAmount.ToString();
            }
        }

        private void paymentAmount_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить проверку, что введенное значение является числом
            if (!decimal.TryParse(paymentAmount.Text, out _))
            {
                MessageBox.Show("Введите корректное числовое значение для суммы оплаты.");
                paymentAmount.Text = ""; // Очищаем поле ввода
            }
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(paymentAmount.Text, out int payment) || payment <= 0)
            {
                MessageBox.Show("Введите корректную сумму оплаты.");
                return;
            }

            var sell = _context.SellOrders.FirstOrDefault(s => s.Id == _sellId);
            if (sell == null)
            {
                MessageBox.Show("Продажа не найдена.");
                return;
            }

            if (payment > sell.RemainingAmount)
            {
                MessageBox.Show("Сумма оплаты не может превышать остаток.");
                return;
            }

            sell.RemainingAmount -= payment;
            _context.SaveChanges();

            PaymentSuccessful?.Invoke();

            MessageBox.Show("Оплата успешно произведена.");
            this.Close();
        }
    }
}
