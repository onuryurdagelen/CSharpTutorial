
namespace outKeyword
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnZar1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblNumber3 = new System.Windows.Forms.Label();
            this.lblNumber4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnZar1
            // 
            this.btnZar1.AutoSize = true;
            this.btnZar1.Location = new System.Drawing.Point(102, 89);
            this.btnZar1.Name = "btnZar1";
            this.btnZar1.Size = new System.Drawing.Size(38, 15);
            this.btnZar1.TabIndex = 0;
            this.btnZar1.Text = "1.ZAR";
            this.btnZar1.Click += new System.EventHandler(this.btnZar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "1.ZAR";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(170, 89);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(0, 15);
            this.lblNumber1.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(287, 224);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(157, 72);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblNumber3
            // 
            this.lblNumber3.AutoSize = true;
            this.lblNumber3.Location = new System.Drawing.Point(215, 89);
            this.lblNumber3.Name = "lblNumber3";
            this.lblNumber3.Size = new System.Drawing.Size(0, 15);
            this.lblNumber3.TabIndex = 5;
            // 
            // lblNumber4
            // 
            this.lblNumber4.AutoSize = true;
            this.lblNumber4.Location = new System.Drawing.Point(605, 89);
            this.lblNumber4.Name = "lblNumber4";
            this.lblNumber4.Size = new System.Drawing.Size(0, 15);
            this.lblNumber4.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumber4);
            this.Controls.Add(this.lblNumber3);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnZar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblNumber3;
        private System.Windows.Forms.Label lblNumber4;
    }
}

