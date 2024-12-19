namespace De02
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
            this.lvSanpham = new System.Windows.Forms.DataGridView();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.dtngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbloaisp = new System.Windows.Forms.ComboBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.btkluu = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // lvSanpham
            // 
            this.lvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lvSanpham.Location = new System.Drawing.Point(12, 142);
            this.lvSanpham.Name = "lvSanpham";
            this.lvSanpham.RowHeadersWidth = 51;
            this.lvSanpham.RowTemplate.Height = 24;
            this.lvSanpham.Size = new System.Drawing.Size(562, 243);
            this.lvSanpham.TabIndex = 0;
            this.lvSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lvSanpham_CellClick);
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(726, 142);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(100, 22);
            this.txtmasp.TabIndex = 1;
            this.txtmasp.TextChanged += new System.EventHandler(this.txtmasp_TextChanged);
            // 
            // dtngaynhap
            // 
            this.dtngaynhap.Location = new System.Drawing.Point(726, 300);
            this.dtngaynhap.Name = "dtngaynhap";
            this.dtngaynhap.Size = new System.Drawing.Size(200, 22);
            this.dtngaynhap.TabIndex = 3;
            this.dtngaynhap.ValueChanged += new System.EventHandler(this.dtngaynhap_ValueChanged);
            // 
            // cbloaisp
            // 
            this.cbloaisp.FormattingEnabled = true;
            this.cbloaisp.Location = new System.Drawing.Point(726, 361);
            this.cbloaisp.Name = "cbloaisp";
            this.cbloaisp.Size = new System.Drawing.Size(121, 24);
            this.cbloaisp.TabIndex = 4;
            this.cbloaisp.SelectedIndexChanged += new System.EventHandler(this.cbloaisp_SelectedIndexChanged);
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(726, 221);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(100, 22);
            this.txttensp.TabIndex = 5;
            this.txttensp.TextChanged += new System.EventHandler(this.txttensp_TextChanged);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(59, 412);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 6;
            this.btthem.Text = "Them";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(152, 412);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 7;
            this.btsua.Text = "Sua";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(242, 412);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 8;
            this.btxoa.Text = "Xoa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btluu
            // 
            this.btluu.Location = new System.Drawing.Point(347, 411);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 23);
            this.btluu.TabIndex = 9;
            this.btluu.Text = "Luu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // btkluu
            // 
            this.btkluu.Location = new System.Drawing.Point(453, 412);
            this.btkluu.Name = "btkluu";
            this.btkluu.Size = new System.Drawing.Size(75, 23);
            this.btkluu.TabIndex = 10;
            this.btkluu.Text = "K.luu";
            this.btkluu.UseVisualStyleBackColor = true;
            this.btkluu.Click += new System.EventHandler(this.btkluu_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(557, 412);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 11;
            this.btthoat.Text = "Thoat";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ma SP :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ten SP :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "NgayNhap:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "LoaiSP :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btkluu);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.cbloaisp);
            this.Controls.Add(this.dtngaynhap);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.lvSanpham);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lvSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lvSanpham;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.DateTimePicker dtngaynhap;
        private System.Windows.Forms.ComboBox cbloaisp;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button btkluu;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

