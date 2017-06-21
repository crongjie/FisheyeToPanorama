using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace FisheyeToPanorama
{
    public partial class Form1 : Form
    {
        private Bitmap source_image = null;
        private Bitmap result_image = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string file_name = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file_name = openFileDialog1.FileName;
            }
            tb_file.Text = file_name;

            if (file_name.Length > 0)
            {
                source_image = new Bitmap(file_name);
                if (source_image.Width == source_image.Height)
                {
                    pb_source.Image = source_image;
                }else
                {
                    pb_source.Image = null;
                    source_image = null;
                    MessageBox.Show("Only Fisheye Image (Square Image) is supported!");
                }
                
            }
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            if (source_image != null)
            {
                int width = source_image.Width * 2;
                int height = source_image.Height / 2;


                result_image = new Bitmap(width, height);
                for (int w = 0; w < width; ++w)
                {
                    for (int h = 0; h < height; ++h)
                    {
                        double radius = height - h;
                        double theta = Math.PI * 2 / width * w * -1;

                        int x = Convert.ToInt32(radius * Math.Cos(theta) + height);
                        int y = Convert.ToInt32(height - radius * Math.Sin(theta));
                        if (x >= 0 && x < source_image.Width && y >= 0 && y < source_image.Height)
                        {
                            result_image.SetPixel(w, height - h - 1, source_image.GetPixel(x, y));
                        }
                    }
                }
                pb_result.Image = result_image;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (result_image != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    result_image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                }
            }else
            {
                MessageBox.Show("No image is converted.");
            }

        }
    }
}
