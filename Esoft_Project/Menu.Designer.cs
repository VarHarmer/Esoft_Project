namespace Esoft_Project
{
    partial class Menu
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenRealEstates = new System.Windows.Forms.Button();
            this.buttonOpenSupplies = new System.Windows.Forms.Button();
            this.buttonOpenDemand = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(19, 30);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(227, 62);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenClients.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenClients.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenClients.Location = new System.Drawing.Point(8, 99);
            this.buttonOpenClients.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenClients.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenAgents.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonOpenAgents.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenAgents.Location = new System.Drawing.Point(8, 177);
            this.buttonOpenAgents.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenAgents.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenAgents.TabIndex = 2;
            this.buttonOpenAgents.Text = "Риелторы";
            this.buttonOpenAgents.UseVisualStyleBackColor = false;
            this.buttonOpenAgents.Click += new System.EventHandler(this.buttonOpenAgents_Click);
            // 
            // buttonOpenRealEstates
            // 
            this.buttonOpenRealEstates.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenRealEstates.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonOpenRealEstates.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenRealEstates.Location = new System.Drawing.Point(8, 255);
            this.buttonOpenRealEstates.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenRealEstates.Name = "buttonOpenRealEstates";
            this.buttonOpenRealEstates.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenRealEstates.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenRealEstates.TabIndex = 3;
            this.buttonOpenRealEstates.Text = "Объекты недвижимости";
            this.buttonOpenRealEstates.UseVisualStyleBackColor = false;
            this.buttonOpenRealEstates.Click += new System.EventHandler(this.buttonOpenRealEstates_Click);
            // 
            // buttonOpenSupplies
            // 
            this.buttonOpenSupplies.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenSupplies.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonOpenSupplies.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenSupplies.Location = new System.Drawing.Point(8, 333);
            this.buttonOpenSupplies.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenSupplies.Name = "buttonOpenSupplies";
            this.buttonOpenSupplies.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenSupplies.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplies.TabIndex = 4;
            this.buttonOpenSupplies.Text = "Предложения";
            this.buttonOpenSupplies.UseVisualStyleBackColor = false;
            this.buttonOpenSupplies.Click += new System.EventHandler(this.buttonOpenDemands_Click);
            // 
            // buttonOpenDemand
            // 
            this.buttonOpenDemand.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenDemand.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonOpenDemand.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenDemand.Location = new System.Drawing.Point(8, 411);
            this.buttonOpenDemand.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenDemand.Name = "buttonOpenDemand";
            this.buttonOpenDemand.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenDemand.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDemand.TabIndex = 5;
            this.buttonOpenDemand.Text = "Потребности";
            this.buttonOpenDemand.UseVisualStyleBackColor = false;
            this.buttonOpenDemand.Click += new System.EventHandler(this.buttonOpenSupplies_Click);
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOpenDeals.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonOpenDeals.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOpenDeals.Location = new System.Drawing.Point(8, 489);
            this.buttonOpenDeals.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenDeals.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDeals.TabIndex = 6;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = false;
            this.buttonOpenDeals.Click += new System.EventHandler(this.buttonOpenDeals_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(12, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(37, 13);
            this.labelHello.TabIndex = 7;
            this.labelHello.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 561);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenDemand);
            this.Controls.Add(this.buttonOpenSupplies);
            this.Controls.Add(this.buttonOpenRealEstates);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.Logo);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenRealEstates;
        private System.Windows.Forms.Button buttonOpenSupplies;
        private System.Windows.Forms.Button buttonOpenDemand;
        private System.Windows.Forms.Button buttonOpenDeals;
        private System.Windows.Forms.Label labelHello;
    }
}

