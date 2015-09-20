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
            this.label1 = new System.Windows.Forms.Label();
            this.myGroupBox1 = new MayaMaya.myGroupBox();
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
            this.pbMinimalize.Location = new System.Drawing.Point(207, 0);
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
            this.pbClose.Location = new System.Drawing.Point(263, 0);
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
            this.btnDownload.Location = new System.Drawing.Point(212, 51);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 23);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDownUp
            // 
            this.btnDownUp.Enabled = false;
            this.btnDownUp.Location = new System.Drawing.Point(212, 80);
            this.btnDownUp.Name = "btnDownUp";
            this.btnDownUp.Size = new System.Drawing.Size(100, 23);
            this.btnDownUp.TabIndex = 8;
            this.btnDownUp.Text = "Game Updates";
            this.btnDownUp.UseVisualStyleBackColor = true;
            this.btnDownUp.Click += new System.EventHandler(this.btnDownUp_Click);
            // 
            // btnDownOther
            // 
            this.btnDownOther.Enabled = false;
            this.btnDownOther.Location = new System.Drawing.Point(212, 109);
            this.btnDownOther.Name = "btnDownOther";
            this.btnDownOther.Size = new System.Drawing.Size(100, 23);
            this.btnDownOther.TabIndex = 9;
            this.btnDownOther.Text = "Other stuff";
            this.btnDownOther.UseVisualStyleBackColor = true;
            this.btnDownOther.Click += new System.EventHandler(this.btnDownOther_Click);
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleForm.Location = new System.Drawing.Point(12, 4);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(152, 21);
            this.lblTitleForm.TabIndex = 11;
            this.lblTitleForm.Text = "NUS grabber GUI vX";
            this.lblTitleForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lblTitleForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseMove);
            this.lblTitleForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(201, 262);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(118, 13);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "NUS grabber by crediar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "GUI by Adr990/Arndoid";
            // 
            // myGroupBox1
            // 
            this.myGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.myGroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.myGroupBox1.Controls.Add(this.prBar);
            this.myGroupBox1.Controls.Add(this.cmbVersions);
            this.myGroupBox1.Controls.Add(this.lblLoad);
            this.myGroupBox1.Controls.Add(this.cmbTitles);
            this.myGroupBox1.Location = new System.Drawing.Point(1, 32);
            this.myGroupBox1.Name = "myGroupBox1";
            this.myGroupBox1.Size = new System.Drawing.Size(200, 278);
            this.myGroupBox1.TabIndex = 10;
            this.myGroupBox1.TabStop = false;
            this.myGroupBox1.Text = "Game Updates";
            // 
            // prBar
            // 
            this.prBar.Location = new System.Drawing.Point(10, 104);
            this.prBar.Name = "prBar";
            this.prBar.Size = new System.Drawing.Size(183, 23);
            this.prBar.TabIndex = 3;
            // 
            // cmbVersions
            // 
            this.cmbVersions.FormattingEnabled = true;
            this.cmbVersions.Location = new System.Drawing.Point(6, 48);
            this.cmbVersions.Name = "cmbVersions";
            this.cmbVersions.Size = new System.Drawing.Size(121, 21);
            this.cmbVersions.TabIndex = 2;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.Location = new System.Drawing.Point(6, 79);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(130, 21);
            this.lblLoad.TabIndex = 1;
            this.lblLoad.Text = "Retrieving Titles...";
            // 
            // cmbTitles
            // 
            this.cmbTitles.FormattingEnabled = true;
            this.cmbTitles.Location = new System.Drawing.Point(6, 19);
            this.cmbTitles.Name = "cmbTitles";
            this.cmbTitles.Size = new System.Drawing.Size(187, 21);
            this.cmbTitles.TabIndex = 0;
            this.cmbTitles.TextChanged += new System.EventHandler(this.cmbTitles_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(319, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.myGroupBox1);
            this.Controls.Add(this.btnDownOther);
            this.Controls.Add(this.btnDownUp);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.pbMinimalize);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "NUS grabber GUI v1.2";
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
        private System.Windows.Forms.Label label1;
    }
}

