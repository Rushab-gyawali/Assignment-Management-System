
namespace Assignment_Management_System.UserControls
{
    partial class UC_Faculty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtTeacher = new Guna.UI2.WinForms.Guna2TextBox();
            this.Combo_Faculty = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Update = new Guna.UI2.WinForms.Guna2Button();
            this.Add = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridTeacher = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TxtTeacher);
            this.panel1.Controls.Add(this.Combo_Faculty);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 544);
            this.panel1.TabIndex = 0;
            // 
            // TxtTeacher
            // 
            this.TxtTeacher.BorderRadius = 5;
            this.TxtTeacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTeacher.DefaultText = "";
            this.TxtTeacher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTeacher.DisabledState.Parent = this.TxtTeacher;
            this.TxtTeacher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTeacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTeacher.FocusedState.Parent = this.TxtTeacher;
            this.TxtTeacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTeacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTeacher.HoverState.Parent = this.TxtTeacher;
            this.TxtTeacher.Location = new System.Drawing.Point(40, 127);
            this.TxtTeacher.Name = "TxtTeacher";
            this.TxtTeacher.PasswordChar = '\0';
            this.TxtTeacher.PlaceholderText = "Teachers Name";
            this.TxtTeacher.SelectedText = "";
            this.TxtTeacher.ShadowDecoration.Parent = this.TxtTeacher;
            this.TxtTeacher.Size = new System.Drawing.Size(350, 36);
            this.TxtTeacher.TabIndex = 11;
            // 
            // Combo_Faculty
            // 
            this.Combo_Faculty.BackColor = System.Drawing.Color.Transparent;
            this.Combo_Faculty.BorderRadius = 5;
            this.Combo_Faculty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Combo_Faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Faculty.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combo_Faculty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Combo_Faculty.FocusedState.Parent = this.Combo_Faculty;
            this.Combo_Faculty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Combo_Faculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Combo_Faculty.HoverState.Parent = this.Combo_Faculty;
            this.Combo_Faculty.ItemHeight = 30;
            this.Combo_Faculty.ItemsAppearance.Parent = this.Combo_Faculty;
            this.Combo_Faculty.Location = new System.Drawing.Point(40, 56);
            this.Combo_Faculty.Name = "Combo_Faculty";
            this.Combo_Faculty.ShadowDecoration.Parent = this.Combo_Faculty;
            this.Combo_Faculty.Size = new System.Drawing.Size(350, 36);
            this.Combo_Faculty.TabIndex = 10;
            // 
            // Delete
            // 
            this.Delete.BorderRadius = 5;
            this.Delete.CheckedState.Parent = this.Delete;
            this.Delete.CustomImages.Parent = this.Delete;
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.DisabledState.Parent = this.Delete;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.HoverState.Parent = this.Delete;
            this.Delete.Location = new System.Drawing.Point(273, 336);
            this.Delete.Name = "Delete";
            this.Delete.ShadowDecoration.Parent = this.Delete;
            this.Delete.Size = new System.Drawing.Size(117, 38);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BorderRadius = 5;
            this.Update.CheckedState.Parent = this.Update;
            this.Update.CustomImages.Parent = this.Update;
            this.Update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Update.DisabledState.Parent = this.Update;
            this.Update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.HoverState.Parent = this.Update;
            this.Update.Location = new System.Drawing.Point(152, 336);
            this.Update.Name = "Update";
            this.Update.ShadowDecoration.Parent = this.Update;
            this.Update.Size = new System.Drawing.Size(114, 38);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.BorderRadius = 5;
            this.Add.CheckedState.Parent = this.Add;
            this.Add.CustomImages.Parent = this.Add;
            this.Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add.DisabledState.Parent = this.Add;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.HoverState.Parent = this.Add;
            this.Add.Location = new System.Drawing.Point(39, 336);
            this.Add.Name = "Add";
            this.Add.ShadowDecoration.Parent = this.Add;
            this.Add.Size = new System.Drawing.Size(107, 38);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teacher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Faculty";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGridTeacher);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(442, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 544);
            this.panel2.TabIndex = 1;
            // 
            // DataGridTeacher
            // 
            this.DataGridTeacher.AllowUserToAddRows = false;
            this.DataGridTeacher.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridTeacher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridTeacher.BackgroundColor = System.Drawing.Color.White;
            this.DataGridTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridTeacher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridTeacher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTeacher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridTeacher.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridTeacher.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridTeacher.EnableHeadersVisualStyles = false;
            this.DataGridTeacher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridTeacher.Location = new System.Drawing.Point(0, 0);
            this.DataGridTeacher.Name = "DataGridTeacher";
            this.DataGridTeacher.ReadOnly = true;
            this.DataGridTeacher.RowHeadersVisible = false;
            this.DataGridTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridTeacher.Size = new System.Drawing.Size(689, 544);
            this.DataGridTeacher.TabIndex = 0;
            this.DataGridTeacher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridTeacher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridTeacher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridTeacher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridTeacher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridTeacher.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridTeacher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridTeacher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridTeacher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridTeacher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridTeacher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridTeacher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridTeacher.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridTeacher.ThemeStyle.ReadOnly = true;
            this.DataGridTeacher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridTeacher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridTeacher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridTeacher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridTeacher.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridTeacher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridTeacher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridTeacher.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridTeacher_CellContentDoubleClick);
            this.DataGridTeacher.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridTeacher_RowHeaderMouseDoubleClick);
            // 
            // UC_Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Faculty";
            this.Size = new System.Drawing.Size(1131, 544);
            this.Load += new System.EventHandler(this.UC_Faculty_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Delete;
        private Guna.UI2.WinForms.Guna2Button Update;
        private Guna.UI2.WinForms.Guna2Button Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridTeacher;
        private Guna.UI2.WinForms.Guna2ComboBox Combo_Faculty;
        private Guna.UI2.WinForms.Guna2TextBox TxtTeacher;
    }
}
