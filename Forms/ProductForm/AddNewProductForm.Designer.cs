namespace Zhuravlev_34.Forms.ProductForm
{
    partial class AddNewProductForm
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
            addProductButton = new Button();
            cancelAddProductBtn = new Button();
            nameInput = new TextBox();
            priceInput = new TextBox();
            nameLabel = new Label();
            priceLabel = new Label();
            SuspendLayout();
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(12, 196);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(75, 23);
            addProductButton.TabIndex = 0;
            addProductButton.Text = "Добавить";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addButtonListener;
            // 
            // cancelAddProductBtn
            // 
            cancelAddProductBtn.Location = new Point(144, 196);
            cancelAddProductBtn.Name = "cancelAddProductBtn";
            cancelAddProductBtn.Size = new Size(75, 23);
            cancelAddProductBtn.TabIndex = 1;
            cancelAddProductBtn.Text = "Отменить";
            cancelAddProductBtn.UseVisualStyleBackColor = true;
            cancelAddProductBtn.Click += cancelAddProductBtnListener;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(69, 33);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(150, 23);
            nameInput.TabIndex = 2;
            nameInput.TextChanged += new EventHandler(nameInputListener);
            // 
            // priceInput
            // 
            priceInput.Location = new Point(69, 117);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(150, 23);
            priceInput.TabIndex = 3;
            priceInput.TextChanged += new EventHandler(priceInputListener);

            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(4, 36);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Название";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(28, 120);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(35, 15);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Цена";
            // 
            // AddNewProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 231);
            Controls.Add(priceLabel);
            Controls.Add(nameLabel);
            Controls.Add(priceInput);
            Controls.Add(nameInput);
            Controls.Add(cancelAddProductBtn);
            Controls.Add(addProductButton);
            Name = "AddNewProductForm";
            Text = "AddNewProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addProductButton;
        private Button cancelAddProductBtn;
        private TextBox nameInput;
        private TextBox priceInput;
        private Label nameLabel;
        private Label priceLabel;
    }
}