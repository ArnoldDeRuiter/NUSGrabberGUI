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
            this.btnDownOther = new System.Windows.Forms.Button();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblOtherAuthor = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.myGroupBox1 = new MayaMaya.myGroupBox();
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
            this.myGroupBox1.SuspendLayout();
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
            // btnDownOther
            // 
            this.btnDownOther.Enabled = false;
            this.btnDownOther.Location = new System.Drawing.Point(205, 109);
            this.btnDownOther.Name = "btnDownOther";
            this.btnDownOther.Size = new System.Drawing.Size(106, 23);
            this.btnDownOther.TabIndex = 9;
            this.btnDownOther.Text = "Other stuff";
            this.btnDownOther.UseVisualStyleBackColor = true;
            this.btnDownOther.Click += new System.EventHandler(this.btnDownOther_Click);
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
            this.lblOtherAuthor.Location = new System.Drawing.Point(201, 280);
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
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.myGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.lblFilter);
            this.myGroupBox1.Controls.Add(this.txtSearchBox);
            this.myGroupBox1.Controls.Add(this.lblVersions);
            this.myGroupBox1.Controls.Add(this.lblGameTitles);
            this.myGroupBox1.Controls.Add(this.lnlGbTitle);
            this.myGroupBox1.Controls.Add(this.prBar);
            this.myGroupBox1.Controls.Add(this.cmbVersions);
            this.myGroupBox1.Controls.Add(this.lblLoad);
            this.myGroupBox1.Controls.Add(this.cmbTitles);
            this.myGroupBox1.Location = new System.Drawing.Point(1, 32);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(200, 278);
            this.myGroupBox1.TabIndex = 10;
            this.myGroupBox1.TabStop = false;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(7, 21);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 17);
            this.lblFilter.TabIndex = 9;
            this.lblFilter.Text = "Filter:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(52, 21);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(145, 20);
            this.txtSearchBox.TabIndex = 8;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // lblVersions
            // 
            this.lblVersions.AutoSize = true;
            this.lblVersions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersions.Location = new System.Drawing.Point(7, 95);
            this.lblVersions.Name = "lblVersions";
            this.lblVersions.Size = new System.Drawing.Size(54, 17);
            this.lblVersions.TabIndex = 7;
            this.lblVersions.Text = "Version:";
            // 
            // lblGameTitles
            // 
            this.lblGameTitles.AutoSize = true;
            this.lblGameTitles.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitles.Location = new System.Drawing.Point(7, 48);
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
            this.cmbVersions.Location = new System.Drawing.Point(10, 115);
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
            this.cmbTitles.Location = new System.Drawing.Point(10, 71);
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
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblOtherAuthor);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.btnDownOther);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnDownUp);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.pbMinimalize);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "NUSGrabber GUI v1.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimalize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.myGroupBox1.ResumeLayout(false);
            this.myGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMinimalize;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnDownUp;
        private System.Windows.Forms.Button btnDownOther;
        private MayaMaya.myGroupBox myGroupBox1;
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
    }
}

