namespace CarServiceForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.client = new System.Windows.Forms.TabPage();
            this.clientBasePage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.newClient = new System.Windows.Forms.Button();
            this.clientList = new System.Windows.Forms.ListBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.clientBasePage.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(4, 22);
            this.client.Name = "client";
            this.client.Padding = new System.Windows.Forms.Padding(3);
            this.client.Size = new System.Drawing.Size(476, 335);
            this.client.TabIndex = 1;
            this.client.Text = "Клиент";
            this.client.UseVisualStyleBackColor = true;
            // 
            // clientBasePage
            // 
            this.clientBasePage.Controls.Add(this.button1);
            this.clientBasePage.Controls.Add(this.newClient);
            this.clientBasePage.Controls.Add(this.clientList);
            this.clientBasePage.Location = new System.Drawing.Point(4, 22);
            this.clientBasePage.Name = "clientBasePage";
            this.clientBasePage.Padding = new System.Windows.Forms.Padding(3);
            this.clientBasePage.Size = new System.Drawing.Size(476, 335);
            this.clientBasePage.TabIndex = 0;
            this.clientBasePage.Text = "Клиентская база";
            this.clientBasePage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(270, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Удалить клиента";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(76, 25);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(120, 23);
            this.newClient.TabIndex = 3;
            this.newClient.Text = "Новый клиент";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // clientList
            // 
            this.clientList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientList.FormattingEnabled = true;
            this.clientList.Location = new System.Drawing.Point(8, 68);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(460, 264);
            this.clientList.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.clientBasePage);
            this.tabControl.Controls.Add(this.client);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(484, 361);
            this.tabControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосервис";
            this.clientBasePage.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage client;
        private System.Windows.Forms.TabPage clientBasePage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.ListBox clientList;
    }
}

