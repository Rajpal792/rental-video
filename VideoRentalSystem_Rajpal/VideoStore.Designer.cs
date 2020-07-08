namespace VideoRentalSystem_Rajpal
{
    partial class VideoStore
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridViewCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridViewMovies = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridViewRental = new System.Windows.Forms.DataGridView();
            this.customerDelete = new System.Windows.Forms.Button();
            this.customerUpdate = new System.Windows.Forms.Button();
            this.customerAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.videoDelete = new System.Windows.Forms.Button();
            this.videoUpdate = new System.Windows.Forms.Button();
            this.videoAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVideo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textReleased = new System.Windows.Forms.TextBox();
            this.textCopies = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textPoints = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.movieReturn = new System.Windows.Forms.Button();
            this.movieIssue = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRentalArea = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.videosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalSystem_RajpalDataSet1 = new VideoRentalSystem_Rajpal.VideoRentalSystem_RajpalDataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoRentalSystem_RajpalDataSet = new VideoRentalSystem_Rajpal.VideoRentalSystem_RajpalDataSet();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.customersTableAdapter = new VideoRentalSystem_Rajpal.VideoRentalSystem_RajpalDataSetTableAdapters.CustomersTableAdapter();
            this.videosTableAdapter = new VideoRentalSystem_Rajpal.VideoRentalSystem_RajpalDataSet1TableAdapters.VideosTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovies)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRental)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalSystem_RajpalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalSystem_RajpalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 233);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridViewCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridViewCustomers
            // 
            this.gridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.gridViewCustomers.Name = "gridViewCustomers";
            this.gridViewCustomers.Size = new System.Drawing.Size(770, 207);
            this.gridViewCustomers.TabIndex = 0;
            this.gridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCustomers_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridViewMovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridViewMovies
            // 
            this.gridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewMovies.Location = new System.Drawing.Point(0, 0);
            this.gridViewMovies.Name = "gridViewMovies";
            this.gridViewMovies.Size = new System.Drawing.Size(770, 207);
            this.gridViewMovies.TabIndex = 0;
            this.gridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewMovies_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridViewRental);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(770, 207);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridViewRental
            // 
            this.gridViewRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRental.Location = new System.Drawing.Point(0, 0);
            this.gridViewRental.Name = "gridViewRental";
            this.gridViewRental.Size = new System.Drawing.Size(770, 207);
            this.gridViewRental.TabIndex = 0;
            this.gridViewRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewRental_CellContentClick);
            // 
            // customerDelete
            // 
            this.customerDelete.BackColor = System.Drawing.Color.Linen;
            this.customerDelete.Location = new System.Drawing.Point(285, 413);
            this.customerDelete.Name = "customerDelete";
            this.customerDelete.Size = new System.Drawing.Size(98, 29);
            this.customerDelete.TabIndex = 25;
            this.customerDelete.Text = "Delete";
            this.customerDelete.UseVisualStyleBackColor = false;
            this.customerDelete.Click += new System.EventHandler(this.customerDelete_Click);
            // 
            // customerUpdate
            // 
            this.customerUpdate.BackColor = System.Drawing.Color.Peru;
            this.customerUpdate.Location = new System.Drawing.Point(172, 413);
            this.customerUpdate.Name = "customerUpdate";
            this.customerUpdate.Size = new System.Drawing.Size(98, 29);
            this.customerUpdate.TabIndex = 24;
            this.customerUpdate.Text = "Update";
            this.customerUpdate.UseVisualStyleBackColor = false;
            this.customerUpdate.Click += new System.EventHandler(this.customerUpdate_Click);
            // 
            // customerAdd
            // 
            this.customerAdd.BackColor = System.Drawing.Color.PeachPuff;
            this.customerAdd.Location = new System.Drawing.Point(49, 413);
            this.customerAdd.Name = "customerAdd";
            this.customerAdd.Size = new System.Drawing.Size(98, 29);
            this.customerAdd.TabIndex = 23;
            this.customerAdd.Text = "Add ";
            this.customerAdd.UseVisualStyleBackColor = false;
            this.customerAdd.Click += new System.EventHandler(this.customerAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Maroon;
            this.groupBox2.Controls.Add(this.lblCustomer);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.txtMobile);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(32, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 142);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Customer";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(16, 46);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(0, 13);
            this.lblCustomer.TabIndex = 13;
            this.lblCustomer.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(161, 102);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(170, 26);
            this.txtAddress.TabIndex = 11;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(161, 54);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(170, 26);
            this.txtMobile.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(161, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 26);
            this.txtName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Mobile";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name";
            // 
            // videoDelete
            // 
            this.videoDelete.BackColor = System.Drawing.Color.BurlyWood;
            this.videoDelete.Location = new System.Drawing.Point(994, 348);
            this.videoDelete.Name = "videoDelete";
            this.videoDelete.Size = new System.Drawing.Size(85, 29);
            this.videoDelete.TabIndex = 29;
            this.videoDelete.Text = "Delete";
            this.videoDelete.UseVisualStyleBackColor = false;
            this.videoDelete.Click += new System.EventHandler(this.videoDelete_Click);
            // 
            // videoUpdate
            // 
            this.videoUpdate.BackColor = System.Drawing.Color.Moccasin;
            this.videoUpdate.Location = new System.Drawing.Point(901, 348);
            this.videoUpdate.Name = "videoUpdate";
            this.videoUpdate.Size = new System.Drawing.Size(78, 29);
            this.videoUpdate.TabIndex = 28;
            this.videoUpdate.Text = "Update";
            this.videoUpdate.UseVisualStyleBackColor = false;
            this.videoUpdate.Click += new System.EventHandler(this.videoUpdate_Click);
            // 
            // videoAdd
            // 
            this.videoAdd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.videoAdd.Location = new System.Drawing.Point(805, 348);
            this.videoAdd.Name = "videoAdd";
            this.videoAdd.Size = new System.Drawing.Size(79, 29);
            this.videoAdd.TabIndex = 26;
            this.videoAdd.Text = "Add ";
            this.videoAdd.UseVisualStyleBackColor = false;
            this.videoAdd.Click += new System.EventHandler(this.videoAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Red;
            this.groupBox1.Controls.Add(this.lblVideo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textReleased);
            this.groupBox1.Controls.Add(this.textCopies);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textYear);
            this.groupBox1.Controls.Add(this.textPoints);
            this.groupBox1.Controls.Add(this.txtMovieName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(805, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 305);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Video";
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Location = new System.Drawing.Point(33, 259);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(0, 13);
            this.lblVideo.TabIndex = 10;
            this.lblVideo.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Realeased By";
            // 
            // textReleased
            // 
            this.textReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReleased.Location = new System.Drawing.Point(87, 215);
            this.textReleased.Name = "textReleased";
            this.textReleased.Size = new System.Drawing.Size(170, 26);
            this.textReleased.TabIndex = 8;
            // 
            // textCopies
            // 
            this.textCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCopies.Location = new System.Drawing.Point(87, 167);
            this.textCopies.Name = "textCopies";
            this.textCopies.Size = new System.Drawing.Size(170, 26);
            this.textCopies.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Copies";
            // 
            // textYear
            // 
            this.textYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textYear.Location = new System.Drawing.Point(87, 121);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(170, 26);
            this.textYear.TabIndex = 5;
            // 
            // textPoints
            // 
            this.textPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPoints.Location = new System.Drawing.Point(87, 73);
            this.textPoints.Name = "textPoints";
            this.textPoints.Size = new System.Drawing.Size(170, 26);
            this.textPoints.TabIndex = 4;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.Location = new System.Drawing.Point(87, 35);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(170, 26);
            this.txtMovieName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // movieReturn
            // 
            this.movieReturn.BackColor = System.Drawing.Color.SaddleBrown;
            this.movieReturn.Location = new System.Drawing.Point(821, 464);
            this.movieReturn.Name = "movieReturn";
            this.movieReturn.Size = new System.Drawing.Size(98, 29);
            this.movieReturn.TabIndex = 32;
            this.movieReturn.Text = "Return";
            this.movieReturn.UseVisualStyleBackColor = false;
            this.movieReturn.Click += new System.EventHandler(this.movieReturn_Click);
            // 
            // movieIssue
            // 
            this.movieIssue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.movieIssue.Location = new System.Drawing.Point(821, 413);
            this.movieIssue.Name = "movieIssue";
            this.movieIssue.Size = new System.Drawing.Size(98, 29);
            this.movieIssue.TabIndex = 31;
            this.movieIssue.Text = "Issue";
            this.movieIssue.UseVisualStyleBackColor = false;
            this.movieIssue.Click += new System.EventHandler(this.movieIssue_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox3.Controls.Add(this.lblRentalArea);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(424, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 142);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rental Area";
            // 
            // lblRentalArea
            // 
            this.lblRentalArea.AutoSize = true;
            this.lblRentalArea.Location = new System.Drawing.Point(391, 34);
            this.lblRentalArea.Name = "lblRentalArea";
            this.lblRentalArea.Size = new System.Drawing.Size(0, 13);
            this.lblRentalArea.TabIndex = 16;
            this.lblRentalArea.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.videosBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.ValueMember = "ID";
            // 
            // videosBindingSource
            // 
            this.videosBindingSource.DataMember = "Videos";
            this.videosBindingSource.DataSource = this.videoRentalSystem_RajpalDataSet1;
            // 
            // videoRentalSystem_RajpalDataSet1
            // 
            this.videoRentalSystem_RajpalDataSet1.DataSetName = "VideoRentalSystem_RajpalDataSet1";
            this.videoRentalSystem_RajpalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.customersBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "ID";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.videoRentalSystem_RajpalDataSet;
            // 
            // videoRentalSystem_RajpalDataSet
            // 
            this.videoRentalSystem_RajpalDataSet.DataSetName = "VideoRentalSystem_RajpalDataSet";
            this.videoRentalSystem_RajpalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(175, 116);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Date of Return";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Date of Issue";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Movie ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Customer ID";
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // videosTableAdapter
            // 
            this.videosTableAdapter.ClearBeforeFill = true;
            // 
            // VideoStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 560);
            this.Controls.Add(this.movieReturn);
            this.Controls.Add(this.movieIssue);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.videoDelete);
            this.Controls.Add(this.videoUpdate);
            this.Controls.Add(this.videoAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerDelete);
            this.Controls.Add(this.customerUpdate);
            this.Controls.Add(this.customerAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "VideoStore";
            this.Text = "VideoStore";
            this.Load += new System.EventHandler(this.VideoStore_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMovies)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRental)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalSystem_RajpalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoRentalSystem_RajpalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridViewCustomers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridViewMovies;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView gridViewRental;
        private System.Windows.Forms.Button customerDelete;
        private System.Windows.Forms.Button customerUpdate;
        private System.Windows.Forms.Button customerAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button videoDelete;
        private System.Windows.Forms.Button videoUpdate;
        private System.Windows.Forms.Button videoAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textReleased;
        private System.Windows.Forms.TextBox textCopies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textPoints;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button movieReturn;
        private System.Windows.Forms.Button movieIssue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRentalArea;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private VideoRentalSystem_RajpalDataSet videoRentalSystem_RajpalDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private VideoRentalSystem_RajpalDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private VideoRentalSystem_RajpalDataSet1 videoRentalSystem_RajpalDataSet1;
        private System.Windows.Forms.BindingSource videosBindingSource;
        private VideoRentalSystem_RajpalDataSet1TableAdapters.VideosTableAdapter videosTableAdapter;
    }
}