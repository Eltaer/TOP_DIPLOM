﻿namespace Diplom
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.Save_Butt = new System.Windows.Forms.Button();
            this.Add_Butt = new System.Windows.Forms.Button();
            this.система_для_технической_поддержкиDataSet = new Diplom.Система_для_технической_поддержкиDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.версия001ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телефонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адресToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchText2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Staff_Butt = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Crash_Butt = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Incident_Butt = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Client_Butt = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Tasks_Butt = new System.Windows.Forms.PictureBox();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crash_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Incident_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_Butt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_Butt)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_Butt
            // 
            this.Save_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_Butt.Location = new System.Drawing.Point(558, 523);
            this.Save_Butt.Name = "Save_Butt";
            this.Save_Butt.Size = new System.Drawing.Size(197, 40);
            this.Save_Butt.TabIndex = 17;
            this.Save_Butt.Text = "Сохранить";
            this.Save_Butt.UseVisualStyleBackColor = true;
            this.Save_Butt.Click += new System.EventHandler(this.Save_Butt_Click);
            // 
            // Add_Butt
            // 
            this.Add_Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Butt.Location = new System.Drawing.Point(355, 523);
            this.Add_Butt.Name = "Add_Butt";
            this.Add_Butt.Size = new System.Drawing.Size(197, 40);
            this.Add_Butt.TabIndex = 16;
            this.Add_Butt.Text = "Добавить";
            this.Add_Butt.UseVisualStyleBackColor = true;
            this.Add_Butt.Click += new System.EventHandler(this.Add_Butt_Click);
            // 
            // система_для_технической_поддержкиDataSet
            // 
            this.система_для_технической_поддержкиDataSet.DataSetName = "Система_для_технической_поддержкиDataSet";
            this.система_для_технической_поддержкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.система_для_технической_поддержкиDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CrashTableAdapter = null;
            this.tableAdapterManager.Incident_ClientTableAdapter = null;
            this.tableAdapterManager.IncidentTableAdapter = null;
            this.tableAdapterManager.Staff_CrashTableAdapter = null;
            this.tableAdapterManager.Staff_IncidentTableAdapter = null;
            this.tableAdapterManager.Staff_TaskTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.Task_ClientTableAdapter = null;
            this.tableAdapterManager.TaskTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.staffDataGridView.DataSource = this.staffBindingSource;
            this.staffDataGridView.Location = new System.Drawing.Point(355, 136);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(1242, 381);
            this.staffDataGridView.TabIndex = 18;
            this.staffDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.staffDataGridView_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Staff_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Сотрудника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Specialist";
            this.dataGridViewTextBoxColumn2.HeaderText = "Специалист";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Post";
            this.dataGridViewTextBoxColumn3.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(761, 523);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(197, 40);
            this.Update.TabIndex = 21;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1254, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Пользователь:";
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userBox.Location = new System.Drawing.Point(1385, 528);
            this.userBox.Multiline = true;
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(200, 35);
            this.userBox.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1597, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.версия001ToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // версия001ToolStripMenuItem
            // 
            this.версия001ToolStripMenuItem.Name = "версия001ToolStripMenuItem";
            this.версия001ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.версия001ToolStripMenuItem.Text = "Версия: 0.0.1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.связьToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // связьToolStripMenuItem
            // 
            this.связьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.телефонToolStripMenuItem,
            this.адресToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.связьToolStripMenuItem.Name = "связьToolStripMenuItem";
            this.связьToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.связьToolStripMenuItem.Text = "Связь";
            // 
            // телефонToolStripMenuItem
            // 
            this.телефонToolStripMenuItem.Name = "телефонToolStripMenuItem";
            this.телефонToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.телефонToolStripMenuItem.Text = "Телефон: +7 (4922) 470-101";
            // 
            // адресToolStripMenuItem
            // 
            this.адресToolStripMenuItem.Name = "адресToolStripMenuItem";
            this.адресToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.адресToolStripMenuItem.Text = "Техподдержка: +7 (4922) 470-111";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.emailToolStripMenuItem.Text = "E-mail: info@rayonline.ru";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.searchText2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchText);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 427);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Статус";
            // 
            // searchText2
            // 
            this.searchText2.Location = new System.Drawing.Point(151, 75);
            this.searchText2.Name = "searchText2";
            this.searchText2.Size = new System.Drawing.Size(192, 26);
            this.searchText2.TabIndex = 2;
            this.searchText2.TextChanged += new System.EventHandler(this.searchText2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Специалист";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(151, 34);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(192, 26);
            this.searchText.TabIndex = 0;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Staff_Butt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.Crash_Butt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Incident_Butt);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.Client_Butt);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.Tasks_Butt);
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2065, 109);
            this.panel2.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(442, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Сотрудники";
            // 
            // Staff_Butt
            // 
            this.Staff_Butt.Image = global::Diplom.Properties.Resources.pngwing_com__4_;
            this.Staff_Butt.Location = new System.Drawing.Point(459, 3);
            this.Staff_Butt.Name = "Staff_Butt";
            this.Staff_Butt.Size = new System.Drawing.Size(60, 66);
            this.Staff_Butt.TabIndex = 7;
            this.Staff_Butt.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(342, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Аварии";
            // 
            // Crash_Butt
            // 
            this.Crash_Butt.Image = global::Diplom.Properties.Resources.pngwing_com__3_;
            this.Crash_Butt.Location = new System.Drawing.Point(346, 3);
            this.Crash_Butt.Name = "Crash_Butt";
            this.Crash_Butt.Size = new System.Drawing.Size(61, 66);
            this.Crash_Butt.TabIndex = 7;
            this.Crash_Butt.TabStop = false;
            this.Crash_Butt.Click += new System.EventHandler(this.Crash_Butt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(212, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Инциденты";
            // 
            // Incident_Butt
            // 
            this.Incident_Butt.Image = global::Diplom.Properties.Resources.pngwing_com__2_;
            this.Incident_Butt.Location = new System.Drawing.Point(228, 3);
            this.Incident_Butt.Name = "Incident_Butt";
            this.Incident_Butt.Size = new System.Drawing.Size(61, 66);
            this.Incident_Butt.TabIndex = 7;
            this.Incident_Butt.TabStop = false;
            this.Incident_Butt.Click += new System.EventHandler(this.Incident_Butt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(111, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Клиенты";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Client_Butt
            // 
            this.Client_Butt.Image = global::Diplom.Properties.Resources.pngwing_com__1_;
            this.Client_Butt.Location = new System.Drawing.Point(115, 6);
            this.Client_Butt.Name = "Client_Butt";
            this.Client_Butt.Size = new System.Drawing.Size(60, 63);
            this.Client_Butt.TabIndex = 7;
            this.Client_Butt.TabStop = false;
            this.Client_Butt.Click += new System.EventHandler(this.Client_Butt_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Задачи";
            // 
            // Tasks_Butt
            // 
            this.Tasks_Butt.Image = global::Diplom.Properties.Resources.pngwing1;
            this.Tasks_Butt.Location = new System.Drawing.Point(12, 6);
            this.Tasks_Butt.Name = "Tasks_Butt";
            this.Tasks_Butt.Size = new System.Drawing.Size(57, 63);
            this.Tasks_Butt.TabIndex = 7;
            this.Tasks_Butt.TabStop = false;
            this.Tasks_Butt.Click += new System.EventHandler(this.Tasks_Butt_Click_1);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(964, 523);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(197, 40);
            this.Delete.TabIndex = 32;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1597, 575);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.Save_Butt);
            this.Controls.Add(this.Add_Butt);
            this.Name = "Form5";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Crash_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Incident_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Client_Butt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks_Butt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Save_Butt;
        public System.Windows.Forms.Button Add_Butt;
        private Система_для_технической_поддержкиDataSet система_для_технической_поддержкиDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Система_для_технической_поддержкиDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView staffDataGridView;
        public System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem версия001ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телефонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адресToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchText2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Staff_Butt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Crash_Butt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Incident_Butt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox Client_Butt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox Tasks_Butt;
        public System.Windows.Forms.Button Delete;
    }
}