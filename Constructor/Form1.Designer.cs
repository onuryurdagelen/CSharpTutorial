
namespace Constructor
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnCreateEasely = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(280, 88);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(150, 23);
            this.txtProduct.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(191, 169);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(168, 55);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "ADD NEW PRODUCT";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnCreateEasely
            // 
            this.btnCreateEasely.Location = new System.Drawing.Point(412, 169);
            this.btnCreateEasely.Name = "btnCreateEasely";
            this.btnCreateEasely.Size = new System.Drawing.Size(168, 55);
            this.btnCreateEasely.TabIndex = 2;
            this.btnCreateEasely.Text = "EASELY CREATE PRODUCT";
            this.btnCreateEasely.UseVisualStyleBackColor = true;
            this.btnCreateEasely.Click += new System.EventHandler(this.btnCreateEasely_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateEasely);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCreateEasely;
    }
}

