using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WizardBase;
using System.IO;
using OSGeo.GDAL;
using System.Xml;  //添加带有csharp的四个dll，并加上该命名空间;

namespace PosCheckApp
{
    public partial class projWard : Form
    {

        XmlDocument xmldoc;
        XmlNode xmlnode;
        XmlElement xmlelem;



        public projWard()
        {
            InitializeComponent();
        }

        private void projWard_Load(object sender, EventArgs e)
        {
            flyHeight.Value = 300;
        }

/// <summary>
/// ///////////////////page 1 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void projName_TextChanged(object sender, EventArgs e)
        {
            if (projPath.Text != "" && projName.Text != "")
            {
                this.wizardControl1.NextButtonEnabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                projPath.Text = foldPath;
            }

            if (projPath.Text != "" && projName.Text != "")
            {
                this.wizardControl1.NextButtonEnabled = true;
            }
            
        }


/// <summary>
/// /////////////////////page 2/////
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void btn_imagePath_Click(object sender, EventArgs e)
        {
            string imagePath = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                imagePath = foldPath;
            }
            else
                return;


        ///分析照片信息
            MainMap.instance.g_imagePath = imagePath;
            DirectoryInfo folder = new DirectoryInfo(imagePath);
            int photoNum = 0;
            foreach (FileInfo file in folder.GetFiles("*.jpg"))
            {
                photoNum++;
                MainMap.instance.m_initphotofiles.Add(file.FullName);
               
            }
            labelimages.Text = "总共有："+photoNum.ToString()+"张航片，均未定位";
        }

        private void btn_posFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pos Files|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;
            try
            {
                openFileDialog1.InitialDirectory = "C:\\";
            }
            catch { } // incase dir doesnt exist

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 MainMap.instance.g_posFilePath = openFileDialog1.FileName;
                 int countpos = MainMap.instance.ReadPosFile(openFileDialog1.FileName);
                 labelPos.Text = "总共有：" + countpos.ToString() + "个航点位置";
            }
        }

        private void wizardControl1_CancelButtonClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定退出新建向导吗？", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Close();
            }
        }

        //工程建立
        private void wizardControl1_FinishButtonClick(object sender, EventArgs e)
        {
            MainMap.instance.g_projName = projName.Text;
            if (Directory.Exists(projName.Text) == false)//如果不存在就创建file文件夹
            {
                string p = projPath.Text + "\\" + projName.Text;
                Directory.CreateDirectory(p);
            }


            xmldoc = new XmlDocument ( ) ;           
            XmlDeclaration xmldecl;
            xmldecl = xmldoc.CreateXmlDeclaration("1.0","gb2312",null);
            xmldoc.AppendChild (xmldecl);
                        //加入一个根元素
            xmlelem = xmldoc.CreateElement ( "" , "PosCheckApp" , "" ) ;
            xmldoc.AppendChild (xmlelem) ;
            //加入另外一个元素
          
            XmlNode root=xmldoc.SelectSingleNode("PosCheckApp");//查找<Employees> 
            XmlElement xe1=xmldoc.CreateElement("version");//创建一个<Node>节点 
            xe1.SetAttribute("value","1.17.05.21");//设置该节点genre属性 
            root.AppendChild(xe1);

            xe1 = xmldoc.CreateElement("projectName");
            xe1.SetAttribute("value", projName.Text);
            root.AppendChild(xe1);

            xe1 = xmldoc.CreateElement("FlyHeight");
            xe1.SetAttribute("value", flyHeight.Text);
            root.AppendChild(xe1);

            xe1=xmldoc.CreateElement("posfilePath");
            xe1.SetAttribute("value",MainMap.instance.g_posFilePath);
            root.AppendChild(xe1);

            xe1=xmldoc.CreateElement("imagefilePath");
            xe1.SetAttribute("value",MainMap.instance.g_imagePath);
            root.AppendChild(xe1);
     
            xe1=xmldoc.CreateElement("images");
           
            root.AppendChild(xe1);
            //保存创建好的XML文档
            xmldoc.Save(projPath.Text + "\\" + projName.Text + ".xml"); 

            //建立影像金字塔

            for (int i = 0; i < MainMap.instance.m_initphotofiles.Count; i++ )
            {
                string photo = System.IO.Path.GetDirectoryName(MainMap.instance.m_initphotofiles[i]) +"\\"+ System.IO.Path.GetFileNameWithoutExtension(MainMap.instance.m_initphotofiles[i]);
                if (!File.Exists(photo+".aux"))
                    CreatePyramids(MainMap.instance.m_initphotofiles[i]);
            }
            Close();
        }

        private bool CreatePyramids(string filename)
        {
            Gdal.AllRegister();
            Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "NO");
            Gdal.SetConfigOption("SHAPE_ENCODING", "");

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
            for (int a = 0; a < nLevelCount; a++)
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
