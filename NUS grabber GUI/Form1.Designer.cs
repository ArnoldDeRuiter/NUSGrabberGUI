namespace NUS_grabber_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMinimalize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnDownUp = new System.Windows.Forms.Button();
            this.btnDownSys = new System.Windows.Forms.Button();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblOtherAuthor = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.btnDownFu = new System.Windows.Forms.Button();
            this.cgbFullTitles = new MayaMaya.myGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFuSearchBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFuVersions = new System.Windows.Forms.ComboBox();
            this.cmbFuTitles = new System.Windows.Forms.ComboBox();
            this.cgbSystemTitles = new MayaMaya.myGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSysSearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSysVersions = new System.Windows.Forms.ComboBox();
            this.cmbSysTitles = new System.Windows.Forms.ComboBox();
            this.cgbGameUpdates = new MayaMaya.myGroupBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lblVersions = new System.Windows.Forms.Label();
            this.lblGameTitles = new System.Windows.Forms.Label();
            this.lnlGbTitle = new System.Windows.Forms.Label();
            this.prBar = new System.Windows.Forms.ProgressBar();
            this.cmbVersions = new System.Windows.Forms.ComboBox();
            this.lblLoad = new System.Windows.Forms.Label();
            this.cmbTitles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimalize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.cgbFullTitles.SuspendLayout();
            this.cgbSystemTitles.SuspendLayout();
            this.cgbGameUpdates.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMinimalize
            // 
            this.pbMinimalize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimalize.Image")));
            this.pbMinimalize.Location = new System.Drawing.Point(202, 0);
            this.pbMinimalize.Name = "pbMinimalize";
            this.pbMinimalize.Padding = new System.Windows.Forms.Padding(50);
            this.pbMinimalize.Size = new System.Drawing.Size(56, 29);
            this.pbMinimalize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimalize.TabIndex = 5;
            this.pbMinimalize.TabStop = false;
            this.pbMinimalize.Click += new System.EventHandler(this.pbMinimalize_Click);
            this.pbMinimalize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMinimalize_MouseDown);
            this.pbMinimalize.MouseLeave += new System.EventHandler(this.pbMinimalize_MouseLeave);
            this.pbMinimalize.MouseHover += new System.EventHandler(this.pbMinimalize_MouseHover);
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(258, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Padding = new System.Windows.Forms.Padding(50);
            this.pbClose.Size = new System.Drawing.Size(56, 29);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbClose_MouseDown);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            this.pbClose.MouseHover += new System.EventHandler(this.pbClose_MouseHover);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(205, 51);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(106, 23);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDownUp
            // 
            this.btnDownUp.Enabled = false;
            this.btnDownUp.Location = new System.Drawing.Point(205, 80);
            this.btnDownUp.Name = "btnDownUp";
            this.btnDownUp.Size = new System.Drawing.Size(106, 23);
            this.btnDownUp.TabIndex = 8;
            this.btnDownUp.Text = "Game Updates";
            this.btnDownUp.UseVisualStyleBackColor = true;
            this.btnDownUp.Click += new System.EventHandler(this.btnDownUp_Click);
            // 
            // btnDownSys
            // 
            this.btnDownSys.Enabled = false;
            this.btnDownSys.Location = new System.Drawing.Point(205, 109);
            this.btnDownSys.Name = "btnDownSys";
            this.btnDownSys.Size = new System.Drawing.Size(106, 23);
            this.btnDownSys.TabIndex = 9;
            this.btnDownSys.Text = "System Titles";
            this.btnDownSys.UseVisualStyleBackColor = true;
            this.btnDownSys.Click += new System.EventHandler(this.btnDownOther_Click);
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.Location = new System.Drawing.Point(3, 5);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(150, 21);
            this.lblTitleForm.TabIndex = 11;
            this.lblTitleForm.Text = "NUSGrabber GUI vX";
            this.lblTitleForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lblTitleForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            this.lblTitleForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(200, 251);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(126, 13);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "NUSGrabber by Crediar";
            // 
            // lblOtherAuthor
            // 
            this.lblOtherAuthor.AutoSize = true;
            this.lblOtherAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblOtherAuthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherAuthor.Location = new System.Drawing.Point(200, 280);
            this.lblOtherAuthor.Name = "lblOtherAuthor";
            this.lblOtherAuthor.Size = new System.Drawing.Size(130, 13);
            this.lblOtherAuthor.TabIndex = 13;
            this.lblOtherAuthor.Text = "GUI by Adr990/Arndroid";
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.Location = new System.Drawing.Point(201, 35);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(78, 13);
            this.lblAlert.TabIndex = 14;
            this.lblAlert.Text = "Alert message";
            this.lblAlert.Visible = false;
            // 
            // btnDownFu
            // 
            this.btnDownFu.Enabled = false;
            this.btnDownFu.Location = new System.Drawing.Point(205, 138);
            this.btnDownFu.Name = "btnDownFu";
            this.btnDownFu.Size = new System.Drawing.Size(106, 23);
            this.btnDownFu.TabIndex = 16;
            this.btnDownFu.Text = "Full Titles";
            this.btnDownFu.UseVisualStyleBackColor = true;
            this.btnDownFu.Click += new System.EventHandler(this.btnDownFu_Click);
            // 
            // cgbFullTitles
            // 
            this.cgbFullTitles.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cgbFullTitles.BorderColor = System.Drawing.Color.Transparent;
            this.cgbFullTitles.Controls.Add(this.label5);
            this.cgbFullTitles.Controls.Add(this.txtFuSearchBox);
            this.cgbFullTitles.Controls.Add(this.label6);
            this.cgbFullTitles.Controls.Add(this.label7);
            this.cgbFullTitles.Controls.Add(this.label8);
            this.cgbFullTitles.Controls.Add(this.cmbFuVersions);
            this.cgbFullTitles.Controls.Add(this.cmbFuTitles);
            this.cgbFullTitles.Location = new System.Drawing.Point(1, 32);
            this.cgbFullTitles.Name = "cgbFullTitles";
            this.cgbFullTitles.Size = new System.Drawing.Size(200, 278);
            this.cgbFullTitles.TabIndex = 15;
            this.cgbFullTitles.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Filter:";
            // 
            // txtFuSearchBox
            // 
            this.txtFuSearchBox.Location = new System.Drawing.Point(50, 21);
            this.txtFuSearchBox.Name = "txtFuSearchBox";
            this.txtFuSearchBox.Size = new System.Drawing.Size(145, 20);
            this.txtFuSearchBox.TabIndex = 8;
            this.txtFuSearchBox.TextChanged += new System.EventHandler(this.txtFuSearchBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Version:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Full Titles";
            // 
            // cmbFuVersions
            // 
            this.cmbFuVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuVersions.FormattingEnabled = true;
            this.cmbFuVersions.Location = new System.Drawing.Point(8, 115);
            this.cmbFuVersions.Name = "cmbFuVersions";
            this.cmbFuVersions.Size = new System.Drawing.Size(121, 21);
            this.cmbFuVersions.TabIndex = 2;
            // 
            // cmbFuTitles
            // 
            this.cmbFuTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuTitles.FormattingEnabled = true;
            this.cmbFuTitles.Location = new System.Drawing.Point(8, 71);
            this.cmbFuTitles.Name = "cmbFuTitles";
            this.cmbFuTitles.Size = new System.Drawing.Size(187, 21);
            this.cmbFuTitles.TabIndex = 0;
            this.cmbFuTitles.SelectedIndexChanged += new System.EventHandler(this.cmbFuTitles_SelectedIndexChanged);
            // 
            // cgbSystemTitles
            // 
            this.cgbSystemTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cgbSystemTitles.BorderColor = System.Drawing.Color.Transparent;
            this.cgbSystemTitles.Controls.Add(this.label1);
            this.cgbSystemTitles.Controls.Add(this.txtSysSearchBox);
            this.cgbSystemTitles.Controls.Add(this.label2);
            this.cgbSystemTitles.Controls.Add(this.label3);
            this.cgbSystemTitles.Controls.Add(this.label4);
            this.cgbSystemTitles.Controls.Add(this.cmbSysVersions);
            this.cgbSystemTitles.Controls.Add(this.cmbSysTitles);
            this.cgbSystemTitles.Location = new System.Drawing.Point(1, 32);
            this.cgbSystemTitles.Name = "cgbSystemTitles";
            this.cgbSystemTitles.Size = new System.Drawing.Size(200, 278);
            this.cgbSystemTitles.TabIndex = 11;
            this.cgbSystemTitles.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter:";
            // 
            // txtSysSearchBox
            // 
            this.txtSysSearchBox.Location = new System.Drawing.Point(50, 21);
            this.txtSysSearchBox.Name = "txtSysSearchBox";
            this.txtSysSearchBox.Size = new System.Drawing.Size(145, 20);
            this.txtSysSearchBox.TabIndex = 8;
            this.txtSysSearchBox.TextChanged += new System.EventHandler(this.txtSysSearchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "System Titles";
            // 
            // cmbSysVersions
            // 
            this.cmbSysVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSysVersions.FormattingEnabled = true;
            this.cmbSysVersions.Location = new System.Drawing.Point(8, 115);
            this.cmbSysVersions.Name = "cmbSysVersions";
            this.cmbSysVersions.Size = new System.Drawing.Size(121, 21);
            this.cmbSysVersions.TabIndex = 2;
            // 
            // cmbSysTitles
            // 
            this.cmbSysTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSysTitles.FormattingEnabled = true;
            this.cmbSysTitles.Location = new System.Drawing.Point(8, 71);
            this.cmbSysTitles.Name = "cmbSysTitles";
            this.cmbSysTitles.Size = new System.Drawing.Size(187, 21);
            this.cmbSysTitles.TabIndex = 0;
            this.cmbSysTitles.SelectedIndexChanged += new System.EventHandler(this.cmbSysTitles_SelectedIndexChanged);
            // 
            // cgbGameUpdates
            // 
            this.cgbGameUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cgbGameUpdates.BorderColor = System.Drawing.Color.Transparent;
            this.cgbGameUpdates.Controls.Add(this.lblFilter);
            this.cgbGameUpdates.Controls.Add(this.txtSearchBox);
            this.cgbGameUpdates.Controls.Add(this.lblVersions);
            this.cgbGameUpdates.Controls.Add(this.lblGameTitles);
            this.cgbGameUpdates.Controls.Add(this.lnlGbTitle);
            this.cgbGameUpdates.Controls.Add(this.prBar);
            this.cgbGameUpdates.Controls.Add(this.cmbVersions);
            this.cgbGameUpdates.Controls.Add(this.lblLoad);
            this.cgbGameUpdates.Controls.Add(this.cmbTitles);
            this.cgbGameUpdates.Location = new System.Drawing.Point(1, 32);
            this.cgbGameUpdates.Name = "cgbGameUpdates";
            this.cgbGameUpdates.Size = new System.Drawing.Size(200, 278);
            this.cgbGameUpdates.TabIndex = 10;
            this.cgbGameUpdates.TabStop = false;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(5, 21);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 17);
            this.lblFilter.TabIndex = 9;
            this.lblFilter.Text = "Filter:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(50, 21);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(145, 20);
            this.txtSearchBox.TabIndex = 8;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // lblVersions
            // 
            this.lblVersions.AutoSize = true;
            this.lblVersions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersions.Location = new System.Drawing.Point(5, 95);
            this.lblVersions.Name = "lblVersions";
            this.lblVersions.Size = new System.Drawing.Size(54, 17);
            this.lblVersions.TabIndex = 7;
            this.lblVersions.Text = "Version:";
            // 
            // lblGameTitles
            // 
            this.lblGameTitles.AutoSize = true;
            this.lblGameTitles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitles.Location = new System.Drawing.Point(5, 48);
            this.lblGameTitles.Name = "lblGameTitles";
            this.lblGameTitles.Size = new System.Drawing.Size(35, 17);
            this.lblGameTitles.TabIndex = 6;
            this.lblGameTitles.Text = "Title:";
            // 
            // lnlGbTitle
            // 
            this.lnlGbTitle.AutoSize = true;
            this.lnlGbTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlGbTitle.Location = new System.Drawing.Point(2, 2);
            this.lnlGbTitle.Name = "lnlGbTitle";
            this.lnlGbTitle.Size = new System.Drawing.Size(82, 13);
            this.lnlGbTitle.TabIndex = 5;
            this.lnlGbTitle.Text = "Game Updates";
            // 
            // prBar
            // 
            this.prBar.Location = new System.Drawing.Point(6, 246);
            this.prBar.Name = "prBar";
            this.prBar.Size = new System.Drawing.Size(183, 23);
            this.prBar.TabIndex = 3;
            // 
            // cmbVersions
            // 
            this.cmbVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersions.FormattingEnabled = true;
            this.cmbVersions.Location = new System.Drawing.Point(8, 115);
            this.cmbVersions.Name = "cmbVersions";
            this.cmbVersions.Size = new System.Drawing.Size(121, 21);
            this.cmbVersions.TabIndex = 2;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.Location = new System.Drawing.Point(2, 222);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(130, 21);
            this.lblLoad.TabIndex = 1;
            this.lblLoad.Text = "Retrieving Titles...";
            // 
            // cmbTitles
            // 
            this.cmbTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitles.FormattingEnabled = true;
            this.cmbTitles.Location = new System.Drawing.Point(8, 71);
            this.cmbTitles.Name = "cmbTitles";
            this.cmbTitles.Size = new System.Drawing.Size(187, 21);
            this.cmbTitles.TabIndex = 0;
            this.cmbTitles.TextChanged += new System.EventHandler(this.cmbTitles_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(314, 311);
            this.Controls.Add(this.btnDownFu);
            this.Controls.Add(this.cgbFullTitles);
            this.Controls.Add(this.cgbSystemTitles);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.cgbGameUpdates);
            this.Controls.Add(this.btnDownSys);
            this.Controls.Add(this.btnDownUp);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.pbMinimalize);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblTitleForm);
            this.Controls.Add(this.lblOtherAuthor);
            this.Controls.Add(this.lblAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "NUSGrabber GUI v1.6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.cgbFullTitles.ResumeLayout(false);
            this.cgbFullTitles.PerformLayout();
            this.cgbSystemTitles.ResumeLayout(false);
            this.cgbSystemTitles.PerformLayout();
            this.cgbGameUpdates.ResumeLayout(false);
            this.cgbGameUpdates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMinimalize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDownUp;
        private System.Windows.Forms.Button btnDownSys;
        private MayaMaya.myGroupBox cgbGameUpdates;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.ComboBox cmbTitles;
        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.ComboBox cmbVersions;
        private System.Windows.Forms.ProgressBar prBar;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblOtherAuthor;
        private System.Windows.Forms.Label lblVersions;
        private System.Windows.Forms.Label lblGameTitles;
        private System.Windows.Forms.Label lnlGbTitle;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label lblAlert;
        private MayaMaya.myGroupBox cgbSystemTitles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSysSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSysVersions;
        private System.Windows.Forms.ComboBox cmbSysTitles;
        private MayaMaya.myGroupBox cgbFullTitles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFuSearchBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFuVersions;
        private System.Windows.Forms.ComboBox cmbFuTitles;
        private System.Windows.Forms.Button btnDownFu;
    }
}

