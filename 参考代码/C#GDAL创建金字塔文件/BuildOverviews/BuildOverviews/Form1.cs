using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OSGeo.GDAL;//记得添加带有csharp的四个dll，并加上该命名空间;

namespace BuildOverviews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //选择要创建金字塔的文件;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择Tiff文件";
            openFileDialog.Filter = "TIFF文件(*.tif;*.tiff)|*.tif;*tiff|TIFF文件(*.tif;*.tiff)|*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text;
            CreatePyramids(fileName);

        }
        private bool CreatePyramids(string filename)
        {
            Gdal.AllRegister();
            Gdal.SetConfigOption("USE_RRD", "YES");//创建Erdas格式的字塔文件 
            Dataset ds = Gdal.Open(filename, Access.GA_Update);
            Driver drv = ds.GetDriver();
            int iWidth = ds.RasterXSize;
            int iHeight = ds.RasterYSize;
            int iPixelNum = iWidth * iHeight;//图像中的总像元个数;
            int iTopNum = 4096;   //顶层金字塔大小，64*64;
            int iCurNum = iPixelNum / 4;


            int[] anLevels = new int[1024];
            int nLevelCount = 0;
            do 
            {
                anLevels[nLevelCount] = Convert.ToInt32(Math.Pow(2.0, nLevelCount + 2));
                nLevelCount++;
                iCurNum /= 4;
            } while (iCurNum > iTopNum);
            int[] levels = new int[nLevelCount];
            for (int a = 0; a < nLevelCount;a++ )
            {
                levels[a] = anLevels[a];
            }
            ds.BuildOverviews("nearest", levels);
            ds.Dispose();
            drv.Dispose();
            return true;
        }
    }
}
