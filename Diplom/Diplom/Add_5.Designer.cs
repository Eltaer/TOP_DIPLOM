namespace Diplom
{
    partial class Add_5
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
            System.Windows.Forms.Label staff_IDLabel;
            System.Windows.Forms.Label specialistLabel;
            System.Windows.Forms.Label postLabel;
            System.Windows.Forms.Label statusLabel;
            this.CloseAdd = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.staff_IDTextBox = new System.Windows.Forms.TextBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.система_для_технической_поддержкиDataSet = new Diplom.Система_для_технической_поддержкиDataSet();
            this.specialistTextBox = new System.Windows.Forms.TextBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.staffTableAdapter = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.StaffTableAdapter();
            this.tableAdapterManager = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager();
            staff_IDLabel = new System.Windows.Forms.Label();
            specialistLabel = new System.Windows.Forms.Label();
            postLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // staff_IDLabel
            // 
            staff_IDLabel.AutoSize = true;
            staff_IDLabel.Location = new System.Drawing.Point(6, 34);
            staff_IDLabel.Name = "staff_IDLabel";
            staff_IDLabel.Size = new System.Drawing.Size(71, 24);
            staff_IDLabel.TabIndex = 16;
            staff_IDLabel.Text = "Staff ID:";
            // 
            // specialistLabel
            // 
            specialistLabel.AutoSize = true;
            specialistLabel.Location = new System.Drawing.Point(6, 69);
            specialistLabel.Name = "specialistLabel";
            specialistLabel.Size = new System.Drawing.Size(94, 24);
            specialistLabel.TabIndex = 18;
            specialistLabel.Text = "Specialist:";
            // 
            // postLabel
            // 
            postLabel.AutoSize = true;
            postLabel.Location = new System.Drawing.Point(6, 104);
            postLabel.Name = "postLabel";
            postLabel.Size = new System.Drawing.Size(51, 24);
            postLabel.TabIndex = 20;
            postLabel.Text = "Post:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(6, 139);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(65, 24);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "Status:";
            // 
            // CloseAdd
            // 
            this.CloseAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseAdd.Location = new System.Drawing.Point(636, 93);
            this.CloseAdd.Name = "CloseAdd";
            this.CloseAdd.Size = new System.Drawing.Size(134, 30);
            this.CloseAdd.TabIndex = 16;
            this.CloseAdd.Text = "Закрыть";
            this.CloseAdd.UseVisualStyleBackColor = true;
            this.CloseAdd.Click += new System.EventHandler(this.CloseAdd_Click);
            // 
            // AddBut
            // 
            this.AddBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBut.Location = new System.Drawing.Point(636, 28);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(134, 30);
            this.AddBut.TabIndex = 15;
            this.AddBut.Text = "Добавить";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(staff_IDLabel);
            this.groupBox1.Controls.Add(this.staff_IDTextBox);
            this.groupBox1.Controls.Add(specialistLabel);
            this.groupBox1.Controls.Add(this.specialistTextBox);
            this.groupBox1.Controls.Add(postLabel);
            this.groupBox1.Controls.Add(this.postTextBox);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(this.CloseAdd);
            this.groupBox1.Controls.Add(this.AddBut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // staff_IDTextBox
            // 
            this.staff_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Staff_ID", true));
            this.staff_IDTextBox.Location = new System.Drawing.Point(106, 31);
            this.staff_IDTextBox.Name = "staff_IDTextBox";
            this.staff_IDTextBox.Size = new System.Drawing.Size(301, 29);
            this.staff_IDTextBox.TabIndex = 17;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.система_для_технической_поддержкиDataSet;
            // 
            // система_для_технической_поддержкиDataSet
            // 
            this.система_для_технической_поддержкиDataSet.DataSetName = "Система_для_технической_поддержкиDataSet";
            this.система_для_технической_поддержкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialistTextBox
            // 
            this.specialistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Specialist", true));
            this.specialistTextBox.Location = new System.Drawing.Point(106, 66);
            this.specialistTextBox.Name = "specialistTextBox";
            this.specialistTextBox.Size = new System.Drawing.Size(301, 29);
            this.specialistTextBox.TabIndex = 19;
            // 
            // postTextBox
            // 
            this.postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Post", true));
            this.postTextBox.Location = new System.Drawing.Point(106, 101);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(301, 29);
            this.postTextBox.TabIndex = 21;
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(106, 136);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(301, 29);
            this.statusTextBox.TabIndex = 23;
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
            // Add_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_5";
            this.Text = "Add_5";
            this.Load += new System.EventHandler(this.Add_5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseAdd;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private Система_для_технической_поддержкиDataSet система_для_технической_поддержкиDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private Система_для_технической_поддержкиDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox staff_IDTextBox;
        private System.Windows.Forms.TextBox specialistTextBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}