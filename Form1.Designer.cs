namespace Zhuravlev_34
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            productBtn = new Button();
            clientBtn = new Button();
            sellBtn = new Button();
            billLink = new Button();
            paymentLink = new Button();
            SuspendLayout();
            // 
            // productBtn
            // 
            productBtn.Location = new Point(12, 12);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(150, 30);
            productBtn.TabIndex = 0;
            productBtn.Text = "Товар";
            productBtn.UseVisualStyleBackColor = true;
            productBtn.Click += ProductLinkListener;
            // 
            // clientBtn
            // 
            clientBtn.Location = new Point(168, 12);
            clientBtn.Name = "clientBtn";
            clientBtn.Size = new Size(150, 30);
            clientBtn.TabIndex = 1;
            clientBtn.Text = "Клиент";
            clientBtn.UseVisualStyleBackColor = true;
            clientBtn.Click += ClientLinkListener;
            // 
            // sellBtn
            // 
            sellBtn.Location = new Point(324, 12);
            sellBtn.Name = "sellBtn";
            sellBtn.Size = new Size(150, 30);
            sellBtn.TabIndex = 2;
            sellBtn.Text = "Продажи";
            sellBtn.UseVisualStyleBackColor = true;
            sellBtn.Click += SellLinkListener;
            // 
            // billLink
            // 
            billLink.Location = new Point(638, 12);
            billLink.Name = "billLink";
            billLink.Size = new Size(150, 30);
            billLink.TabIndex = 3;
            billLink.Text = "Счета";
            billLink.UseVisualStyleBackColor = true;
            billLink.Click += operationLink_Click;
            // 
            // paymentLink
            // 
            paymentLink.Location = new Point(638, 57);
            paymentLink.Name = "paymentLink";
            paymentLink.Size = new Size(150, 30);
            paymentLink.TabIndex = 4;
            paymentLink.Text = "Оплата";
            paymentLink.UseVisualStyleBackColor = true;
            paymentLink.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(paymentLink);
            Controls.Add(billLink);
            Controls.Add(sellBtn);
            Controls.Add(clientBtn);
            Controls.Add(productBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button productBtn;
        private Button clientBtn;
        private Button sellBtn;
        private Button billLink;
        private Button paymentLink;
    }
}
