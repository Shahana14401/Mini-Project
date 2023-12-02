namespace ImageForensic
{
    partial class Embedd1
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
            this.Bt_embbd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.lb_max_amt_data1 = new System.Windows.Forms.Label();
            this.lb_space1 = new System.Windows.Forms.Label();
            this.lb_img_size1 = new System.Windows.Forms.Label();
            this.lb_max_amt_data = new System.Windows.Forms.Label();
            this.lb_space = new System.Windows.Forms.Label();
            this.lb_img_size = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.histogramaDesenat1 = new ImageForensic.HistogramaDesenat();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_embbd
            // 
            this.Bt_embbd.BackColor = System.Drawing.Color.Transparent;
            this.Bt_embbd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_embbd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_embbd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_embbd.ForeColor = System.Drawing.Color.White;
            this.Bt_embbd.Location = new System.Drawing.Point(20, 534);
            this.Bt_embbd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bt_embbd.Name = "Bt_embbd";
            this.Bt_embbd.Size = new System.Drawing.Size(369, 65);
            this.Bt_embbd.TabIndex = 16;
            this.Bt_embbd.Text = "Embedd";
            this.Bt_embbd.UseVisualStyleBackColor = false;
            this.Bt_embbd.Click += new System.EventHandler(this.Bt_embbd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select File :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(20, 614);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 48);
            this.button3.TabIndex = 15;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "Embedd here....";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(207, 615);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 47);
            this.button5.TabIndex = 21;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb_file
            // 
            this.tb_file.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_file.Location = new System.Drawing.Point(21, 462);
            this.tb_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_file.Multiline = true;
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(368, 46);
            this.tb_file.TabIndex = 18;
            // 
            // lb_max_amt_data1
            // 
            this.lb_max_amt_data1.AutoSize = true;
            this.lb_max_amt_data1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_max_amt_data1.ForeColor = System.Drawing.Color.White;
            this.lb_max_amt_data1.Location = new System.Drawing.Point(864, 355);
            this.lb_max_amt_data1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_max_amt_data1.Name = "lb_max_amt_data1";
            this.lb_max_amt_data1.Size = new System.Drawing.Size(0, 17);
            this.lb_max_amt_data1.TabIndex = 30;
            this.lb_max_amt_data1.Visible = false;
            // 
            // lb_space1
            // 
            this.lb_space1.AutoSize = true;
            this.lb_space1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_space1.ForeColor = System.Drawing.Color.White;
            this.lb_space1.Location = new System.Drawing.Point(823, 319);
            this.lb_space1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_space1.Name = "lb_space1";
            this.lb_space1.Size = new System.Drawing.Size(0, 17);
            this.lb_space1.TabIndex = 29;
            this.lb_space1.Visible = false;
            // 
            // lb_img_size1
            // 
            this.lb_img_size1.AutoSize = true;
            this.lb_img_size1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img_size1.ForeColor = System.Drawing.Color.White;
            this.lb_img_size1.Location = new System.Drawing.Point(804, 281);
            this.lb_img_size1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_img_size1.Name = "lb_img_size1";
            this.lb_img_size1.Size = new System.Drawing.Size(0, 17);
            this.lb_img_size1.TabIndex = 28;
            this.lb_img_size1.Visible = false;
            // 
            // lb_max_amt_data
            // 
            this.lb_max_amt_data.AutoSize = true;
            this.lb_max_amt_data.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_max_amt_data.ForeColor = System.Drawing.Color.White;
            this.lb_max_amt_data.Location = new System.Drawing.Point(701, 356);
            this.lb_max_amt_data.Name = "lb_max_amt_data";
            this.lb_max_amt_data.Size = new System.Drawing.Size(140, 19);
            this.lb_max_amt_data.TabIndex = 27;
            this.lb_max_amt_data.Text = "Max. amount of Data :";
            // 
            // lb_space
            // 
            this.lb_space.AutoSize = true;
            this.lb_space.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_space.ForeColor = System.Drawing.Color.White;
            this.lb_space.Location = new System.Drawing.Point(701, 319);
            this.lb_space.Name = "lb_space";
            this.lb_space.Size = new System.Drawing.Size(101, 19);
            this.lb_space.TabIndex = 26;
            this.lb_space.Text = "Possible Space :";
            // 
            // lb_img_size
            // 
            this.lb_img_size.AutoSize = true;
            this.lb_img_size.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_img_size.ForeColor = System.Drawing.Color.White;
            this.lb_img_size.Location = new System.Drawing.Point(701, 281);
            this.lb_img_size.Name = "lb_img_size";
            this.lb_img_size.Size = new System.Drawing.Size(80, 19);
            this.lb_img_size.TabIndex = 25;
            this.lb_img_size.Text = "Image Size :";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(695, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 238);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::ImageForensic.Properties.Resources.search;
            this.button4.Location = new System.Drawing.Point(418, 462);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 52);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // histogramaDesenat1
            // 
            this.histogramaDesenat1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.histogramaDesenat1.DisplayColor = System.Drawing.Color.Black;
            this.histogramaDesenat1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histogramaDesenat1.Location = new System.Drawing.Point(695, 430);
            this.histogramaDesenat1.Margin = new System.Windows.Forms.Padding(4);
            this.histogramaDesenat1.Name = "histogramaDesenat1";
            this.histogramaDesenat1.Offset = 20;
            this.histogramaDesenat1.Size = new System.Drawing.Size(404, 232);
            this.histogramaDesenat1.TabIndex = 24;
            // 
            // Embedd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(119)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1185, 722);
            this.Controls.Add(this.lb_max_amt_data1);
            this.Controls.Add(this.lb_space1);
            this.Controls.Add(this.lb_img_size1);
            this.Controls.Add(this.lb_max_amt_data);
            this.Controls.Add(this.lb_space);
            this.Controls.Add(this.lb_img_size);
            this.Controls.Add(this.histogramaDesenat1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bt_embbd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tb_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Embedd1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Embedd1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button Bt_embbd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private HistogramaDesenat histogramaDesenat1;
        private System.Windows.Forms.Label lb_max_amt_data1;
        private System.Windows.Forms.Label lb_space1;
        private System.Windows.Forms.Label lb_img_size1;
        private System.Windows.Forms.Label lb_max_amt_data;
        private System.Windows.Forms.Label lb_space;
        private System.Windows.Forms.Label lb_img_size;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}