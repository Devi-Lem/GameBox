namespace WindowsFormsApp2
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelGameInfo = new System.Windows.Forms.Panel();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelGener = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStores = new System.Windows.Forms.Label();
            this.buttonLike = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelGameInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(265, 146);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(28, 28, 3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelGameInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelStores);
            this.splitContainer1.Size = new System.Drawing.Size(401, 247);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.TabIndex = 14;
            // 
            // panelGameInfo
            // 
            this.panelGameInfo.Controls.Add(this.labelPlatform);
            this.panelGameInfo.Controls.Add(this.labelAge);
            this.panelGameInfo.Controls.Add(this.labelDeveloper);
            this.panelGameInfo.Controls.Add(this.labelDate);
            this.panelGameInfo.Controls.Add(this.labelGener);
            this.panelGameInfo.Controls.Add(this.labelName);
            this.panelGameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGameInfo.Location = new System.Drawing.Point(0, 0);
            this.panelGameInfo.Margin = new System.Windows.Forms.Padding(28, 3, 3, 3);
            this.panelGameInfo.Name = "panelGameInfo";
            this.panelGameInfo.Size = new System.Drawing.Size(401, 121);
            this.panelGameInfo.TabIndex = 9;
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelPlatform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.labelPlatform.Location = new System.Drawing.Point(0, 100);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(134, 18);
            this.labelPlatform.TabIndex = 5;
            this.labelPlatform.Text = "Platform: Test";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.labelAge.Location = new System.Drawing.Point(0, 80);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(89, 18);
            this.labelAge.TabIndex = 4;
            this.labelAge.Text = "Age: Test";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelDeveloper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.labelDeveloper.Location = new System.Drawing.Point(0, 60);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(143, 18);
            this.labelDeveloper.TabIndex = 3;
            this.labelDeveloper.Text = "Developer: Test";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.labelDate.Location = new System.Drawing.Point(0, 40);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(98, 18);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date: Test";
            // 
            // labelGener
            // 
            this.labelGener.AutoSize = true;
            this.labelGener.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelGener.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.labelGener.Location = new System.Drawing.Point(0, 20);
            this.labelGener.Name = "labelGener";
            this.labelGener.Size = new System.Drawing.Size(107, 18);
            this.labelGener.TabIndex = 1;
            this.labelGener.Text = "Gener: Test";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name: Test";
            // 
            // labelStores
            // 
            this.labelStores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStores.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelStores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(240)))));
            this.labelStores.Location = new System.Drawing.Point(0, 0);
            this.labelStores.Name = "labelStores";
            this.labelStores.Size = new System.Drawing.Size(401, 122);
            this.labelStores.TabIndex = 0;
            this.labelStores.Text = "Stores:";
            // 
            // buttonLike
            // 
            this.buttonLike.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLike.FlatAppearance.BorderSize = 0;
            this.buttonLike.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(31)))), ((int)(((byte)(138)))));
            this.buttonLike.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(37)))), ((int)(((byte)(167)))));
            this.buttonLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLike.ImageIndex = 0;
            this.buttonLike.ImageList = this.imageList1;
            this.buttonLike.Location = new System.Drawing.Point(268, 426);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.buttonLike.Size = new System.Drawing.Size(25, 25);
            this.buttonLike.TabIndex = 15;
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "like.png");
            this.imageList1.Images.SetKeyName(1, "liked.png");
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(31)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(37)))), ((int)(((byte)(167)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 28, 28, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(674, 536);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.Text = "Form3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelGameInfo.ResumeLayout(false);
            this.panelGameInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelGameInfo;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelGener;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStores;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.ImageList imageList1;
    }
}