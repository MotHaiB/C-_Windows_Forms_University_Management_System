namespace WindowsFormsApp
{
    partial class Form1
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
            this.database1DataSet = new WindowsFormsApp.Database1DataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new WindowsFormsApp.Database1DataSetTableAdapters.PeopleTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp.Database1DataSetTableAdapters.TableAdapterManager();
            this.peopleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isPartTime = new System.Windows.Forms.CheckBox();
            this.isFullTime = new System.Windows.Forms.CheckBox();
            this.i = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.ax = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.adminSalary = new System.Windows.Forms.TextBox();
            this.workingHours = new System.Windows.Forms.TextBox();
            this.adminEmail = new System.Windows.Forms.TextBox();
            this.adminTelephone = new System.Windows.Forms.TextBox();
            this.adminName = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Admin_Done = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.teacherSubject1 = new System.Windows.Forms.TextBox();
            this.teacherSalary = new System.Windows.Forms.TextBox();
            this.teacherSubject2 = new System.Windows.Forms.TextBox();
            this.teacherEmail = new System.Windows.Forms.TextBox();
            this.teacherTelephone = new System.Windows.Forms.TextBox();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.tCancel = new System.Windows.Forms.Button();
            this.tDone = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.studentSubject2 = new System.Windows.Forms.TextBox();
            this.studentSubject1 = new System.Windows.Forms.TextBox();
            this.studentSubject3 = new System.Windows.Forms.TextBox();
            this.studentEmail = new System.Windows.Forms.TextBox();
            this.studentTelephone = new System.Windows.Forms.TextBox();
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentCancel = new System.Windows.Forms.Button();
            this.studentDone = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.telephone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adads = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.subject2 = new System.Windows.Forms.TextBox();
            this.subject1 = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.workHours = new System.Windows.Forms.TextBox();
            this.subject3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save_and_exit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.database1DataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeopleTableAdapter = this.peopleTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // peopleBindingSource1
            // 
            this.peopleBindingSource1.DataMember = "People";
            this.peopleBindingSource1.DataSource = this.database1DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 191);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(981, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Admin",
            "Teacher",
            "Student"});
            this.comboBox1.Location = new System.Drawing.Point(37, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Role";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isPartTime);
            this.groupBox1.Controls.Add(this.isFullTime);
            this.groupBox1.Controls.Add(this.i);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.e);
            this.groupBox1.Controls.Add(this.ax);
            this.groupBox1.Controls.Add(this.a);
            this.groupBox1.Controls.Add(this.adminSalary);
            this.groupBox1.Controls.Add(this.workingHours);
            this.groupBox1.Controls.Add(this.adminEmail);
            this.groupBox1.Controls.Add(this.adminTelephone);
            this.groupBox1.Controls.Add(this.adminName);
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.Admin_Done);
            this.groupBox1.Location = new System.Drawing.Point(730, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 302);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // isPartTime
            // 
            this.isPartTime.AutoSize = true;
            this.isPartTime.Location = new System.Drawing.Point(214, 187);
            this.isPartTime.Name = "isPartTime";
            this.isPartTime.Size = new System.Drawing.Size(87, 20);
            this.isPartTime.TabIndex = 15;
            this.isPartTime.Text = "Part Time";
            this.isPartTime.UseVisualStyleBackColor = true;
            // 
            // isFullTime
            // 
            this.isFullTime.AutoSize = true;
            this.isFullTime.Location = new System.Drawing.Point(117, 187);
            this.isFullTime.Name = "isFullTime";
            this.isFullTime.Size = new System.Drawing.Size(84, 20);
            this.isFullTime.TabIndex = 14;
            this.isFullTime.Text = "Full Time";
            this.isFullTime.UseVisualStyleBackColor = true;
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Location = new System.Drawing.Point(18, 225);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(99, 16);
            this.i.TabIndex = 13;
            this.i.Text = "Working Hours:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Full/Part Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Salary:";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(18, 108);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(44, 16);
            this.e.TabIndex = 10;
            this.e.Text = "Email:";
            // 
            // ax
            // 
            this.ax.AutoSize = true;
            this.ax.Location = new System.Drawing.Point(18, 70);
            this.ax.Name = "ax";
            this.ax.Size = new System.Drawing.Size(76, 16);
            this.ax.TabIndex = 9;
            this.ax.Text = "Telephone:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(18, 33);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(71, 16);
            this.a.TabIndex = 8;
            this.a.Text = "Full Name:";
            // 
            // adminSalary
            // 
            this.adminSalary.Location = new System.Drawing.Point(115, 148);
            this.adminSalary.Name = "adminSalary";
            this.adminSalary.Size = new System.Drawing.Size(194, 22);
            this.adminSalary.TabIndex = 6;
            // 
            // workingHours
            // 
            this.workingHours.Location = new System.Drawing.Point(123, 225);
            this.workingHours.Name = "workingHours";
            this.workingHours.Size = new System.Drawing.Size(186, 22);
            this.workingHours.TabIndex = 5;
            // 
            // adminEmail
            // 
            this.adminEmail.Location = new System.Drawing.Point(115, 108);
            this.adminEmail.Name = "adminEmail";
            this.adminEmail.Size = new System.Drawing.Size(194, 22);
            this.adminEmail.TabIndex = 4;
            // 
            // adminTelephone
            // 
            this.adminTelephone.Location = new System.Drawing.Point(115, 70);
            this.adminTelephone.Name = "adminTelephone";
            this.adminTelephone.Size = new System.Drawing.Size(194, 22);
            this.adminTelephone.TabIndex = 3;
            // 
            // adminName
            // 
            this.adminName.Location = new System.Drawing.Point(115, 33);
            this.adminName.Name = "adminName";
            this.adminName.Size = new System.Drawing.Size(194, 22);
            this.adminName.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(250, 258);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Admin_Done
            // 
            this.Admin_Done.Location = new System.Drawing.Point(31, 258);
            this.Admin_Done.Name = "Admin_Done";
            this.Admin_Done.Size = new System.Drawing.Size(75, 23);
            this.Admin_Done.TabIndex = 0;
            this.Admin_Done.Text = "Done";
            this.Admin_Done.UseVisualStyleBackColor = true;
            this.Admin_Done.Click += new System.EventHandler(this.Admin_Done_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.teacherSubject1);
            this.groupBox2.Controls.Add(this.teacherSalary);
            this.groupBox2.Controls.Add(this.teacherSubject2);
            this.groupBox2.Controls.Add(this.teacherEmail);
            this.groupBox2.Controls.Add(this.teacherTelephone);
            this.groupBox2.Controls.Add(this.teacherName);
            this.groupBox2.Controls.Add(this.tCancel);
            this.groupBox2.Controls.Add(this.tDone);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 302);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Subject 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Subject 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salary:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telephone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Full Name:";
            // 
            // teacherSubject1
            // 
            this.teacherSubject1.Location = new System.Drawing.Point(115, 187);
            this.teacherSubject1.Name = "teacherSubject1";
            this.teacherSubject1.Size = new System.Drawing.Size(194, 22);
            this.teacherSubject1.TabIndex = 7;
            // 
            // teacherSalary
            // 
            this.teacherSalary.Location = new System.Drawing.Point(115, 148);
            this.teacherSalary.Name = "teacherSalary";
            this.teacherSalary.Size = new System.Drawing.Size(194, 22);
            this.teacherSalary.TabIndex = 6;
            // 
            // teacherSubject2
            // 
            this.teacherSubject2.Location = new System.Drawing.Point(115, 225);
            this.teacherSubject2.Name = "teacherSubject2";
            this.teacherSubject2.Size = new System.Drawing.Size(194, 22);
            this.teacherSubject2.TabIndex = 5;
            // 
            // teacherEmail
            // 
            this.teacherEmail.Location = new System.Drawing.Point(115, 108);
            this.teacherEmail.Name = "teacherEmail";
            this.teacherEmail.Size = new System.Drawing.Size(194, 22);
            this.teacherEmail.TabIndex = 4;
            // 
            // teacherTelephone
            // 
            this.teacherTelephone.Location = new System.Drawing.Point(115, 70);
            this.teacherTelephone.Name = "teacherTelephone";
            this.teacherTelephone.Size = new System.Drawing.Size(194, 22);
            this.teacherTelephone.TabIndex = 3;
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(115, 33);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(194, 22);
            this.teacherName.TabIndex = 2;
            // 
            // tCancel
            // 
            this.tCancel.Location = new System.Drawing.Point(250, 258);
            this.tCancel.Name = "tCancel";
            this.tCancel.Size = new System.Drawing.Size(75, 23);
            this.tCancel.TabIndex = 1;
            this.tCancel.Text = "Cancel";
            this.tCancel.UseVisualStyleBackColor = true;
            this.tCancel.Click += new System.EventHandler(this.tCancel_Click);
            // 
            // tDone
            // 
            this.tDone.Location = new System.Drawing.Point(31, 258);
            this.tDone.Name = "tDone";
            this.tDone.Size = new System.Drawing.Size(75, 23);
            this.tDone.TabIndex = 0;
            this.tDone.Text = "Done";
            this.tDone.UseVisualStyleBackColor = true;
            this.tDone.Click += new System.EventHandler(this.tDone_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.studentSubject2);
            this.groupBox3.Controls.Add(this.studentSubject1);
            this.groupBox3.Controls.Add(this.studentSubject3);
            this.groupBox3.Controls.Add(this.studentEmail);
            this.groupBox3.Controls.Add(this.studentTelephone);
            this.groupBox3.Controls.Add(this.studentName);
            this.groupBox3.Controls.Add(this.studentCancel);
            this.groupBox3.Controls.Add(this.studentDone);
            this.groupBox3.Location = new System.Drawing.Point(373, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 302);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Subject 3:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Subject 2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Subject 1:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "Telephone:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 16);
            this.label16.TabIndex = 8;
            this.label16.Text = "Full Name:";
            // 
            // studentSubject2
            // 
            this.studentSubject2.Location = new System.Drawing.Point(115, 187);
            this.studentSubject2.Name = "studentSubject2";
            this.studentSubject2.Size = new System.Drawing.Size(194, 22);
            this.studentSubject2.TabIndex = 7;
            // 
            // studentSubject1
            // 
            this.studentSubject1.Location = new System.Drawing.Point(115, 148);
            this.studentSubject1.Name = "studentSubject1";
            this.studentSubject1.Size = new System.Drawing.Size(194, 22);
            this.studentSubject1.TabIndex = 6;
            // 
            // studentSubject3
            // 
            this.studentSubject3.Location = new System.Drawing.Point(115, 225);
            this.studentSubject3.Name = "studentSubject3";
            this.studentSubject3.Size = new System.Drawing.Size(194, 22);
            this.studentSubject3.TabIndex = 5;
            // 
            // studentEmail
            // 
            this.studentEmail.Location = new System.Drawing.Point(115, 108);
            this.studentEmail.Name = "studentEmail";
            this.studentEmail.Size = new System.Drawing.Size(194, 22);
            this.studentEmail.TabIndex = 4;
            // 
            // studentTelephone
            // 
            this.studentTelephone.Location = new System.Drawing.Point(115, 70);
            this.studentTelephone.Name = "studentTelephone";
            this.studentTelephone.Size = new System.Drawing.Size(194, 22);
            this.studentTelephone.TabIndex = 3;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(115, 33);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(194, 22);
            this.studentName.TabIndex = 2;
            // 
            // studentCancel
            // 
            this.studentCancel.Location = new System.Drawing.Point(250, 258);
            this.studentCancel.Name = "studentCancel";
            this.studentCancel.Size = new System.Drawing.Size(75, 23);
            this.studentCancel.TabIndex = 1;
            this.studentCancel.Text = "Cancel";
            this.studentCancel.UseVisualStyleBackColor = true;
            this.studentCancel.Click += new System.EventHandler(this.studentCancel_Click);
            // 
            // studentDone
            // 
            this.studentDone.Location = new System.Drawing.Point(31, 258);
            this.studentDone.Name = "studentDone";
            this.studentDone.Size = new System.Drawing.Size(75, 23);
            this.studentDone.TabIndex = 0;
            this.studentDone.Text = "Done";
            this.studentDone.UseVisualStyleBackColor = true;
            this.studentDone.Click += new System.EventHandler(this.studentDone_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(10, 82);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 15;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(111, 32);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(140, 22);
            this.name.TabIndex = 16;
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(111, 86);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(140, 22);
            this.telephone.TabIndex = 17;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(111, 140);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(140, 22);
            this.email.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Name:";
            // 
            // adads
            // 
            this.adads.AutoSize = true;
            this.adads.Location = new System.Drawing.Point(111, 67);
            this.adads.Name = "adads";
            this.adads.Size = new System.Drawing.Size(76, 16);
            this.adads.TabIndex = 26;
            this.adads.Text = "Telephone:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(111, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 16);
            this.label18.TabIndex = 27;
            this.label18.Text = "Email:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(303, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 16);
            this.label19.TabIndex = 33;
            this.label19.Text = "Subject 2:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(303, 67);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 16);
            this.label20.TabIndex = 32;
            this.label20.Text = "Subject 1:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(303, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 16);
            this.label21.TabIndex = 31;
            this.label21.Text = "Salary:";
            // 
            // subject2
            // 
            this.subject2.Location = new System.Drawing.Point(303, 140);
            this.subject2.Name = "subject2";
            this.subject2.Size = new System.Drawing.Size(140, 22);
            this.subject2.TabIndex = 30;
            // 
            // subject1
            // 
            this.subject1.Location = new System.Drawing.Point(303, 86);
            this.subject1.Name = "subject1";
            this.subject1.Size = new System.Drawing.Size(140, 22);
            this.subject1.TabIndex = 29;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(303, 32);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(140, 22);
            this.salary.TabIndex = 28;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(492, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 16);
            this.label22.TabIndex = 39;
            this.label22.Text = "Is Full Time?";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(492, 69);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 16);
            this.label23.TabIndex = 38;
            this.label23.Text = "Working Hours:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(492, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 16);
            this.label24.TabIndex = 37;
            this.label24.Text = "Subject 3:";
            // 
            // workHours
            // 
            this.workHours.Location = new System.Drawing.Point(492, 88);
            this.workHours.Name = "workHours";
            this.workHours.Size = new System.Drawing.Size(140, 22);
            this.workHours.TabIndex = 35;
            // 
            // subject3
            // 
            this.subject3.Location = new System.Drawing.Point(492, 34);
            this.subject3.Name = "subject3";
            this.subject3.Size = new System.Drawing.Size(140, 22);
            this.subject3.TabIndex = 34;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Full Time",
            "Not Full Time"});
            this.comboBox2.Location = new System.Drawing.Point(492, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 24);
            this.comboBox2.TabIndex = 40;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(10, 112);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 41;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // _cancel
            // 
            this._cancel.Location = new System.Drawing.Point(10, 141);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(75, 23);
            this._cancel.TabIndex = 42;
            this._cancel.Text = "Clear";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(245, 116);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 27);
            this.delete.TabIndex = 43;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save_and_exit
            // 
            this.save_and_exit.BackColor = System.Drawing.Color.Brown;
            this.save_and_exit.ForeColor = System.Drawing.Color.White;
            this.save_and_exit.Location = new System.Drawing.Point(903, 557);
            this.save_and_exit.Name = "save_and_exit";
            this.save_and_exit.Size = new System.Drawing.Size(115, 31);
            this.save_and_exit.TabIndex = 44;
            this.save_and_exit.Text = "Save and Exit";
            this.save_and_exit.UseVisualStyleBackColor = false;
            this.save_and_exit.Click += new System.EventHandler(this.save_and_exit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.subject2);
            this.groupBox4.Controls.Add(this.edit);
            this.groupBox4.Controls.Add(this.name);
            this.groupBox4.Controls.Add(this._cancel);
            this.groupBox4.Controls.Add(this.telephone);
            this.groupBox4.Controls.Add(this.save);
            this.groupBox4.Controls.Add(this.email);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.adads);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.salary);
            this.groupBox4.Controls.Add(this.workHours);
            this.groupBox4.Controls.Add(this.subject1);
            this.groupBox4.Controls.Add(this.subject3);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(400, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(641, 173);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 593);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.save_and_exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private Database1DataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource peopleBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Admin_Done;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox adminEmail;
        private System.Windows.Forms.TextBox adminTelephone;
        private System.Windows.Forms.TextBox adminName;
        private System.Windows.Forms.TextBox adminSalary;
        private System.Windows.Forms.TextBox workingHours;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label ax;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox teacherSubject1;
        private System.Windows.Forms.TextBox teacherSalary;
        private System.Windows.Forms.TextBox teacherSubject2;
        private System.Windows.Forms.TextBox teacherEmail;
        private System.Windows.Forms.TextBox teacherTelephone;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.Button tCancel;
        private System.Windows.Forms.Button tDone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox studentSubject2;
        private System.Windows.Forms.TextBox studentSubject1;
        private System.Windows.Forms.TextBox studentSubject3;
        private System.Windows.Forms.TextBox studentEmail;
        private System.Windows.Forms.TextBox studentTelephone;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Button studentCancel;
        private System.Windows.Forms.Button studentDone;
        private System.Windows.Forms.CheckBox isPartTime;
        private System.Windows.Forms.CheckBox isFullTime;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label adads;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox subject2;
        private System.Windows.Forms.TextBox subject1;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox workHours;
        private System.Windows.Forms.TextBox subject3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button _cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save_and_exit;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

