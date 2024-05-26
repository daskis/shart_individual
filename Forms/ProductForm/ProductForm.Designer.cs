namespace Zhuravlev_34.Forms.ProductForm
{
    partial class ProductForm
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
            menuStrip1 = new MenuStrip();
            addProduct = new ToolStripMenuItem();
            removeProduct = new ToolStripMenuItem();
            productGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addProduct, removeProduct });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addProduct
            // 
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(71, 20);
            addProduct.Text = "Добавить";
            addProduct.Click += addProductListener;
            // 
            // removeProduct
            // 
            removeProduct.Name = "removeProduct";
            removeProduct.Size = new Size(63, 20);
            removeProduct.Text = "Удалить";
            removeProduct.Click += removeProductListener;
            // 
            // productGridView
            // 
            productGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.Location = new Point(12, 27);
            productGridView.Name = "productGridView";
            productGridView.Size = new Size(500, 300);
            productGridView.TabIndex = 1;
            productGridView.ColumnCount = 3; // Определение количества столбцов
            productGridView.Columns[0].Name = "Id"; // Наименование первого столбца
            productGridView.Columns[1].Name = "Название"; // Наименование второго столбца
            productGridView.Columns[2].Name = "Цена";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productGridView);
            Controls.Add(menuStrip1);
            Name = "ProductForm";
            Text = "ProductForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addProduct;
        private ToolStripMenuItem removeProduct;
        private DataGridView productGridView;
    }
}