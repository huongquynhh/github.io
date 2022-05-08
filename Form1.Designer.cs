namespace form_ptrinhbachai
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
            this.label3 = new System.Windows.Forms.Label();
            this.nudNhapA = new System.Windows.Forms.NumericUpDown();
            this.nudNhapB = new System.Windows.Forms.NumericUpDown();
            this.nudNhapC = new System.Windows.Forms.NumericUpDown();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbx2 = new System.Windows.Forms.Label();
            this.lbx1 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.btnGiaiPTBH = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNhapA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNhapB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNhapC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b";
            // 
            // nudNhapA
            // 
            this.nudNhapA.Location = new System.Drawing.Point(137, 42);
            this.nudNhapA.Name = "nudNhapA";
            this.nudNhapA.Size = new System.Drawing.Size(120, 20);
            this.nudNhapA.TabIndex = 3;
            this.nudNhapA.ValueChanged += new System.EventHandler(this.nudNhapA_ValueChanged);
            // 
            // nudNhapB
            // 
            this.nudNhapB.Location = new System.Drawing.Point(390, 41);
            this.nudNhapB.Name = "nudNhapB";
            this.nudNhapB.Size = new System.Drawing.Size(120, 20);
            this.nudNhapB.TabIndex = 4;
            this.nudNhapB.ValueChanged += new System.EventHandler(this.nudNhapB_ValueChanged);
            // 
            // nudNhapC
            // 
            this.nudNhapC.Location = new System.Drawing.Point(619, 42);
            this.nudNhapC.Name = "nudNhapC";
            this.nudNhapC.Size = new System.Drawing.Size(120, 20);
            this.nudNhapC.TabIndex = 5;
            this.nudNhapC.ValueChanged += new System.EventHandler(this.nudNhapC_ValueChanged);
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(102, 178);
            this.txtKetqua.Multiline = true;
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(197, 141);
            this.txtKetqua.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbx2);
            this.groupBox1.Controls.Add(this.lbx1);
            this.groupBox1.Controls.Add(this.txtX2);
            this.groupBox1.Controls.Add(this.txtX1);
            this.groupBox1.Location = new System.Drawing.Point(501, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nghiệm";
            // 
            // lbx2
            // 
            this.lbx2.AutoSize = true;
            this.lbx2.Location = new System.Drawing.Point(6, 101);
            this.lbx2.Name = "lbx2";
            this.lbx2.Size = new System.Drawing.Size(18, 13);
            this.lbx2.TabIndex = 3;
            this.lbx2.Text = "x2";
            // 
            // lbx1
            // 
            this.lbx1.AutoSize = true;
            this.lbx1.Location = new System.Drawing.Point(7, 38);
            this.lbx1.Name = "lbx1";
            this.lbx1.Size = new System.Drawing.Size(18, 13);
            this.lbx1.TabIndex = 2;
            this.lbx1.Text = "x1";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(60, 98);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 20);
            this.txtX2.TabIndex = 1;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(60, 38);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 20);
            this.txtX1.TabIndex = 0;
            // 
            // btnGiaiPTBH
            // 
            this.btnGiaiPTBH.Location = new System.Drawing.Point(218, 389);
            this.btnGiaiPTBH.Name = "btnGiaiPTBH";
            this.btnGiaiPTBH.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiPTBH.TabIndex = 8;
            this.btnGiaiPTBH.Text = "Giải PTBH";
            this.btnGiaiPTBH.UseVisualStyleBackColor = true;
            this.btnGiaiPTBH.Click += new System.EventHandler(this.btnGiaiPTBH_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(458, 388);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiaiPTBH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.nudNhapC);
            this.Controls.Add(this.nudNhapB);
            this.Controls.Add(this.nudNhapA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNhapA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNhapB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNhapC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNhapA;
        private System.Windows.Forms.NumericUpDown nudNhapB;
        private System.Windows.Forms.NumericUpDown nudNhapC;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbx2;
        private System.Windows.Forms.Label lbx1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Button btnGiaiPTBH;
        private System.Windows.Forms.Button btnThoat;
    }
}

