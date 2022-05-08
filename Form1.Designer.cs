namespace form_font
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTahoma = new System.Windows.Forms.RadioButton();
            this.rdoVnVogue = new System.Windows.Forms.RadioButton();
            this.rdoVnUniverse = new System.Windows.Forms.RadioButton();
            this.rdoVnTime = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbUnderLine = new System.Windows.Forms.CheckBox();
            this.ckbStrikeout = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoTim = new System.Windows.Forms.RadioButton();
            this.rdoVang = new System.Windows.Forms.RadioButton();
            this.rdoDo = new System.Windows.Forms.RadioButton();
            this.rdoXanh = new System.Windows.Forms.RadioButton();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtnhapten = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTahoma);
            this.groupBox1.Controls.Add(this.rdoVnVogue);
            this.groupBox1.Controls.Add(this.rdoVnUniverse);
            this.groupBox1.Controls.Add(this.rdoVnTime);
            this.groupBox1.Location = new System.Drawing.Point(88, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu Font";
            // 
            // rdoTahoma
            // 
            this.rdoTahoma.AutoSize = true;
            this.rdoTahoma.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTahoma.Location = new System.Drawing.Point(7, 161);
            this.rdoTahoma.Name = "rdoTahoma";
            this.rdoTahoma.Size = new System.Drawing.Size(75, 19);
            this.rdoTahoma.TabIndex = 3;
            this.rdoTahoma.TabStop = true;
            this.rdoTahoma.Text = "Tahoma";
            this.rdoTahoma.UseVisualStyleBackColor = true;
            this.rdoTahoma.CheckedChanged += new System.EventHandler(this.rdoTahoma_CheckedChanged);
            // 
            // rdoVnVogue
            // 
            this.rdoVnVogue.AutoSize = true;
            this.rdoVnVogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVnVogue.Location = new System.Drawing.Point(7, 121);
            this.rdoVnVogue.Name = "rdoVnVogue";
            this.rdoVnVogue.Size = new System.Drawing.Size(88, 20);
            this.rdoVnVogue.TabIndex = 2;
            this.rdoVnVogue.TabStop = true;
            this.rdoVnVogue.Text = "VnVogue";
            this.rdoVnVogue.UseVisualStyleBackColor = true;
            this.rdoVnVogue.CheckedChanged += new System.EventHandler(this.rdoVnVogue_CheckedChanged);
            // 
            // rdoVnUniverse
            // 
            this.rdoVnUniverse.AutoSize = true;
            this.rdoVnUniverse.Location = new System.Drawing.Point(7, 78);
            this.rdoVnUniverse.Name = "rdoVnUniverse";
            this.rdoVnUniverse.Size = new System.Drawing.Size(80, 17);
            this.rdoVnUniverse.TabIndex = 1;
            this.rdoVnUniverse.TabStop = true;
            this.rdoVnUniverse.Text = "VnUniverse";
            this.rdoVnUniverse.UseVisualStyleBackColor = true;
            this.rdoVnUniverse.CheckedChanged += new System.EventHandler(this.rdoVnUniverse_CheckedChanged);
            // 
            // rdoVnTime
            // 
            this.rdoVnTime.AutoSize = true;
            this.rdoVnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVnTime.Location = new System.Drawing.Point(7, 34);
            this.rdoVnTime.Name = "rdoVnTime";
            this.rdoVnTime.Size = new System.Drawing.Size(67, 19);
            this.rdoVnTime.TabIndex = 0;
            this.rdoVnTime.TabStop = true;
            this.rdoVnTime.Text = "VnTime";
            this.rdoVnTime.UseVisualStyleBackColor = true;
            this.rdoVnTime.CheckedChanged += new System.EventHandler(this.rdoVnTime_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbUnderLine);
            this.groupBox2.Controls.Add(this.ckbStrikeout);
            this.groupBox2.Controls.Add(this.ckbItalic);
            this.groupBox2.Controls.Add(this.ckbBold);
            this.groupBox2.Location = new System.Drawing.Point(318, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiệu ứng";
            // 
            // ckbUnderLine
            // 
            this.ckbUnderLine.AutoSize = true;
            this.ckbUnderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUnderLine.Location = new System.Drawing.Point(6, 162);
            this.ckbUnderLine.Name = "ckbUnderLine";
            this.ckbUnderLine.Size = new System.Drawing.Size(102, 21);
            this.ckbUnderLine.TabIndex = 3;
            this.ckbUnderLine.Text = "UnderLine";
            this.ckbUnderLine.UseVisualStyleBackColor = true;
            this.ckbUnderLine.CheckedChanged += new System.EventHandler(this.ckbUnderLine_CheckedChanged);
            // 
            // ckbStrikeout
            // 
            this.ckbStrikeout.AutoSize = true;
            this.ckbStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStrikeout.Location = new System.Drawing.Point(6, 121);
            this.ckbStrikeout.Name = "ckbStrikeout";
            this.ckbStrikeout.Size = new System.Drawing.Size(87, 20);
            this.ckbStrikeout.TabIndex = 2;
            this.ckbStrikeout.Text = "Strikeout";
            this.ckbStrikeout.UseVisualStyleBackColor = true;
            this.ckbStrikeout.CheckedChanged += new System.EventHandler(this.ckbStrikeout_CheckedChanged);
            // 
            // ckbItalic
            // 
            this.ckbItalic.AutoSize = true;
            this.ckbItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbItalic.Location = new System.Drawing.Point(7, 78);
            this.ckbItalic.Name = "ckbItalic";
            this.ckbItalic.Size = new System.Drawing.Size(55, 21);
            this.ckbItalic.TabIndex = 1;
            this.ckbItalic.Text = "Italic";
            this.ckbItalic.UseVisualStyleBackColor = true;
            this.ckbItalic.CheckedChanged += new System.EventHandler(this.ckbItalic_CheckedChanged);
            // 
            // ckbBold
            // 
            this.ckbBold.AutoSize = true;
            this.ckbBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBold.Location = new System.Drawing.Point(7, 34);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(59, 21);
            this.ckbBold.TabIndex = 0;
            this.ckbBold.Text = "Bold";
            this.ckbBold.UseVisualStyleBackColor = true;
            this.ckbBold.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoTim);
            this.groupBox3.Controls.Add(this.rdoVang);
            this.groupBox3.Controls.Add(this.rdoDo);
            this.groupBox3.Controls.Add(this.rdoXanh);
            this.groupBox3.Location = new System.Drawing.Point(552, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 203);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Màu chữ";
            // 
            // rdoTim
            // 
            this.rdoTim.AutoSize = true;
            this.rdoTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTim.ForeColor = System.Drawing.Color.Fuchsia;
            this.rdoTim.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdoTim.Location = new System.Drawing.Point(16, 161);
            this.rdoTim.Name = "rdoTim";
            this.rdoTim.Size = new System.Drawing.Size(48, 20);
            this.rdoTim.TabIndex = 3;
            this.rdoTim.TabStop = true;
            this.rdoTim.Text = "Tím";
            this.rdoTim.UseVisualStyleBackColor = true;
            this.rdoTim.CheckedChanged += new System.EventHandler(this.rdoTim_CheckedChanged);
            // 
            // rdoVang
            // 
            this.rdoVang.AutoSize = true;
            this.rdoVang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVang.ForeColor = System.Drawing.Color.Yellow;
            this.rdoVang.Location = new System.Drawing.Point(16, 121);
            this.rdoVang.Name = "rdoVang";
            this.rdoVang.Size = new System.Drawing.Size(57, 20);
            this.rdoVang.TabIndex = 2;
            this.rdoVang.TabStop = true;
            this.rdoVang.Text = "Vàng";
            this.rdoVang.UseVisualStyleBackColor = true;
            this.rdoVang.CheckedChanged += new System.EventHandler(this.rdoVang_CheckedChanged);
            // 
            // rdoDo
            // 
            this.rdoDo.AutoSize = true;
            this.rdoDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDo.ForeColor = System.Drawing.Color.Red;
            this.rdoDo.Location = new System.Drawing.Point(16, 78);
            this.rdoDo.Name = "rdoDo";
            this.rdoDo.Size = new System.Drawing.Size(42, 20);
            this.rdoDo.TabIndex = 1;
            this.rdoDo.TabStop = true;
            this.rdoDo.Text = "Đỏ";
            this.rdoDo.UseVisualStyleBackColor = true;
            this.rdoDo.CheckedChanged += new System.EventHandler(this.rdoDo_CheckedChanged);
            // 
            // rdoXanh
            // 
            this.rdoXanh.AutoSize = true;
            this.rdoXanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoXanh.ForeColor = System.Drawing.Color.Blue;
            this.rdoXanh.Location = new System.Drawing.Point(16, 34);
            this.rdoXanh.Name = "rdoXanh";
            this.rdoXanh.Size = new System.Drawing.Size(55, 20);
            this.rdoXanh.TabIndex = 0;
            this.rdoXanh.TabStop = true;
            this.rdoXanh.Text = "Xanh";
            this.rdoXanh.UseVisualStyleBackColor = true;
            this.rdoXanh.CheckedChanged += new System.EventHandler(this.rdoXanh_CheckedChanged);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(224, 391);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(75, 29);
            this.btnLamlai.TabIndex = 3;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(444, 391);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 29);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtnhapten
            // 
            this.txtnhapten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhapten.Location = new System.Drawing.Point(297, 51);
            this.txtnhapten.Multiline = true;
            this.txtnhapten.Name = "txtnhapten";
            this.txtnhapten.Size = new System.Drawing.Size(222, 46);
            this.txtnhapten.TabIndex = 5;
            this.txtnhapten.Text = "Microsoft Visual Basic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtnhapten);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTahoma;
        private System.Windows.Forms.RadioButton rdoVnVogue;
        private System.Windows.Forms.RadioButton rdoVnUniverse;
        private System.Windows.Forms.RadioButton rdoVnTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbUnderLine;
        private System.Windows.Forms.CheckBox ckbStrikeout;
        private System.Windows.Forms.CheckBox ckbItalic;
        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoTim;
        private System.Windows.Forms.RadioButton rdoVang;
        private System.Windows.Forms.RadioButton rdoDo;
        private System.Windows.Forms.RadioButton rdoXanh;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtnhapten;
    }
}

