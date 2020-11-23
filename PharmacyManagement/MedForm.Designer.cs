namespace PharmacyManagement
{
    partial class MedForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mnameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.bpriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.datepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.spriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.qtyTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.companyComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.exportBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(389, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Information";
            // 
            // datagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid.ColumnHeadersHeight = 60;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid.EnableHeadersVisualStyles = false;
            this.datagrid.GridColor = System.Drawing.Color.White;
            this.datagrid.Location = new System.Drawing.Point(467, 105);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowHeadersVisible = false;
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(650, 380);
            this.datagrid.TabIndex = 2;
            this.datagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagrid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.datagrid.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagrid.ThemeStyle.HeaderStyle.Height = 60;
            this.datagrid.ThemeStyle.ReadOnly = false;
            this.datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Silver;
            this.datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datagrid.ThemeStyle.RowsStyle.Height = 24;
            this.datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // mnameTxt
            // 
            this.mnameTxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mnameTxt.BorderColor = System.Drawing.Color.Gray;
            this.mnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mnameTxt.DefaultText = "";
            this.mnameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mnameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mnameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mnameTxt.DisabledState.Parent = this.mnameTxt;
            this.mnameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mnameTxt.FillColor = System.Drawing.SystemColors.GrayText;
            this.mnameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mnameTxt.FocusedState.Parent = this.mnameTxt;
            this.mnameTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnameTxt.ForeColor = System.Drawing.Color.White;
            this.mnameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mnameTxt.HoverState.Parent = this.mnameTxt;
            this.mnameTxt.Location = new System.Drawing.Point(60, 144);
            this.mnameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.mnameTxt.Name = "mnameTxt";
            this.mnameTxt.PasswordChar = '\0';
            this.mnameTxt.PlaceholderText = "Medicine Name";
            this.mnameTxt.SelectedText = "";
            this.mnameTxt.ShadowDecoration.Parent = this.mnameTxt;
            this.mnameTxt.Size = new System.Drawing.Size(149, 45);
            this.mnameTxt.TabIndex = 3;
            // 
            // bpriceTxt
            // 
            this.bpriceTxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bpriceTxt.BorderColor = System.Drawing.Color.Gray;
            this.bpriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bpriceTxt.DefaultText = "";
            this.bpriceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.bpriceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.bpriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bpriceTxt.DisabledState.Parent = this.bpriceTxt;
            this.bpriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.bpriceTxt.FillColor = System.Drawing.SystemColors.GrayText;
            this.bpriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bpriceTxt.FocusedState.Parent = this.bpriceTxt;
            this.bpriceTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpriceTxt.ForeColor = System.Drawing.Color.White;
            this.bpriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bpriceTxt.HoverState.Parent = this.bpriceTxt;
            this.bpriceTxt.Location = new System.Drawing.Point(246, 144);
            this.bpriceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.bpriceTxt.Name = "bpriceTxt";
            this.bpriceTxt.PasswordChar = '\0';
            this.bpriceTxt.PlaceholderText = "Buying Price";
            this.bpriceTxt.SelectedText = "";
            this.bpriceTxt.ShadowDecoration.Parent = this.bpriceTxt;
            this.bpriceTxt.Size = new System.Drawing.Size(134, 45);
            this.bpriceTxt.TabIndex = 4;
            // 
            // datepicker
            // 
            this.datepicker.CheckedState.Parent = this.datepicker;
            this.datepicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datepicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepicker.HoverState.Parent = this.datepicker;
            this.datepicker.Location = new System.Drawing.Point(60, 326);
            this.datepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.ShadowDecoration.Parent = this.datepicker;
            this.datepicker.Size = new System.Drawing.Size(205, 44);
            this.datepicker.TabIndex = 5;
            this.datepicker.Value = new System.DateTime(2020, 11, 8, 7, 58, 25, 318);
            // 
            // spriceTxt
            // 
            this.spriceTxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.spriceTxt.BorderColor = System.Drawing.Color.Gray;
            this.spriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.spriceTxt.DefaultText = "";
            this.spriceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.spriceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.spriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.spriceTxt.DisabledState.Parent = this.spriceTxt;
            this.spriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.spriceTxt.FillColor = System.Drawing.SystemColors.GrayText;
            this.spriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.spriceTxt.FocusedState.Parent = this.spriceTxt;
            this.spriceTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spriceTxt.ForeColor = System.Drawing.Color.White;
            this.spriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.spriceTxt.HoverState.Parent = this.spriceTxt;
            this.spriceTxt.Location = new System.Drawing.Point(246, 235);
            this.spriceTxt.Margin = new System.Windows.Forms.Padding(4);
            this.spriceTxt.Name = "spriceTxt";
            this.spriceTxt.PasswordChar = '\0';
            this.spriceTxt.PlaceholderText = "Selling Price";
            this.spriceTxt.SelectedText = "";
            this.spriceTxt.ShadowDecoration.Parent = this.spriceTxt;
            this.spriceTxt.Size = new System.Drawing.Size(134, 45);
            this.spriceTxt.TabIndex = 6;
            // 
            // qtyTxt
            // 
            this.qtyTxt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.qtyTxt.BorderColor = System.Drawing.Color.Gray;
            this.qtyTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.qtyTxt.DefaultText = "";
            this.qtyTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.qtyTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.qtyTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qtyTxt.DisabledState.Parent = this.qtyTxt;
            this.qtyTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.qtyTxt.FillColor = System.Drawing.SystemColors.GrayText;
            this.qtyTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qtyTxt.FocusedState.Parent = this.qtyTxt;
            this.qtyTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTxt.ForeColor = System.Drawing.Color.White;
            this.qtyTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.qtyTxt.HoverState.Parent = this.qtyTxt;
            this.qtyTxt.Location = new System.Drawing.Point(281, 325);
            this.qtyTxt.Margin = new System.Windows.Forms.Padding(4);
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.PasswordChar = '\0';
            this.qtyTxt.PlaceholderText = "Quantity";
            this.qtyTxt.SelectedText = "";
            this.qtyTxt.ShadowDecoration.Parent = this.qtyTxt;
            this.qtyTxt.Size = new System.Drawing.Size(99, 45);
            this.qtyTxt.TabIndex = 7;
            // 
            // companyComboBox
            // 
            this.companyComboBox.BackColor = System.Drawing.Color.Transparent;
            this.companyComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.companyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.companyComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companyComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companyComboBox.FocusedState.Parent = this.companyComboBox;
            this.companyComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.companyComboBox.ForeColor = System.Drawing.Color.White;
            this.companyComboBox.HoverState.Parent = this.companyComboBox;
            this.companyComboBox.ItemHeight = 30;
            this.companyComboBox.ItemsAppearance.Parent = this.companyComboBox;
            this.companyComboBox.Location = new System.Drawing.Point(60, 235);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.ShadowDecoration.Parent = this.companyComboBox;
            this.companyComboBox.Size = new System.Drawing.Size(149, 36);
            this.companyComboBox.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.CheckedState.Parent = this.addBtn;
            this.addBtn.CustomImages.Parent = this.addBtn;
            this.addBtn.FillColor = System.Drawing.Color.Black;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.Parent = this.addBtn;
            this.addBtn.Location = new System.Drawing.Point(70, 423);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(88, 45);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.CheckedState.Parent = this.updateBtn;
            this.updateBtn.CustomImages.Parent = this.updateBtn;
            this.updateBtn.FillColor = System.Drawing.Color.Black;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.HoverState.Parent = this.updateBtn;
            this.updateBtn.Location = new System.Drawing.Point(200, 423);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ShadowDecoration.Parent = this.updateBtn;
            this.updateBtn.Size = new System.Drawing.Size(88, 45);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.CheckedState.Parent = this.deleteBtn;
            this.deleteBtn.CustomImages.Parent = this.deleteBtn;
            this.deleteBtn.FillColor = System.Drawing.Color.Black;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.HoverState.Parent = this.deleteBtn;
            this.deleteBtn.Location = new System.Drawing.Point(329, 423);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ShadowDecoration.Parent = this.deleteBtn;
            this.deleteBtn.Size = new System.Drawing.Size(88, 45);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.CheckedState.Parent = this.homeBtn;
            this.homeBtn.CustomImages.Parent = this.homeBtn;
            this.homeBtn.FillColor = System.Drawing.Color.Black;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.HoverState.Parent = this.homeBtn;
            this.homeBtn.Location = new System.Drawing.Point(1029, 26);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.ShadowDecoration.Parent = this.homeBtn;
            this.homeBtn.Size = new System.Drawing.Size(88, 45);
            this.homeBtn.TabIndex = 13;
            this.homeBtn.Text = "Home";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.CheckedState.Parent = this.exportBtn;
            this.exportBtn.CustomImages.Parent = this.exportBtn;
            this.exportBtn.FillColor = System.Drawing.Color.Black;
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.HoverState.Parent = this.exportBtn;
            this.exportBtn.Location = new System.Drawing.Point(906, 26);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.ShadowDecoration.Parent = this.exportBtn;
            this.exportBtn.Size = new System.Drawing.Size(88, 45);
            this.exportBtn.TabIndex = 40;
            this.exportBtn.Text = "Export";
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // MedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1162, 539);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.qtyTxt);
            this.Controls.Add(this.spriceTxt);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.bpriceTxt);
            this.Controls.Add(this.mnameTxt);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedForm";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView datagrid;
        private Guna.UI2.WinForms.Guna2TextBox mnameTxt;
        private Guna.UI2.WinForms.Guna2TextBox bpriceTxt;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepicker;
        private Guna.UI2.WinForms.Guna2TextBox spriceTxt;
        private Guna.UI2.WinForms.Guna2TextBox qtyTxt;
        private Guna.UI2.WinForms.Guna2ComboBox companyComboBox;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private Guna.UI2.WinForms.Guna2Button deleteBtn;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private Guna.UI2.WinForms.Guna2Button exportBtn;
    }
}