namespace WindowsFormsApp2
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCollapseMenu = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.panelGameDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
            this.panelGameDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(194)))));
            this.panelMenu.Controls.Add(this.buttonCollapseMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 25);
            this.panelMenu.MinimumSize = new System.Drawing.Size(25, 85);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(110, 536);
            this.panelMenu.TabIndex = 7;
            // 
            // buttonCollapseMenu
            // 
            this.buttonCollapseMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(194)))));
            this.buttonCollapseMenu.FlatAppearance.BorderSize = 0;
            this.buttonCollapseMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(31)))), ((int)(((byte)(138)))));
            this.buttonCollapseMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(37)))), ((int)(((byte)(167)))));
            this.buttonCollapseMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollapseMenu.Image = global::WindowsFormsApp2.Properties.Resources.MenuButton;
            this.buttonCollapseMenu.Location = new System.Drawing.Point(3, 2);
            this.buttonCollapseMenu.Name = "buttonCollapseMenu";
            this.buttonCollapseMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.buttonCollapseMenu.Size = new System.Drawing.Size(25, 25);
            this.buttonCollapseMenu.TabIndex = 2;
            this.buttonCollapseMenu.UseVisualStyleBackColor = false;
            this.buttonCollapseMenu.Click += new System.EventHandler(this.buttonCollapseMenu_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(194)))));
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.buttonMinimize);
            this.panelControl.Controls.Add(this.buttonMaximize);
            this.panelControl.Controls.Add(this.buttonClose);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(784, 25);
            this.panelControl.TabIndex = 6;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(31, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "GameBox";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(194)))));
            this.buttonMinimize.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Minimize;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(31)))), ((int)(((byte)(138)))));
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(37)))), ((int)(((byte)(167)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonMinimize.Location = new System.Drawing.Point(679, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(35, 25);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(194)))));
            this.buttonMaximize.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Maximize;
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(31)))), ((int)(((byte)(138)))));
            this.buttonMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(37)))), ((int)(((byte)(167)))));
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonMaximize.Location = new System.Drawing.Point(714, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(35, 25);
            this.buttonMaximize.TabIndex = 1;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(194)))));
            this.buttonClose.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Close;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(31)))), ((int)(((byte)(138)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(37)))), ((int)(((byte)(167)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonClose.Location = new System.Drawing.Point(749, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(35, 25);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(77)))));
            this.panelWorkspace.Controls.Add(this.panelGameDisplay);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(110, 25);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(674, 536);
            this.panelWorkspace.TabIndex = 11;
            // 
            // panelGameDisplay
            // 
            this.panelGameDisplay.AutoScroll = true;
            this.panelGameDisplay.AutoSize = true;
            this.panelGameDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGameDisplay.ColumnCount = 4;
            this.panelGameDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelGameDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelGameDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelGameDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelGameDisplay.Controls.Add(this.pictureBox1, 0, 0);
            this.panelGameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelGameDisplay.Margin = new System.Windows.Forms.Padding(10);
            this.panelGameDisplay.Name = "panelGameDisplay";
            this.panelGameDisplay.RowCount = 23;
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelGameDisplay.Size = new System.Drawing.Size(674, 536);
            this.panelGameDisplay.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 215);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(194)))));
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(31)))), ((int)(((byte)(138)))));
            this.buttonProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(37)))), ((int)(((byte)(167)))));
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.buttonProfile.Image = global::WindowsFormsApp2.Properties.Resources.Profile;
            this.buttonProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.Location = new System.Drawing.Point(0, 58);
            this.buttonProfile.MaximumSize = new System.Drawing.Size(110, 25);
            this.buttonProfile.MinimumSize = new System.Drawing.Size(0, 25);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonProfile.Size = new System.Drawing.Size(110, 25);
            this.buttonProfile.TabIndex = 9;
            this.buttonProfile.Text = "   Profile";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            this.buttonProfile.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonProfile.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(194)))));
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(31)))), ((int)(((byte)(138)))));
            this.buttonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(37)))), ((int)(((byte)(167)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.buttonLogout.Image = global::WindowsFormsApp2.Properties.Resources.Logout;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 88);
            this.buttonLogout.MaximumSize = new System.Drawing.Size(110, 25);
            this.buttonLogout.MinimumSize = new System.Drawing.Size(0, 25);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonLogout.Size = new System.Drawing.Size(110, 25);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "   Log out";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            this.buttonLogout.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.buttonLogout.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.icon;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxLogo.TabIndex = 10;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(43)))), ((int)(((byte)(194)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(760, 115);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameBox";
            this.ResizeBegin += new System.EventHandler(this.Form2_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Form2_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelWorkspace.ResumeLayout(false);
            this.panelWorkspace.PerformLayout();
            this.panelGameDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonCollapseMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.TableLayoutPanel panelGameDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}