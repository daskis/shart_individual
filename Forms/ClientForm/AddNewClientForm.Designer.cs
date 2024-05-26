namespace Zhuravlev_34.Forms.ClientForm
{
    partial class AddNewClientForm
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
            addClientBtn = new Button();
            cancelClientBtn = new Button();
            clientName = new TextBox();
            phoneClient = new TextBox();
            addressClient = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // addClientBtn
            // 
            addClientBtn.Location = new Point(12, 252);
            addClientBtn.Name = "addClientBtn";
            addClientBtn.Size = new Size(75, 23);
            addClientBtn.TabIndex = 0;
            addClientBtn.Text = "Добавить";
            addClientBtn.UseVisualStyleBackColor = true;
            addClientBtn.Click += addButtonListener;
            // 
            // cancelClientBtn
            // 
            cancelClientBtn.Location = new Point(182, 252);
            cancelClientBtn.Name = "cancelClientBtn";
            cancelClientBtn.Size = new Size(75, 23);
            cancelClientBtn.TabIndex = 1;
            cancelClientBtn.Text = "Отменить";
            cancelClientBtn.UseVisualStyleBackColor = true;
            cancelClientBtn.Click += cancelButtonListener;
            // 
            // clientName
            // 
            clientName.Location = new Point(107, 77);
            clientName.Name = "clientName";
            clientName.Size = new Size(150, 23);
            clientName.TabIndex = 2;
            clientName.TextChanged += new EventHandler(nameClientListener);
            // 
            // phoneClient
            // 
            phoneClient.Location = new Point(107, 130);
            phoneClient.Name = "phoneClient";
            phoneClient.Size = new Size(150, 23);
            phoneClient.TabIndex = 3;
            phoneClient.TextChanged += new EventHandler(phoneClientListener);
            // 
            // addressClient
            // 
            addressClient.Location = new Point(107, 182);
            addressClient.Name = "addressClient";
            addressClient.Size = new Size(150, 23);
            addressClient.TabIndex = 4;
            addressClient.TextChanged += new EventHandler(addressClientListener);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 80);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 185);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Адрес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 133);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 8;
            label2.Text = "Телефон";
            // 
            // AddNewClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 287);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(addressClient);
            Controls.Add(phoneClient);
            Controls.Add(clientName);
            Controls.Add(cancelClientBtn);
            Controls.Add(addClientBtn);
            Name = "AddNewClientForm";
            Text = "AddNewClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addClientBtn;
        private Button cancelClientBtn;
        private TextBox clientName;
        private TextBox phoneClient;
        private TextBox addressClient;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}