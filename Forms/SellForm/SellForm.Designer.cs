namespace Zhuravlev_34.Forms.SellForm
{
    partial class SellForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sellGridView = new DataGridView();
            menuStrip1 = new MenuStrip();
            addSell = new ToolStripMenuItem();
            removeSell = new ToolStripMenuItem();
            downloadBill = new ToolStripMenuItem();
            pay = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)sellGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // sellGridView
            // 
            sellGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sellGridView.Location = new Point(12, 32);
            sellGridView.Name = "sellGridView";
            sellGridView.RowHeadersWidth = 51;
            sellGridView.Size = new Size(500, 300);
            sellGridView.TabIndex = 3;
            sellGridView.ColumnCount = 7;
            sellGridView.Columns[0].Name = "id";
            sellGridView.Columns[1].Name = "название";
            sellGridView.Columns[2].Name = "клиент";
            sellGridView.Columns[3].Name = "товар";
            sellGridView.Columns[4].Name = "дата";
            sellGridView.Columns[5].Name = "остаток";
            sellGridView.Columns[6].Name = "статус";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addSell, removeSell, downloadBill, pay });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // addSell
            // 
            addSell.Name = "addSell";
            addSell.Size = new Size(71, 20);
            addSell.Text = "Добавить";
            addSell.Click += addSellListener;
            // 
            // removeSell
            // 
            removeSell.Name = "removeSell";
            removeSell.Size = new Size(63, 20);
            removeSell.Text = "Удалить";
            removeSell.Click += removeSellListener;
            // 
            // downloadBill
            // 
            downloadBill.Name = "downloadBill";
            downloadBill.Size = new Size(103, 20);
            downloadBill.Text = "Выгрузить счет";
            downloadBill.Click += exportInvoiceToExcel;
            // 
            // pay
            // 
            pay.Name = "pay";
            pay.Size = new Size(71, 20);
            pay.Text = "Оплатить";
            pay.Click += payListener;


            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(sellGridView);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SellForm";
            Text = "SellForm";
            ((System.ComponentModel.ISupportInitialize)sellGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView sellGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addSell;
        private ToolStripMenuItem removeSell;
        private ToolStripMenuItem downloadBill;
        private ToolStripMenuItem pay;
    }
}