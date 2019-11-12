namespace WindowsFormsApplication1
{
    partial class ViewAnSangFromm
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
            this.GRDAnSang = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddAnSang = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GRDAnSang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRDAnSang
            // 
            this.GRDAnSang.AllowUserToAddRows = false;
            this.GRDAnSang.AllowUserToDeleteRows = false;
            this.GRDAnSang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRDAnSang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GRDAnSang.Location = new System.Drawing.Point(0, 24);
            this.GRDAnSang.Name = "GRDAnSang";
            this.GRDAnSang.ReadOnly = true;
            this.GRDAnSang.Size = new System.Drawing.Size(681, 281);
            this.GRDAnSang.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAnSang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddAnSang
            // 
            this.btnAddAnSang.Name = "btnAddAnSang";
            this.btnAddAnSang.Size = new System.Drawing.Size(94, 20);
            this.btnAddAnSang.Text = "Them mon an";
            // 
            // ViewAnSangFromm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 305);
            this.Controls.Add(this.GRDAnSang);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewAnSangFromm";
            this.Text = "Danh sach cac mon an sang";
            ((System.ComponentModel.ISupportInitialize)(this.GRDAnSang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GRDAnSang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddAnSang;
    }
}

