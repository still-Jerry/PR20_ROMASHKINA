namespace Repair
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.LogoBox = new System.Windows.Forms.GroupBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoPictures = new System.Windows.Forms.PictureBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.AddingButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.JobTitleTextBox = new System.Windows.Forms.TextBox();
            this.OTextBox = new System.Windows.Forms.TextBox();
            this.ITextBox = new System.Windows.Forms.TextBox();
            this.FTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.AddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.LogoBox.Controls.Add(this.LogoLabel);
            this.LogoBox.Controls.Add(this.LogoPictures);
            this.LogoBox.Location = new System.Drawing.Point(179, -9);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(0);
            this.LogoBox.MinimumSize = new System.Drawing.Size(315, 0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(315, 61);
            this.LogoBox.TabIndex = 9;
            this.LogoBox.TabStop = false;
            // 
            // LogoLabel
            // 
            this.LogoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoLabel.AutoSize = true;
            this.LogoLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogoLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoLabel.Location = new System.Drawing.Point(59, 22);
            this.LogoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.LogoLabel.Name = "LogoLabel";
            this.LogoLabel.Size = new System.Drawing.Size(255, 27);
            this.LogoLabel.TabIndex = 0;
            this.LogoLabel.Text = "Ремонт бытовой техники ";
            // 
            // LogoPictures
            // 
            this.LogoPictures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoPictures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPictures.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictures.Image")));
            this.LogoPictures.Location = new System.Drawing.Point(6, 16);
            this.LogoPictures.Name = "LogoPictures";
            this.LogoPictures.Size = new System.Drawing.Size(49, 39);
            this.LogoPictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictures.TabIndex = 1;
            this.LogoPictures.TabStop = false;
            // 
            // MenuButton
            // 
            this.MenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuButton.BackColor = System.Drawing.Color.OrangeRed;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.ForeColor = System.Drawing.Color.White;
            this.MenuButton.Location = new System.Drawing.Point(13, 33);
            this.MenuButton.MaximumSize = new System.Drawing.Size(0, 34);
            this.MenuButton.MinimumSize = new System.Drawing.Size(63, 34);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(63, 34);
            this.MenuButton.TabIndex = 8;
            this.MenuButton.Text = "Назад";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablesComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesComboBox.Location = new System.Drawing.Point(528, 36);
            this.TablesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(150, 31);
            this.TablesComboBox.Sorted = true;
            this.TablesComboBox.TabIndex = 7;
            this.TablesComboBox.Visible = false;
            // 
            // AddGroupBox
            // 
            this.AddGroupBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.AddGroupBox.Controls.Add(this.AddingButton);
            this.AddGroupBox.Controls.Add(this.dateTimePicker);
            this.AddGroupBox.Controls.Add(this.JobTitleTextBox);
            this.AddGroupBox.Controls.Add(this.OTextBox);
            this.AddGroupBox.Controls.Add(this.ITextBox);
            this.AddGroupBox.Controls.Add(this.FTextBox);
            this.AddGroupBox.Controls.Add(this.label5);
            this.AddGroupBox.Controls.Add(this.label4);
            this.AddGroupBox.Controls.Add(this.label3);
            this.AddGroupBox.Controls.Add(this.label2);
            this.AddGroupBox.Controls.Add(this.label1);
            this.AddGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGroupBox.Location = new System.Drawing.Point(0, 348);
            this.AddGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(684, 138);
            this.AddGroupBox.TabIndex = 10;
            this.AddGroupBox.TabStop = false;
            // 
            // AddingButton
            // 
            this.AddingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddingButton.BackColor = System.Drawing.Color.OrangeRed;
            this.AddingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddingButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddingButton.ForeColor = System.Drawing.Color.White;
            this.AddingButton.Location = new System.Drawing.Point(554, 98);
            this.AddingButton.MaximumSize = new System.Drawing.Size(120, 34);
            this.AddingButton.MinimumSize = new System.Drawing.Size(63, 34);
            this.AddingButton.Name = "AddingButton";
            this.AddingButton.Size = new System.Drawing.Size(120, 34);
            this.AddingButton.TabIndex = 10;
            this.AddingButton.Text = "Добавить";
            this.AddingButton.UseVisualStyleBackColor = false;
            this.AddingButton.Click += new System.EventHandler(this.AddingButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CustomFormat = "yyyy.mm.dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(554, 41);
            this.dateTimePicker.MaxDate = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(120, 30);
            this.dateTimePicker.TabIndex = 9;
            this.dateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // JobTitleTextBox
            // 
            this.JobTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JobTitleTextBox.Location = new System.Drawing.Point(281, 102);
            this.JobTitleTextBox.MaxLength = 45;
            this.JobTitleTextBox.Name = "JobTitleTextBox";
            this.JobTitleTextBox.Size = new System.Drawing.Size(250, 30);
            this.JobTitleTextBox.TabIndex = 8;
            this.JobTitleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JobTitleTextBox_KeyPress);
            // 
            // OTextBox
            // 
            this.OTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OTextBox.Location = new System.Drawing.Point(281, 41);
            this.OTextBox.MaxLength = 30;
            this.OTextBox.Name = "OTextBox";
            this.OTextBox.Size = new System.Drawing.Size(250, 30);
            this.OTextBox.TabIndex = 7;
            this.OTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OTextBox_KeyPress);
            // 
            // ITextBox
            // 
            this.ITextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ITextBox.Location = new System.Drawing.Point(10, 102);
            this.ITextBox.MaxLength = 15;
            this.ITextBox.Name = "ITextBox";
            this.ITextBox.Size = new System.Drawing.Size(250, 30);
            this.ITextBox.TabIndex = 6;
            this.ITextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ITextBox_KeyPress);
            // 
            // FTextBox
            // 
            this.FTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FTextBox.Location = new System.Drawing.Point(10, 41);
            this.FTextBox.MaxLength = 30;
            this.FTextBox.Name = "FTextBox";
            this.FTextBox.Size = new System.Drawing.Size(250, 30);
            this.FTextBox.TabIndex = 5;
            this.FTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 486);
            this.Controls.Add(this.AddGroupBox);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.TablesComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(670, 300);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.LogoBox.ResumeLayout(false);
            this.LogoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.AddGroupBox.ResumeLayout(false);
            this.AddGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LogoBox;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox LogoPictures;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TablesComboBox;
        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.Button AddingButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox JobTitleTextBox;
        private System.Windows.Forms.TextBox OTextBox;
        private System.Windows.Forms.TextBox ITextBox;
        private System.Windows.Forms.TextBox FTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}