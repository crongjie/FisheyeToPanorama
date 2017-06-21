namespace FisheyeToPanorama
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
            this.pb_source = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_convert = new System.Windows.Forms.Button();
            this.pb_result = new System.Windows.Forms.PictureBox();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_source
            // 
            this.pb_source.BackColor = System.Drawing.Color.Black;
            this.pb_source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_source.Location = new System.Drawing.Point(12, 12);
            this.pb_source.Name = "pb_source";
            this.pb_source.Size = new System.Drawing.Size(350, 350);
            this.pb_source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_source.TabIndex = 0;
            this.pb_source.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(12, 368);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(368, 174);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 2;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // pb_result
            // 
            this.pb_result.BackColor = System.Drawing.Color.Black;
            this.pb_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_result.Location = new System.Drawing.Point(449, 12);
            this.pb_result.Name = "pb_result";
            this.pb_result.Size = new System.Drawing.Size(350, 350);
            this.pb_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_result.TabIndex = 3;
            this.pb_result.TabStop = false;
            // 
            // tb_file
            // 
            this.tb_file.Location = new System.Drawing.Point(94, 371);
            this.tb_file.Name = "tb_file";
            this.tb_file.ReadOnly = true;
            this.tb_file.Size = new System.Drawing.Size(268, 19);
            this.tb_file.TabIndex = 4;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(724, 369);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "PNG Files|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 401);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_file);
            this.Controls.Add(this.pb_result);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.pb_source);
            this.Name = "Form1";
            this.Text = "Fisheye To Panorama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_source;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.PictureBox pb_result;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

