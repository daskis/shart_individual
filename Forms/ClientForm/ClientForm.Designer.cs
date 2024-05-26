namespace Zhuravlev_34.Forms.ClientForm
{
    partial class ClientForm
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
            addClient = new ToolStripMenuItem();
            removeClient = new ToolStripMenuItem();
            clientGridView = new DataGridView();
            reportLink = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addClient, removeClient, reportLink });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addClient
            // 
            addClient.Name = "addClient";
            addClient.Size = new Size(71, 20);
            addClient.Text = "Добавить";
            addClient.Click += addClientListener;
            // 
            // removeClient
            // 
            removeClient.Name = "removeClient";
            removeClient.Size = new Size(63, 20);
            removeClient.Text = "Удалить";
            removeClient.Click += removeClientListener;
            // 
            // clientGridView
            // 
            clientGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientGridView.Location = new Point(12, 27);
            clientGridView.Name = "clientGridView";
            clientGridView.Size = new Size(500, 273);
            clientGridView.TabIndex = 1;
            clientGridView.ColumnCount = 4;
            clientGridView.Columns[0].Name = "Id";
            clientGridView.Columns[1].Name = "Имя";
            clientGridView.Columns[2].Name = "Телефон";
            clientGridView.Columns[3].Name = "Адрес";
            clientGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientGridView.MultiSelect = true;
            // 
            // reportLink
            // 
            reportLink.Name = "reportLink";
            reportLink.Size = new Size(51, 20);
            reportLink.Text = "Отчет";
            reportLink.Click += reportListener;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clientGridView);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ClientForm";
            Text = "ClientForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addClient;
        private ToolStripMenuItem removeClient;
        private DataGridView clientGridView;
        private ToolStripMenuItem reportLink;
    }
}