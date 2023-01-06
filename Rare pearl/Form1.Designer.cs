namespace Rare_pearl
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
            this.tileBar1 = new System.Windows.Forms.Panel();
            this.btnSearchPage = new System.Windows.Forms.Button();
            this.btn_primary = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.tileBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileBar1.Controls.Add(this.btnSearchPage);
            this.tileBar1.Controls.Add(this.btn_primary);
            this.tileBar1.Controls.Add(this.btn_report);
            this.tileBar1.Controls.Add(this.btn_help);
            this.tileBar1.Controls.Add(this.btn_home);
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Size = new System.Drawing.Size(1384, 75);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Paint += new System.Windows.Forms.PaintEventHandler(this.tileBar1_Paint);
            // 
            // btnSearchPage
            // 
            this.btnSearchPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSearchPage.Location = new System.Drawing.Point(1007, 12);
            this.btnSearchPage.Name = "btnSearchPage";
            this.btnSearchPage.Size = new System.Drawing.Size(127, 45);
            this.btnSearchPage.TabIndex = 5;
            this.btnSearchPage.Text = "صفحة البحث";
            this.btnSearchPage.UseVisualStyleBackColor = false;
            this.btnSearchPage.Click += new System.EventHandler(this.btnSearchPage_Click);
            // 
            // btn_primary
            // 
            this.btn_primary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_primary.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_primary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_primary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_primary.Location = new System.Drawing.Point(1140, 12);
            this.btn_primary.Name = "btn_primary";
            this.btn_primary.Size = new System.Drawing.Size(113, 45);
            this.btn_primary.TabIndex = 4;
            this.btn_primary.Text = "اضبارة";
            this.btn_primary.UseVisualStyleBackColor = false;
            this.btn_primary.Click += new System.EventHandler(this.btn_primary_Click);
            // 
            // btn_report
            // 
            this.btn_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_report.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_report.Location = new System.Drawing.Point(604, 24);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(113, 45);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "طباعة تقرير";
            this.btn_report.UseVisualStyleBackColor = false;
            // 
            // btn_help
            // 
            this.btn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_help.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_help.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_help.Location = new System.Drawing.Point(735, 12);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(113, 45);
            this.btn_help.TabIndex = 3;
            this.btn_help.Text = "مساعدة";
            this.btn_help.UseVisualStyleBackColor = false;
            // 
            // btn_home
            // 
            this.btn_home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_home.Location = new System.Drawing.Point(1259, 12);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(113, 45);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "الرئيسية";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.Color.DimGray;
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 75);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1384, 613);
            this.panel_container.TabIndex = 1;
            this.panel_container.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_container_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 688);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.tileBar1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Pearl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tileBar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tileBar1;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_primary;
        private System.Windows.Forms.Button btnSearchPage;
    }
}

