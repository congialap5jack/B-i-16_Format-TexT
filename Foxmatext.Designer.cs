namespace Bài_16_Format_TexT
{
    partial class Formatext
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
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.ListBox();
            this.Font = new System.Windows.Forms.ListBox();
            this.redRed = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lable = new System.Windows.Forms.Label();
            this.lblLaptrinh = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên:";
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(100, 21);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(209, 20);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.Text = "Tèo 2011";
            this.txtNhapTen.TextChanged += new System.EventHandler(this.txtNhapTen_TextChanged);
            // 
            // Color
            // 
            this.Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Color.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.ForeColor = System.Drawing.Color.Black;
            this.Color.FormattingEnabled = true;
            this.Color.ItemHeight = 16;
            this.Color.Location = new System.Drawing.Point(2, 91);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(149, 196);
            this.Color.TabIndex = 2;
            this.Color.UseWaitCursor = true;
            this.Color.SelectedIndexChanged += new System.EventHandler(this.Color_SelectedIndexChanged);
            // 
            // Font
            // 
            this.Font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Font.FormattingEnabled = true;
            this.Font.Location = new System.Drawing.Point(271, 91);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(149, 199);
            this.Font.TabIndex = 2;
            // 
            // redRed
            // 
            this.redRed.AutoSize = true;
            this.redRed.BackColor = System.Drawing.Color.White;
            this.redRed.ForeColor = System.Drawing.Color.Red;
            this.redRed.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.redRed.Location = new System.Drawing.Point(28, 126);
            this.redRed.Name = "redRed";
            this.redRed.Size = new System.Drawing.Size(45, 17);
            this.redRed.TabIndex = 3;
            this.redRed.TabStop = true;
            this.redRed.Text = "Red";
            this.redRed.UseVisualStyleBackColor = false;
            this.redRed.CheckedChanged += new System.EventHandler(this.redRed_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(28, 161);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(54, 17);
            this.radGreen.TabIndex = 3;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(28, 198);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(46, 17);
            this.radBlue.TabIndex = 3;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(28, 232);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(52, 17);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.ForeColor = System.Drawing.Color.Blue;
            this.chkBold.Location = new System.Drawing.Point(284, 117);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(71, 17);
            this.chkBold.TabIndex = 4;
            this.chkBold.Text = "Đậm bold";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkItalic.ForeColor = System.Drawing.Color.Blue;
            this.chkItalic.Location = new System.Drawing.Point(284, 161);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(91, 17);
            this.chkItalic.TabIndex = 4;
            this.chkItalic.Text = "Nghiêng Italic";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.Blue;
            this.checkBox3.Location = new System.Drawing.Point(284, 208);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Gạch Chân";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.ForeColor = System.Drawing.Color.Red;
            this.lable.Location = new System.Drawing.Point(12, 329);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(76, 13);
            this.lable.TabIndex = 5;
            this.lable.Text = "Lập Trình Bởi :";
            // 
            // lblLaptrinh
            // 
            this.lblLaptrinh.AutoSize = true;
            this.lblLaptrinh.Location = new System.Drawing.Point(116, 329);
            this.lblLaptrinh.Name = "lblLaptrinh";
            this.lblLaptrinh.Size = new System.Drawing.Size(53, 13);
            this.lblLaptrinh.TabIndex = 6;
            this.lblLaptrinh.Text = "Tèo 2011";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(264, 316);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 38);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Formatext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblLaptrinh);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.chkItalic);
            this.Controls.Add(this.chkBold);
            this.Controls.Add(this.radBlack);
            this.Controls.Add(this.radBlue);
            this.Controls.Add(this.radGreen);
            this.Controls.Add(this.redRed);
            this.Controls.Add(this.Font);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.label1);
            this.Name = "Formatext";
            this.Text = "Foxmatext";
            this.Load += new System.EventHandler(this.Foxmatext_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.ListBox Color;
        private System.Windows.Forms.ListBox Font;
        private System.Windows.Forms.RadioButton redRed;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lblLaptrinh;
        private System.Windows.Forms.Button btnThoat;
    }
}