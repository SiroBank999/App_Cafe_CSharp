
namespace GUI
{
    partial class BillManger
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCount = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dataView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNameTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHeaderTable = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.EHeader = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.pHeaderTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCount);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.guna2GradientButton1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.ToDate);
            this.panel1.Controls.Add(this.FromDate);
            this.panel1.Controls.Add(this.dataView);
            this.panel1.Controls.Add(this.pHeaderTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 610);
            this.panel1.TabIndex = 0;
            // 
            // lbCount
            // 
            this.lbCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(30, 523);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(83, 13);
            this.lbCount.TabIndex = 18;
            this.lbCount.Text = "Tổng số HD: 35";
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.Location = new System.Drawing.Point(686, 523);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(167, 13);
            this.lbTotal.TabIndex = 17;
            this.lbTotal.Text = "Tổng doanh thu: 5.000.000 đ";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.DisabledState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Green;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Green;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(388, 559);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(107, 32);
            this.guna2GradientButton1.TabIndex = 16;
            this.guna2GradientButton1.Text = "Xuất";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.BorderRadius = 18;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.IconRight = global::GUI.Properties.Resources.icons8_search_24px_1;
            this.txtSearch.Location = new System.Drawing.Point(346, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Mã hóa đơn";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(210, 36);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ToDate
            // 
            this.ToDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDate.CheckedState.Parent = this.ToDate;
            this.ToDate.FillColor = System.Drawing.Color.Navy;
            this.ToDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToDate.ForeColor = System.Drawing.Color.White;
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ToDate.HoverState.Parent = this.ToDate;
            this.ToDate.Location = new System.Drawing.Point(653, 97);
            this.ToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.ShadowDecoration.Parent = this.ToDate;
            this.ToDate.Size = new System.Drawing.Size(200, 36);
            this.ToDate.TabIndex = 14;
            this.ToDate.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // FromDate
            // 
            this.FromDate.CheckedState.Parent = this.FromDate;
            this.FromDate.FillColor = System.Drawing.Color.Navy;
            this.FromDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FromDate.ForeColor = System.Drawing.Color.White;
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromDate.HoverState.Parent = this.FromDate;
            this.FromDate.Location = new System.Drawing.Point(33, 97);
            this.FromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.ShadowDecoration.Parent = this.FromDate;
            this.FromDate.Size = new System.Drawing.Size(200, 36);
            this.FromDate.TabIndex = 13;
            this.FromDate.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.BackgroundColor = System.Drawing.Color.White;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataView.ColumnHeadersHeight = 35;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNo,
            this.ColNameTable,
            this.ColDateCheckIn,
            this.ColDateCheckOut,
            this.ColTotal});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataView.EnableHeadersVisualStyles = false;
            this.dataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataView.Location = new System.Drawing.Point(33, 139);
            this.dataView.Name = "dataView";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataView.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            this.dataView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(820, 367);
            this.dataView.TabIndex = 12;
            this.dataView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataView.ThemeStyle.HeaderStyle.Height = 35;
            this.dataView.ThemeStyle.ReadOnly = false;
            this.dataView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataView.ThemeStyle.RowsStyle.Height = 22;
            this.dataView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColNo
            // 
            this.ColNo.HeaderText = "#";
            this.ColNo.Name = "ColNo";
            // 
            // ColNameTable
            // 
            this.ColNameTable.HeaderText = "Tên bàn";
            this.ColNameTable.Name = "ColNameTable";
            // 
            // ColDateCheckIn
            // 
            this.ColDateCheckIn.HeaderText = "Ngày vào";
            this.ColDateCheckIn.Name = "ColDateCheckIn";
            // 
            // ColDateCheckOut
            // 
            this.ColDateCheckOut.HeaderText = "Ngày ra";
            this.ColDateCheckOut.Name = "ColDateCheckOut";
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Tổng tiền";
            this.ColTotal.Name = "ColTotal";
            // 
            // pHeaderTable
            // 
            this.pHeaderTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHeaderTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pHeaderTable.Controls.Add(this.lbTitle);
            this.pHeaderTable.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.pHeaderTable.Location = new System.Drawing.Point(215, 8);
            this.pHeaderTable.Name = "pHeaderTable";
            this.pHeaderTable.Size = new System.Drawing.Size(485, 41);
            this.pHeaderTable.TabIndex = 11;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTitle.Location = new System.Drawing.Point(192, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(82, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "THỐNG KÊ";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EHeader
            // 
            this.EHeader.BorderRadius = 35;
            this.EHeader.TargetControl = this.pHeaderTable;
            // 
            // BillManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BillManger";
            this.Size = new System.Drawing.Size(886, 610);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.pHeaderTable.ResumeLayout(false);
            this.pHeaderTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pHeaderTable;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dataView;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private Guna.UI2.WinForms.Guna2Elipse EHeader;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDate;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label lbTotal;
    }
}
