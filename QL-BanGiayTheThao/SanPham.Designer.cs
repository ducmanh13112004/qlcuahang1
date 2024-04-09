namespace QL_BanGiayTheThao
{
    partial class SanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbXuatxu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTheloai = new System.Windows.Forms.ComboBox();
            this.cbbHangSP = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgrvHienThiListSP = new System.Windows.Forms.DataGridView();
            this.clMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHangSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTheloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_sua);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(824, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 226);
            this.panel1.TabIndex = 26;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Silver;
            this.btn_reset.Location = new System.Drawing.Point(53, 172);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(88, 33);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Silver;
            this.btn_xoa.Location = new System.Drawing.Point(53, 123);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(88, 33);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Silver;
            this.btn_sua.Location = new System.Drawing.Point(53, 73);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(88, 33);
            this.btn_sua.TabIndex = 1;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Silver;
            this.btn_them.Location = new System.Drawing.Point(53, 23);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(88, 34);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cbbNCC
            // 
            this.cbbNCC.BackColor = System.Drawing.Color.White;
            this.cbbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbNCC.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(206, 74);
            this.cbbNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(168, 24);
            this.cbbNCC.TabIndex = 18;
            this.cbbNCC.Text = "  Chọn nhà cung cấp";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(30, 212);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 12, 3, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(344, 33);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.Text = "    Tìm kiếm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSP.Location = new System.Drawing.Point(30, 151);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(137, 24);
            this.txtTenSP.TabIndex = 12;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Location = new System.Drawing.Point(30, 75);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(137, 24);
            this.txtMaSP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(27, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(203, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thể Loại";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiaBan.Location = new System.Drawing.Point(615, 75);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(137, 24);
            this.txtGiaBan.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(612, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giá Bán";
            // 
            // cbbXuatxu
            // 
            this.cbbXuatxu.BackColor = System.Drawing.Color.White;
            this.cbbXuatxu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbXuatxu.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbXuatxu.FormattingEnabled = true;
            this.cbbXuatxu.Items.AddRange(new object[] {
            "Việt Nam",
            "Mĩ",
            "Lào",
            "Campuchia",
            "Thái Lan",
            "Nhật",
            "Đức",
            "Hàn Quốc",
            "Nga"});
            this.cbbXuatxu.Location = new System.Drawing.Point(406, 151);
            this.cbbXuatxu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbXuatxu.Name = "cbbXuatxu";
            this.cbbXuatxu.Size = new System.Drawing.Size(176, 24);
            this.cbbXuatxu.TabIndex = 23;
            this.cbbXuatxu.Text = "  Chọn xuất xứ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(403, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Xuất Xứ";
            // 
            // cbbTheloai
            // 
            this.cbbTheloai.BackColor = System.Drawing.Color.White;
            this.cbbTheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTheloai.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbTheloai.FormattingEnabled = true;
            this.cbbTheloai.Items.AddRange(new object[] {
            "Giày thể thao",
            "Giày thể thao nam",
            "Giày Đá bóng",
            "Giày leo núi",
            "Giày đi bộ",
            "Giày thể thao, Golf",
            "Giày thể thao, Đua xe",
            "Giày thể thao, Trượt patin"});
            this.cbbTheloai.Location = new System.Drawing.Point(206, 151);
            this.cbbTheloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTheloai.Name = "cbbTheloai";
            this.cbbTheloai.Size = new System.Drawing.Size(168, 24);
            this.cbbTheloai.TabIndex = 21;
            this.cbbTheloai.Text = "  Chọn thể loại";
            // 
            // cbbHangSP
            // 
            this.cbbHangSP.BackColor = System.Drawing.Color.White;
            this.cbbHangSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbHangSP.ForeColor = System.Drawing.Color.DarkGray;
            this.cbbHangSP.FormattingEnabled = true;
            this.cbbHangSP.ItemHeight = 16;
            this.cbbHangSP.Items.AddRange(new object[] {
            "Puma",
            "Asics",
            "Adidas",
            "North Face",
            "Nike",
            "Under Armour",
            "Puma",
            "Rollerblade"});
            this.cbbHangSP.Location = new System.Drawing.Point(406, 74);
            this.cbbHangSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHangSP.Name = "cbbHangSP";
            this.cbbHangSP.Size = new System.Drawing.Size(176, 24);
            this.cbbHangSP.TabIndex = 20;
            this.cbbHangSP.Text = "  Chọn hãng sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(203, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(403, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hãng Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgrvHienThiListSP);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 261);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 16, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1005, 241);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các sản phẩm";
            // 
            // dtgrvHienThiListSP
            // 
            this.dtgrvHienThiListSP.AllowUserToResizeColumns = false;
            this.dtgrvHienThiListSP.AllowUserToResizeRows = false;
            this.dtgrvHienThiListSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrvHienThiListSP.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgrvHienThiListSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgrvHienThiListSP.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtgrvHienThiListSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrvHienThiListSP.ColumnHeadersHeight = 33;
            this.dtgrvHienThiListSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgrvHienThiListSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaSP,
            this.clTenNV,
            this.clHangSP,
            this.clTenSP,
            this.clTheloai,
            this.clXuatXu,
            this.clGiaBan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrvHienThiListSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrvHienThiListSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrvHienThiListSP.EnableHeadersVisualStyles = false;
            this.dtgrvHienThiListSP.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtgrvHienThiListSP.Location = new System.Drawing.Point(3, 18);
            this.dtgrvHienThiListSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgrvHienThiListSP.Name = "dtgrvHienThiListSP";
            this.dtgrvHienThiListSP.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrvHienThiListSP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrvHienThiListSP.RowHeadersVisible = false;
            this.dtgrvHienThiListSP.RowHeadersWidth = 62;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.dtgrvHienThiListSP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrvHienThiListSP.RowTemplate.Height = 28;
            this.dtgrvHienThiListSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrvHienThiListSP.Size = new System.Drawing.Size(999, 221);
            this.dtgrvHienThiListSP.TabIndex = 0;
            this.dtgrvHienThiListSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHienThiListSP_CellClick);
            this.dtgrvHienThiListSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrvHienThiListSP_CellContentClick);
            // 
            // clMaSP
            // 
            this.clMaSP.DataPropertyName = "MaSP";
            this.clMaSP.FillWeight = 62.88284F;
            this.clMaSP.HeaderText = "Mã SP";
            this.clMaSP.MinimumWidth = 8;
            this.clMaSP.Name = "clMaSP";
            this.clMaSP.ReadOnly = true;
            // 
            // clTenNV
            // 
            this.clTenNV.DataPropertyName = "MaNCC";
            this.clTenNV.FillWeight = 74.69347F;
            this.clTenNV.HeaderText = "Mã NCC";
            this.clTenNV.MinimumWidth = 8;
            this.clTenNV.Name = "clTenNV";
            this.clTenNV.ReadOnly = true;
            // 
            // clHangSP
            // 
            this.clHangSP.DataPropertyName = "HangSP";
            this.clHangSP.FillWeight = 73.68264F;
            this.clHangSP.HeaderText = "Hãng SP";
            this.clHangSP.MinimumWidth = 8;
            this.clHangSP.Name = "clHangSP";
            this.clHangSP.ReadOnly = true;
            // 
            // clTenSP
            // 
            this.clTenSP.DataPropertyName = "TenSP";
            this.clTenSP.FillWeight = 139.2045F;
            this.clTenSP.HeaderText = "Tên Sản Phẩm";
            this.clTenSP.MinimumWidth = 8;
            this.clTenSP.Name = "clTenSP";
            this.clTenSP.ReadOnly = true;
            // 
            // clTheloai
            // 
            this.clTheloai.DataPropertyName = "TheLoai";
            this.clTheloai.FillWeight = 138.8195F;
            this.clTheloai.HeaderText = "Thể loại";
            this.clTheloai.MinimumWidth = 8;
            this.clTheloai.Name = "clTheloai";
            this.clTheloai.ReadOnly = true;
            // 
            // clXuatXu
            // 
            this.clXuatXu.DataPropertyName = "XuatXu";
            this.clXuatXu.FillWeight = 84.30445F;
            this.clXuatXu.HeaderText = "Xuất Xứ";
            this.clXuatXu.MinimumWidth = 8;
            this.clXuatXu.Name = "clXuatXu";
            this.clXuatXu.ReadOnly = true;
            // 
            // clGiaBan
            // 
            this.clGiaBan.DataPropertyName = "GiaBan";
            this.clGiaBan.FillWeight = 126.4124F;
            this.clGiaBan.HeaderText = "Giá Bán";
            this.clGiaBan.MinimumWidth = 8;
            this.clGiaBan.Name = "clGiaBan";
            this.clGiaBan.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbXuatxu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbTheloai);
            this.groupBox1.Controls.Add(this.cbbHangSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbNCC);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 16);
            this.groupBox1.Size = new System.Drawing.Size(1005, 261);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(325, 214);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 31);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvHienThiListSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbXuatxu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTheloai;
        private System.Windows.Forms.ComboBox cbbHangSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgrvHienThiListSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHangSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTheloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clXuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_reset;
    }
}