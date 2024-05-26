using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zhuravlev_34.Forms.ProductForm;
using Zhuravlev_34.Models;

namespace Zhuravlev_34.Forms.ClientForm
{
    public partial class ClientForm : Form
    {
        private ApplicationContext _context; // Database context instance
        private List<Client> _clients;

        public void UpdateClientTable()
        {
            clientGridView.Rows.Clear();

            // Add user data to the table
            foreach (Client client in _clients)
            {
                clientGridView.Rows.Add(client.Id, client.Name, client.Address, client.Phone);
            }
        }
        public ClientForm()
        {
            InitializeComponent();
            _context = new ApplicationContext();
            _clients = _context.Clients.ToList();
            UpdateClientTable();
        }

        public void addClientListener(object sender, EventArgs e)
        {
            AddNewClientForm pf = new AddNewClientForm();
            pf.ShowDialog();

            // Обновление списка продуктов из базы данных
            _clients = _context.Clients.ToList();
            UpdateClientTable();
        }
        public void reportListener(object sender, EventArgs e)
        {
            var selectedRows = clientGridView.SelectedRows;
            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну строку для создания отчета.");
                return;
            }

            List<int> selectedClientIds = new List<int>();
            foreach (DataGridViewRow row in selectedRows)
            {
                int clientId = (int)row.Cells["Id"].Value;
                selectedClientIds.Add(clientId);
            }

            ClientReportForm reportForm = new ClientReportForm(selectedClientIds);
            reportForm.ShowDialog();
        }


        private void removeClientListener(object sender, EventArgs e)
        {
            int id = (int)clientGridView.CurrentRow.Cells["ID"].Value;
            DialogResult dr = MessageBox.Show("Удаление", "Вы уверены?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                // Найти продукт по ID
                var client = _context.Clients.FirstOrDefault(p => p.Id == id);
                if (client != null)
                {
                    // Удалить продукт из контекста
                    _context.Clients.Remove(client);

                    // Сохранить изменения в базе данных
                    _context.SaveChanges();

                    // Обновить список продуктов из базы данных
                    _clients = _context.Clients.ToList();
                    UpdateClientTable();
                }
                else
                {
                    MessageBox.Show("Клиент не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
