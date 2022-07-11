
namespace CSharp_08
{
    partial class CSharpFm_08
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_04 = new System.Windows.Forms.Button();
            this.btn_03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_01
            // 
            this.btn_01.BackColor = System.Drawing.Color.MistyRose;
            this.btn_01.Location = new System.Drawing.Point(529, 80);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(109, 51);
            this.btn_01.TabIndex = 0;
            this.btn_01.Text = "+";
            this.btn_01.UseVisualStyleBackColor = false;
            this.btn_01.Click += new System.EventHandler(this.btn_01_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(161, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Num1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(161, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Num2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(161, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "==================";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(161, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "ANS:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 29);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(293, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 29);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(293, 316);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 29);
            this.textBox3.TabIndex = 7;
            // 
            // btn_02
            // 
            this.btn_02.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_02.Location = new System.Drawing.Point(529, 152);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(109, 51);
            this.btn_02.TabIndex = 8;
            this.btn_02.Text = "-";
            this.btn_02.UseVisualStyleBackColor = false;
            this.btn_02.Click += new System.EventHandler(this.btn_02_Click);
            // 
            // btn_04
            // 
            this.btn_04.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_04.Location = new System.Drawing.Point(529, 296);
            this.btn_04.Name = "btn_04";
            this.btn_04.Size = new System.Drawing.Size(109, 51);
            this.btn_04.TabIndex = 10;
            this.btn_04.Text = "/";
            this.btn_04.UseVisualStyleBackColor = false;
            this.btn_04.Click += new System.EventHandler(this.btn_04_Click);
            // 
            // btn_03
            // 
            this.btn_03.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_03.Location = new System.Drawing.Point(529, 224);
            this.btn_03.Name = "btn_03";
            this.btn_03.Size = new System.Drawing.Size(109, 51);
            this.btn_03.TabIndex = 9;
            this.btn_03.Text = "x";
            this.btn_03.UseVisualStyleBackColor = false;
            this.btn_03.Click += new System.EventHandler(this.btn_03_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_04);
            this.Controls.Add(this.btn_03);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_04;
        private System.Windows.Forms.Button btn_03;
    }
}

