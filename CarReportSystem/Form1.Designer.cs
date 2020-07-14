namespace CarReportSystem {
	partial class Form1 {
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
			this.cbAuthor = new System.Windows.Forms.ComboBox();
			this.cbCarName = new System.Windows.Forms.ComboBox();
			this.rbToyota = new System.Windows.Forms.RadioButton();
			this.rbNisan = new System.Windows.Forms.RadioButton();
			this.rbHonda = new System.Windows.Forms.RadioButton();
			this.rbSubaru = new System.Windows.Forms.RadioButton();
			this.rbForeignCar = new System.Windows.Forms.RadioButton();
			this.rbOther = new System.Windows.Forms.RadioButton();
			this.tbReport = new System.Windows.Forms.TextBox();
			this.dgvCarReportData = new System.Windows.Forms.DataGridView();
			this.pbCarPicture = new System.Windows.Forms.PictureBox();
			this.btImageOpen = new System.Windows.Forms.Button();
			this.btImageDelete = new System.Windows.Forms.Button();
			this.btDataOpen = new System.Windows.Forms.Button();
			this.btDataSave = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btDataAdd = new System.Windows.Forms.Button();
			this.btDataFix = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.btDataDelete = new System.Windows.Forms.Button();
			this.makerGroup = new System.Windows.Forms.GroupBox();
			this.ofdImageOpen = new System.Windows.Forms.OpenFileDialog();
			this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msNew = new System.Windows.Forms.ToolStripMenuItem();
			this.msOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.msSave = new System.Windows.Forms.ToolStripMenuItem();
			this.msNamedSave = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslNowTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.infosys202028DataSetCarReport = new CarReportSystem.infosys202028DataSetCarReport();
			this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.carReportTableAdapter = new CarReportSystem.infosys202028DataSetCarReportTableAdapters.CarReportTableAdapter();
			this.tableAdapterManager = new CarReportSystem.infosys202028DataSetCarReportTableAdapters.TableAdapterManager();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCarReportData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).BeginInit();
			this.makerGroup.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.infosys202028DataSetCarReport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(56, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "日付：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(35, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "メーカー：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(56, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "車名：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(34, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "レポート：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(18, 309);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "記事一覧：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(518, 28);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 19);
			this.label6.TabIndex = 0;
			this.label6.Text = "画像：";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.Location = new System.Drawing.Point(37, 55);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 19);
			this.label7.TabIndex = 0;
			this.label7.Text = "記録者：";
			// 
			// dtpCreateDate
			// 
			this.dtpCreateDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carReportBindingSource, "CreateDate", true));
			this.dtpCreateDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.dtpCreateDate.Location = new System.Drawing.Point(119, 25);
			this.dtpCreateDate.Name = "dtpCreateDate";
			this.dtpCreateDate.Size = new System.Drawing.Size(200, 23);
			this.dtpCreateDate.TabIndex = 1;
			// 
			// cbAuthor
			// 
			this.cbAuthor.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbAuthor.FormattingEnabled = true;
			this.cbAuthor.Location = new System.Drawing.Point(119, 54);
			this.cbAuthor.Name = "cbAuthor";
			this.cbAuthor.Size = new System.Drawing.Size(261, 24);
			this.cbAuthor.TabIndex = 2;
			// 
			// cbCarName
			// 
			this.cbCarName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cbCarName.FormattingEnabled = true;
			this.cbCarName.Location = new System.Drawing.Point(119, 125);
			this.cbCarName.Name = "cbCarName";
			this.cbCarName.Size = new System.Drawing.Size(261, 24);
			this.cbCarName.TabIndex = 2;
			// 
			// rbToyota
			// 
			this.rbToyota.AutoSize = true;
			this.rbToyota.Checked = true;
			this.rbToyota.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rbToyota.Location = new System.Drawing.Point(6, 9);
			this.rbToyota.Name = "rbToyota";
			this.rbToyota.Size = new System.Drawing.Size(58, 20);
			this.rbToyota.TabIndex = 3;
			this.rbToyota.TabStop = true;
			this.rbToyota.Tag = "1";
			this.rbToyota.Text = "トヨタ";
			this.rbToyota.UseVisualStyleBackColor = true;
			// 
			// rbNisan
			// 
			this.rbNisan.AutoSize = true;
			this.rbNisan.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rbNisan.Location = new System.Drawing.Point(70, 9);
			this.rbNisan.Name = "rbNisan";
			this.rbNisan.Size = new System.Drawing.Size(58, 20);
			this.rbNisan.TabIndex = 3;
			this.rbNisan.TabStop = true;
			this.rbNisan.Tag = "2";
			this.rbNisan.Text = "日産";
			this.rbNisan.UseVisualStyleBackColor = true;
			// 
			// rbHonda
			// 
			this.rbHonda.AutoSize = true;
			this.rbHonda.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rbHonda.Location = new System.Drawing.Point(134, 9);
			this.rbHonda.Name = "rbHonda";
			this.rbHonda.Size = new System.Drawing.Size(63, 20);
			this.rbHonda.TabIndex = 3;
			this.rbHonda.TabStop = true;
			this.rbHonda.Tag = "3";
			this.rbHonda.Text = "ホンダ";
			this.rbHonda.UseVisualStyleBackColor = true;
			// 
			// rbSubaru
			// 
			this.rbSubaru.AutoSize = true;
			this.rbSubaru.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rbSubaru.Location = new System.Drawing.Point(203, 9);
			this.rbSubaru.Name = "rbSubaru";
			this.rbSubaru.Size = new System.Drawing.Size(65, 20);
			this.rbSubaru.TabIndex = 3;
			this.rbSubaru.TabStop = true;
			this.rbSubaru.Tag = "4";
			this.rbSubaru.Text = "スバル";
			this.rbSubaru.UseVisualStyleBackColor = true;
			// 
			// rbForeignCar
			// 
			this.rbForeignCar.AutoSize = true;
			this.rbForeignCar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rbForeignCar.Location = new System.Drawing.Point(274, 9);
			this.rbForeignCar.Name = "rbForeignCar";
			this.rbForeignCar.Size = new System.Drawing.Size(58, 20);
			this.rbForeignCar.TabIndex = 3;
			this.rbForeignCar.TabStop = true;
			this.rbForeignCar.Tag = "5";
			this.rbForeignCar.Text = "外車";
			this.rbForeignCar.UseVisualStyleBackColor = true;
			// 
			// rbOther
			// 
			this.rbOther.AutoSize = true;
			this.rbOther.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rbOther.Location = new System.Drawing.Point(338, 9);
			this.rbOther.Name = "rbOther";
			this.rbOther.Size = new System.Drawing.Size(67, 20);
			this.rbOther.TabIndex = 3;
			this.rbOther.TabStop = true;
			this.rbOther.Tag = "6";
			this.rbOther.Text = "その他";
			this.rbOther.UseVisualStyleBackColor = true;
			// 
			// tbReport
			// 
			this.tbReport.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tbReport.Location = new System.Drawing.Point(119, 155);
			this.tbReport.Multiline = true;
			this.tbReport.Name = "tbReport";
			this.tbReport.Size = new System.Drawing.Size(399, 148);
			this.tbReport.TabIndex = 4;
			// 
			// dgvCarReportData
			// 
			this.dgvCarReportData.AllowUserToAddRows = false;
			this.dgvCarReportData.AutoGenerateColumns = false;
			this.dgvCarReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCarReportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
			this.dgvCarReportData.DataSource = this.carReportBindingSource;
			this.dgvCarReportData.Location = new System.Drawing.Point(119, 309);
			this.dgvCarReportData.MultiSelect = false;
			this.dgvCarReportData.Name = "dgvCarReportData";
			this.dgvCarReportData.ReadOnly = true;
			this.dgvCarReportData.RowTemplate.Height = 21;
			this.dgvCarReportData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCarReportData.Size = new System.Drawing.Size(700, 170);
			this.dgvCarReportData.TabIndex = 5;
			this.dgvCarReportData.Click += new System.EventHandler(this.dgvCarReportData_Click);
			// 
			// pbCarPicture
			// 
			this.pbCarPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbCarPicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.carReportBindingSource, "Picture", true));
			this.pbCarPicture.Location = new System.Drawing.Point(542, 55);
			this.pbCarPicture.Name = "pbCarPicture";
			this.pbCarPicture.Size = new System.Drawing.Size(277, 219);
			this.pbCarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbCarPicture.TabIndex = 6;
			this.pbCarPicture.TabStop = false;
			// 
			// btImageOpen
			// 
			this.btImageOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btImageOpen.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btImageOpen.Location = new System.Drawing.Point(581, 25);
			this.btImageOpen.Name = "btImageOpen";
			this.btImageOpen.Size = new System.Drawing.Size(92, 23);
			this.btImageOpen.TabIndex = 7;
			this.btImageOpen.Text = "開く";
			this.btImageOpen.UseVisualStyleBackColor = true;
			this.btImageOpen.Click += new System.EventHandler(this.btImageOpen_Click);
			// 
			// btImageDelete
			// 
			this.btImageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btImageDelete.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btImageDelete.Location = new System.Drawing.Point(699, 25);
			this.btImageDelete.Name = "btImageDelete";
			this.btImageDelete.Size = new System.Drawing.Size(92, 23);
			this.btImageDelete.TabIndex = 7;
			this.btImageDelete.Text = "削除";
			this.btImageDelete.UseVisualStyleBackColor = true;
			this.btImageDelete.Click += new System.EventHandler(this.btImageDelete_Click);
			// 
			// btDataOpen
			// 
			this.btDataOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDataOpen.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btDataOpen.Location = new System.Drawing.Point(22, 347);
			this.btDataOpen.Name = "btDataOpen";
			this.btDataOpen.Size = new System.Drawing.Size(74, 50);
			this.btDataOpen.TabIndex = 7;
			this.btDataOpen.Text = "接続";
			this.btDataOpen.UseVisualStyleBackColor = true;
			this.btDataOpen.Click += new System.EventHandler(this.btDataOpen_Click);
			// 
			// btDataSave
			// 
			this.btDataSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDataSave.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btDataSave.Location = new System.Drawing.Point(22, 403);
			this.btDataSave.Name = "btDataSave";
			this.btDataSave.Size = new System.Drawing.Size(74, 50);
			this.btDataSave.TabIndex = 7;
			this.btDataSave.Text = "保存";
			this.btDataSave.UseVisualStyleBackColor = true;
			this.btDataSave.Click += new System.EventHandler(this.btDataSave_Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.button5.Location = new System.Drawing.Point(-507, 704);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "button1";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// btDataAdd
			// 
			this.btDataAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDataAdd.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btDataAdd.Location = new System.Drawing.Point(522, 280);
			this.btDataAdd.Name = "btDataAdd";
			this.btDataAdd.Size = new System.Drawing.Size(92, 23);
			this.btDataAdd.TabIndex = 7;
			this.btDataAdd.Text = "追加";
			this.btDataAdd.UseVisualStyleBackColor = true;
			this.btDataAdd.Click += new System.EventHandler(this.btDataAdd_Click);
			// 
			// btDataFix
			// 
			this.btDataFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDataFix.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btDataFix.Location = new System.Drawing.Point(620, 280);
			this.btDataFix.Name = "btDataFix";
			this.btDataFix.Size = new System.Drawing.Size(92, 23);
			this.btDataFix.TabIndex = 7;
			this.btDataFix.Text = "修正";
			this.btDataFix.UseVisualStyleBackColor = true;
			this.btDataFix.Click += new System.EventHandler(this.btDataFix_Click);
			// 
			// btExit
			// 
			this.btExit.Cursor = System.Windows.Forms.Cursors.Default;
			this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btExit.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btExit.Location = new System.Drawing.Point(715, 485);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(104, 23);
			this.btExit.TabIndex = 7;
			this.btExit.Text = "終了";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// btDataDelete
			// 
			this.btDataDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDataDelete.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btDataDelete.Location = new System.Drawing.Point(718, 280);
			this.btDataDelete.Name = "btDataDelete";
			this.btDataDelete.Size = new System.Drawing.Size(92, 23);
			this.btDataDelete.TabIndex = 7;
			this.btDataDelete.Text = "削除";
			this.btDataDelete.UseVisualStyleBackColor = true;
			this.btDataDelete.Click += new System.EventHandler(this.btDataDelete_Click);
			// 
			// makerGroup
			// 
			this.makerGroup.Controls.Add(this.rbToyota);
			this.makerGroup.Controls.Add(this.rbNisan);
			this.makerGroup.Controls.Add(this.rbHonda);
			this.makerGroup.Controls.Add(this.rbSubaru);
			this.makerGroup.Controls.Add(this.rbForeignCar);
			this.makerGroup.Controls.Add(this.rbOther);
			this.makerGroup.Location = new System.Drawing.Point(119, 84);
			this.makerGroup.Name = "makerGroup";
			this.makerGroup.Size = new System.Drawing.Size(417, 35);
			this.makerGroup.TabIndex = 8;
			this.makerGroup.TabStop = false;
			this.makerGroup.Text = "makerGroup";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(835, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ファイルToolStripMenuItem
			// 
			this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msNew,
            this.msOpen,
            this.msSave,
            this.msNamedSave});
			this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
			this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ファイルToolStripMenuItem.Text = "ファイル";
			// 
			// msNew
			// 
			this.msNew.Name = "msNew";
			this.msNew.Size = new System.Drawing.Size(257, 22);
			this.msNew.Text = "新規入力";
			this.msNew.Click += new System.EventHandler(this.msNew_Click);
			// 
			// msOpen
			// 
			this.msOpen.Name = "msOpen";
			this.msOpen.Size = new System.Drawing.Size(257, 22);
			this.msOpen.Text = "開く(&O)...";
			this.msOpen.Click += new System.EventHandler(this.msOpen_Click);
			// 
			// msSave
			// 
			this.msSave.Name = "msSave";
			this.msSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.msSave.Size = new System.Drawing.Size(257, 22);
			this.msSave.Text = "保存(&S)";
			this.msSave.Click += new System.EventHandler(this.msSave_Click);
			// 
			// msNamedSave
			// 
			this.msNamedSave.Name = "msNamedSave";
			this.msNamedSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.msNamedSave.Size = new System.Drawing.Size(257, 22);
			this.msNamedSave.Text = "名前を付けて保存(&A)...";
			this.msNamedSave.Click += new System.EventHandler(this.msNamedSave_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNowTime});
			this.statusStrip1.Location = new System.Drawing.Point(0, 513);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(835, 22);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslNowTime
			// 
			this.tsslNowTime.Name = "tsslNowTime";
			this.tsslNowTime.Size = new System.Drawing.Size(74, 17);
			this.tsslNowTime.Text = "tsslNowTime";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// infosys202028DataSetCarReport
			// 
			this.infosys202028DataSetCarReport.DataSetName = "infosys202028DataSetCarReport";
			this.infosys202028DataSetCarReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// carReportBindingSource
			// 
			this.carReportBindingSource.DataMember = "CarReport";
			this.carReportBindingSource.DataSource = this.infosys202028DataSetCarReport;
			// 
			// carReportTableAdapter
			// 
			this.carReportTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
			this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202028DataSetCarReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// createDateDataGridViewTextBoxColumn
			// 
			this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
			this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
			this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
			this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// authorDataGridViewTextBoxColumn
			// 
			this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
			this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
			this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
			this.authorDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// makerDataGridViewTextBoxColumn
			// 
			this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
			this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
			this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
			this.makerDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// reportDataGridViewTextBoxColumn
			// 
			this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
			this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
			this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
			this.reportDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pictureDataGridViewImageColumn
			// 
			this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
			this.pictureDataGridViewImageColumn.HeaderText = "Picture";
			this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
			this.pictureDataGridViewImageColumn.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 535);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.makerGroup);
			this.Controls.Add(this.btImageDelete);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btDataSave);
			this.Controls.Add(this.btDataOpen);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btDataDelete);
			this.Controls.Add(this.btDataFix);
			this.Controls.Add(this.btDataAdd);
			this.Controls.Add(this.btImageOpen);
			this.Controls.Add(this.pbCarPicture);
			this.Controls.Add(this.dgvCarReportData);
			this.Controls.Add(this.tbReport);
			this.Controls.Add(this.cbCarName);
			this.Controls.Add(this.cbAuthor);
			this.Controls.Add(this.dtpCreateDate);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "試乗レポート管理システム";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dgvCarReportData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCarPicture)).EndInit();
			this.makerGroup.ResumeLayout(false);
			this.makerGroup.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.infosys202028DataSetCarReport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpCreateDate;
		private System.Windows.Forms.ComboBox cbAuthor;
		private System.Windows.Forms.ComboBox cbCarName;
		private System.Windows.Forms.RadioButton rbToyota;
		private System.Windows.Forms.RadioButton rbNisan;
		private System.Windows.Forms.RadioButton rbHonda;
		private System.Windows.Forms.RadioButton rbSubaru;
		private System.Windows.Forms.RadioButton rbForeignCar;
		private System.Windows.Forms.RadioButton rbOther;
		private System.Windows.Forms.TextBox tbReport;
		private System.Windows.Forms.DataGridView dgvCarReportData;
		private System.Windows.Forms.PictureBox pbCarPicture;
		private System.Windows.Forms.Button btImageOpen;
		private System.Windows.Forms.Button btImageDelete;
		private System.Windows.Forms.Button btDataOpen;
		private System.Windows.Forms.Button btDataSave;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btDataAdd;
		private System.Windows.Forms.Button btDataFix;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.Button btDataDelete;
		private System.Windows.Forms.GroupBox makerGroup;
		private System.Windows.Forms.OpenFileDialog ofdImageOpen;
		private System.Windows.Forms.OpenFileDialog ofdOpenFile;
		private System.Windows.Forms.SaveFileDialog sfdSaveFile;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem msNew;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslNowTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripMenuItem msOpen;
		private System.Windows.Forms.ToolStripMenuItem msSave;
		private System.Windows.Forms.ToolStripMenuItem msNamedSave;
		private infosys202028DataSetCarReport infosys202028DataSetCarReport;
		private System.Windows.Forms.BindingSource carReportBindingSource;
		private infosys202028DataSetCarReportTableAdapters.CarReportTableAdapter carReportTableAdapter;
		private infosys202028DataSetCarReportTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
	}
}

