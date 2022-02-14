
namespace Methods
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
            this.reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.increment = new System.Windows.Forms.Button();
            this.decrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(310, 192);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(128, 46);
            this.reset.TabIndex = 0;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(364, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 1;
            // 
            // increment
            // 
            this.increment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.increment.Location = new System.Drawing.Point(116, 192);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(127, 46);
            this.increment.TabIndex = 2;
            this.increment.Text = "+";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // decrement
            // 
            this.decrement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decrement.Location = new System.Drawing.Point(513, 192);
            this.decrement.Name = "decrement";
            this.decrement.Size = new System.Drawing.Size(129, 46);
            this.decrement.TabIndex = 3;
            this.decrement.Text = "-";
            this.decrement.UseVisualStyleBackColor = true;
            this.decrement.Click += new System.EventHandler(this.decrement_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decrement);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Button decrement;
    }
}

