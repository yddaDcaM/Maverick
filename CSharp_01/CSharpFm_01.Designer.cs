﻿
namespace CSharp_01
{
    partial class CSharpFm_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_01 = new System.Windows.Forms.TextBox();
            this.txt_02 = new System.Windows.Forms.TextBox();
            this.txt_03 = new System.Windows.Forms.TextBox();
            this.txt_04 = new System.Windows.Forms.TextBox();
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(258, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(142, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "English Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(258, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "性別:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(258, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "星座:";
            // 
            // txt_01
            // 
            this.txt_01.Location = new System.Drawing.Point(378, 69);
            this.txt_01.Name = "txt_01";
            this.txt_01.Size = new System.Drawing.Size(296, 29);
            this.txt_01.TabIndex = 4;
            // 
            // txt_02
            // 
            this.txt_02.Location = new System.Drawing.Point(378, 157);
            this.txt_02.Name = "txt_02";
            this.txt_02.Size = new System.Drawing.Size(296, 29);
            this.txt_02.TabIndex = 5;
            // 
            // txt_03
            // 
            this.txt_03.Location = new System.Drawing.Point(378, 237);
            this.txt_03.Name = "txt_03";
            this.txt_03.Size = new System.Drawing.Size(296, 29);
            this.txt_03.TabIndex = 6;
            // 
            // txt_04
            // 
            this.txt_04.Location = new System.Drawing.Point(378, 313);
            this.txt_04.Name = "txt_04";
            this.txt_04.Size = new System.Drawing.Size(296, 29);
            this.txt_04.TabIndex = 7;
            // 
            // btn_01
            // 
            this.btn_01.Location = new System.Drawing.Point(163, 414);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(275, 102);
            this.btn_01.TabIndex = 8;
            this.btn_01.Text = "HELLO";
            this.btn_01.UseVisualStyleBackColor = true;
            this.btn_01.Click += new System.EventHandler(this.btn_01_Click);
            // 
            // btn_02
            // 
            this.btn_02.Location = new System.Drawing.Point(491, 414);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(275, 102);
            this.btn_02.TabIndex = 9;
            this.btn_02.Text = "HI";
            this.btn_02.UseVisualStyleBackColor = true;
            this.btn_02.Click += new System.EventHandler(this.btn_02_Click_1);
            // 
            // CSharpFm_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 577);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.btn_01);
            this.Controls.Add(this.txt_04);
            this.Controls.Add(this.txt_03);
            this.Controls.Add(this.txt_02);
            this.Controls.Add(this.txt_01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CSharpFm_01";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_01;
        private System.Windows.Forms.TextBox txt_02;
        private System.Windows.Forms.TextBox txt_03;
        private System.Windows.Forms.TextBox txt_04;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_02;
    }
}

