namespace SoThuXiGon
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstThuMoi = new System.Windows.Forms.ListBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.bntChon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thú mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách thú";
            // 
            // lstThuMoi
            // 
            this.lstThuMoi.AllowDrop = true;
            this.lstThuMoi.FormattingEnabled = true;
            this.lstThuMoi.Items.AddRange(new object[] {
            "Chó",
            "Mèo",
            "Khỉ",
            "Sư tử",
            "Báo",
            "Trăn"});
            this.lstThuMoi.Location = new System.Drawing.Point(15, 26);
            this.lstThuMoi.Name = "lstThuMoi";
            this.lstThuMoi.Size = new System.Drawing.Size(135, 147);
            this.lstThuMoi.TabIndex = 2;
            this.lstThuMoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstThuMoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LisBox_MouseDown);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.AllowDrop = true;
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Location = new System.Drawing.Point(237, 26);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(135, 147);
            this.lstDanhSach.TabIndex = 3;
            this.lstDanhSach.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstDanhSach_DragDrop);
            this.lstDanhSach.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstDanhSach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LisBox_MouseDown);
            // 
            // bntChon
            // 
            this.bntChon.Location = new System.Drawing.Point(156, 66);
            this.bntChon.Name = "bntChon";
            this.bntChon.Size = new System.Drawing.Size(75, 23);
            this.bntChon.TabIndex = 4;
            this.bntChon.Text = "Chọn";
            this.bntChon.UseVisualStyleBackColor = true;
            this.bntChon.Click += new System.EventHandler(this.bntChon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 261);
            this.Controls.Add(this.bntChon);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.lstThuMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "So Thu Xi Gon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstThuMoi;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button bntChon;
    }
}

