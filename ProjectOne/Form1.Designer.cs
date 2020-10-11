namespace ProjectOne
{
    partial class Form1
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
            this.ShootHead = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShootAway = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.ReLoad = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShootHead
            // 
            this.ShootHead.Location = new System.Drawing.Point(12, 12);
            this.ShootHead.Name = "ShootHead";
            this.ShootHead.Size = new System.Drawing.Size(146, 62);
            this.ShootHead.TabIndex = 1;
            this.ShootHead.Text = "Shoot at Head";
            this.ShootHead.UseVisualStyleBackColor = true;
            this.ShootHead.Click += new System.EventHandler(this.ShootHead_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectOne.Properties.Resources.GameHub;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ShootAway
            // 
            this.ShootAway.Location = new System.Drawing.Point(13, 89);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(145, 67);
            this.ShootAway.TabIndex = 2;
            this.ShootAway.Text = "ShootAway";
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(639, 297);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(157, 62);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Spin
            // 
            this.Spin.Location = new System.Drawing.Point(13, 171);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(145, 60);
            this.Spin.TabIndex = 4;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // ReLoad
            // 
            this.ReLoad.Location = new System.Drawing.Point(13, 252);
            this.ReLoad.Name = "ReLoad";
            this.ReLoad.Size = new System.Drawing.Size(145, 65);
            this.ReLoad.TabIndex = 5;
            this.ReLoad.Text = "ReLoad";
            this.ReLoad.UseVisualStyleBackColor = true;
            this.ReLoad.Click += new System.EventHandler(this.ReLoad_Click);
            // 
            // Points
            // 
            this.Points.Location = new System.Drawing.Point(669, 0);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(127, 51);
            this.Points.TabIndex = 6;
            this.Points.Text = "Points";
            this.Points.UseVisualStyleBackColor = true;
            this.Points.Click += new System.EventHandler(this.Marks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.ReLoad);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.ShootHead);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ShootHead;
        private System.Windows.Forms.Button ShootAway;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button ReLoad;
        private System.Windows.Forms.Button Points;
    }
}

