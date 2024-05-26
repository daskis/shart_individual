using OfficeOpenXml;
using OfficeOpenXml.Drawing.Chart;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Zhuravlev_34.Models;

namespace Zhuravlev_34.Forms.ClientForm
{
    public partial class ClientReportForm : Form
    {
        private List<int> _clientIds;
        private ApplicationContext _context;

        public ClientReportForm(List<int> clientIds)
        {
            InitializeComponent();
            _clientIds = clientIds;
            _context = new ApplicationContext();
            reportBtn.Click += reportBtn_Click;
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = reportStartDate.Value.ToUniversalTime();
            DateTime endDate = reportEndDate.Value.ToUniversalTime();

            if (startDate > endDate)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания.");
                return;
            }

            ExportClientReportToExcel(startDate, endDate);
        }

        private void ExportClientReportToExcel(DateTime startDate, DateTime endDate)
        {
            var salesData = GetSalesData(startDate, endDate);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Client Report");

                // Заголовки
                worksheet.Cells[1, 1].Value = "ID Клиента";
                worksheet.Cells[1, 2].Value = "Имя Клиента";
                worksheet.Cells[1, 3].Value = "Дата Счета";
                worksheet.Cells[1, 4].Value = "Сумма";
                worksheet.Cells[1, 5].Value = "НДС";
                worksheet.Cells[1, 6].Value = "Статус";

                int row = 2;
                foreach (var data in salesData)
                {
                    worksheet.Cells[row, 1].Value = data.ClientId;
                    worksheet.Cells[row, 2].Value = data.ClientName;
                    worksheet.Cells[row, 3].Value = data.InvoiceDate.ToString("yyyy-MM-dd");
                    worksheet.Cells[row, 4].Value = data.Amount;
                    worksheet.Cells[row, 5].Value = data.Tax;
                    worksheet.Cells[row, 6].Value = data.Status.ToString();
                    row++;
                }

                // Создание круговой диаграммы
                var pieChart = worksheet.Drawings.AddChart("PieChart", eChartType.Pie3D) as ExcelPieChart;
                pieChart.Title.Text = "Соотношение сумм проданных товаров по ставкам НДС";
                pieChart.Series.Add(ExcelRange.GetAddress(2, 4, row - 1, 4), ExcelRange.GetAddress(2, 5, row - 1, 5));
                pieChart.SetPosition(row + 1, 0, 0, 0);
                pieChart.SetSize(800, 600);

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
                    MessageBox.Show("Отчет успешно экспортирован.");
                }
            }
        }

        private List<SalesData> GetSalesData(DateTime startDate, DateTime endDate)
        {
            var salesData = new List<SalesData>();

            foreach (int clientId in _clientIds)
            {
                var client = _context.Clients.FirstOrDefault(c => c.Id == clientId);
                if (client != null)
                {
                    var sells = _context.SellOrders
                        .Where(s => s.ClientId == clientId && s.InvoiceDate >= startDate && s.InvoiceDate <= endDate)
                        .ToList();

                    foreach (var sell in sells)
                    {
                        salesData.Add(new SalesData
                        {
                            ClientId = client.Id,
                            ClientName = client.Name,
                            InvoiceDate = sell.InvoiceDate,
                            Amount = sell.RemainingAmount,
                            Tax = sell.Tax,
                            Status = sell.Status
                        });
                    }
                }
            }

            return salesData;
        }

        public class SalesData
        {
            public int ClientId { get; set; }
            public string ClientName { get; set; }
            public DateTime InvoiceDate { get; set; }
            public int Amount { get; set; }
            public int Tax { get; set; }
            public SellStatus Status { get; set; }
        }
    }
}
