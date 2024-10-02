namespace agriWinAppTest
{
    partial class frm_MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabDepartment = new TabPage();
            btnClearDepartment = new Button();
            label3 = new Label();
            tbDepartmentAddress = new TextBox();
            btnDeleteDepartment = new Button();
            btnSaveDepartment = new Button();
            tbDepartmentName = new TextBox();
            label1 = new Label();
            tbDepartmentID = new TextBox();
            label2 = new Label();
            gbDepartmentList = new GroupBox();
            btnDepartmentRefresh = new Button();
            dgvDepartmentList = new DataGridView();
            departmentCode = new DataGridViewTextBoxColumn();
            departmentName = new DataGridViewTextBoxColumn();
            departmentAddress = new DataGridViewTextBoxColumn();
            tabEmployee = new TabPage();
            btnClearEmp = new Button();
            gbEmployeeList = new GroupBox();
            btnEmployeeRefresh = new Button();
            dgvEmployee = new DataGridView();
            employeeCode = new DataGridViewTextBoxColumn();
            empFirstName = new DataGridViewTextBoxColumn();
            empLastName = new DataGridViewTextBoxColumn();
            empGender = new DataGridViewTextBoxColumn();
            empBirthDate = new DataGridViewTextBoxColumn();
            empDateJoined = new DataGridViewTextBoxColumn();
            empAddress = new DataGridViewTextBoxColumn();
            picEmployee = new PictureBox();
            btnDeleteEmp = new Button();
            btnSaveEmp = new Button();
            tbEmpAddress = new TextBox();
            dtpDateJoined = new DateTimePicker();
            dtpDateOfBirth = new DateTimePicker();
            cbGender = new ComboBox();
            tbEmpLastName = new TextBox();
            tbEmpFirstName = new TextBox();
            tbEmployeeID = new TextBox();
            tbEmpDepartmentID = new TextBox();
            lbEmpAddress = new Label();
            lbDateJoined = new Label();
            lbDateOfBirth = new Label();
            lbGender = new Label();
            lbLastName = new Label();
            lbFirstName = new Label();
            lbDepartmentID = new Label();
            lbEmployeeID = new Label();
            tabControl1.SuspendLayout();
            tabDepartment.SuspendLayout();
            gbDepartmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartmentList).BeginInit();
            tabEmployee.SuspendLayout();
            gbEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDepartment);
            tabControl1.Controls.Add(tabEmployee);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 651);
            tabControl1.TabIndex = 2;
            // 
            // tabDepartment
            // 
            tabDepartment.Controls.Add(btnClearDepartment);
            tabDepartment.Controls.Add(label3);
            tabDepartment.Controls.Add(tbDepartmentAddress);
            tabDepartment.Controls.Add(btnDeleteDepartment);
            tabDepartment.Controls.Add(btnSaveDepartment);
            tabDepartment.Controls.Add(tbDepartmentName);
            tabDepartment.Controls.Add(label1);
            tabDepartment.Controls.Add(tbDepartmentID);
            tabDepartment.Controls.Add(label2);
            tabDepartment.Controls.Add(gbDepartmentList);
            tabDepartment.Location = new Point(4, 24);
            tabDepartment.Name = "tabDepartment";
            tabDepartment.Padding = new Padding(3);
            tabDepartment.Size = new Size(912, 623);
            tabDepartment.TabIndex = 0;
            tabDepartment.Text = "Department";
            tabDepartment.UseVisualStyleBackColor = true;
            // 
            // btnClearDepartment
            // 
            btnClearDepartment.Location = new Point(586, 239);
            btnClearDepartment.Name = "btnClearDepartment";
            btnClearDepartment.Size = new Size(93, 26);
            btnClearDepartment.TabIndex = 30;
            btnClearDepartment.Text = "Clear";
            btnClearDepartment.UseVisualStyleBackColor = true;
            btnClearDepartment.MouseClick += btnClearDepartment_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 130);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 29;
            label3.Text = "Department Address";
            // 
            // tbDepartmentAddress
            // 
            tbDepartmentAddress.Location = new Point(487, 148);
            tbDepartmentAddress.Multiline = true;
            tbDepartmentAddress.Name = "tbDepartmentAddress";
            tbDepartmentAddress.Size = new Size(406, 65);
            tbDepartmentAddress.TabIndex = 28;
            // 
            // btnDeleteDepartment
            // 
            btnDeleteDepartment.ForeColor = Color.Red;
            btnDeleteDepartment.Location = new Point(719, 239);
            btnDeleteDepartment.Name = "btnDeleteDepartment";
            btnDeleteDepartment.Size = new Size(93, 26);
            btnDeleteDepartment.TabIndex = 27;
            btnDeleteDepartment.Text = "Delete";
            btnDeleteDepartment.UseVisualStyleBackColor = true;
            btnDeleteDepartment.MouseClick += btnDeleteDepartment_MouseClick;
            // 
            // btnSaveDepartment
            // 
            btnSaveDepartment.Location = new Point(487, 239);
            btnSaveDepartment.Name = "btnSaveDepartment";
            btnSaveDepartment.Size = new Size(93, 26);
            btnSaveDepartment.TabIndex = 26;
            btnSaveDepartment.Text = "Save";
            btnSaveDepartment.UseVisualStyleBackColor = true;
            btnSaveDepartment.MouseClick += btnSaveDepartment_MouseClick;
            // 
            // tbDepartmentName
            // 
            tbDepartmentName.Location = new Point(487, 91);
            tbDepartmentName.Name = "tbDepartmentName";
            tbDepartmentName.Size = new Size(406, 23);
            tbDepartmentName.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 73);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 24;
            label1.Text = "Department Name";
            // 
            // tbDepartmentID
            // 
            tbDepartmentID.Location = new Point(487, 41);
            tbDepartmentID.Name = "tbDepartmentID";
            tbDepartmentID.Size = new Size(151, 23);
            tbDepartmentID.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 23);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 22;
            label2.Text = "Department ID";
            // 
            // gbDepartmentList
            // 
            gbDepartmentList.Controls.Add(btnDepartmentRefresh);
            gbDepartmentList.Controls.Add(dgvDepartmentList);
            gbDepartmentList.Location = new Point(14, 19);
            gbDepartmentList.Name = "gbDepartmentList";
            gbDepartmentList.Size = new Size(452, 554);
            gbDepartmentList.TabIndex = 19;
            gbDepartmentList.TabStop = false;
            gbDepartmentList.Text = "Department List";
            // 
            // btnDepartmentRefresh
            // 
            btnDepartmentRefresh.Location = new Point(17, 509);
            btnDepartmentRefresh.Name = "btnDepartmentRefresh";
            btnDepartmentRefresh.Size = new Size(93, 26);
            btnDepartmentRefresh.TabIndex = 30;
            btnDepartmentRefresh.Text = "Refresh";
            btnDepartmentRefresh.UseVisualStyleBackColor = true;
            btnDepartmentRefresh.MouseClick += btnDepartmentRefresh_MouseClick;
            // 
            // dgvDepartmentList
            // 
            dgvDepartmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartmentList.Columns.AddRange(new DataGridViewColumn[] { departmentCode, departmentName, departmentAddress });
            dgvDepartmentList.Location = new Point(17, 22);
            dgvDepartmentList.Name = "dgvDepartmentList";
            dgvDepartmentList.RowTemplate.Height = 25;
            dgvDepartmentList.Size = new Size(417, 465);
            dgvDepartmentList.TabIndex = 18;
            dgvDepartmentList.CellMouseClick += dgvDepartmentList_CellMouseClick;
            // 
            // departmentCode
            // 
            departmentCode.HeaderText = "Department ID";
            departmentCode.Name = "departmentCode";
            departmentCode.ReadOnly = true;
            departmentCode.Width = 150;
            // 
            // departmentName
            // 
            departmentName.HeaderText = "Department Name";
            departmentName.Name = "departmentName";
            departmentName.ReadOnly = true;
            departmentName.Width = 150;
            // 
            // departmentAddress
            // 
            departmentAddress.HeaderText = "Department Address";
            departmentAddress.Name = "departmentAddress";
            departmentAddress.ReadOnly = true;
            departmentAddress.Width = 300;
            // 
            // tabEmployee
            // 
            tabEmployee.Controls.Add(btnClearEmp);
            tabEmployee.Controls.Add(gbEmployeeList);
            tabEmployee.Controls.Add(picEmployee);
            tabEmployee.Controls.Add(btnDeleteEmp);
            tabEmployee.Controls.Add(btnSaveEmp);
            tabEmployee.Controls.Add(tbEmpAddress);
            tabEmployee.Controls.Add(dtpDateJoined);
            tabEmployee.Controls.Add(dtpDateOfBirth);
            tabEmployee.Controls.Add(cbGender);
            tabEmployee.Controls.Add(tbEmpLastName);
            tabEmployee.Controls.Add(tbEmpFirstName);
            tabEmployee.Controls.Add(tbEmployeeID);
            tabEmployee.Controls.Add(tbEmpDepartmentID);
            tabEmployee.Controls.Add(lbEmpAddress);
            tabEmployee.Controls.Add(lbDateJoined);
            tabEmployee.Controls.Add(lbDateOfBirth);
            tabEmployee.Controls.Add(lbGender);
            tabEmployee.Controls.Add(lbLastName);
            tabEmployee.Controls.Add(lbFirstName);
            tabEmployee.Controls.Add(lbDepartmentID);
            tabEmployee.Controls.Add(lbEmployeeID);
            tabEmployee.Location = new Point(4, 24);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.Padding = new Padding(3);
            tabEmployee.Size = new Size(912, 623);
            tabEmployee.TabIndex = 1;
            tabEmployee.Text = "Employee";
            tabEmployee.UseVisualStyleBackColor = true;
            // 
            // btnClearEmp
            // 
            btnClearEmp.Location = new Point(117, 240);
            btnClearEmp.Name = "btnClearEmp";
            btnClearEmp.Size = new Size(93, 26);
            btnClearEmp.TabIndex = 24;
            btnClearEmp.Text = "Clear";
            btnClearEmp.UseVisualStyleBackColor = true;
            btnClearEmp.MouseClick += btnClearEmployee_MouseClick;
            // 
            // gbEmployeeList
            // 
            gbEmployeeList.Controls.Add(btnEmployeeRefresh);
            gbEmployeeList.Controls.Add(dgvEmployee);
            gbEmployeeList.Location = new Point(18, 300);
            gbEmployeeList.Name = "gbEmployeeList";
            gbEmployeeList.Size = new Size(878, 297);
            gbEmployeeList.TabIndex = 23;
            gbEmployeeList.TabStop = false;
            gbEmployeeList.Text = "Employee List";
            // 
            // btnEmployeeRefresh
            // 
            btnEmployeeRefresh.Location = new Point(20, 254);
            btnEmployeeRefresh.Name = "btnEmployeeRefresh";
            btnEmployeeRefresh.Size = new Size(93, 26);
            btnEmployeeRefresh.TabIndex = 19;
            btnEmployeeRefresh.Text = "Refresh";
            btnEmployeeRefresh.UseVisualStyleBackColor = true;
            btnEmployeeRefresh.MouseClick += btnRefreshEmployee_MouseClick;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { employeeCode, empFirstName, empLastName, empGender, empBirthDate, empDateJoined, empAddress });
            dgvEmployee.Location = new Point(20, 22);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowTemplate.Height = 25;
            dgvEmployee.Size = new Size(846, 213);
            dgvEmployee.TabIndex = 17;
            dgvEmployee.CellMouseClick += dgvEmployee_CellMouseClick;
            // 
            // employeeCode
            // 
            employeeCode.HeaderText = "Employee ID";
            employeeCode.Name = "employeeCode";
            employeeCode.ReadOnly = true;
            employeeCode.Width = 120;
            // 
            // empFirstName
            // 
            empFirstName.HeaderText = "Firstname";
            empFirstName.Name = "empFirstName";
            empFirstName.ReadOnly = true;
            empFirstName.Width = 150;
            // 
            // empLastName
            // 
            empLastName.HeaderText = "Lastname";
            empLastName.Name = "empLastName";
            empLastName.ReadOnly = true;
            empLastName.Width = 150;
            // 
            // empGender
            // 
            empGender.HeaderText = "Gender";
            empGender.Name = "empGender";
            empGender.ReadOnly = true;
            // 
            // empBirthDate
            // 
            empBirthDate.HeaderText = "Birth of Date";
            empBirthDate.Name = "empBirthDate";
            empBirthDate.ReadOnly = true;
            empBirthDate.Width = 120;
            // 
            // empDateJoined
            // 
            empDateJoined.HeaderText = "Joined date";
            empDateJoined.Name = "empDateJoined";
            empDateJoined.ReadOnly = true;
            empDateJoined.Width = 120;
            // 
            // empAddress
            // 
            empAddress.HeaderText = "Address";
            empAddress.Name = "empAddress";
            empAddress.ReadOnly = true;
            empAddress.Width = 200;
            // 
            // picEmployee
            // 
            picEmployee.Image = Properties.Resources.images;
            picEmployee.InitialImage = Properties.Resources.images;
            picEmployee.Location = new Point(671, 20);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new Size(225, 225);
            picEmployee.SizeMode = PictureBoxSizeMode.Zoom;
            picEmployee.TabIndex = 22;
            picEmployee.TabStop = false;
            picEmployee.MouseClick += picEmployee_MouseClick;
            // 
            // btnDeleteEmp
            // 
            btnDeleteEmp.ForeColor = Color.Red;
            btnDeleteEmp.Location = new Point(254, 240);
            btnDeleteEmp.Name = "btnDeleteEmp";
            btnDeleteEmp.Size = new Size(93, 26);
            btnDeleteEmp.TabIndex = 19;
            btnDeleteEmp.Text = "Delete";
            btnDeleteEmp.UseVisualStyleBackColor = true;
            btnDeleteEmp.MouseClick += btnDeleteEmployee_MouseClick;
            // 
            // btnSaveEmp
            // 
            btnSaveEmp.Location = new Point(18, 240);
            btnSaveEmp.Name = "btnSaveEmp";
            btnSaveEmp.Size = new Size(93, 26);
            btnSaveEmp.TabIndex = 18;
            btnSaveEmp.Text = "Save";
            btnSaveEmp.UseVisualStyleBackColor = true;
            btnSaveEmp.MouseClick += btnSaveEmployee_MouseClick;
            // 
            // tbEmpAddress
            // 
            tbEmpAddress.Location = new Point(18, 164);
            tbEmpAddress.Multiline = true;
            tbEmpAddress.Name = "tbEmpAddress";
            tbEmpAddress.Size = new Size(591, 55);
            tbEmpAddress.TabIndex = 16;
            // 
            // dtpDateJoined
            // 
            dtpDateJoined.Format = DateTimePickerFormat.Short;
            dtpDateJoined.Location = new Point(451, 38);
            dtpDateJoined.Name = "dtpDateJoined";
            dtpDateJoined.Size = new Size(103, 23);
            dtpDateJoined.TabIndex = 15;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(342, 38);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(103, 23);
            dtpDateOfBirth.TabIndex = 14;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbGender.Location = new Point(405, 96);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 13;
            // 
            // tbEmpLastName
            // 
            tbEmpLastName.Location = new Point(207, 96);
            tbEmpLastName.Name = "tbEmpLastName";
            tbEmpLastName.Size = new Size(183, 23);
            tbEmpLastName.TabIndex = 12;
            // 
            // tbEmpFirstName
            // 
            tbEmpFirstName.Location = new Point(18, 96);
            tbEmpFirstName.Name = "tbEmpFirstName";
            tbEmpFirstName.Size = new Size(183, 23);
            tbEmpFirstName.TabIndex = 11;
            // 
            // tbEmployeeID
            // 
            tbEmployeeID.Location = new Point(174, 38);
            tbEmployeeID.Name = "tbEmployeeID";
            tbEmployeeID.Size = new Size(151, 23);
            tbEmployeeID.TabIndex = 10;
            // 
            // tbEmpDepartmentID
            // 
            tbEmpDepartmentID.Location = new Point(17, 38);
            tbEmpDepartmentID.Name = "tbEmpDepartmentID";
            tbEmpDepartmentID.Size = new Size(151, 23);
            tbEmpDepartmentID.TabIndex = 9;
            // 
            // lbEmpAddress
            // 
            lbEmpAddress.AutoSize = true;
            lbEmpAddress.Location = new Point(18, 146);
            lbEmpAddress.Name = "lbEmpAddress";
            lbEmpAddress.Size = new Size(104, 15);
            lbEmpAddress.TabIndex = 7;
            lbEmpAddress.Text = "Employee Address";
            // 
            // lbDateJoined
            // 
            lbDateJoined.AutoSize = true;
            lbDateJoined.Location = new Point(451, 20);
            lbDateJoined.Name = "lbDateJoined";
            lbDateJoined.Size = new Size(68, 15);
            lbDateJoined.TabIndex = 6;
            lbDateJoined.Text = "Date Joined";
            // 
            // lbDateOfBirth
            // 
            lbDateOfBirth.AutoSize = true;
            lbDateOfBirth.Location = new Point(342, 20);
            lbDateOfBirth.Name = "lbDateOfBirth";
            lbDateOfBirth.Size = new Size(73, 15);
            lbDateOfBirth.TabIndex = 5;
            lbDateOfBirth.Text = "Date of Birth";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(405, 78);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 4;
            lbGender.Text = "Gender";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(207, 78);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(58, 15);
            lbLastName.TabIndex = 3;
            lbLastName.Text = "Lastname";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(18, 78);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(59, 15);
            lbFirstName.TabIndex = 2;
            lbFirstName.Text = "Firstname";
            // 
            // lbDepartmentID
            // 
            lbDepartmentID.AutoSize = true;
            lbDepartmentID.Location = new Point(17, 20);
            lbDepartmentID.Name = "lbDepartmentID";
            lbDepartmentID.Size = new Size(84, 15);
            lbDepartmentID.TabIndex = 1;
            lbDepartmentID.Text = "Department ID";
            // 
            // lbEmployeeID
            // 
            lbEmployeeID.AutoSize = true;
            lbEmployeeID.Location = new Point(174, 20);
            lbEmployeeID.Name = "lbEmployeeID";
            lbEmployeeID.Size = new Size(73, 15);
            lbEmployeeID.TabIndex = 0;
            lbEmployeeID.Text = "Employee ID";
            // 
            // frm_MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 675);
            Controls.Add(tabControl1);
            Name = "frm_MainMenu";
            Text = "Main Menu";
            tabControl1.ResumeLayout(false);
            tabDepartment.ResumeLayout(false);
            tabDepartment.PerformLayout();
            gbDepartmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDepartmentList).EndInit();
            tabEmployee.ResumeLayout(false);
            tabEmployee.PerformLayout();
            gbEmployeeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabDepartment;
        private TabPage tabEmployee;
        private DateTimePicker dtpDateJoined;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbGender;
        private TextBox tbEmpLastName;
        private TextBox tbEmpFirstName;
        private TextBox tbEmployeeID;
        private TextBox tbEmpDepartmentID;
        private Label lbEmpAddress;
        private Label lbDateJoined;
        private Label lbDateOfBirth;
        private Label lbGender;
        private Label lbLastName;
        private Label lbFirstName;
        private Label lbDepartmentID;
        private Label lbEmployeeID;
        private DataGridView dgvEmployee;
        private TextBox tbEmpAddress;
        private Button btnDeleteDepartment;
        private Button btnSaveDepartment;
        private TextBox tbDepartmentName;
        private Label label1;
        private TextBox tbDepartmentID;
        private Label label2;
        private GroupBox gbDepartmentList;
        private DataGridView dgvDepartmentList;
        private GroupBox gbEmployeeList;
        private PictureBox picEmployee;
        private Button btnDeleteEmp;
        private Button btnSaveEmp;
        private Label label3;
        private TextBox tbDepartmentAddress;
        private DataGridViewTextBoxColumn departmentCode;
        private DataGridViewTextBoxColumn departmentName;
        private DataGridViewTextBoxColumn departmentAddress;
        private Button btnDepartmentRefresh;
        private Button btnClearDepartment;
        private Button btnClearEmp;
        private Button btnEmployeeRefresh;
        private DataGridViewTextBoxColumn employeeCode;
        private DataGridViewTextBoxColumn empFirstName;
        private DataGridViewTextBoxColumn empLastName;
        private DataGridViewTextBoxColumn empGender;
        private DataGridViewTextBoxColumn empBirthDate;
        private DataGridViewTextBoxColumn empDateJoined;
        private DataGridViewTextBoxColumn empAddress;
    }
}