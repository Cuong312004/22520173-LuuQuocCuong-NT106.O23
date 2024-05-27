namespace Lab4
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBai7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBai7
            // 
            this.btnBai7.Location = new System.Drawing.Point(465, 237);
            this.btnBai7.Name = "btnBai7";
            this.btnBai7.Size = new System.Drawing.Size(154, 49);
            this.btnBai7.TabIndex = 0;
            this.btnBai7.Text = "Bài 7";
            this.btnBai7.UseVisualStyleBackColor = true;
            this.btnBai7.Click += new System.EventHandler(this.btnBai7_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBai7);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBai7;
    }
}

