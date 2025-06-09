namespace ContactList
{
    partial class MainForm
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
            this.btnThemLienHe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThemLienHe
            // 
            this.btnThemLienHe.Location = new System.Drawing.Point(16, 64);
            this.btnThemLienHe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemLienHe.Name = "btnThemLienHe";
            this.btnThemLienHe.Size = new System.Drawing.Size(156, 28);
            this.btnThemLienHe.TabIndex = 0;
            this.btnThemLienHe.Text = "Thêm liên hệ";
            this.btnThemLienHe.UseVisualStyleBackColor = true;
            this.btnThemLienHe.Click += new System.EventHandler(this.btnThemLienHe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách liên hệ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemLienHe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemLienHe;
        private System.Windows.Forms.Label label1;
    }
}