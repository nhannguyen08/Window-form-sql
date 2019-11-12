namespace WindowsFormsApplication1
{
    partial class AddAnSangForm
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
            this.lbTenmon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTenmon
            // 
            this.lbTenmon.AutoSize = true;
            this.lbTenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenmon.Location = new System.Drawing.Point(39, 35);
            this.lbTenmon.Name = "lbTenmon";
            this.lbTenmon.Size = new System.Drawing.Size(75, 20);
            this.lbTenmon.TabIndex = 0;
            this.lbTenmon.Text = "Ten mon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gia tien:";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(137, 35);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(128, 20);
            this.txtTenMon.TabIndex = 2;
            this.txtTenMon.TextChanged += new System.EventHandler(this.txtTenMon_TextChanged);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(137, 109);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(128, 20);
            this.txtGiaTien.TabIndex = 3;
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.Location = new System.Drawing.Point(125, 158);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(75, 32);
            this.btnThemmoi.TabIndex = 4;
            this.btnThemmoi.Text = "Lưu";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            // 
            // AddAnSangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 202);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTenmon);
            this.Name = "AddAnSangForm";
            this.Text = "AddAnSangForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenmon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnThemmoi;
    }
}