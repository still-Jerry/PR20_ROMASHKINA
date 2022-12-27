namespace Repair
{
    partial class ViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TablesComboBox = new System.Windows.Forms.ComboBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.LogoBox = new System.Windows.Forms.GroupBox();
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoPictures = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LogoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 72);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(683, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // TablesComboBox
            // 
            this.TablesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablesComboBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TablesComboBox.FormattingEnabled = true;
            this.TablesComboBox.Location = new System.Drawing.Point(527, 35);
            this.TablesComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TablesComboBox.Name = "TablesComboBox";
            this.TablesComboBox.Size = new System.Drawing.Size(150, 31);
            this.TablesComboBox.TabIndex = 1;
            this.TablesComboBox.Visible = false;
            // 
            // MenuButton
            // 
            this.MenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MenuButton.BackColor = System.Drawing.Color.OrangeRed;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuButton.ForeColor = System.Drawing.Color.White;
            this.MenuButton.Location = new System.Drawing.Point(12, 32);
            this.MenuButton.MaximumSize = new System.Drawing.Size(0, 34);
            this.MenuButton.MinimumSize = new System.Drawing.Size(63, 34);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(63, 34);
            this.MenuButton.TabIndex = 4;
            this.MenuButton.Text = "Назад";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.LogoBox.Controls.Add(this.LogoLabel);
            this.LogoBox.Controls.Add(this.LogoPictures);
            this.LogoBox.Location = new System.Drawing.Point(178, -10);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(0);
            this.LogoBox.MinimumSize = new System.Drawing.Size(315, 0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(315, 61);
            this.LogoBox.TabIndex = 5;
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
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 487);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.TablesComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(670, 160);
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewForm_FormClosed);
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LogoBox.ResumeLayout(false);
            this.LogoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TablesComboBox;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.GroupBox LogoBox;
        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox LogoPictures;
    }
}

