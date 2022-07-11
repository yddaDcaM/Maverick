
namespace CSharp_worktable
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_06 = new System.Windows.Forms.Button();
            this.btn_05 = new System.Windows.Forms.Button();
            this.btn_04 = new System.Windows.Forms.Button();
            this.btn_03 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.BackgroundImage")));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1817, 1205);
            this.splitContainer1.SplitterDistance = 347;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel1.Controls.Add(this.btn_06);
            this.splitContainer2.Panel1.Controls.Add(this.btn_05);
            this.splitContainer2.Panel1.Controls.Add(this.btn_04);
            this.splitContainer2.Panel1.Controls.Add(this.btn_03);
            this.splitContainer2.Panel1.Controls.Add(this.btn_02);
            this.splitContainer2.Panel1.Controls.Add(this.btn_01);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer2.Size = new System.Drawing.Size(1817, 854);
            this.splitContainer2.SplitterDistance = 366;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // btn_06
            // 
            this.btn_06.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_06.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_06.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_06.Location = new System.Drawing.Point(49, 670);
            this.btn_06.Name = "btn_06";
            this.btn_06.Size = new System.Drawing.Size(259, 63);
            this.btn_06.TabIndex = 5;
            this.btn_06.Text = "My Clac";
            this.btn_06.UseVisualStyleBackColor = false;
            this.btn_06.Click += new System.EventHandler(this.btn_06_Click);
            // 
            // btn_05
            // 
            this.btn_05.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_05.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_05.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_05.Location = new System.Drawing.Point(49, 550);
            this.btn_05.Name = "btn_05";
            this.btn_05.Size = new System.Drawing.Size(259, 63);
            this.btn_05.TabIndex = 4;
            this.btn_05.Text = "Students Grade";
            this.btn_05.UseVisualStyleBackColor = false;
            this.btn_05.Click += new System.EventHandler(this.btn_05_Click);
            // 
            // btn_04
            // 
            this.btn_04.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_04.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_04.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_04.Location = new System.Drawing.Point(49, 430);
            this.btn_04.Name = "btn_04";
            this.btn_04.Size = new System.Drawing.Size(259, 63);
            this.btn_04.TabIndex = 3;
            this.btn_04.Text = "Student Struck Form";
            this.btn_04.UseVisualStyleBackColor = false;
            this.btn_04.Click += new System.EventHandler(this.btn_04_Click);
            // 
            // btn_03
            // 
            this.btn_03.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_03.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_03.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_03.Location = new System.Drawing.Point(49, 305);
            this.btn_03.Name = "btn_03";
            this.btn_03.Size = new System.Drawing.Size(259, 63);
            this.btn_03.TabIndex = 2;
            this.btn_03.Text = "Like Some Drinks?";
            this.btn_03.UseVisualStyleBackColor = false;
            this.btn_03.Click += new System.EventHandler(this.btn_03_Click);
            // 
            // btn_02
            // 
            this.btn_02.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_02.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_02.Location = new System.Drawing.Point(49, 185);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(259, 63);
            this.btn_02.TabIndex = 1;
            this.btn_02.Text = "Withdraw?";
            this.btn_02.UseVisualStyleBackColor = false;
            this.btn_02.Click += new System.EventHandler(this.btn_02_Click);
            // 
            // btn_01
            // 
            this.btn_01.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_01.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_01.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_01.Location = new System.Drawing.Point(49, 65);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(259, 63);
            this.btn_01.TabIndex = 0;
            this.btn_01.Text = "HELLO";
            this.btn_01.UseVisualStyleBackColor = false;
            this.btn_01.Click += new System.EventHandler(this.btn_01_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 1205);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_06;
        private System.Windows.Forms.Button btn_05;
        private System.Windows.Forms.Button btn_04;
        private System.Windows.Forms.Button btn_03;
        private System.Windows.Forms.Button btn_02;
    }
}

