
namespace insert_image_to_pdf
{
    partial class frmMain
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtY2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtX2 = new MetroFramework.Controls.MetroTextBox();
            this.txtY1 = new MetroFramework.Controls.MetroTextBox();
            this.txtX1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.pgbMain = new MetroFramework.Controls.MetroProgressBar();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtOutput = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.txtImg = new MetroFramework.Controls.MetroTextBox();
            this.txtPdf = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bwMain = new System.ComponentModel.BackgroundWorker();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.txtY2);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtX2);
            this.metroPanel1.Controls.Add(this.txtY1);
            this.metroPanel1.Controls.Add(this.txtX1);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.pgbMain);
            this.metroPanel1.Controls.Add(this.btnOutput);
            this.metroPanel1.Controls.Add(this.txtOutput);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.btnGenerate);
            this.metroPanel1.Controls.Add(this.btnImg);
            this.metroPanel1.Controls.Add(this.btnPdf);
            this.metroPanel1.Controls.Add(this.txtImg);
            this.metroPanel1.Controls.Add(this.txtPdf);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(443, 277);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtY2
            // 
            this.txtY2.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtY2.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtY2.Location = new System.Drawing.Point(368, 168);
            this.txtY2.Multiline = false;
            this.txtY2.Name = "txtY2";
            this.txtY2.SelectedText = "";
            this.txtY2.Size = new System.Drawing.Size(42, 23);
            this.txtY2.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtY2.StyleManager = null;
            this.txtY2.TabIndex = 20;
            this.txtY2.Text = "110";
            this.txtY2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtY2.UseStyleColors = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.CustomBackground = false;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel7.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel7.Location = new System.Drawing.Point(333, 169);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(31, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.StyleManager = null;
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Y2 :";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel7.UseStyleColors = false;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.CustomBackground = false;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel6.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel6.Location = new System.Drawing.Point(129, 169);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(31, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.StyleManager = null;
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "X2 :";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel6.UseStyleColors = false;
            // 
            // txtX2
            // 
            this.txtX2.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtX2.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtX2.Location = new System.Drawing.Point(166, 168);
            this.txtX2.Multiline = false;
            this.txtX2.Name = "txtX2";
            this.txtX2.SelectedText = "";
            this.txtX2.Size = new System.Drawing.Size(42, 23);
            this.txtX2.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtX2.StyleManager = null;
            this.txtX2.TabIndex = 17;
            this.txtX2.Text = "85";
            this.txtX2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtX2.UseStyleColors = false;
            // 
            // txtY1
            // 
            this.txtY1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtY1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtY1.Location = new System.Drawing.Point(274, 168);
            this.txtY1.Multiline = false;
            this.txtY1.Name = "txtY1";
            this.txtY1.SelectedText = "";
            this.txtY1.Size = new System.Drawing.Size(42, 23);
            this.txtY1.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtY1.StyleManager = null;
            this.txtY1.TabIndex = 16;
            this.txtY1.Text = "5";
            this.txtY1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtY1.UseStyleColors = false;
            // 
            // txtX1
            // 
            this.txtX1.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtX1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtX1.Location = new System.Drawing.Point(63, 169);
            this.txtX1.Multiline = false;
            this.txtX1.Name = "txtX1";
            this.txtX1.SelectedText = "";
            this.txtX1.Size = new System.Drawing.Size(42, 23);
            this.txtX1.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtX1.StyleManager = null;
            this.txtX1.TabIndex = 15;
            this.txtX1.Text = "85";
            this.txtX1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtX1.UseStyleColors = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.CustomBackground = false;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel5.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel5.Location = new System.Drawing.Point(239, 169);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(29, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.StyleManager = null;
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Y1 :";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel5.UseStyleColors = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.CustomBackground = false;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel4.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel4.Location = new System.Drawing.Point(20, 169);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(37, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.StyleManager = null;
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "X1 :  ";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = false;
            // 
            // pgbMain
            // 
            this.pgbMain.FontSize = MetroFramework.MetroProgressBarSize.Medium;
            this.pgbMain.FontWeight = MetroFramework.MetroProgressBarWeight.Light;
            this.pgbMain.HideProgressText = true;
            this.pgbMain.Location = new System.Drawing.Point(22, 223);
            this.pgbMain.Name = "pgbMain";
            this.pgbMain.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbMain.Size = new System.Drawing.Size(223, 23);
            this.pgbMain.Style = MetroFramework.MetroColorStyle.Blue;
            this.pgbMain.StyleManager = null;
            this.pgbMain.TabIndex = 12;
            this.pgbMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pgbMain.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnOutput
            // 
            this.btnOutput.BackgroundImage = global::insert_image_to_pdf.Properties.Resources.magnifier;
            this.btnOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOutput.Location = new System.Drawing.Point(367, 120);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(39, 23);
            this.btnOutput.TabIndex = 11;
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtOutput.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtOutput.Location = new System.Drawing.Point(128, 120);
            this.txtOutput.Multiline = false;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.SelectedText = "";
            this.txtOutput.Size = new System.Drawing.Size(223, 23);
            this.txtOutput.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOutput.StyleManager = null;
            this.txtOutput.TabIndex = 10;
            this.txtOutput.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOutput.UseStyleColors = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.CustomBackground = false;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel3.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel3.Location = new System.Drawing.Point(32, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.StyleManager = null;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Output Path : ";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Highlight = false;
            this.btnGenerate.Location = new System.Drawing.Point(331, 223);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 35);
            this.btnGenerate.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGenerate.StyleManager = null;
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnImg
            // 
            this.btnImg.BackgroundImage = global::insert_image_to_pdf.Properties.Resources.magnifier;
            this.btnImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImg.Location = new System.Drawing.Point(367, 77);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(39, 23);
            this.btnImg.TabIndex = 7;
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = global::insert_image_to_pdf.Properties.Resources.magnifier;
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPdf.Location = new System.Drawing.Point(367, 37);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(39, 23);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // txtImg
            // 
            this.txtImg.Enabled = false;
            this.txtImg.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtImg.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtImg.Location = new System.Drawing.Point(128, 77);
            this.txtImg.Multiline = false;
            this.txtImg.Name = "txtImg";
            this.txtImg.SelectedText = "";
            this.txtImg.Size = new System.Drawing.Size(223, 23);
            this.txtImg.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtImg.StyleManager = null;
            this.txtImg.TabIndex = 5;
            this.txtImg.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImg.UseStyleColors = false;
            // 
            // txtPdf
            // 
            this.txtPdf.Enabled = false;
            this.txtPdf.FontSize = MetroFramework.MetroTextBoxSize.Small;
            this.txtPdf.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.txtPdf.Location = new System.Drawing.Point(128, 37);
            this.txtPdf.Multiline = false;
            this.txtPdf.Name = "txtPdf";
            this.txtPdf.SelectedText = "";
            this.txtPdf.Size = new System.Drawing.Size(223, 23);
            this.txtPdf.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPdf.StyleManager = null;
            this.txtPdf.TabIndex = 4;
            this.txtPdf.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPdf.UseStyleColors = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.CustomBackground = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel2.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel2.Location = new System.Drawing.Point(41, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.StyleManager = null;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Image File : ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(54, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "PDF File : ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // bwMain
            // 
            this.bwMain.WorkerReportsProgress = true;
            this.bwMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwMain_DoWork);
            this.bwMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwMain_ProgressChanged);
            this.bwMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwMain_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 357);
            this.Controls.Add(this.metroPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMain";
            this.Text = "Insert Image to PDF";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtImg;
        private MetroFramework.Controls.MetroTextBox txtPdf;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnPdf;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private System.Windows.Forms.Button btnOutput;
        private MetroFramework.Controls.MetroTextBox txtOutput;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressBar pgbMain;
        private System.ComponentModel.BackgroundWorker bwMain;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtY1;
        private MetroFramework.Controls.MetroTextBox txtX1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtX2;
        private MetroFramework.Controls.MetroTextBox txtY2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}

