
namespace CSharp_02
{
    partial class CsharpFm_02
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
            this.lab_01 = new System.Windows.Forms.Label();
            this.lab_02 = new System.Windows.Forms.Label();
            this.lab_03 = new System.Windows.Forms.Label();
            this.lab_04 = new System.Windows.Forms.Label();
            this.but_01 = new System.Windows.Forms.Button();
            this.but_02 = new System.Windows.Forms.Button();
            this.but_03 = new System.Windows.Forms.Button();
            this.txt_01 = new System.Windows.Forms.TextBox();
            this.txt_02 = new System.Windows.Forms.TextBox();
            this.txt_03 = new System.Windows.Forms.TextBox();
            this.txt_04 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab_01
            // 
            this.lab_01.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_01.Location = new System.Drawing.Point(464, 66);
            this.lab_01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_01.Name = "lab_01";
            this.lab_01.Size = new System.Drawing.Size(152, 56);
            this.lab_01.TabIndex = 0;
            this.lab_01.Text = "貸款金額";
            this.lab_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_02
            // 
            this.lab_02.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_02.Location = new System.Drawing.Point(464, 166);
            this.lab_02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_02.Name = "lab_02";
            this.lab_02.Size = new System.Drawing.Size(152, 56);
            this.lab_02.TabIndex = 0;
            this.lab_02.Text = "期限(年)";
            this.lab_02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_03
            // 
            this.lab_03.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_03.Location = new System.Drawing.Point(464, 264);
            this.lab_03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_03.Name = "lab_03";
            this.lab_03.Size = new System.Drawing.Size(152, 56);
            this.lab_03.TabIndex = 0;
            this.lab_03.Text = "利率(%)";
            this.lab_03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_04
            // 
            this.lab_04.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_04.Location = new System.Drawing.Point(464, 357);
            this.lab_04.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_04.Name = "lab_04";
            this.lab_04.Size = new System.Drawing.Size(152, 56);
            this.lab_04.TabIndex = 0;
            this.lab_04.Text = "頭期款";
            this.lab_04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_01
            // 
            this.but_01.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_01.Location = new System.Drawing.Point(495, 468);
            this.but_01.Margin = new System.Windows.Forms.Padding(4);
            this.but_01.Name = "but_01";
            this.but_01.Size = new System.Drawing.Size(178, 106);
            this.but_01.TabIndex = 1;
            this.but_01.Text = "PMT(月)";
            this.but_01.UseVisualStyleBackColor = true;
            this.but_01.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_02
            // 
            this.but_02.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_02.Location = new System.Drawing.Point(722, 468);
            this.but_02.Margin = new System.Windows.Forms.Padding(4);
            this.but_02.Name = "but_02";
            this.but_02.Size = new System.Drawing.Size(178, 106);
            this.but_02.TabIndex = 1;
            this.but_02.Text = "總付款";
            this.but_02.UseVisualStyleBackColor = true;
            this.but_02.Click += new System.EventHandler(this.but_02_Click);
            // 
            // but_03
            // 
            this.but_03.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_03.Location = new System.Drawing.Point(951, 468);
            this.but_03.Margin = new System.Windows.Forms.Padding(4);
            this.but_03.Name = "but_03";
            this.but_03.Size = new System.Drawing.Size(178, 106);
            this.but_03.TabIndex = 1;
            this.but_03.Text = "Report";
            this.but_03.UseVisualStyleBackColor = true;
            // 
            // txt_01
            // 
            this.txt_01.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_01.Location = new System.Drawing.Point(642, 72);
            this.txt_01.Margin = new System.Windows.Forms.Padding(4);
            this.txt_01.Name = "txt_01";
            this.txt_01.Size = new System.Drawing.Size(486, 36);
            this.txt_01.TabIndex = 2;
            this.txt_01.Text = "100000";
            // 
            // txt_02
            // 
            this.txt_02.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_02.Location = new System.Drawing.Point(642, 176);
            this.txt_02.Margin = new System.Windows.Forms.Padding(4);
            this.txt_02.Name = "txt_02";
            this.txt_02.Size = new System.Drawing.Size(486, 36);
            this.txt_02.TabIndex = 2;
            this.txt_02.Text = "2";
            // 
            // txt_03
            // 
            this.txt_03.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_03.Location = new System.Drawing.Point(642, 278);
            this.txt_03.Margin = new System.Windows.Forms.Padding(4);
            this.txt_03.Name = "txt_03";
            this.txt_03.Size = new System.Drawing.Size(486, 36);
            this.txt_03.TabIndex = 2;
            this.txt_03.Text = "10";
            // 
            // txt_04
            // 
            this.txt_04.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_04.Location = new System.Drawing.Point(642, 370);
            this.txt_04.Margin = new System.Windows.Forms.Padding(4);
            this.txt_04.Name = "txt_04";
            this.txt_04.Size = new System.Drawing.Size(486, 36);
            this.txt_04.TabIndex = 2;
            this.txt_04.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.txt_04);
            this.Controls.Add(this.txt_03);
            this.Controls.Add(this.txt_02);
            this.Controls.Add(this.txt_01);
            this.Controls.Add(this.but_03);
            this.Controls.Add(this.but_02);
            this.Controls.Add(this.but_01);
            this.Controls.Add(this.lab_04);
            this.Controls.Add(this.lab_03);
            this.Controls.Add(this.lab_02);
            this.Controls.Add(this.lab_01);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_01;
        private System.Windows.Forms.Label lab_02;
        private System.Windows.Forms.Label lab_03;
        private System.Windows.Forms.Label lab_04;
        private System.Windows.Forms.Button but_01;
        private System.Windows.Forms.Button but_02;
        private System.Windows.Forms.Button but_03;
        private System.Windows.Forms.TextBox txt_01;
        private System.Windows.Forms.TextBox txt_02;
        private System.Windows.Forms.TextBox txt_03;
        private System.Windows.Forms.TextBox txt_04;
    }
}

