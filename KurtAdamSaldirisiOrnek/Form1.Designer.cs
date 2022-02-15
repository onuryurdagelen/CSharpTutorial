
namespace KurtAdamSaldirisiOrnek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.cmbEthnicity = new System.Windows.Forms.ComboBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pcrWolf = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lblHealthText = new System.Windows.Forms.Label();
            this.lblMe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcrWolf)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(124, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ethnicity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(124, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Major:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(124, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weapon:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(257, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(181, 33);
            this.txtUsername.TabIndex = 4;
            // 
            // txtWeapon
            // 
            this.txtWeapon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeapon.Location = new System.Drawing.Point(257, 204);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(181, 33);
            this.txtWeapon.TabIndex = 7;
            // 
            // cmbEthnicity
            // 
            this.cmbEthnicity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEthnicity.FormattingEnabled = true;
            this.cmbEthnicity.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbEthnicity.Location = new System.Drawing.Point(257, 95);
            this.cmbEthnicity.Name = "cmbEthnicity";
            this.cmbEthnicity.Size = new System.Drawing.Size(181, 33);
            this.cmbEthnicity.TabIndex = 8;
            // 
            // cmbMajor
            // 
            this.cmbMajor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Archer",
            "Assassin"});
            this.cmbMajor.Location = new System.Drawing.Point(257, 151);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(181, 33);
            this.cmbMajor.TabIndex = 9;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.Location = new System.Drawing.Point(672, 75);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(165, 53);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pcrWolf
            // 
            this.pcrWolf.Image = global::KurtAdamSaldirisiOrnek.Properties.Resources.kurtadam;
            this.pcrWolf.Location = new System.Drawing.Point(585, 258);
            this.pcrWolf.Name = "pcrWolf";
            this.pcrWolf.Size = new System.Drawing.Size(364, 180);
            this.pcrWolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrWolf.TabIndex = 11;
            this.pcrWolf.TabStop = false;
            this.pcrWolf.Visible = false;
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Red;
            this.lblHealth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHealth.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblHealth.Location = new System.Drawing.Point(585, 196);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(364, 41);
            this.lblHealth.TabIndex = 12;
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHealth.Visible = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAttack.Location = new System.Drawing.Point(235, 374);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(203, 64);
            this.btnAttack.TabIndex = 13;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lblHealthText
            // 
            this.lblHealthText.AutoSize = true;
            this.lblHealthText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHealthText.Location = new System.Drawing.Point(118, 303);
            this.lblHealthText.Name = "lblHealthText";
            this.lblHealthText.Size = new System.Drawing.Size(114, 25);
            this.lblHealthText.TabIndex = 14;
            this.lblHealthText.Text = "Your Health:";
            this.lblHealthText.Visible = false;
            // 
            // lblMe
            // 
            this.lblMe.AutoSize = true;
            this.lblMe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMe.Location = new System.Drawing.Point(247, 307);
            this.lblMe.Name = "lblMe";
            this.lblMe.Size = new System.Drawing.Size(0, 21);
            this.lblMe.TabIndex = 15;
            this.lblMe.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 508);
            this.Controls.Add(this.lblMe);
            this.Controls.Add(this.lblHealthText);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.pcrWolf);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.cmbEthnicity);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcrWolf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.ComboBox cmbEthnicity;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pcrWolf;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblHealthText;
        private System.Windows.Forms.Label lblMe;
    }
}

