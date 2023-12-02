namespace Forensic
{
    partial class ExtractMultiImg
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.or = new Forensic.Histogram();
            this.tr = new Forensic.Histogram();
            this.og = new Forensic.Histogram();
            this.tb = new Forensic.Histogram();
            this.ob = new Forensic.Histogram();
            this.histogramaDesenat1 = new Forensic.HistogramaDesenat();
            this.histogramaDesenat2 = new Forensic.HistogramaDesenat();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DCTMapImage2 = new System.Windows.Forms.PictureBox();
            this.DCTMapImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tg = new Forensic.Histogram();
            ((System.ComponentModel.ISupportInitialize)(this.DCTMapImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCTMapImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 48F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(521, 106);
            this.label3.TabIndex = 10;
            this.label3.Text = "Extract Here....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Orginal Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(370, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Suspected Image";
            // 
            // or
            // 
            this.or.Location = new System.Drawing.Point(748, 141);
            this.or.Margin = new System.Windows.Forms.Padding(4);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(225, 159);
            this.or.TabIndex = 24;
            this.or.Text = "histogram1";
            // 
            // tr
            // 
            this.tr.Location = new System.Drawing.Point(995, 141);
            this.tr.Margin = new System.Windows.Forms.Padding(4);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(236, 159);
            this.tr.TabIndex = 25;
            this.tr.Text = "histogram4";
            // 
            // og
            // 
            this.og.Location = new System.Drawing.Point(748, 308);
            this.og.Margin = new System.Windows.Forms.Padding(4);
            this.og.Name = "og";
            this.og.Size = new System.Drawing.Size(225, 166);
            this.og.TabIndex = 26;
            this.og.Text = "histogram2";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(995, 483);
            this.tb.Margin = new System.Windows.Forms.Padding(4);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(261, 149);
            this.tb.TabIndex = 27;
            this.tb.Text = "histogram6";
            // 
            // ob
            // 
            this.ob.Location = new System.Drawing.Point(762, 483);
            this.ob.Margin = new System.Windows.Forms.Padding(4);
            this.ob.Name = "ob";
            this.ob.Size = new System.Drawing.Size(225, 149);
            this.ob.TabIndex = 28;
            this.ob.Text = "histogram3";
            this.ob.Click += new System.EventHandler(this.ob_Click);
            // 
            // histogramaDesenat1
            // 
            this.histogramaDesenat1.DisplayColor = System.Drawing.Color.Black;
            this.histogramaDesenat1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histogramaDesenat1.Location = new System.Drawing.Point(762, 653);
            this.histogramaDesenat1.Margin = new System.Windows.Forms.Padding(4);
            this.histogramaDesenat1.Name = "histogramaDesenat1";
            this.histogramaDesenat1.Offset = 20;
            this.histogramaDesenat1.Size = new System.Drawing.Size(225, 151);
            this.histogramaDesenat1.TabIndex = 29;
            // 
            // histogramaDesenat2
            // 
            this.histogramaDesenat2.DisplayColor = System.Drawing.Color.Black;
            this.histogramaDesenat2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histogramaDesenat2.Location = new System.Drawing.Point(1008, 669);
            this.histogramaDesenat2.Margin = new System.Windows.Forms.Padding(4);
            this.histogramaDesenat2.Name = "histogramaDesenat2";
            this.histogramaDesenat2.Offset = 20;
            this.histogramaDesenat2.Size = new System.Drawing.Size(261, 151);
            this.histogramaDesenat2.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(45, 788);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 32);
            this.label11.TabIndex = 67;
            this.label11.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 653);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Save File to";
            // 
            // tb_file
            // 
            this.tb_file.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_file.Location = new System.Drawing.Point(23, 698);
            this.tb_file.Margin = new System.Windows.Forms.Padding(4);
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(331, 32);
            this.tb_file.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Forensic.Properties.Resources.delete;
            this.button2.Location = new System.Drawing.Point(640, 653);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 89);
            this.button2.TabIndex = 68;
            this.button2.Text = "Close";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Forensic.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(469, 653);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 89);
            this.button1.TabIndex = 64;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Forensic.Properties.Resources.stack_of_photos;
            this.button3.Location = new System.Drawing.Point(556, 653);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 89);
            this.button3.TabIndex = 66;
            this.button3.Text = "Embed";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DCTMapImage2
            // 
            this.DCTMapImage2.Location = new System.Drawing.Point(387, 373);
            this.DCTMapImage2.Margin = new System.Windows.Forms.Padding(4);
            this.DCTMapImage2.Name = "DCTMapImage2";
            this.DCTMapImage2.Size = new System.Drawing.Size(343, 259);
            this.DCTMapImage2.TabIndex = 23;
            this.DCTMapImage2.TabStop = false;
            // 
            // DCTMapImage
            // 
            this.DCTMapImage.Location = new System.Drawing.Point(18, 373);
            this.DCTMapImage.Margin = new System.Windows.Forms.Padding(4);
            this.DCTMapImage.Name = "DCTMapImage";
            this.DCTMapImage.Size = new System.Drawing.Size(338, 256);
            this.DCTMapImage.TabIndex = 22;
            this.DCTMapImage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(373, 141);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(357, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 141);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Forensic.Properties.Resources.play;
            this.button4.Location = new System.Drawing.Point(637, 34);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 72);
            this.button4.TabIndex = 69;
            this.button4.Tag = "Check for dct difference";
            this.button4.Text = "Apply";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(995, 309);
            this.tg.Margin = new System.Windows.Forms.Padding(4);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(249, 166);
            this.tg.TabIndex = 70;
            this.tg.Text = "histogram5";
            // 
            // ExtractMultiImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(76)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1311, 916);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_file);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.histogramaDesenat2);
            this.Controls.Add(this.histogramaDesenat1);
            this.Controls.Add(this.ob);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.og);
            this.Controls.Add(this.tr);
            this.Controls.Add(this.or);
            this.Controls.Add(this.DCTMapImage2);
            this.Controls.Add(this.DCTMapImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtractMultiImg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExtractMultiImg";
            this.Load += new System.EventHandler(this.ExtractMultiImg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DCTMapImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCTMapImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox DCTMapImage;
        private System.Windows.Forms.PictureBox DCTMapImage2;
        private Histogram or;
        private Histogram tr;
        private Histogram og;
        private Histogram tb;
        private Histogram ob;
        private HistogramaDesenat histogramaDesenat1;
        private HistogramaDesenat histogramaDesenat2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Histogram tg;
    }
}