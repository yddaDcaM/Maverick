
namespace CSHarp_04
{
    partial class back_01
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
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_03 = new System.Windows.Forms.Button();
            this.txt_01 = new System.Windows.Forms.TextBox();
            this.txt_02 = new System.Windows.Forms.TextBox();
            this.lbl_01 = new System.Windows.Forms.Label();
            this.lbl_02 = new System.Windows.Forms.Label();
            this.lbl_03 = new System.Windows.Forms.Label();
            this.lbl_04 = new System.Windows.Forms.Label();
            this.lbl_05 = new System.Windows.Forms.Label();
            this.lbl_06 = new System.Windows.Forms.Label();
            this.txt_04 = new System.Windows.Forms.TextBox();
            this.txt_03 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_01
            // 
            this.btn_01.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_01.Location = new System.Drawing.Point(87, 568);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(205, 92);
            this.btn_01.TabIndex = 0;
            this.btn_01.Text = "儲存";
            this.btn_01.UseVisualStyleBackColor = true;
            this.btn_01.Click += new System.EventHandler(this.btn_01_Click);
            // 
            // btn_02
            // 
            this.btn_02.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_02.Location = new System.Drawing.Point(321, 568);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(205, 92);
            this.btn_02.TabIndex = 1;
            this.btn_02.Text = "顯示儲存內容";
            this.btn_02.UseVisualStyleBackColor = true;
            this.btn_02.Click += new System.EventHandler(this.btn_02_Click);
            // 
            // btn_03
            // 
            this.btn_03.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_03.Location = new System.Drawing.Point(573, 568);
            this.btn_03.Name = "btn_03";
            this.btn_03.Size = new System.Drawing.Size(432, 92);
            this.btn_03.TabIndex = 2;
            this.btn_03.Text = "最高分/最低分科目";
            this.btn_03.UseVisualStyleBackColor = true;
            this.btn_03.Click += new System.EventHandler(this.btn_03_Click);
            // 
            // txt_01
            // 
            this.txt_01.Location = new System.Drawing.Point(201, 97);
            this.txt_01.Name = "txt_01";
            this.txt_01.Size = new System.Drawing.Size(326, 29);
            this.txt_01.TabIndex = 3;
            this.txt_01.Text = "0";
            this.txt_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_02
            // 
            this.txt_02.Location = new System.Drawing.Point(201, 214);
            this.txt_02.Name = "txt_02";
            this.txt_02.Size = new System.Drawing.Size(326, 29);
            this.txt_02.TabIndex = 4;
            this.txt_02.Text = "0";
            this.txt_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_01.Location = new System.Drawing.Point(98, 93);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(87, 32);
            this.lbl_01.TabIndex = 7;
            this.lbl_01.Text = "姓名:";
            // 
            // lbl_02
            // 
            this.lbl_02.AutoSize = true;
            this.lbl_02.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_02.Location = new System.Drawing.Point(98, 210);
            this.lbl_02.Name = "lbl_02";
            this.lbl_02.Size = new System.Drawing.Size(87, 32);
            this.lbl_02.TabIndex = 8;
            this.lbl_02.Text = "國文:";
            // 
            // lbl_03
            // 
            this.lbl_03.AutoSize = true;
            this.lbl_03.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_03.Location = new System.Drawing.Point(98, 334);
            this.lbl_03.Name = "lbl_03";
            this.lbl_03.Size = new System.Drawing.Size(87, 32);
            this.lbl_03.TabIndex = 9;
            this.lbl_03.Text = "英文:";
            // 
            // lbl_04
            // 
            this.lbl_04.AutoSize = true;
            this.lbl_04.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_04.Location = new System.Drawing.Point(98, 453);
            this.lbl_04.Name = "lbl_04";
            this.lbl_04.Size = new System.Drawing.Size(87, 32);
            this.lbl_04.TabIndex = 10;
            this.lbl_04.Text = "數學:";
            // 
            // lbl_05
            // 
            this.lbl_05.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_05.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_05.Location = new System.Drawing.Point(570, 93);
            this.lbl_05.Name = "lbl_05";
            this.lbl_05.Size = new System.Drawing.Size(435, 336);
            this.lbl_05.TabIndex = 11;
            // 
            // lbl_06
            // 
            this.lbl_06.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_06.Location = new System.Drawing.Point(570, 444);
            this.lbl_06.Name = "lbl_06";
            this.lbl_06.Size = new System.Drawing.Size(435, 96);
            this.lbl_06.TabIndex = 12;
            // 
            // txt_04
            // 
            this.txt_04.Location = new System.Drawing.Point(200, 455);
            this.txt_04.Name = "txt_04";
            this.txt_04.Size = new System.Drawing.Size(326, 29);
            this.txt_04.TabIndex = 14;
            this.txt_04.Text = "0";
            this.txt_04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_03
            // 
            this.txt_03.Location = new System.Drawing.Point(200, 338);
            this.txt_03.Name = "txt_03";
            this.txt_03.Size = new System.Drawing.Size(326, 29);
            this.txt_03.TabIndex = 13;
            this.txt_03.Text = "0";
            this.txt_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // back_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 710);
            this.Controls.Add(this.txt_04);
            this.Controls.Add(this.txt_03);
            this.Controls.Add(this.lbl_06);
            this.Controls.Add(this.lbl_05);
            this.Controls.Add(this.lbl_04);
            this.Controls.Add(this.lbl_03);
            this.Controls.Add(this.lbl_02);
            this.Controls.Add(this.lbl_01);
            this.Controls.Add(this.txt_02);
            this.Controls.Add(this.txt_01);
            this.Controls.Add(this.btn_03);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.btn_01);
            this.Name = "back_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_03;
        private System.Windows.Forms.TextBox txt_01;
        private System.Windows.Forms.TextBox txt_02;
        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.Label lbl_02;
        private System.Windows.Forms.Label lbl_03;
        private System.Windows.Forms.Label lbl_04;
        private System.Windows.Forms.Label lbl_05;
        private System.Windows.Forms.Label lbl_06;
        private System.Windows.Forms.TextBox txt_04;
        private System.Windows.Forms.TextBox txt_03;
    }
}

