namespace Repair
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.LogoLabel = new System.Windows.Forms.Label();
            this.LogoPictures = new System.Windows.Forms.PictureBox();
            this.LogoBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictures)).BeginInit();
            this.LogoBox.SuspendLayout();
            this.SuspendLayout();
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
            // LogoBox
            // 
            this.LogoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.LogoBox.Controls.Add(this.LogoLabel);
            this.LogoBox.Controls.Add(this.LogoPictures);
            this.LogoBox.Location = new System.Drawing.Point(40, -8);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(315, 61);
            this.LogoBox.TabIndex = 2;
            this.LogoBox.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.BackColor = System.Drawing.Color.OrangeRed;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(100, 138);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(195, 40);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавление";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewButton.BackColor = System.Drawing.Color.OrangeRed;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewButton.ForeColor = System.Drawing.Color.White;
            this.ViewButton.Location = new System.Drawing.Point(100, 78);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(195, 39);
            this.ViewButton.TabIndex = 4;
            this.ViewButton.Text = "Просмотр";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 211);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LogoBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(395, 250);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictures)).EndInit();
            this.LogoBox.ResumeLayout(false);
            this.LogoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LogoLabel;
        private System.Windows.Forms.PictureBox LogoPictures;
        private System.Windows.Forms.GroupBox LogoBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ViewButton;
    }
}

