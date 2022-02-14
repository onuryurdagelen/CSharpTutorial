
namespace MetotParametreleri
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
            this.btnOkcu = new System.Windows.Forms.Button();
            this.btnMage = new System.Windows.Forms.Button();
            this.btnWarrior = new System.Windows.Forms.Button();
            this.btnAssassin = new System.Windows.Forms.Button();
            this.btnNpc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOkcu
            // 
            this.btnOkcu.Location = new System.Drawing.Point(95, 133);
            this.btnOkcu.Name = "btnOkcu";
            this.btnOkcu.Size = new System.Drawing.Size(144, 71);
            this.btnOkcu.TabIndex = 0;
            this.btnOkcu.Text = "Okcu";
            this.btnOkcu.UseVisualStyleBackColor = true;
            this.btnOkcu.Click += new System.EventHandler(this.btnOkcu_Click);
            // 
            // btnMage
            // 
            this.btnMage.Location = new System.Drawing.Point(291, 133);
            this.btnMage.Name = "btnMage";
            this.btnMage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMage.Size = new System.Drawing.Size(141, 71);
            this.btnMage.TabIndex = 1;
            this.btnMage.Text = "Buyucu";
            this.btnMage.UseVisualStyleBackColor = true;
            this.btnMage.Click += new System.EventHandler(this.btnMage_Click);
            // 
            // btnWarrior
            // 
            this.btnWarrior.Location = new System.Drawing.Point(483, 133);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(129, 71);
            this.btnWarrior.TabIndex = 2;
            this.btnWarrior.Text = "Warrior";
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.Click += new System.EventHandler(this.btnWarrior_Click);
            // 
            // btnAssassin
            // 
            this.btnAssassin.Location = new System.Drawing.Point(291, 261);
            this.btnAssassin.Name = "btnAssassin";
            this.btnAssassin.Size = new System.Drawing.Size(141, 64);
            this.btnAssassin.TabIndex = 3;
            this.btnAssassin.Text = "Suikastci";
            this.btnAssassin.UseVisualStyleBackColor = true;
            this.btnAssassin.Click += new System.EventHandler(this.btnAssassin_Click);
            // 
            // btnNpc
            // 
            this.btnNpc.Location = new System.Drawing.Point(483, 261);
            this.btnNpc.Name = "btnNpc";
            this.btnNpc.Size = new System.Drawing.Size(129, 64);
            this.btnNpc.TabIndex = 4;
            this.btnNpc.Text = "Npc";
            this.btnNpc.UseVisualStyleBackColor = true;
            this.btnNpc.Click += new System.EventHandler(this.btnNpc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNpc);
            this.Controls.Add(this.btnAssassin);
            this.Controls.Add(this.btnWarrior);
            this.Controls.Add(this.btnMage);
            this.Controls.Add(this.btnOkcu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOkcu;
        private System.Windows.Forms.Button btnMage;
        private System.Windows.Forms.Button btnWarrior;
        private System.Windows.Forms.Button btnAssassin;
        private System.Windows.Forms.Button btnNpc;
    }
}

