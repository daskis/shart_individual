namespace Zhuravlev_34.Forms.ClientForm
{
    partial class ClientReportForm
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
            reportStartDate = new DateTimePicker();
            reportEndDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            reportBtn = new Button();
            SuspendLayout();
            // 
            // reportStartDate
            // 
            reportStartDate.Location = new Point(85, 44);
            reportStartDate.Name = "reportStartDate";
            reportStartDate.Size = new Size(200, 23);
            reportStartDate.TabIndex = 0;
            // 
            // reportEndDate
            // 
            reportEndDate.Location = new Point(85, 121);
            reportEndDate.Name = "reportEndDate";
            reportEndDate.Size = new Size(200, 23);
            reportEndDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 50);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Начало";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 127);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Конец";
            // 
            // reportBtn
            // 
            reportBtn.Location = new Point(72, 223);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(150, 30);
            reportBtn.TabIndex = 4;
            reportBtn.Text = "Сформировать";
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // ClientReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 265);
            Controls.Add(reportBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reportEndDate);
            Controls.Add(reportStartDate);
            Name = "ClientReportForm";
            Text = "ClientReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker reportStartDate;
        private DateTimePicker reportEndDate;
        private Label label1;
        private Label label2;
        private Button reportBtn;
    }
}