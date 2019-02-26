using AppManage.modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AppManage.Util;
using System.IO;

namespace AppManage
{
    public partial class AddCatalogForm : Form
    {
        private String imagePath;// 件路径名


        public AddCatalogForm()
        {
            InitializeComponent();
        }
        
        // 获取图片
        private void openImage_Click(object sender, EventArgs e)
        {
            this.imagePath = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.jpg,*.png,*.jpeg,*.bmp,*.gif)|*.jgp;*.png;*.jpeg;*.bmp;*.gif|All files(*.*)|*.*";
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(openFile.FileName);
                this.imagePath = openFile.FileName;
                Console.WriteLine(openFile.FileName);
            
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
               
                var imgPath = Directory.GetCurrentDirectory() + "\\catlogImage";
                if (!Directory.Exists(imgPath))
                {
                    Directory.CreateDirectory(imgPath);
                }
                if (imagePath!=null&&!File.Exists(imagePath))
                {
                    MessageBox.Show("图片不存在");
                    return;
                }
                String filename = null;
                if (imagePath != null)
                {
                    filename=Path.GetFileName(imagePath);
                    if (File.Exists(imgPath + "\\" + filename))
                    {
                        File.Delete(imgPath + "\\" + filename);
                    }
                    File.Copy(imagePath, imgPath + "\\" + filename);
                }
                
                if (this.catalogNameText.Text == "")
                {
                    MessageBox.Show("请输入文件目录名称");
                    return;
                }
                if (this.catalogDescText.Text == "")
                {
                    MessageBox.Show("请输入目录描述");
                    return;
                }

                using (AppManageEntities entities = new AppManageEntities())
                {
                    Catalog log = entities.Catalog.FirstOrDefault(p => p.catalog_name == this.catalogNameText.Text);

                    if (log == null) 
                    {
                        Catalog catalog = new Catalog();
                        catalog.catalog_desc = this.catalogDescText.Text;
                        catalog.catalog_name = this.catalogNameText.Text;
                        catalog.catlog_image_path = filename;
                        entities.Catalog.Add(catalog);

                    }
                    else
                    {
                        log.catalog_desc = this.catalogDescText.Text;
                        log.catlog_image_path = filename;
                        entities.Catalog.Attach(log);
                     
                    }
                    entities.SaveChanges();
                    this.Close();

                }
            
            }
            catch(Exception ex)
            {
                LoggerUtil.WriteLog(typeof(AddCatalogForm), ex.ToString());
                MessageBox.Show(ex.ToString());

            }
        

        }

        private void AddCatalogForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
