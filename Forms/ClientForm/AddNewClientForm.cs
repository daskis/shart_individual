using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Zhuravlev_34.Models;

namespace Zhuravlev_34.Forms.ClientForm
{
    public partial class AddNewClientForm : Form
    {
        private string name;
        private string phone;
        private string address;
        private ApplicationContext _context; // Database context instance
        private List<Client> _clients;

        public AddNewClientForm()
        {
            InitializeComponent();
            _context = new ApplicationContext();
            _clients = _context.Clients.ToList();
        }

        private void nameClientListener(object sender, EventArgs e)
        {
            name = clientName.Text;
            if (name.Length > 50)
            {
                MessageBox.Show("Имя слишком длинное");
            }
        }

        private void phoneClientListener(object sender, EventArgs e)
        {
            phone = phoneClient.Text;

            if (phone.Any(c => !char.IsDigit(c) && c != '+'))
            {
                MessageBox.Show("Введите корректное значение для номера");
            }
            if (phone.Length > 11)
            {
                MessageBox.Show("Введите корректный номер");
            }
        }

        private void addressClientListener(object sender, EventArgs e)
        {
            address = addressClient.Text;
            if (address.Length > 50)
            {
                MessageBox.Show("Название адреса слишком длинное");
            }
        }

        private void cancelButtonListener(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButtonListener(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите название продукта");
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Введите название адреса");
                return;
            }

            if (phone.Any(c => !char.IsDigit(c) && c != '+'))
            {
                MessageBox.Show("Введите корректное значение для номера");
                return;
            }

            Client newClient = new Client
            {
                Name = name,
                Address = address,
                Phone = phone,
            };

            _context.Clients.Add(newClient);
            _context.SaveChanges();

            this.Close();
        }
    }

}
