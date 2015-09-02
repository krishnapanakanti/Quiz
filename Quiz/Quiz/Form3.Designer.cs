namespace Quiz
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Aptitude = new System.Windows.Forms.Button();
            this.Technical = new System.Windows.Forms.Button();
            this.Current_aff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aptitude
            // 
            this.Aptitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aptitude.BackColor = System.Drawing.Color.Black;
            this.Aptitude.FlatAppearance.BorderSize = 3;
            this.Aptitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aptitude.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aptitude.ForeColor = System.Drawing.Color.Gold;
            this.Aptitude.Location = new System.Drawing.Point(562, 47);
            this.Aptitude.Name = "Aptitude";
            this.Aptitude.Size = new System.Drawing.Size(117, 34);
            this.Aptitude.TabIndex = 1;
            this.Aptitude.Text = "Aptitude";
            this.Aptitude.UseVisualStyleBackColor = false;
            this.Aptitude.Click += new System.EventHandler(this.Aptitude_Click);
            // 
            // Technical
            // 
            this.Technical.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Technical.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Technical.FlatAppearance.BorderSize = 3;
            this.Technical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Technical.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technical.ForeColor = System.Drawing.Color.Gold;
            this.Technical.Location = new System.Drawing.Point(562, 151);
            this.Technical.Name = "Technical";
            this.Technical.Size = new System.Drawing.Size(117, 34);
            this.Technical.TabIndex = 2;
            this.Technical.Text = "Technical";
            this.Technical.UseVisualStyleBackColor = false;
            this.Technical.Click += new System.EventHandler(this.Technical_Click);
            // 
            // Current_aff
            // 
            this.Current_aff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Current_aff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Current_aff.FlatAppearance.BorderSize = 3;
            this.Current_aff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Current_aff.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_aff.ForeColor = System.Drawing.Color.Gold;
            this.Current_aff.Location = new System.Drawing.Point(540, 247);
            this.Current_aff.Name = "Current_aff";
            this.Current_aff.Size = new System.Drawing.Size(159, 35);
            this.Current_aff.TabIndex = 3;
            this.Current_aff.Text = "Current Affairs";
            this.Current_aff.UseVisualStyleBackColor = false;
            this.Current_aff.Click += new System.EventHandler(this.Current_aff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 331);
            this.Controls.Add(this.Current_aff);
            this.Controls.Add(this.Technical);
            this.Controls.Add(this.Aptitude);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aptitude;
        private System.Windows.Forms.Button Technical;
        private System.Windows.Forms.Button Current_aff;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}