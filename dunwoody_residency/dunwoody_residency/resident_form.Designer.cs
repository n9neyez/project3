namespace dunwoody_residency
{
    partial class form_resident
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_control_main = new System.Windows.Forms.TabControl();
            this.tab_residents = new System.Windows.Forms.TabPage();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label_search = new System.Windows.Forms.Label();
            this.data_residents = new System.Windows.Forms.DataGridView();
            this.tab_editResident = new System.Windows.Forms.TabPage();
            this.btn_accept = new System.Windows.Forms.Button();
            this.textBox_dormRoom = new System.Windows.Forms.TextBox();
            this.textBox_dormFloor = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.label_dormRoom = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.label_dormFloor = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.radio_scholarship = new System.Windows.Forms.RadioButton();
            this.radio_athlete = new System.Windows.Forms.RadioButton();
            this.radio_studenWorker = new System.Windows.Forms.RadioButton();
            this.label_id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._ = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_control_main.SuspendLayout();
            this.tab_residents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_residents)).BeginInit();
            this.tab_editResident.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control_main
            // 
            this.tab_control_main.Controls.Add(this.tab_residents);
            this.tab_control_main.Controls.Add(this.tab_editResident);
            this.tab_control_main.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_control_main.Location = new System.Drawing.Point(136, 79);
            this.tab_control_main.Name = "tab_control_main";
            this.tab_control_main.Padding = new System.Drawing.Point(40, 5);
            this.tab_control_main.SelectedIndex = 0;
            this.tab_control_main.Size = new System.Drawing.Size(1141, 545);
            this.tab_control_main.TabIndex = 1;
            // 
            // tab_residents
            // 
            this.tab_residents.BackColor = System.Drawing.Color.Silver;
            this.tab_residents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_residents.Controls.Add(this.btn_add);
            this.tab_residents.Controls.Add(this.btn_edit);
            this.tab_residents.Controls.Add(this.btn_search);
            this.tab_residents.Controls.Add(this.textBox_search);
            this.tab_residents.Controls.Add(this.label_search);
            this.tab_residents.Controls.Add(this.data_residents);
            this.tab_residents.Location = new System.Drawing.Point(4, 81);
            this.tab_residents.Name = "tab_residents";
            this.tab_residents.Padding = new System.Windows.Forms.Padding(3);
            this.tab_residents.Size = new System.Drawing.Size(1133, 460);
            this.tab_residents.TabIndex = 1;
            this.tab_residents.Text = "Residents";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_add.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(826, 358);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(262, 58);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_edit.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(826, 272);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(262, 58);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_search.FlatAppearance.BorderSize = 3;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(855, 124);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(194, 64);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(793, 53);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(332, 55);
            this.textBox_search.TabIndex = 2;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Adobe Gothic Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_search.Location = new System.Drawing.Point(849, 15);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(200, 35);
            this.label_search.TabIndex = 1;
            this.label_search.Text = "Search (By ID):";
            // 
            // data_residents
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_residents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_residents.AutoGenerateColumns = false;
            this.data_residents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.data_residents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_residents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.residentTypeDataGridViewTextBoxColumn,
            this.monthlyFeeDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.dormDataGridViewTextBoxColumn});
            this.data_residents.DataSource = this.residentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_residents.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_residents.Location = new System.Drawing.Point(6, 6);
            this.data_residents.Name = "data_residents";
            this.data_residents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.data_residents.RowTemplate.Height = 24;
            this.data_residents.Size = new System.Drawing.Size(781, 446);
            this.data_residents.TabIndex = 0;
            // 
            // tab_editResident
            // 
            this.tab_editResident.BackColor = System.Drawing.Color.Silver;
            this.tab_editResident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_editResident.Controls.Add(this.btn_accept);
            this.tab_editResident.Controls.Add(this.textBox_dormRoom);
            this.tab_editResident.Controls.Add(this.textBox_dormFloor);
            this.tab_editResident.Controls.Add(this.textBox_id);
            this.tab_editResident.Controls.Add(this.textBox_lastname);
            this.tab_editResident.Controls.Add(this.label_dormRoom);
            this.tab_editResident.Controls.Add(this.textBox_firstname);
            this.tab_editResident.Controls.Add(this.label_dormFloor);
            this.tab_editResident.Controls.Add(this.label_lastName);
            this.tab_editResident.Controls.Add(this.label_firstName);
            this.tab_editResident.Controls.Add(this.radio_scholarship);
            this.tab_editResident.Controls.Add(this.radio_athlete);
            this.tab_editResident.Controls.Add(this.radio_studenWorker);
            this.tab_editResident.Controls.Add(this.label_id);
            this.tab_editResident.Location = new System.Drawing.Point(4, 81);
            this.tab_editResident.Name = "tab_editResident";
            this.tab_editResident.Size = new System.Drawing.Size(1133, 460);
            this.tab_editResident.TabIndex = 2;
            this.tab_editResident.Text = "Edit Resident";
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_accept.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.Location = new System.Drawing.Point(845, 368);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(182, 73);
            this.btn_accept.TabIndex = 13;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = false;
            // 
            // textBox_dormRoom
            // 
            this.textBox_dormRoom.Enabled = false;
            this.textBox_dormRoom.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dormRoom.Location = new System.Drawing.Point(329, 379);
            this.textBox_dormRoom.Name = "textBox_dormRoom";
            this.textBox_dormRoom.ReadOnly = true;
            this.textBox_dormRoom.Size = new System.Drawing.Size(100, 47);
            this.textBox_dormRoom.TabIndex = 12;
            // 
            // textBox_dormFloor
            // 
            this.textBox_dormFloor.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dormFloor.Location = new System.Drawing.Point(329, 316);
            this.textBox_dormFloor.Name = "textBox_dormFloor";
            this.textBox_dormFloor.ReadOnly = true;
            this.textBox_dormFloor.Size = new System.Drawing.Size(100, 47);
            this.textBox_dormFloor.TabIndex = 11;
            // 
            // textBox_id
            // 
            this.textBox_id.Enabled = false;
            this.textBox_id.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(329, 251);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(100, 47);
            this.textBox_id.TabIndex = 10;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastname.Location = new System.Drawing.Point(329, 182);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(405, 47);
            this.textBox_lastname.TabIndex = 9;
            // 
            // label_dormRoom
            // 
            this.label_dormRoom.AutoSize = true;
            this.label_dormRoom.Font = new System.Drawing.Font("Adobe Gothic Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dormRoom.Location = new System.Drawing.Point(97, 391);
            this.label_dormRoom.Name = "label_dormRoom";
            this.label_dormRoom.Size = new System.Drawing.Size(200, 35);
            this.label_dormRoom.TabIndex = 8;
            this.label_dormRoom.Text = "Dorm Room #:";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstname.Location = new System.Drawing.Point(329, 114);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(405, 47);
            this.textBox_firstname.TabIndex = 7;
            // 
            // label_dormFloor
            // 
            this.label_dormFloor.AutoSize = true;
            this.label_dormFloor.Font = new System.Drawing.Font("Adobe Gothic Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dormFloor.Location = new System.Drawing.Point(127, 328);
            this.label_dormFloor.Name = "label_dormFloor";
            this.label_dormFloor.Size = new System.Drawing.Size(170, 35);
            this.label_dormFloor.TabIndex = 6;
            this.label_dormFloor.Text = "Dorm Floor:";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Font = new System.Drawing.Font("Adobe Gothic Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastName.Location = new System.Drawing.Point(140, 194);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(157, 35);
            this.label_lastName.TabIndex = 5;
            this.label_lastName.Text = "Last Name:";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Font = new System.Drawing.Font("Adobe Gothic Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstName.Location = new System.Drawing.Point(140, 124);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(161, 35);
            this.label_firstName.TabIndex = 4;
            this.label_firstName.Text = "First Name:";
            // 
            // radio_scholarship
            // 
            this.radio_scholarship.AutoSize = true;
            this.radio_scholarship.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_scholarship.Location = new System.Drawing.Point(725, 38);
            this.radio_scholarship.Name = "radio_scholarship";
            this.radio_scholarship.Size = new System.Drawing.Size(232, 29);
            this.radio_scholarship.TabIndex = 3;
            this.radio_scholarship.TabStop = true;
            this.radio_scholarship.Text = "Scholarship Recipient";
            this.radio_scholarship.UseVisualStyleBackColor = true;
            // 
            // radio_athlete
            // 
            this.radio_athlete.AutoSize = true;
            this.radio_athlete.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_athlete.Location = new System.Drawing.Point(446, 38);
            this.radio_athlete.Name = "radio_athlete";
            this.radio_athlete.Size = new System.Drawing.Size(102, 29);
            this.radio_athlete.TabIndex = 2;
            this.radio_athlete.TabStop = true;
            this.radio_athlete.Text = "Athlete";
            this.radio_athlete.UseVisualStyleBackColor = true;
            // 
            // radio_studenWorker
            // 
            this.radio_studenWorker.AutoSize = true;
            this.radio_studenWorker.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_studenWorker.Location = new System.Drawing.Point(86, 38);
            this.radio_studenWorker.Name = "radio_studenWorker";
            this.radio_studenWorker.Size = new System.Drawing.Size(179, 29);
            this.radio_studenWorker.TabIndex = 1;
            this.radio_studenWorker.TabStop = true;
            this.radio_studenWorker.Text = "Student Worker";
            this.radio_studenWorker.UseVisualStyleBackColor = true;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Adobe Gothic Std B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(224, 263);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(73, 35);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID #:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BackgroundImage = global::dunwoody_residency.Properties.Resources.super_stylish_dorm_room_ideas;
            this.panel2.Location = new System.Drawing.Point(1347, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 785);
            this.panel2.TabIndex = 12;
            // 
            // _
            // 
            this._.BackgroundImage = global::dunwoody_residency.Properties.Resources.EyoTO3NQ_400x400;
            this._.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._.Location = new System.Drawing.Point(743, 5);
            this._.Name = "_";
            this._.Size = new System.Drawing.Size(171, 149);
            this._.TabIndex = 3;
            this._.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImage = global::dunwoody_residency.Properties.Resources.super_stylish_dorm_room_ideas;
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 785);
            this.panel1.TabIndex = 13;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Orange;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Font = new System.Drawing.Font("Adobe Gothic Std B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_logout.Location = new System.Drawing.Point(591, 669);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(226, 73);
            this.btn_logout.TabIndex = 14;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.FillWeight = 210.0175F;
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 243;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.FillWeight = 159.1257F;
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 234;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 51.04791F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 109;
            // 
            // residentTypeDataGridViewTextBoxColumn
            // 
            this.residentTypeDataGridViewTextBoxColumn.DataPropertyName = "ResidentType";
            this.residentTypeDataGridViewTextBoxColumn.FillWeight = 137.4516F;
            this.residentTypeDataGridViewTextBoxColumn.HeaderText = "ResidentType";
            this.residentTypeDataGridViewTextBoxColumn.Name = "residentTypeDataGridViewTextBoxColumn";
            this.residentTypeDataGridViewTextBoxColumn.Width = 295;
            // 
            // monthlyFeeDataGridViewTextBoxColumn
            // 
            this.monthlyFeeDataGridViewTextBoxColumn.DataPropertyName = "MonthlyFee";
            this.monthlyFeeDataGridViewTextBoxColumn.FillWeight = 81.65472F;
            this.monthlyFeeDataGridViewTextBoxColumn.HeaderText = "MonthlyFee";
            this.monthlyFeeDataGridViewTextBoxColumn.Name = "monthlyFeeDataGridViewTextBoxColumn";
            this.monthlyFeeDataGridViewTextBoxColumn.Width = 267;
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.FillWeight = 31.69708F;
            this.floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            this.floorDataGridViewTextBoxColumn.Width = 154;
            // 
            // dormDataGridViewTextBoxColumn
            // 
            this.dormDataGridViewTextBoxColumn.DataPropertyName = "Dorm";
            this.dormDataGridViewTextBoxColumn.FillWeight = 29.00553F;
            this.dormDataGridViewTextBoxColumn.HeaderText = "Dorm";
            this.dormDataGridViewTextBoxColumn.Name = "dormDataGridViewTextBoxColumn";
            this.dormDataGridViewTextBoxColumn.Width = 162;
            // 
            // residentBindingSource
            // 
            this.residentBindingSource.DataSource = typeof(dunwoody_residency.Resident);
            // 
            // form_resident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1418, 781);
            this.ControlBox = false;
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tab_control_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_resident";
            this.Text = "Residents";
            this.Load += new System.EventHandler(this.form_resident_Load);
            this.tab_control_main.ResumeLayout(false);
            this.tab_residents.ResumeLayout(false);
            this.tab_residents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_residents)).EndInit();
            this.tab_editResident.ResumeLayout(false);
            this.tab_editResident.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.residentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tab_control_main;
        private System.Windows.Forms.TabPage tab_residents;
        private System.Windows.Forms.TabPage tab_editResident;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.DataGridView data_residents;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox _;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TextBox textBox_dormRoom;
        private System.Windows.Forms.TextBox textBox_dormFloor;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.Label label_dormRoom;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.Label label_dormFloor;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.RadioButton radio_scholarship;
        private System.Windows.Forms.RadioButton radio_athlete;
        private System.Windows.Forms.RadioButton radio_studenWorker;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlyFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource residentBindingSource;
    }
}