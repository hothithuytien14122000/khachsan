
namespace QLKhachSan
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.data_gridview = new System.Windows.Forms.DataGridView();
            this.phongBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.khachsanDataSet = new QLKhachSan.khachsanDataSet();
            this.rtb_mota = new System.Windows.Forms.RichTextBox();
            this.cbx_tt = new System.Windows.Forms.ComboBox();
            this.phongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbx_loaip = new System.Windows.Forms.ComboBox();
            this.lPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khachsanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_song = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lPhongTableAdapter = new QLKhachSan.khachsanDataSetTableAdapters.LPhongTableAdapter();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phongTableAdapter = new QLKhachSan.khachsanDataSetTableAdapters.PhongTableAdapter();
            this.lPhongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phongBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songtoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPhongLPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lPhongBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKPhongLPhongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lPhongBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachsanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachsanDataSetBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPhongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhongLPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPhongBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhongLPhongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPhongBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mô tả phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên phòng";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(151, 41);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(239, 29);
            this.txt_ma.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(988, 169);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(231, 53);
            this.btn_xoa.TabIndex = 49;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_them.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(988, 23);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(231, 49);
            this.btn_them.TabIndex = 47;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng thái";
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(988, 89);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(231, 57);
            this.btn_sua.TabIndex = 48;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(537, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quản lý phòng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // data_gridview
            // 
            this.data_gridview.AllowUserToOrderColumns = true;
            this.data_gridview.AutoGenerateColumns = false;
            this.data_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.loaiphong,
            this.Mota,
            this.songtoida,
            this.trangthai});
            this.data_gridview.DataSource = this.phongBindingSource3;
            this.data_gridview.Location = new System.Drawing.Point(28, 30);
            this.data_gridview.Margin = new System.Windows.Forms.Padding(4);
            this.data_gridview.Name = "data_gridview";
            this.data_gridview.ReadOnly = true;
            this.data_gridview.RowHeadersWidth = 51;
            this.data_gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_gridview.ShowCellToolTips = false;
            this.data_gridview.Size = new System.Drawing.Size(1214, 338);
            this.data_gridview.TabIndex = 0;
            this.data_gridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_gridview_CellClick);
            // 
            // phongBindingSource3
            // 
            this.phongBindingSource3.DataMember = "Phong";
            this.phongBindingSource3.DataSource = this.khachsanDataSet;
            // 
            // khachsanDataSet
            // 
            this.khachsanDataSet.DataSetName = "khachsanDataSet";
            this.khachsanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtb_mota
            // 
            this.rtb_mota.Location = new System.Drawing.Point(620, 44);
            this.rtb_mota.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_mota.Name = "rtb_mota";
            this.rtb_mota.Size = new System.Drawing.Size(290, 73);
            this.rtb_mota.TabIndex = 3;
            this.rtb_mota.Text = "";
            // 
            // cbx_tt
            // 
            this.cbx_tt.DataSource = this.fKPhongLPhongBindingSource1;
            this.cbx_tt.DisplayMember = "trangthai";
            this.cbx_tt.FormattingEnabled = true;
            this.cbx_tt.Location = new System.Drawing.Point(620, 143);
            this.cbx_tt.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_tt.Name = "cbx_tt";
            this.cbx_tt.Size = new System.Drawing.Size(239, 32);
            this.cbx_tt.TabIndex = 2;
            // 
            // phongBindingSource1
            // 
            this.phongBindingSource1.DataMember = "Phong";
            this.phongBindingSource1.DataSource = this.khachsanDataSet;
            // 
            // cbx_loaip
            // 
            this.cbx_loaip.DataSource = this.lPhongBindingSource3;
            this.cbx_loaip.DisplayMember = "loaiphong";
            this.cbx_loaip.FormattingEnabled = true;
            this.cbx_loaip.Location = new System.Drawing.Point(151, 146);
            this.cbx_loaip.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_loaip.Name = "cbx_loaip";
            this.cbx_loaip.Size = new System.Drawing.Size(239, 32);
            this.cbx_loaip.TabIndex = 2;
            // 
            // lPhongBindingSource
            // 
            this.lPhongBindingSource.DataMember = "LPhong";
            this.lPhongBindingSource.DataSource = this.khachsanDataSetBindingSource;
            // 
            // khachsanDataSetBindingSource
            // 
            this.khachsanDataSetBindingSource.DataSource = this.khachsanDataSet;
            this.khachsanDataSetBindingSource.Position = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.data_gridview);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(44, 341);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1257, 405);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin dữ liệu  bảng";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(151, 89);
            this.txt_ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ten.Multiline = true;
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(239, 31);
            this.txt_ten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.rtb_mota);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.cbx_tt);
            this.groupBox1.Controls.Add(this.cbx_loaip);
            this.groupBox1.Controls.Add(this.txt_song);
            this.groupBox1.Controls.Add(this.txt_ten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1257, 244);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // txt_song
            // 
            this.txt_song.Location = new System.Drawing.Point(151, 198);
            this.txt_song.Margin = new System.Windows.Forms.Padding(4);
            this.txt_song.Name = "txt_song";
            this.txt_song.Size = new System.Drawing.Size(239, 29);
            this.txt_song.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số người tối đa";
            // 
            // lPhongTableAdapter
            // 
            this.lPhongTableAdapter.ClearBeforeFill = true;
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "Phong";
            this.phongBindingSource.DataSource = this.khachsanDataSet;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // lPhongBindingSource1
            // 
            this.lPhongBindingSource1.DataMember = "LPhong";
            this.lPhongBindingSource1.DataSource = this.khachsanDataSet;
            // 
            // phongBindingSource2
            // 
            this.phongBindingSource2.DataMember = "Phong";
            this.phongBindingSource2.DataSource = this.khachsanDataSetBindingSource;
            // 
            // MaPhong
            // 
            this.MaPhong.DataPropertyName = "MaPhong";
            this.MaPhong.HeaderText = "MaPhong";
            this.MaPhong.MinimumWidth = 6;
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            this.MaPhong.Width = 125;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "TenPhong";
            this.TenPhong.MinimumWidth = 6;
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.ReadOnly = true;
            this.TenPhong.Width = 125;
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "loaiphong";
            this.loaiphong.HeaderText = "loaiphong";
            this.loaiphong.MinimumWidth = 6;
            this.loaiphong.Name = "loaiphong";
            this.loaiphong.ReadOnly = true;
            this.loaiphong.Width = 125;
            // 
            // Mota
            // 
            this.Mota.DataPropertyName = "Mota";
            this.Mota.HeaderText = "Mota";
            this.Mota.MinimumWidth = 6;
            this.Mota.Name = "Mota";
            this.Mota.ReadOnly = true;
            this.Mota.Width = 300;
            // 
            // songtoida
            // 
            this.songtoida.DataPropertyName = "songtoida";
            this.songtoida.HeaderText = "songtoida";
            this.songtoida.MinimumWidth = 6;
            this.songtoida.Name = "songtoida";
            this.songtoida.ReadOnly = true;
            this.songtoida.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "trangthai";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Width = 140;
            // 
            // fKPhongLPhongBindingSource
            // 
            this.fKPhongLPhongBindingSource.DataMember = "FK_Phong_LPhong";
            this.fKPhongLPhongBindingSource.DataSource = this.lPhongBindingSource;
            // 
            // lPhongBindingSource2
            // 
            this.lPhongBindingSource2.DataMember = "LPhong";
            this.lPhongBindingSource2.DataSource = this.khachsanDataSetBindingSource;
            // 
            // fKPhongLPhongBindingSource1
            // 
            this.fKPhongLPhongBindingSource1.DataMember = "FK_Phong_LPhong";
            this.fKPhongLPhongBindingSource1.DataSource = this.lPhongBindingSource;
            // 
            // lPhongBindingSource3
            // 
            this.lPhongBindingSource3.DataMember = "LPhong";
            this.lPhongBindingSource3.DataSource = this.khachsanDataSetBindingSource;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 854);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachsanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachsanDataSetBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPhongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhongLPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPhongBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPhongLPhongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPhongBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_gridview;
        private System.Windows.Forms.RichTextBox rtb_mota;
        private System.Windows.Forms.ComboBox cbx_tt;
        private System.Windows.Forms.ComboBox cbx_loaip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource khachsanDataSetBindingSource;
        private khachsanDataSet khachsanDataSet;
        private System.Windows.Forms.BindingSource lPhongBindingSource;
        private khachsanDataSetTableAdapters.LPhongTableAdapter lPhongTableAdapter;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private khachsanDataSetTableAdapters.PhongTableAdapter phongTableAdapter;
        private System.Windows.Forms.BindingSource phongBindingSource1;
        private System.Windows.Forms.BindingSource lPhongBindingSource1;
        private System.Windows.Forms.BindingSource phongBindingSource2;
        private System.Windows.Forms.BindingSource phongBindingSource3;
        private System.Windows.Forms.TextBox txt_song;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
        private System.Windows.Forms.DataGridViewTextBoxColumn songtoida;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.BindingSource fKPhongLPhongBindingSource1;
        private System.Windows.Forms.BindingSource lPhongBindingSource3;
        private System.Windows.Forms.BindingSource fKPhongLPhongBindingSource;
        private System.Windows.Forms.BindingSource lPhongBindingSource2;
    }
}