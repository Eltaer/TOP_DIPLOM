namespace Diplom
{
    partial class Add_3
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
            System.Windows.Forms.Label incident_IDLabel;
            System.Windows.Forms.Label registration_DateLabel;
            System.Windows.Forms.Label f_CNameLabel;
            System.Windows.Forms.Label r_CNameLabel;
            System.Windows.Forms.Label o_CNameLabel;
            System.Windows.Forms.Label contract_NumberLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label evidenceLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label specialistLabel;
            System.Windows.Forms.Label client_IDLabel;
            this.CloseAdd = new System.Windows.Forms.Button();
            this.AddBut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incident_IDTextBox = new System.Windows.Forms.TextBox();
            this.incidentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.система_для_технической_поддержкиDataSet = new Diplom.Система_для_технической_поддержкиDataSet();
            this.registration_DateTextBox = new System.Windows.Forms.TextBox();
            this.f_CNameTextBox = new System.Windows.Forms.TextBox();
            this.r_CNameTextBox = new System.Windows.Forms.TextBox();
            this.o_CNameTextBox = new System.Windows.Forms.TextBox();
            this.contract_NumberTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.evidenceTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.specialistTextBox = new System.Windows.Forms.TextBox();
            this.client_IDTextBox = new System.Windows.Forms.TextBox();
            this.incidentTableAdapter = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.IncidentTableAdapter();
            this.tableAdapterManager = new Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager();
            incident_IDLabel = new System.Windows.Forms.Label();
            registration_DateLabel = new System.Windows.Forms.Label();
            f_CNameLabel = new System.Windows.Forms.Label();
            r_CNameLabel = new System.Windows.Forms.Label();
            o_CNameLabel = new System.Windows.Forms.Label();
            contract_NumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            evidenceLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            specialistLabel = new System.Windows.Forms.Label();
            client_IDLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // incident_IDLabel
            // 
            incident_IDLabel.AutoSize = true;
            incident_IDLabel.Location = new System.Drawing.Point(6, 31);
            incident_IDLabel.Name = "incident_IDLabel";
            incident_IDLabel.Size = new System.Drawing.Size(103, 24);
            incident_IDLabel.TabIndex = 16;
            incident_IDLabel.Text = "Incident ID:";
            // 
            // registration_DateLabel
            // 
            registration_DateLabel.AutoSize = true;
            registration_DateLabel.Location = new System.Drawing.Point(6, 66);
            registration_DateLabel.Name = "registration_DateLabel";
            registration_DateLabel.Size = new System.Drawing.Size(156, 24);
            registration_DateLabel.TabIndex = 18;
            registration_DateLabel.Text = "Registration Date:";
            // 
            // f_CNameLabel
            // 
            f_CNameLabel.AutoSize = true;
            f_CNameLabel.Location = new System.Drawing.Point(6, 101);
            f_CNameLabel.Name = "f_CNameLabel";
            f_CNameLabel.Size = new System.Drawing.Size(96, 24);
            f_CNameLabel.TabIndex = 20;
            f_CNameLabel.Text = "F CName:";
            // 
            // r_CNameLabel
            // 
            r_CNameLabel.AutoSize = true;
            r_CNameLabel.Location = new System.Drawing.Point(6, 136);
            r_CNameLabel.Name = "r_CNameLabel";
            r_CNameLabel.Size = new System.Drawing.Size(97, 24);
            r_CNameLabel.TabIndex = 22;
            r_CNameLabel.Text = "R CName:";
            // 
            // o_CNameLabel
            // 
            o_CNameLabel.AutoSize = true;
            o_CNameLabel.Location = new System.Drawing.Point(6, 171);
            o_CNameLabel.Name = "o_CNameLabel";
            o_CNameLabel.Size = new System.Drawing.Size(99, 24);
            o_CNameLabel.TabIndex = 24;
            o_CNameLabel.Text = "O CName:";
            // 
            // contract_NumberLabel
            // 
            contract_NumberLabel.AutoSize = true;
            contract_NumberLabel.Location = new System.Drawing.Point(6, 206);
            contract_NumberLabel.Name = "contract_NumberLabel";
            contract_NumberLabel.Size = new System.Drawing.Size(158, 24);
            contract_NumberLabel.TabIndex = 26;
            contract_NumberLabel.Text = "Contract Number:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 241);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(109, 24);
            descriptionLabel.TabIndex = 28;
            descriptionLabel.Text = "Description:";
            // 
            // evidenceLabel
            // 
            evidenceLabel.AutoSize = true;
            evidenceLabel.Location = new System.Drawing.Point(6, 276);
            evidenceLabel.Name = "evidenceLabel";
            evidenceLabel.Size = new System.Drawing.Size(95, 24);
            evidenceLabel.TabIndex = 30;
            evidenceLabel.Text = "Evidence:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(6, 311);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(85, 24);
            addressLabel.TabIndex = 32;
            addressLabel.Text = "Address:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(6, 346);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(95, 24);
            conditionLabel.TabIndex = 34;
            conditionLabel.Text = "Condition:";
            // 
            // specialistLabel
            // 
            specialistLabel.AutoSize = true;
            specialistLabel.Location = new System.Drawing.Point(6, 381);
            specialistLabel.Name = "specialistLabel";
            specialistLabel.Size = new System.Drawing.Size(94, 24);
            specialistLabel.TabIndex = 36;
            specialistLabel.Text = "Specialist:";
            // 
            // client_IDLabel
            // 
            client_IDLabel.AutoSize = true;
            client_IDLabel.Location = new System.Drawing.Point(6, 416);
            client_IDLabel.Name = "client_IDLabel";
            client_IDLabel.Size = new System.Drawing.Size(84, 24);
            client_IDLabel.TabIndex = 38;
            client_IDLabel.Text = "Client ID:";
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(incident_IDLabel);
            this.groupBox1.Controls.Add(this.incident_IDTextBox);
            this.groupBox1.Controls.Add(registration_DateLabel);
            this.groupBox1.Controls.Add(this.registration_DateTextBox);
            this.groupBox1.Controls.Add(f_CNameLabel);
            this.groupBox1.Controls.Add(this.f_CNameTextBox);
            this.groupBox1.Controls.Add(r_CNameLabel);
            this.groupBox1.Controls.Add(this.r_CNameTextBox);
            this.groupBox1.Controls.Add(o_CNameLabel);
            this.groupBox1.Controls.Add(this.o_CNameTextBox);
            this.groupBox1.Controls.Add(contract_NumberLabel);
            this.groupBox1.Controls.Add(this.contract_NumberTextBox);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(evidenceLabel);
            this.groupBox1.Controls.Add(this.evidenceTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(conditionLabel);
            this.groupBox1.Controls.Add(this.conditionTextBox);
            this.groupBox1.Controls.Add(specialistLabel);
            this.groupBox1.Controls.Add(this.specialistTextBox);
            this.groupBox1.Controls.Add(client_IDLabel);
            this.groupBox1.Controls.Add(this.client_IDTextBox);
            this.groupBox1.Controls.Add(this.CloseAdd);
            this.groupBox1.Controls.Add(this.AddBut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 532);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            // 
            // incident_IDTextBox
            // 
            this.incident_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "Incident_ID", true));
            this.incident_IDTextBox.Location = new System.Drawing.Point(170, 28);
            this.incident_IDTextBox.Name = "incident_IDTextBox";
            this.incident_IDTextBox.Size = new System.Drawing.Size(301, 29);
            this.incident_IDTextBox.TabIndex = 17;
            // 
            // incidentBindingSource
            // 
            this.incidentBindingSource.DataMember = "Incident";
            this.incidentBindingSource.DataSource = this.система_для_технической_поддержкиDataSet;
            // 
            // система_для_технической_поддержкиDataSet
            // 
            this.система_для_технической_поддержкиDataSet.DataSetName = "Система_для_технической_поддержкиDataSet";
            this.система_для_технической_поддержкиDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registration_DateTextBox
            // 
            this.registration_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "Registration_Date", true));
            this.registration_DateTextBox.Location = new System.Drawing.Point(170, 63);
            this.registration_DateTextBox.Name = "registration_DateTextBox";
            this.registration_DateTextBox.Size = new System.Drawing.Size(301, 29);
            this.registration_DateTextBox.TabIndex = 19;
            // 
            // f_CNameTextBox
            // 
            this.f_CNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "F_CName", true));
            this.f_CNameTextBox.Location = new System.Drawing.Point(170, 98);
            this.f_CNameTextBox.Name = "f_CNameTextBox";
            this.f_CNameTextBox.Size = new System.Drawing.Size(301, 29);
            this.f_CNameTextBox.TabIndex = 21;
            // 
            // r_CNameTextBox
            // 
            this.r_CNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "R_CName", true));
            this.r_CNameTextBox.Location = new System.Drawing.Point(170, 133);
            this.r_CNameTextBox.Name = "r_CNameTextBox";
            this.r_CNameTextBox.Size = new System.Drawing.Size(301, 29);
            this.r_CNameTextBox.TabIndex = 23;
            // 
            // o_CNameTextBox
            // 
            this.o_CNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "O_CName", true));
            this.o_CNameTextBox.Location = new System.Drawing.Point(170, 168);
            this.o_CNameTextBox.Name = "o_CNameTextBox";
            this.o_CNameTextBox.Size = new System.Drawing.Size(301, 29);
            this.o_CNameTextBox.TabIndex = 25;
            // 
            // contract_NumberTextBox
            // 
            this.contract_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "Contract_Number", true));
            this.contract_NumberTextBox.Location = new System.Drawing.Point(170, 203);
            this.contract_NumberTextBox.Name = "contract_NumberTextBox";
            this.contract_NumberTextBox.Size = new System.Drawing.Size(301, 29);
            this.contract_NumberTextBox.TabIndex = 27;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(170, 238);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(301, 29);
            this.descriptionTextBox.TabIndex = 29;
            // 
            // evidenceTextBox
            // 
            this.evidenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "Evidence", true));
            this.evidenceTextBox.Location = new System.Drawing.Point(170, 273);
            this.evidenceTextBox.Name = "evidenceTextBox";
            this.evidenceTextBox.Size = new System.Drawing.Size(301, 29);
            this.evidenceTextBox.TabIndex = 31;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(170, 308);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(301, 29);
            this.addressTextBox.TabIndex = 33;
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "Condition", true));
            this.conditionTextBox.Location = new System.Drawing.Point(170, 343);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(301, 29);
            this.conditionTextBox.TabIndex = 35;
            // 
            // specialistTextBox
            // 
            this.specialistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "Specialist", true));
            this.specialistTextBox.Location = new System.Drawing.Point(170, 378);
            this.specialistTextBox.Name = "specialistTextBox";
            this.specialistTextBox.Size = new System.Drawing.Size(301, 29);
            this.specialistTextBox.TabIndex = 37;
            // 
            // client_IDTextBox
            // 
            this.client_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentBindingSource, "Client_ID", true));
            this.client_IDTextBox.Location = new System.Drawing.Point(170, 413);
            this.client_IDTextBox.Name = "client_IDTextBox";
            this.client_IDTextBox.Size = new System.Drawing.Size(301, 29);
            this.client_IDTextBox.TabIndex = 39;
            // 
            // incidentTableAdapter
            // 
            this.incidentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CrashTableAdapter = null;
            this.tableAdapterManager.Incident_ClientTableAdapter = null;
            this.tableAdapterManager.IncidentTableAdapter = this.incidentTableAdapter;
            this.tableAdapterManager.Staff_CrashTableAdapter = null;
            this.tableAdapterManager.Staff_IncidentTableAdapter = null;
            this.tableAdapterManager.Staff_TaskTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.Task_ClientTableAdapter = null;
            this.tableAdapterManager.TaskTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom.Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Add_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 544);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_3";
            this.Text = "Add_3";
            this.Load += new System.EventHandler(this.Add_3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.система_для_технической_поддержкиDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseAdd;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.GroupBox groupBox1;
        private Система_для_технической_поддержкиDataSet система_для_технической_поддержкиDataSet;
        private System.Windows.Forms.BindingSource incidentBindingSource;
        private Система_для_технической_поддержкиDataSetTableAdapters.IncidentTableAdapter incidentTableAdapter;
        private Система_для_технической_поддержкиDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox incident_IDTextBox;
        private System.Windows.Forms.TextBox registration_DateTextBox;
        private System.Windows.Forms.TextBox f_CNameTextBox;
        private System.Windows.Forms.TextBox r_CNameTextBox;
        private System.Windows.Forms.TextBox o_CNameTextBox;
        private System.Windows.Forms.TextBox contract_NumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox evidenceTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.TextBox specialistTextBox;
        private System.Windows.Forms.TextBox client_IDTextBox;
    }
}