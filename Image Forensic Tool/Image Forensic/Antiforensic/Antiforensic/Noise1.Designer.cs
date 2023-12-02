namespace ImageForensic
{
    partial class Noise1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompareDCT = new System.Windows.Forms.PictureBox();
            this.Noisedetails = new System.Windows.Forms.PictureBox();
            this.Noisequantized = new System.Windows.Forms.PictureBox();
            this.NOISEDCT = new System.Windows.Forms.PictureBox();
            this.newDCTimage = new System.Windows.Forms.PictureBox();
            this.orgDCTimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CompareDCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noisedetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noisequantized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOISEDCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDCTimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgDCTimg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "DCT Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "DCT Image(After Quantization)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(225, 637);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Noise";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(340, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "DCT Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(340, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "DCT Image(After Quantization)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(639, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "Noise Signal";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(888, 566);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 28);
            this.label8.TabIndex = 23;
            this.label8.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(653, 588);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 28);
            this.label9.TabIndex = 24;
            this.label9.Text = "Difference";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(642, 637);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(299, 56);
            this.button2.TabIndex = 25;
            this.button2.Text = "Proceed";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(819, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "0.00 %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(639, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Difference";
            // 
            // CompareDCT
            // 
            this.CompareDCT.Location = new System.Drawing.Point(642, 87);
            this.CompareDCT.Margin = new System.Windows.Forms.Padding(4);
            this.CompareDCT.Name = "CompareDCT";
            this.CompareDCT.Size = new System.Drawing.Size(299, 202);
            this.CompareDCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CompareDCT.TabIndex = 26;
            this.CompareDCT.TabStop = false;
            // 
            // Noisedetails
            // 
            this.Noisedetails.Location = new System.Drawing.Point(642, 336);
            this.Noisedetails.Margin = new System.Windows.Forms.Padding(4);
            this.Noisedetails.Name = "Noisedetails";
            this.Noisedetails.Size = new System.Drawing.Size(299, 217);
            this.Noisedetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Noisedetails.TabIndex = 21;
            this.Noisedetails.TabStop = false;
            // 
            // Noisequantized
            // 
            this.Noisequantized.Location = new System.Drawing.Point(343, 325);
            this.Noisequantized.Margin = new System.Windows.Forms.Padding(4);
            this.Noisequantized.Name = "Noisequantized";
            this.Noisequantized.Size = new System.Drawing.Size(279, 228);
            this.Noisequantized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Noisequantized.TabIndex = 19;
            this.Noisequantized.TabStop = false;
            // 
            // NOISEDCT
            // 
            this.NOISEDCT.Location = new System.Drawing.Point(343, 87);
            this.NOISEDCT.Margin = new System.Windows.Forms.Padding(4);
            this.NOISEDCT.Name = "NOISEDCT";
            this.NOISEDCT.Size = new System.Drawing.Size(279, 202);
            this.NOISEDCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NOISEDCT.TabIndex = 17;
            this.NOISEDCT.TabStop = false;
            // 
            // newDCTimage
            // 
            this.newDCTimage.Location = new System.Drawing.Point(13, 325);
            this.newDCTimage.Margin = new System.Windows.Forms.Padding(4);
            this.newDCTimage.Name = "newDCTimage";
            this.newDCTimage.Size = new System.Drawing.Size(312, 228);
            this.newDCTimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newDCTimage.TabIndex = 11;
            this.newDCTimage.TabStop = false;
            // 
            // orgDCTimg
            // 
            this.orgDCTimg.Location = new System.Drawing.Point(13, 87);
            this.orgDCTimg.Margin = new System.Windows.Forms.Padding(4);
            this.orgDCTimg.Name = "orgDCTimg";
            this.orgDCTimg.Size = new System.Drawing.Size(312, 202);
            this.orgDCTimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orgDCTimg.TabIndex = 10;
            this.orgDCTimg.TabStop = false;
            // 
            // Noise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(119)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(960, 721);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CompareDCT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Noisedetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Noisequantized);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NOISEDCT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newDCTimage);
            this.Controls.Add(this.orgDCTimg);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Noise1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Noise1";
            ((System.ComponentModel.ISupportInitialize)(this.CompareDCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noisedetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noisequantized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOISEDCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDCTimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgDCTimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox orgDCTimg;
        private System.Windows.Forms.PictureBox newDCTimage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox NOISEDCT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Noisequantized;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Noisedetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox CompareDCT;
    }
}