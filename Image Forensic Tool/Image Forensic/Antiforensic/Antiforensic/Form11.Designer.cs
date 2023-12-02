namespace ImageForensic
{
    partial class Form11
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
            this.lblImageCreatedOn = new System.Windows.Forms.Label();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.lblImageDimension = new System.Windows.Forms.Label();
            this.lblImageLocation = new System.Windows.Forms.Label();
            this.lblImageExtension = new System.Windows.Forms.Label();
            this.lblImageName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orginalpic = new System.Windows.Forms.PictureBox();
            this.histogram4 = new ImageForensic.Histogram();
            this.histogram3 = new ImageForensic.Histogram();
            this.histogram2 = new ImageForensic.Histogram();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginalpic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImageCreatedOn
            // 
            this.lblImageCreatedOn.AutoSize = true;
            this.lblImageCreatedOn.BackColor = System.Drawing.Color.Transparent;
            this.lblImageCreatedOn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageCreatedOn.ForeColor = System.Drawing.Color.White;
            this.lblImageCreatedOn.Location = new System.Drawing.Point(885, 250);
            this.lblImageCreatedOn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageCreatedOn.Name = "lblImageCreatedOn";
            this.lblImageCreatedOn.Size = new System.Drawing.Size(13, 17);
            this.lblImageCreatedOn.TabIndex = 35;
            this.lblImageCreatedOn.Text = "-";
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.BackColor = System.Drawing.Color.Transparent;
            this.lblImageSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageSize.ForeColor = System.Drawing.Color.White;
            this.lblImageSize.Location = new System.Drawing.Point(882, 213);
            this.lblImageSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(13, 17);
            this.lblImageSize.TabIndex = 34;
            this.lblImageSize.Text = "-";
            // 
            // lblImageDimension
            // 
            this.lblImageDimension.AutoSize = true;
            this.lblImageDimension.BackColor = System.Drawing.Color.Transparent;
            this.lblImageDimension.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageDimension.ForeColor = System.Drawing.Color.White;
            this.lblImageDimension.Location = new System.Drawing.Point(882, 174);
            this.lblImageDimension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageDimension.Name = "lblImageDimension";
            this.lblImageDimension.Size = new System.Drawing.Size(13, 17);
            this.lblImageDimension.TabIndex = 33;
            this.lblImageDimension.Text = "-";
            // 
            // lblImageLocation
            // 
            this.lblImageLocation.AutoSize = true;
            this.lblImageLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblImageLocation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageLocation.ForeColor = System.Drawing.Color.White;
            this.lblImageLocation.Location = new System.Drawing.Point(879, 133);
            this.lblImageLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageLocation.Name = "lblImageLocation";
            this.lblImageLocation.Size = new System.Drawing.Size(13, 17);
            this.lblImageLocation.TabIndex = 32;
            this.lblImageLocation.Text = "-";
            // 
            // lblImageExtension
            // 
            this.lblImageExtension.AutoSize = true;
            this.lblImageExtension.BackColor = System.Drawing.Color.Transparent;
            this.lblImageExtension.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageExtension.ForeColor = System.Drawing.Color.White;
            this.lblImageExtension.Location = new System.Drawing.Point(879, 94);
            this.lblImageExtension.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageExtension.Name = "lblImageExtension";
            this.lblImageExtension.Size = new System.Drawing.Size(13, 17);
            this.lblImageExtension.TabIndex = 31;
            this.lblImageExtension.Text = "-";
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.BackColor = System.Drawing.Color.Transparent;
            this.lblImageName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageName.ForeColor = System.Drawing.Color.White;
            this.lblImageName.Location = new System.Drawing.Point(864, 51);
            this.lblImageName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(13, 17);
            this.lblImageName.TabIndex = 30;
            this.lblImageName.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(752, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Image Created On:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(756, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Image Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(756, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Image Dimension:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(756, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Image Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(756, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Image Extension:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(756, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Image Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(755, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 59);
            this.button1.TabIndex = 36;
            this.button1.Text = "Find DCT-->";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(403, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // orginalpic
            // 
            this.orginalpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orginalpic.Location = new System.Drawing.Point(13, 51);
            this.orginalpic.Margin = new System.Windows.Forms.Padding(4);
            this.orginalpic.Name = "orginalpic";
            this.orginalpic.Size = new System.Drawing.Size(372, 313);
            this.orginalpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orginalpic.TabIndex = 2;
            this.orginalpic.TabStop = false;
            // 
            // histogram4
            // 
            this.histogram4.Location = new System.Drawing.Point(658, 395);
            this.histogram4.Margin = new System.Windows.Forms.Padding(4);
            this.histogram4.Name = "histogram4";
            this.histogram4.Size = new System.Drawing.Size(289, 166);
            this.histogram4.TabIndex = 6;
            this.histogram4.Text = "histogram4";
            // 
            // histogram3
            // 
            this.histogram3.Location = new System.Drawing.Point(348, 395);
            this.histogram3.Margin = new System.Windows.Forms.Padding(4);
            this.histogram3.Name = "histogram3";
            this.histogram3.Size = new System.Drawing.Size(275, 178);
            this.histogram3.TabIndex = 5;
            this.histogram3.Text = "histogram3";
            // 
            // histogram2
            // 
            this.histogram2.Location = new System.Drawing.Point(13, 383);
            this.histogram2.Margin = new System.Windows.Forms.Padding(4);
            this.histogram2.Name = "histogram2";
            this.histogram2.Size = new System.Drawing.Size(283, 178);
            this.histogram2.TabIndex = 4;
            this.histogram2.Text = "histogram2";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(119)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1081, 628);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblImageCreatedOn);
            this.Controls.Add(this.lblImageSize);
            this.Controls.Add(this.lblImageDimension);
            this.Controls.Add(this.lblImageLocation);
            this.Controls.Add(this.lblImageExtension);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.histogram4);
            this.Controls.Add(this.histogram3);
            this.Controls.Add(this.histogram2);
            this.Controls.Add(this.orginalpic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orginalpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orginalpic;
        private Histogram histogram2;
        private Histogram histogram3;
        private Histogram histogram4;
        private System.Windows.Forms.Label lblImageCreatedOn;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Label lblImageDimension;
        private System.Windows.Forms.Label lblImageLocation;
        private System.Windows.Forms.Label lblImageExtension;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}