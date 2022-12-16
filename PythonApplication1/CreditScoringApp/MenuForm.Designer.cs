namespace CreditScoringApp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btModel = new System.Windows.Forms.Button();
            this.btReports = new System.Windows.Forms.Button();
            this.btCheckClient = new System.Windows.Forms.Button();
            this.btAddClient = new System.Windows.Forms.Button();
            this.btClients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGWorker = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.сменитьПользователяToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
            this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.закрытьToolStripMenuItem1_Click);
            // 
            // сменитьПользователяToolStripMenuItem1
            // 
            this.сменитьПользователяToolStripMenuItem1.Name = "сменитьПользователяToolStripMenuItem1";
            this.сменитьПользователяToolStripMenuItem1.Size = new System.Drawing.Size(145, 20);
            this.сменитьПользователяToolStripMenuItem1.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem1.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem1_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btModel);
            this.panel1.Controls.Add(this.btReports);
            this.panel1.Controls.Add(this.btCheckClient);
            this.panel1.Controls.Add(this.btAddClient);
            this.panel1.Controls.Add(this.btClients);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 411);
            this.panel1.TabIndex = 2;
            // 
            // btModel
            // 
            this.btModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btModel.FlatAppearance.BorderSize = 0;
            this.btModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btModel.Image = global::CreditScoringApp.Properties.Resources.rsz_gear;
            this.btModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btModel.Location = new System.Drawing.Point(3, 271);
            this.btModel.Name = "btModel";
            this.btModel.Size = new System.Drawing.Size(245, 61);
            this.btModel.TabIndex = 0;
            this.btModel.Text = "Обучение модели";
            this.btModel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btModel.UseVisualStyleBackColor = false;
            this.btModel.Click += new System.EventHandler(this.btModel_Click);
            // 
            // btReports
            // 
            this.btReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btReports.FlatAppearance.BorderSize = 0;
            this.btReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReports.Image = global::CreditScoringApp.Properties.Resources.rsz_reports;
            this.btReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReports.Location = new System.Drawing.Point(3, 204);
            this.btReports.Name = "btReports";
            this.btReports.Size = new System.Drawing.Size(245, 61);
            this.btReports.TabIndex = 0;
            this.btReports.Text = "Отчёты";
            this.btReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReports.UseVisualStyleBackColor = false;
            this.btReports.Click += new System.EventHandler(this.btReports_Click);
            // 
            // btCheckClient
            // 
            this.btCheckClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCheckClient.FlatAppearance.BorderSize = 0;
            this.btCheckClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCheckClient.Image = global::CreditScoringApp.Properties.Resources.rsz_checkuser;
            this.btCheckClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCheckClient.Location = new System.Drawing.Point(3, 137);
            this.btCheckClient.Name = "btCheckClient";
            this.btCheckClient.Size = new System.Drawing.Size(245, 61);
            this.btCheckClient.TabIndex = 0;
            this.btCheckClient.Text = "Проверка клиента";
            this.btCheckClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCheckClient.UseVisualStyleBackColor = false;
            this.btCheckClient.Click += new System.EventHandler(this.btCheckClient_Click);
            // 
            // btAddClient
            // 
            this.btAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAddClient.FlatAppearance.BorderSize = 0;
            this.btAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAddClient.Image = global::CreditScoringApp.Properties.Resources.rsz_adduser;
            this.btAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAddClient.Location = new System.Drawing.Point(3, 70);
            this.btAddClient.Name = "btAddClient";
            this.btAddClient.Size = new System.Drawing.Size(245, 61);
            this.btAddClient.TabIndex = 0;
            this.btAddClient.Text = "Добавление клиента";
            this.btAddClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddClient.UseVisualStyleBackColor = false;
            this.btAddClient.Click += new System.EventHandler(this.btAddClient_Click);
            // 
            // btClients
            // 
            this.btClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btClients.FlatAppearance.BorderSize = 0;
            this.btClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClients.Image = global::CreditScoringApp.Properties.Resources.rsz_users;
            this.btClients.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClients.Location = new System.Drawing.Point(3, 3);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(245, 61);
            this.btClients.TabIndex = 0;
            this.btClients.Text = "Данные о клиентах";
            this.btClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btClients.UseVisualStyleBackColor = false;
            this.btClients.Click += new System.EventHandler(this.btClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данные о пользователе:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.txtPost);
            this.panel2.Controls.Add(this.txtFIO);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(380, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 136);
            this.panel2.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(78, 91);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(325, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(78, 56);
            this.txtPost.Name = "txtPost";
            this.txtPost.ReadOnly = true;
            this.txtPost.Size = new System.Drawing.Size(325, 20);
            this.txtPost.TabIndex = 4;
            // 
            // txtFIO
            // 
            this.txtFIO.Location = new System.Drawing.Point(78, 23);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.ReadOnly = true;
            this.txtFIO.Size = new System.Drawing.Size(325, 20);
            this.txtFIO.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Офис:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Должность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ФИО:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Для начала работы выберете пункт меню слева";
            // 
            // DGWorker
            // 
            this.DGWorker.AllowUserToAddRows = false;
            this.DGWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWorker.Location = new System.Drawing.Point(620, 354);
            this.DGWorker.Name = "DGWorker";
            this.DGWorker.ReadOnly = true;
            this.DGWorker.Size = new System.Drawing.Size(163, 83);
            this.DGWorker.TabIndex = 5;
            this.DGWorker.Visible = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGWorker);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.Button btClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btModel;
        private System.Windows.Forms.Button btReports;
        private System.Windows.Forms.Button btCheckClient;
        private System.Windows.Forms.Button btAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtFIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGWorker;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem1;
    }
}