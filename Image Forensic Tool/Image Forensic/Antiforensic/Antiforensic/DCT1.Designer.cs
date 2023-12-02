namespace ImageForensic
{
    partial class DCT1
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
            this.picOrginal = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DCTMapImage = new System.Windows.Forms.PictureBox();
            this.histogramaDesenat1 = new ImageForensic.HistogramaDesenat();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOrginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCTMapImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picOrginal
            // 
            this.picOrginal.Location = new System.Drawing.Point(13, 13);
            this.picOrginal.Margin = new System.Windows.Forms.Padding(4);
            this.picOrginal.Name = "picOrginal";
            this.picOrginal.Size = new System.Drawing.Size(274, 344);
            this.picOrginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrginal.TabIndex = 6;
            this.picOrginal.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(13, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 71);
            this.button1.TabIndex = 7;
            this.button1.Text = "Find DCT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DCTMapImage
            // 
            this.DCTMapImage.Location = new System.Drawing.Point(319, 13);
            this.DCTMapImage.Margin = new System.Windows.Forms.Padding(4);
            this.DCTMapImage.Name = "DCTMapImage";
            this.DCTMapImage.Size = new System.Drawing.Size(501, 344);
            this.DCTMapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DCTMapImage.TabIndex = 8;
            this.DCTMapImage.TabStop = false;
            // 
            // histogramaDesenat1
            // 
            this.histogramaDesenat1.DisplayColor = System.Drawing.Color.Black;
            this.histogramaDesenat1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histogramaDesenat1.ForeColor = System.Drawing.Color.White;
            this.histogramaDesenat1.Location = new System.Drawing.Point(319, 368);
            this.histogramaDesenat1.Margin = new System.Windows.Forms.Padding(4);
            this.histogramaDesenat1.Name = "histogramaDesenat1";
            this.histogramaDesenat1.Offset = 20;
            this.histogramaDesenat1.Size = new System.Drawing.Size(501, 275);
            this.histogramaDesenat1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(13, 459);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 79);
            this.button2.TabIndex = 10;
            this.button2.Text = "Quantize";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DCT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(119)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(860, 680);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.histogramaDesenat1);
            this.Controls.Add(this.DCTMapImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picOrginal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DCT1";
            this.Text = "DCT1";
            this.Load += new System.EventHandler(this.DCT1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOrginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DCTMapImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOrginal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox DCTMapImage;
        private HistogramaDesenat histogramaDesenat1;
        private System.Windows.Forms.Button button2;
    }
}