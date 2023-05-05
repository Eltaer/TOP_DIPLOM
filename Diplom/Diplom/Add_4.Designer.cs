namespace Diplom
{
    partial class Add_4
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
            System.Windows.Forms.Label crash_IDLabel;
            System.Windows.Forms.Label registrarion_DateLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label causeLabel;
            System.Windows.Forms.Label specialistLabel;
            System.Windows.Forms.Label priorityLabel;
            this.CloseAdd = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crash_IDTextBox = new System.Windows.Forms.TextBox();
            this.crashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.система_для_технической_поддержкиDataSet = new Diplom.Система_для_технической_поддержкиDataSet();
            this.registrarion_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.causeTextBox = new System.Windows.Forms.TextBox();
            this.specialistTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.crashTableAdapter = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.CrashTableAdapter();
            this.tableAdapterManager = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager();
            crash_IDLabel = new System.Windows.Forms.Label();
            registrarion_DateLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            causeLabel = new System.Windows.Forms.Label();
            specialistLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crashBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // crash_IDLabel
            // 
            crash_IDLabel.AutoSize = true;
            crash_IDLabel.Location = new System.Drawing.Point(6, 34);
            crash_IDLabel.Name = "crash_IDLabel";
            crash_IDLabel.Size = new System.Drawing.Size(86, 24);
            crash_IDLabel.TabIndex = 16;
            crash_IDLabel.Text = "Crash ID:";
            // 
            // registrarion_DateLabel
            // 
            registrarion_DateLabel.AutoSize = true;
            registrarion_DateLabel.Location = new System.Drawing.Point(6, 70);
            registrarion_DateLabel.Name = "registrarion_DateLabel";
            registrarion_DateLabel.Size = new System.Drawing.Size(158, 24);
            registrarion_DateLabel.TabIndex = 18;
            registrarion_DateLabel.Text = "Registrarion Date:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(6, 104);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(85, 24);
            addressLabel.TabIndex = 20;
            addressLabel.Text = "Address:";
            // 
            // causeLabel
            // 
            causeLabel.AutoSize = true;
            causeLabel.Location = new System.Drawing.Point(6, 139);
            causeLabel.Name = "causeLabel";
            causeLabel.Size = new System.Drawing.Size(69, 24);
            causeLabel.TabIndex = 22;
            causeLabel.Text = "Cause:";
            // 
            // specialistLabel
            // 
            specialistLabel.AutoSize = true;
            specialistLabel.Location = new System.Drawing.Point(6, 174);
            specialistLabel.Name = "specialistLabel";
            specialistLabel.Size = new System.Drawing.Size(94, 24);
            specialistLabel.TabIndex = 24;
            specialistLabel.Text = "Specialist:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(6, 209);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(71, 24);
            priorityLabel.TabIndex = 26;
            priorityLabel.Text = "Priority:";
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
            this.groupBox1.Controls.Add(crash_IDLabel);
            this.groupBox1.Controls.Add(this.crash_IDTextBox);
            this.groupBox1.Controls.Add(registrarion_DateLabel);
            this.groupBox1.Controls.Add(this.registrarion_DateDateTimePicker);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(causeLabel);
            this.groupBox1.Controls.Add(this.causeTextBox);
            this.groupBox1.Controls.Add(specialistLabel);
            this.groupBox1.Controls.Add(this.specialistTextBox);
            this.groupBox1.Controls.Add(priorityLabel);
            this.groupBox1.Controls.Add(this.priorityTextBox);
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
            // crash_IDTextBox
            // 
            this.crash_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crashBindingSource, "Crash_ID", true));
            this.crash_IDTextBox.Location = new System.Drawing.Point(170, 31);
            this.crash_IDTextBox.Name = "crash_IDTextBox";
            this.crash_IDTextBox.Size = new System.Drawing.Size(301, 29);
            this.crash_IDTextBox.TabIndex = 17;
            // 
            // crashBindingSource
            // 
            this.crashBindingSource.DataMember = "Crash";
            this.crashBindingSource.DataSource = this.система_для_технической_поддержкиDataSet;
            // 
            // система_для_технической_поддержкиDataSet
            // 
            this.система_для_технической_поддержкиDataSet.DataSetName = "Система_для_технической_поддержкиDataSet";
            this.система_для_технической_поддержкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrarion_DateDateTimePicker
            // 
            this.registrarion_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.crashBindingSource, "Registrarion_Date", true));
            this.registrarion_DateDateTimePicker.Location = new System.Drawing.Point(170, 66);
            this.registrarion_DateDateTimePicker.Name = "registrarion_DateDateTimePicker";
            this.registrarion_DateDateTimePicker.Size = new System.Drawing.Size(301, 29);
            this.registrarion_DateDateTimePicker.TabIndex = 19;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crashBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(170, 101);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 29);
            this.addressTextBox.TabIndex = 21;
            // 
            // causeTextBox
            // 
            this.causeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crashBindingSource, "Cause", true));
            this.causeTextBox.Location = new System.Drawing.Point(170, 136);
            this.causeTextBox.Name = "causeTextBox";
            this.causeTextBox.Size = new System.Drawing.Size(301, 29);
            this.causeTextBox.TabIndex = 23;
            // 
            // specialistTextBox
            // 
            this.specialistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crashBindingSource, "Specialist", true));
            this.specialistTextBox.Location = new System.Drawing.Point(170, 171);
            this.specialistTextBox.Name = "specialistTextBox";
            this.specialistTextBox.Size = new System.Drawing.Size(301, 29);
            this.specialistTextBox.TabIndex = 25;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crashBindingSource, "Priority", true));
            this.priorityTextBox.Location = new System.Drawing.Point(170, 206);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(301, 29);
            this.priorityTextBox.TabIndex = 27;
            // 
            // crashTableAdapter
            // 
            this.crashTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CrashTableAdapter = this.crashTableAdapter;
            this.tableAdapterManager.Incident_ClientTableAdapter = null;
            this.tableAdapterManager.IncidentTableAdapter = null;
            this.tableAdapterManager.Staff_CrashTableAdapter = null;
            this.tableAdapterManager.Staff_IncidentTableAdapter = null;
            this.tableAdapterManager.Staff_TaskTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Task_ClientTableAdapter = null;
            this.tableAdapterManager.TaskTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Add_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_4";
            this.Text = "Add_4";
            this.Load += new System.EventHandler(this.Add_4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crashBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseAdd;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private Система_для_технической_поддержкиDataSet система_для_технической_поддержкиDataSet;
        private System.Windows.Forms.BindingSource crashBindingSource;
        private Система_для_технической_поддержкиDataSetTableAdapters.CrashTableAdapter crashTableAdapter;
        private Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox crash_IDTextBox;
        private System.Windows.Forms.DateTimePicker registrarion_DateDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox causeTextBox;
        private System.Windows.Forms.TextBox specialistTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
    }
}