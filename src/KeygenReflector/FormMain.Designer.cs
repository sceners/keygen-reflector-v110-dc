namespace KeygenReflector
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbSerial = new System.Windows.Forms.ComboBox();
			this.btnAddSerial = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbWindow = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbGenerate = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkWait = new System.Windows.Forms.CheckBox();
			this.edtCurrent = new System.Windows.Forms.TextBox();
			this.lblDuplicates = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.prgProgress = new System.Windows.Forms.ProgressBar();
			this.btnStart = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.edtCount = new System.Windows.Forms.NumericUpDown();
			this.DialogSave = new System.Windows.Forms.SaveFileDialog();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblMD5 = new System.Windows.Forms.Label();
			this.lblExecPath = new System.Windows.Forms.Label();
			this.lblParentProcess = new System.Windows.Forms.Label();
			this.lblProcess = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.edtCount)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cmbSerial);
			this.groupBox1.Controls.Add(this.btnAddSerial);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbWindow);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbGenerate);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(288, 96);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "GUI";
			// 
			// cmbSerial
			// 
			this.cmbSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSerial.FormattingEnabled = true;
			this.cmbSerial.Location = new System.Drawing.Point(96, 64);
			this.cmbSerial.Name = "cmbSerial";
			this.cmbSerial.Size = new System.Drawing.Size(160, 21);
			this.cmbSerial.TabIndex = 2;
			this.cmbSerial.DropDown += new System.EventHandler(this.cmbSerial_DropDown);
			this.cmbSerial.SelectedIndexChanged += new System.EventHandler(this.cmbSerial_SelectedIndexChanged);
			// 
			// btnAddSerial
			// 
			this.btnAddSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddSerial.Image = global::KeygenReflector.Properties.Resources.Add;
			this.btnAddSerial.Location = new System.Drawing.Point(256, 64);
			this.btnAddSerial.Name = "btnAddSerial";
			this.btnAddSerial.Size = new System.Drawing.Size(24, 23);
			this.btnAddSerial.TabIndex = 3;
			this.btnAddSerial.UseVisualStyleBackColor = true;
			this.btnAddSerial.Click += new System.EventHandler(this.btnAddSerial_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Window:";
			// 
			// cmbWindow
			// 
			this.cmbWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbWindow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbWindow.FormattingEnabled = true;
			this.cmbWindow.Location = new System.Drawing.Point(64, 16);
			this.cmbWindow.Name = "cmbWindow";
			this.cmbWindow.Size = new System.Drawing.Size(216, 21);
			this.cmbWindow.TabIndex = 0;
			this.cmbWindow.DropDown += new System.EventHandler(this.cmbWindow_DropDown);
			this.cmbWindow.SelectedIndexChanged += new System.EventHandler(this.cmbWindow_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Serial textbox:";
			// 
			// cmbGenerate
			// 
			this.cmbGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cmbGenerate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGenerate.FormattingEnabled = true;
			this.cmbGenerate.Location = new System.Drawing.Point(96, 40);
			this.cmbGenerate.Name = "cmbGenerate";
			this.cmbGenerate.Size = new System.Drawing.Size(184, 21);
			this.cmbGenerate.TabIndex = 1;
			this.cmbGenerate.DropDown += new System.EventHandler(this.cmbGenerate_DropDown);
			this.cmbGenerate.SelectedIndexChanged += new System.EventHandler(this.cmbGenerate_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Generate button:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.chkWait);
			this.groupBox2.Controls.Add(this.edtCurrent);
			this.groupBox2.Controls.Add(this.lblDuplicates);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.prgProgress);
			this.groupBox2.Controls.Add(this.btnStart);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.edtCount);
			this.groupBox2.Location = new System.Drawing.Point(8, 112);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 104);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Generate";
			// 
			// chkWait
			// 
			this.chkWait.AutoSize = true;
			this.chkWait.Location = new System.Drawing.Point(128, 16);
			this.chkWait.Name = "chkWait";
			this.chkWait.Size = new System.Drawing.Size(117, 17);
			this.chkWait.TabIndex = 1;
			this.chkWait.Text = "Wait between keys";
			this.chkWait.UseVisualStyleBackColor = true;
			// 
			// edtCurrent
			// 
			this.edtCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.edtCurrent.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCurrent.Location = new System.Drawing.Point(8, 72);
			this.edtCurrent.Name = "edtCurrent";
			this.edtCurrent.Size = new System.Drawing.Size(192, 20);
			this.edtCurrent.TabIndex = 2;
			// 
			// lblDuplicates
			// 
			this.lblDuplicates.AutoSize = true;
			this.lblDuplicates.Location = new System.Drawing.Point(72, 48);
			this.lblDuplicates.Name = "lblDuplicates";
			this.lblDuplicates.Size = new System.Drawing.Size(13, 13);
			this.lblDuplicates.TabIndex = 5;
			this.lblDuplicates.Text = "0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Duplicates:";
			// 
			// prgProgress
			// 
			this.prgProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.prgProgress.Location = new System.Drawing.Point(120, 48);
			this.prgProgress.Name = "prgProgress";
			this.prgProgress.Size = new System.Drawing.Size(160, 16);
			this.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prgProgress.TabIndex = 3;
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStart.Enabled = false;
			this.btnStart.Image = global::KeygenReflector.Properties.Resources.Start;
			this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnStart.Location = new System.Drawing.Point(208, 72);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(72, 23);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "Start";
			this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Generate:";
			// 
			// edtCount
			// 
			this.edtCount.Location = new System.Drawing.Point(64, 16);
			this.edtCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.edtCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.edtCount.Name = "edtCount";
			this.edtCount.Size = new System.Drawing.Size(56, 20);
			this.edtCount.TabIndex = 0;
			this.edtCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// DialogSave
			// 
			this.DialogSave.DefaultExt = "txt";
			this.DialogSave.FileName = "Keygen.txt";
			this.DialogSave.Filter = "Text files (*.txt)|*.txt";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.lblMD5);
			this.groupBox3.Controls.Add(this.lblExecPath);
			this.groupBox3.Controls.Add(this.lblParentProcess);
			this.groupBox3.Controls.Add(this.lblProcess);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Location = new System.Drawing.Point(8, 224);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(288, 88);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Keygen integrity";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(52, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "File MD5:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "Execution path:";
			// 
			// lblMD5
			// 
			this.lblMD5.AutoSize = true;
			this.lblMD5.Location = new System.Drawing.Point(88, 64);
			this.lblMD5.Name = "lblMD5";
			this.lblMD5.Size = new System.Drawing.Size(13, 13);
			this.lblMD5.TabIndex = 0;
			this.lblMD5.Text = "?";
			// 
			// lblExecPath
			// 
			this.lblExecPath.AutoSize = true;
			this.lblExecPath.Location = new System.Drawing.Point(88, 48);
			this.lblExecPath.Name = "lblExecPath";
			this.lblExecPath.Size = new System.Drawing.Size(13, 13);
			this.lblExecPath.TabIndex = 0;
			this.lblExecPath.Text = "?";
			// 
			// lblParentProcess
			// 
			this.lblParentProcess.AutoSize = true;
			this.lblParentProcess.Location = new System.Drawing.Point(88, 32);
			this.lblParentProcess.Name = "lblParentProcess";
			this.lblParentProcess.Size = new System.Drawing.Size(13, 13);
			this.lblParentProcess.TabIndex = 0;
			this.lblParentProcess.Text = "?";
			// 
			// lblProcess
			// 
			this.lblProcess.AutoSize = true;
			this.lblProcess.Location = new System.Drawing.Point(88, 16);
			this.lblProcess.Name = "lblProcess";
			this.lblProcess.Size = new System.Drawing.Size(13, 13);
			this.lblProcess.TabIndex = 0;
			this.lblProcess.Text = "?";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Parent process:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Process:";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 321);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(585, 359);
			this.MinimumSize = new System.Drawing.Size(321, 359);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Keygen Reflector 1.1.0";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.edtCount)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbSerial;
		private System.Windows.Forms.Button btnAddSerial;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbWindow;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbGenerate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkWait;
		private System.Windows.Forms.TextBox edtCurrent;
		private System.Windows.Forms.Label lblDuplicates;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ProgressBar prgProgress;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown edtCount;
		private System.Windows.Forms.SaveFileDialog DialogSave;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblProcess;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblParentProcess;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblExecPath;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblMD5;
	}
}

