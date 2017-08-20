namespace QuanLyPhongKham
{
    partial class FormKhamChuyenKhoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dataThongTin = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtNguoiTao = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX18 = new DevComponents.DotNetBar.LabelX();
            this.dtiNgayTao = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.lbBHYT = new DevComponents.DotNetBar.LabelX();
            this.txtBaoHiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtCMND = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.btnIn = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.cbbTenBN = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.LoaiKhamCK = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.NoiDung = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.txtTuoi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataThongTin)).BeginInit();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgayTao)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // dataThongTin
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataThongTin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiKhamCK,
            this.NoiDung});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataThongTin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataThongTin.EnableHeadersVisualStyles = false;
            this.dataThongTin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataThongTin.Location = new System.Drawing.Point(47, 281);
            this.dataThongTin.Margin = new System.Windows.Forms.Padding(5);
            this.dataThongTin.Name = "dataThongTin";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataThongTin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataThongTin.Size = new System.Drawing.Size(736, 255);
            this.dataThongTin.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX1.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Red;
            this.labelX1.BackgroundStyle.BorderBottomWidth = 2;
            this.labelX1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX1.BackgroundStyle.BorderLeftColor = System.Drawing.Color.Red;
            this.labelX1.BackgroundStyle.BorderLeftWidth = 2;
            this.labelX1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX1.BackgroundStyle.BorderRightColor = System.Drawing.Color.Red;
            this.labelX1.BackgroundStyle.BorderRightWidth = 2;
            this.labelX1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.labelX1.BackgroundStyle.BorderTopColor = System.Drawing.Color.Red;
            this.labelX1.BackgroundStyle.BorderTopWidth = 2;
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(47, 7);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(736, 42);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelX1.TabIndex = 45;
            this.labelX1.Text = "PHIẾU KHÁM CHUYÊN KHOA";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtSDT);
            this.groupPanel1.Controls.Add(this.txtTuoi);
            this.groupPanel1.Controls.Add(this.txtNguoiTao);
            this.groupPanel1.Controls.Add(this.labelX18);
            this.groupPanel1.Controls.Add(this.dtiNgayTao);
            this.groupPanel1.Controls.Add(this.labelX17);
            this.groupPanel1.Controls.Add(this.lbBHYT);
            this.groupPanel1.Controls.Add(this.txtBaoHiem);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.cbbTenBN);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.txtCMND);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.txtDiaChi);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.groupPanel1.Location = new System.Drawing.Point(47, 55);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(736, 218);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 61;
            this.groupPanel1.Text = "Thông Tin";
            this.groupPanel1.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center;
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // txtNguoiTao
            // 
            this.txtNguoiTao.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNguoiTao.Border.Class = "TextBoxBorder";
            this.txtNguoiTao.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNguoiTao.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtNguoiTao.ForeColor = System.Drawing.Color.Black;
            this.txtNguoiTao.Location = new System.Drawing.Point(508, 104);
            this.txtNguoiTao.Name = "txtNguoiTao";
            this.txtNguoiTao.PreventEnterBeep = true;
            this.txtNguoiTao.Size = new System.Drawing.Size(200, 29);
            this.txtNguoiTao.TabIndex = 55;
            // 
            // labelX18
            // 
            this.labelX18.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX18.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelX18.ForeColor = System.Drawing.Color.Black;
            this.labelX18.Location = new System.Drawing.Point(417, 103);
            this.labelX18.Name = "labelX18";
            this.labelX18.Size = new System.Drawing.Size(86, 23);
            this.labelX18.TabIndex = 56;
            this.labelX18.Text = "Người Tạo";
            // 
            // dtiNgayTao
            // 
            this.dtiNgayTao.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtiNgayTao.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiNgayTao.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgayTao.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiNgayTao.ButtonDropDown.Visible = true;
            this.dtiNgayTao.Enabled = false;
            this.dtiNgayTao.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.dtiNgayTao.ForeColor = System.Drawing.Color.Black;
            this.dtiNgayTao.IsPopupCalendarOpen = false;
            this.dtiNgayTao.Location = new System.Drawing.Point(508, 62);
            // 
            // 
            // 
            this.dtiNgayTao.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiNgayTao.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgayTao.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiNgayTao.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiNgayTao.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiNgayTao.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgayTao.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiNgayTao.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiNgayTao.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiNgayTao.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiNgayTao.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgayTao.MonthCalendar.DisplayMonth = new System.DateTime(2017, 8, 1, 0, 0, 0, 0);
            this.dtiNgayTao.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtiNgayTao.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiNgayTao.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiNgayTao.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiNgayTao.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgayTao.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiNgayTao.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgayTao.MonthCalendar.TodayButtonVisible = true;
            this.dtiNgayTao.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiNgayTao.Name = "dtiNgayTao";
            this.dtiNgayTao.Size = new System.Drawing.Size(200, 29);
            this.dtiNgayTao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiNgayTao.TabIndex = 54;
            // 
            // labelX17
            // 
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX17.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelX17.ForeColor = System.Drawing.Color.Black;
            this.labelX17.Location = new System.Drawing.Point(417, 63);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(86, 23);
            this.labelX17.TabIndex = 53;
            this.labelX17.Text = "Ngày Tạo";
            // 
            // lbBHYT
            // 
            this.lbBHYT.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbBHYT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbBHYT.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lbBHYT.ForeColor = System.Drawing.Color.Black;
            this.lbBHYT.Location = new System.Drawing.Point(417, 21);
            this.lbBHYT.Name = "lbBHYT";
            this.lbBHYT.Size = new System.Drawing.Size(75, 23);
            this.lbBHYT.TabIndex = 40;
            this.lbBHYT.Text = "BHYT";
            // 
            // txtBaoHiem
            // 
            this.txtBaoHiem.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtBaoHiem.Border.Class = "TextBoxBorder";
            this.txtBaoHiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBaoHiem.Enabled = false;
            this.txtBaoHiem.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtBaoHiem.ForeColor = System.Drawing.Color.Black;
            this.txtBaoHiem.Location = new System.Drawing.Point(509, 18);
            this.txtBaoHiem.Name = "txtBaoHiem";
            this.txtBaoHiem.PreventEnterBeep = true;
            this.txtBaoHiem.Size = new System.Drawing.Size(200, 29);
            this.txtBaoHiem.TabIndex = 14;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(20, 144);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 36;
            this.labelX5.Text = "SDT";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(20, 106);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 30;
            this.labelX9.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCMND.Border.Class = "TextBoxBorder";
            this.txtCMND.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCMND.Enabled = false;
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(152, 103);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PreventEnterBeep = true;
            this.txtCMND.Size = new System.Drawing.Size(200, 29);
            this.txtCMND.TabIndex = 10;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(20, 63);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(93, 23);
            this.labelX3.TabIndex = 26;
            this.labelX3.Text = "Tuổi";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(417, 144);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 20;
            this.labelX10.Text = "Địa Chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(509, 144);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PreventEnterBeep = true;
            this.txtDiaChi.Size = new System.Drawing.Size(200, 29);
            this.txtDiaChi.TabIndex = 9;
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(20, 21);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(126, 23);
            this.labelX11.TabIndex = 18;
            this.labelX11.Text = "Tên Bệnh Nhân";
            // 
            // btnIn
            // 
            this.btnIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnIn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnIn.Location = new System.Drawing.Point(499, 557);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(135, 48);
            this.btnIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnIn.TabIndex = 63;
            this.btnIn.Text = "In Toa";
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnThem.Location = new System.Drawing.Point(348, 557);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(135, 48);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Lưu";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnThoat.Location = new System.Drawing.Point(648, 557);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 48);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 64;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbTenBN
            // 
            this.cbbTenBN.DisplayMember = "Text";
            this.cbbTenBN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenBN.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cbbTenBN.ForeColor = System.Drawing.Color.Black;
            this.cbbTenBN.FormattingEnabled = true;
            this.cbbTenBN.ItemHeight = 23;
            this.cbbTenBN.Location = new System.Drawing.Point(152, 15);
            this.cbbTenBN.Name = "cbbTenBN";
            this.cbbTenBN.Size = new System.Drawing.Size(200, 29);
            this.cbbTenBN.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbTenBN.TabIndex = 7;
            this.cbbTenBN.SelectedIndexChanged += new System.EventHandler(this.cbbTenBN_SelectedIndexChanged);
            // 
            // LoaiKhamCK
            // 
            this.LoaiKhamCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiKhamCK.DisplayMember = "Text";
            this.LoaiKhamCK.DropDownHeight = 106;
            this.LoaiKhamCK.DropDownWidth = 121;
            this.LoaiKhamCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoaiKhamCK.HeaderText = "Tên XN/Chuẩn Đoán";
            this.LoaiKhamCK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoaiKhamCK.IntegralHeight = false;
            this.LoaiKhamCK.ItemHeight = 15;
            this.LoaiKhamCK.Name = "LoaiKhamCK";
            this.LoaiKhamCK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoaiKhamCK.WatermarkEnabled = false;
            // 
            // NoiDung
            // 
            this.NoiDung.DisplayMember = "Text";
            this.NoiDung.DropDownHeight = 106;
            this.NoiDung.DropDownWidth = 121;
            this.NoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoiDung.HeaderText = "Nội Dung Yêu Cầu";
            this.NoiDung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NoiDung.IntegralHeight = false;
            this.NoiDung.ItemHeight = 15;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NoiDung.Width = 350;
            // 
            // txtTuoi
            // 
            this.txtTuoi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTuoi.Border.Class = "TextBoxBorder";
            this.txtTuoi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTuoi.Enabled = false;
            this.txtTuoi.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtTuoi.ForeColor = System.Drawing.Color.Black;
            this.txtTuoi.Location = new System.Drawing.Point(152, 57);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.PreventEnterBeep = true;
            this.txtTuoi.Size = new System.Drawing.Size(200, 29);
            this.txtTuoi.TabIndex = 55;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSDT.Border.Class = "TextBoxBorder";
            this.txtSDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSDT.Enabled = false;
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtSDT.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(152, 138);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PreventEnterBeep = true;
            this.txtSDT.Size = new System.Drawing.Size(200, 29);
            this.txtSDT.TabIndex = 55;
            // 
            // FormKhamChuyenKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 612);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dataThongTin);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormKhamChuyenKhoa";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhamChuyenKhoa";
            this.Load += new System.EventHandler(this.FormKhamChuyenKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataThongTin)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgayTao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataThongTin;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNguoiTao;
        private DevComponents.DotNetBar.LabelX labelX18;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiNgayTao;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX lbBHYT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBaoHiem;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCMND;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.ButtonX btnIn;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn LoaiKhamCK;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn NoiDung;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTenBN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSDT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTuoi;
    }
}