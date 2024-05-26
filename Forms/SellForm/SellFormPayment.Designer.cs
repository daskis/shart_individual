namespace Zhuravlev_34.Forms.SellForm
{
    partial class SellFormPayment
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
            paymentBtn = new Button();
            paymentAmount = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // paymentBtn
            // 
            paymentBtn.Location = new Point(50, 151);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.Size = new Size(150, 30);
            paymentBtn.TabIndex = 0;
            paymentBtn.Text = "Оплатить";
            paymentBtn.UseVisualStyleBackColor = true;
            paymentBtn.Click += PaymentBtn_Click;
            // 
            // paymentAmount
            // 
            paymentAmount.Location = new Point(89, 63);
            paymentAmount.Name = "paymentAmount";
            paymentAmount.Size = new Size(150, 23);
            paymentAmount.TabIndex = 1;
            paymentAmount.TextChanged += new EventHandler(paymentAmount_TextChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 66);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Сумма";
            // 
            // SellFormPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 193);
            Controls.Add(label1);
            Controls.Add(paymentAmount);
            Controls.Add(paymentBtn);
            Name = "SellFormPayment";
            Text = "SellFormPayment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button paymentBtn;
        private TextBox paymentAmount;
        private Label label1;
    }
}