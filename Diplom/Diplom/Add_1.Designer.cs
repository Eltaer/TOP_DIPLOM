namespace Diplom
{
    partial class Add_1
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
            System.Windows.Forms.Label task_IDLabel;
            System.Windows.Forms.Label registration_DateLabel;
            System.Windows.Forms.Label f_CNameLabel;
            System.Windows.Forms.Label r_CNameLabel;
            System.Windows.Forms.Label o_CNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label completion_DateLabel;
            System.Windows.Forms.Label specialistLabel;
            System.Windows.Forms.Label addressLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.task_IDTextBox = new System.Windows.Forms.TextBox();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.система_для_технической_поддержкиDataSet = new Diplom.Система_для_технической_поддержкиDataSet();
            this.registration_DateTextBox = new System.Windows.Forms.TextBox();
            this.f_CNameTextBox = new System.Windows.Forms.TextBox();
            this.r_CNameTextBox = new System.Windows.Forms.TextBox();
            this.o_CNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.completion_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.specialistTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.CloseAdd = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.taskTableAdapter = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TaskTableAdapter();
            this.tableAdapterManager = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager();
            task_IDLabel = new System.Windows.Forms.Label();
            registration_DateLabel = new System.Windows.Forms.Label();
            f_CNameLabel = new System.Windows.Forms.Label();
            r_CNameLabel = new System.Windows.Forms.Label();
            o_CNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            completion_DateLabel = new System.Windows.Forms.Label();
            specialistLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // task_IDLabel
            // 
            task_IDLabel.AutoSize = true;
            task_IDLabel.Location = new System.Drawing.Point(6, 34);
            task_IDLabel.Name = "task_IDLabel";
            task_IDLabel.Size = new System.Drawing.Size(77, 24);
            task_IDLabel.TabIndex = 16;
            task_IDLabel.Text = "Task ID:";
            // 
            // registration_DateLabel
            // 
            registration_DateLabel.AutoSize = true;
            registration_DateLabel.Location = new System.Drawing.Point(6, 69);
            registration_DateLabel.Name = "registration_DateLabel";
            registration_DateLabel.Size = new System.Drawing.Size(156, 24);
            registration_DateLabel.TabIndex = 18;
            registration_DateLabel.Text = "Registration Date:";
            // 
            // f_CNameLabel
            // 
            f_CNameLabel.AutoSize = true;
            f_CNameLabel.Location = new System.Drawing.Point(6, 104);
            f_CNameLabel.Name = "f_CNameLabel";
            f_CNameLabel.Size = new System.Drawing.Size(96, 24);
            f_CNameLabel.TabIndex = 20;
            f_CNameLabel.Text = "F CName:";
            // 
            // r_CNameLabel
            // 
            r_CNameLabel.AutoSize = true;
            r_CNameLabel.Location = new System.Drawing.Point(6, 139);
            r_CNameLabel.Name = "r_CNameLabel";
            r_CNameLabel.Size = new System.Drawing.Size(97, 24);
            r_CNameLabel.TabIndex = 22;
            r_CNameLabel.Text = "R CName:";
            // 
            // o_CNameLabel
            // 
            o_CNameLabel.AutoSize = true;
            o_CNameLabel.Location = new System.Drawing.Point(6, 174);
            o_CNameLabel.Name = "o_CNameLabel";
            o_CNameLabel.Size = new System.Drawing.Size(99, 24);
            o_CNameLabel.TabIndex = 24;
            o_CNameLabel.Text = "O CName:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 209);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(109, 24);
            descriptionLabel.TabIndex = 26;
            descriptionLabel.Text = "Description:";
            // 
            // completion_DateLabel
            // 
            completion_DateLabel.AutoSize = true;
            completion_DateLabel.Location = new System.Drawing.Point(6, 245);
            completion_DateLabel.Name = "completion_DateLabel";
            completion_DateLabel.Size = new System.Drawing.Size(154, 24);
            completion_DateLabel.TabIndex = 28;
            completion_DateLabel.Text = "Completion Date:";
            // 
            // specialistLabel
            // 
            specialistLabel.AutoSize = true;
            specialistLabel.Location = new System.Drawing.Point(6, 279);
            specialistLabel.Name = "specialistLabel";
            specialistLabel.Size = new System.Drawing.Size(94, 24);
            specialistLabel.TabIndex = 30;
            specialistLabel.Text = "Specialist:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(6, 314);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(85, 24);
            addressLabel.TabIndex = 32;
            addressLabel.Text = "Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(task_IDLabel);
            this.groupBox1.Controls.Add(this.task_IDTextBox);
            this.groupBox1.Controls.Add(registration_DateLabel);
            this.groupBox1.Controls.Add(this.registration_DateTextBox);
            this.groupBox1.Controls.Add(f_CNameLabel);
            this.groupBox1.Controls.Add(this.f_CNameTextBox);
            this.groupBox1.Controls.Add(r_CNameLabel);
            this.groupBox1.Controls.Add(this.r_CNameTextBox);
            this.groupBox1.Controls.Add(o_CNameLabel);
            this.groupBox1.Controls.Add(this.o_CNameTextBox);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(completion_DateLabel);
            this.groupBox1.Controls.Add(this.completion_DateDateTimePicker);
            this.groupBox1.Controls.Add(specialistLabel);
            this.groupBox1.Controls.Add(this.specialistTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.CloseAdd);
            this.groupBox1.Controls.Add(this.AddBut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // task_IDTextBox
            // 
            this.task_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Task_ID", true));
            this.task_IDTextBox.Location = new System.Drawing.Point(168, 31);
            this.task_IDTextBox.Name = "task_IDTextBox";
            this.task_IDTextBox.Size = new System.Drawing.Size(301, 29);
            this.task_IDTextBox.TabIndex = 17;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.система_для_технической_поддержкиDataSet;
            // 
            // система_для_технической_поддержкиDataSet
            // 
            this.система_для_технической_поддержкиDataSet.DataSetName = "Система_для_технической_поддержкиDataSet";
            this.система_для_технической_поддержкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registration_DateTextBox
            // 
            this.registration_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Registration_Date", true));
            this.registration_DateTextBox.Location = new System.Drawing.Point(168, 66);
            this.registration_DateTextBox.Name = "registration_DateTextBox";
            this.registration_DateTextBox.Size = new System.Drawing.Size(301, 29);
            this.registration_DateTextBox.TabIndex = 19;
            // 
            // f_CNameTextBox
            // 
            this.f_CNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "F_CName", true));
            this.f_CNameTextBox.Location = new System.Drawing.Point(168, 101);
            this.f_CNameTextBox.Name = "f_CNameTextBox";
            this.f_CNameTextBox.Size = new System.Drawing.Size(301, 29);
            this.f_CNameTextBox.TabIndex = 21;
            // 
            // r_CNameTextBox
            // 
            this.r_CNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "R_CName", true));
            this.r_CNameTextBox.Location = new System.Drawing.Point(168, 136);
            this.r_CNameTextBox.Name = "r_CNameTextBox";
            this.r_CNameTextBox.Size = new System.Drawing.Size(301, 29);
            this.r_CNameTextBox.TabIndex = 23;
            // 
            // o_CNameTextBox
            // 
            this.o_CNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "O_CName", true));
            this.o_CNameTextBox.Location = new System.Drawing.Point(168, 171);
            this.o_CNameTextBox.Name = "o_CNameTextBox";
            this.o_CNameTextBox.Size = new System.Drawing.Size(301, 29);
            this.o_CNameTextBox.TabIndex = 25;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(168, 206);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(301, 29);
            this.descriptionTextBox.TabIndex = 27;
            // 
            // completion_DateDateTimePicker
            // 
            this.completion_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.taskBindingSource, "Completion_Date", true));
            this.completion_DateDateTimePicker.Location = new System.Drawing.Point(168, 241);
            this.completion_DateDateTimePicker.Name = "completion_DateDateTimePicker";
            this.completion_DateDateTimePicker.Size = new System.Drawing.Size(301, 29);
            this.completion_DateDateTimePicker.TabIndex = 29;
            // 
            // specialistTextBox
            // 
            this.specialistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Specialist", true));
            this.specialistTextBox.Location = new System.Drawing.Point(168, 276);
            this.specialistTextBox.Name = "specialistTextBox";
            this.specialistTextBox.Size = new System.Drawing.Size(301, 29);
            this.specialistTextBox.TabIndex = 31;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taskBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(168, 311);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 29);
            this.addressTextBox.TabIndex = 33;
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
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Task_ClientTableAdapter = null;
            this.tableAdapterManager.TaskTableAdapter = this.taskTableAdapter;
            this.tableAdapterManager.UpdateOrder = Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Add_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 473);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_1";
            this.Text = "Add_1";
            this.Load += new System.EventHandler(this.Add_1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CloseAdd;
        private System.Windows.Forms.Button AddBut;
        private Система_для_технической_поддержкиDataSet система_для_технической_поддержкиDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private Система_для_технической_поддержкиDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox task_IDTextBox;
        private System.Windows.Forms.TextBox registration_DateTextBox;
        private System.Windows.Forms.TextBox f_CNameTextBox;
        private System.Windows.Forms.TextBox r_CNameTextBox;
        private System.Windows.Forms.TextBox o_CNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker completion_DateDateTimePicker;
        private System.Windows.Forms.TextBox specialistTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
    }
}