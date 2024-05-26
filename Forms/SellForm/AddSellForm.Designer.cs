namespace Zhuravlev_34.Forms.SellForm
{
    partial class AddSellForm
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
            addSell = new Button();
            cancelSell = new Button();
            taxInput = new TextBox();
            clientCombobox = new ComboBox();
            productCombobox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            sellDatePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // addSell
            // 
            addSell.Location = new Point(12, 281);
            addSell.Name = "addSell";
            addSell.Size = new Size(100, 23);
            addSell.TabIndex = 0;
            addSell.Text = "Добавить";
            addSell.UseVisualStyleBackColor = true;
            addSell.Click += addSell_Click;
            // 
            // cancelSell
            // 
            cancelSell.Location = new Point(129, 281);
            cancelSell.Name = "cancelSell";
            cancelSell.Size = new Size(100, 23);
            cancelSell.TabIndex = 1;
            cancelSell.Text = "Отмена";
            cancelSell.UseVisualStyleBackColor = true;
            cancelSell.Click += cancelSell_Click;
            // 
            // taxInput
            // 
            taxInput.Location = new Point(79, 23);
            taxInput.Name = "taxInput";
            taxInput.Size = new Size(150, 23);
            taxInput.TabIndex = 2;
            taxInput.TextChanged += taxInput_TextChanged;
            // 
            // clientCombobox
            // 
            clientCombobox.FormattingEnabled = true;
            clientCombobox.Location = new Point(79, 88);
            clientCombobox.Name = "clientCombobox";
            clientCombobox.Size = new Size(150, 23);
            clientCombobox.TabIndex = 3;
            // 
            // productCombobox
            // 
            productCombobox.FormattingEnabled = true;
            productCombobox.Location = new Point(79, 156);
            productCombobox.Name = "productCombobox";
            productCombobox.Size = new Size(150, 23);
            productCombobox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "НДС";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 91);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Клиент";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 159);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 7;
            label3.Text = "Товар";
            // 
            // sellDatePicker
            // 
            sellDatePicker.Location = new Point(29, 221);
            sellDatePicker.Name = "sellDatePicker";
            sellDatePicker.Size = new Size(200, 23);
            sellDatePicker.TabIndex = 9;
            // 
            // AddSellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 316);
            Controls.Add(sellDatePicker);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productCombobox);
            Controls.Add(clientCombobox);
            Controls.Add(taxInput);
            Controls.Add(cancelSell);
            Controls.Add(addSell);
            Name = "AddSellForm";
            Text = "AddSellForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addSell;
        private Button cancelSell;
        private TextBox taxInput;
        private ComboBox clientCombobox;
        private ComboBox productCombobox;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker sellDatePicker;
    }
}