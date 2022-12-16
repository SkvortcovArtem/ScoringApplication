namespace CreditScoringApp
{
    partial class ModelLearningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelLearningForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.DGDatabase = new System.Windows.Forms.DataGridView();
            this.btLearnModel = new System.Windows.Forms.Button();
            this.btSaveModel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.сохранитьToolStripMenuItem1,
            this.закрытьToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem1
            // 
            this.сохранитьToolStripMenuItem1.Name = "сохранитьToolStripMenuItem1";
            this.сохранитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem1.Text = "Сохранить";
            this.сохранитьToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
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
            this.btModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btModel.FlatAppearance.BorderSize = 2;
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
            // DGDatabase
            // 
            this.DGDatabase.AllowUserToAddRows = false;
            this.DGDatabase.AllowUserToDeleteRows = false;
            this.DGDatabase.AllowUserToResizeRows = false;
            this.DGDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDatabase.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDatabase.Location = new System.Drawing.Point(271, 27);
            this.DGDatabase.MultiSelect = false;
            this.DGDatabase.Name = "DGDatabase";
            this.DGDatabase.ReadOnly = true;
            this.DGDatabase.RowHeadersWidth = 15;
            this.DGDatabase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGDatabase.Size = new System.Drawing.Size(517, 353);
            this.DGDatabase.TabIndex = 7;
            // 
            // btLearnModel
            // 
            this.btLearnModel.Location = new System.Drawing.Point(517, 386);
            this.btLearnModel.Name = "btLearnModel";
            this.btLearnModel.Size = new System.Drawing.Size(271, 23);
            this.btLearnModel.TabIndex = 8;
            this.btLearnModel.Text = "Обучить модель";
            this.btLearnModel.UseVisualStyleBackColor = true;
            this.btLearnModel.Click += new System.EventHandler(this.btLearnModel_Click);
            // 
            // btSaveModel
            // 
            this.btSaveModel.Location = new System.Drawing.Point(517, 415);
            this.btSaveModel.Name = "btSaveModel";
            this.btSaveModel.Size = new System.Drawing.Size(271, 23);
            this.btSaveModel.TabIndex = 8;
            this.btSaveModel.Text = "Сохранить модель";
            this.btSaveModel.UseVisualStyleBackColor = true;
            this.btSaveModel.Click += new System.EventHandler(this.btSaveModel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(271, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(76, 25);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "1. Обучить модель и создать файл с ней";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "2. Сохпранить файл с моделью в базу данных";
            // 
            // ModelLearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btSaveModel);
            this.Controls.Add(this.btLearnModel);
            this.Controls.Add(this.DGDatabase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ModelLearningForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обучение модели";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModelLearningForm_FormClosed);
            this.Shown += new System.EventHandler(this.ModelLearningForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem1;
        private System.Windows.Forms.DataGridView DGDatabase;
        private System.Windows.Forms.Button btLearnModel;
        private System.Windows.Forms.Button btSaveModel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}