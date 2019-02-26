using AppManage.Forms;
using AppManage.modal;
using AppManage.Usercontrol;
using AppManage.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppManage
{
    public partial class Main : Form
    {
        private Int32 currentCatalogId=-1;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            setSpliterDistance();
            this.loadAllCatalog();

        }
        //获取所有的目录

        private void loadAllCatalog()
        {
            
            using (AppManageEntities entities = new AppManageEntities())
            {
                List<Catalog> catalogs = entities.Catalog.ToList();
                if (catalogs != null && catalogs.Count > 0)
                {
                    Content[] contents = new Content[catalogs.Count];
                    for (int j = 0; j < catalogs.Count; j++)
                    {
                        int x = 31 + j * 115;//k第几列

                        contents[j] = new Content();
                        contents[j].name =catalogs[j].catalog_name;
                        contents[j].Id = catalogs[j].Id;
                        contents[j].Location = new System.Drawing.Point(x, 22);
                        contents[j].Size = new System.Drawing.Size(101, 119);
                        if (catalogs[j].catlog_image_path!=null&& catalogs[j].catlog_image_path!="")
                        {
                            contents[j].backgroundImage = "\\catlogImage" + "\\"+ catalogs[j].catlog_image_path;
                        }
                        contents[j].ClickContrlDelegate = this.clickContentControl;

                        //list.Add(content);
                        //this.panel1.Controls.Add(contents[j]);
                    }
                    this.panel1.AutoScroll = true;
                    this.panel1.Controls.Clear();
                    this.panel1.Controls.AddRange(contents);
                }
            }
        }
        #region 自定义方法
        /// <summary>
        /// 设定容器的分割距离随着窗体变化而变化
        /// </summary>
        private void setSpliterDistance()
        {
            var split = this.Size.Height -250;
            this.splitContainer1.SplitterDistance = (int)(split);
          
          
        }
        #endregion

        private void clickContentControl(Content content)
        {

            //MessageBox.Show(content.name);
            currentCatalogId = -1;
            Int32 catalogId = content.Id;
            currentCatalogId = catalogId;
            loadAllAppsByCatalogId(catalogId);
        }

        private void loadAllAppsByCatalogId(Int32 catalogId)
        {
            this.flowLayoutPanel1.Controls.Clear();
            using (AppManageEntities entities = new AppManageEntities())
            {
                List<Apps> apps = entities.Apps.Where(p => p.app_catalogId == catalogId).ToList();
                if (apps != null && apps.Count > 0)
                {
                    Content[] contents = new Content[apps.Count];
                    for (int j = 0; j < apps.Count; j++)
                    {
                        int x = 31 + j * 115;//k第几列

                        contents[j] = new Content();
                        contents[j].name = apps[j].app_name;
                        contents[j].Id = apps[j].Id;
                        if (apps[j].app_image!=null&& apps[j].app_image != "")
                        {
                            contents[j].backgroundImage = "\\appImage" + "\\"+apps[j].app_image;
                        }
                        
                        contents[j].ClickContrlDelegate = this.clickAppControl;
                    }
                    this.flowLayoutPanel1.Controls.AddRange(contents);
                }


            }
        }

        private void clickAppControl(Content content)
        {
            Int32 appId = content.Id;
            //MessageBox.Show(appId.ToString());
            using (AppManageEntities entities = new AppManageEntities())
            {
                Apps app = entities.Apps.FirstOrDefault(p => p.Id == appId);
                if (app != null)
                {
                    Process myProcess = new Process();
                    try
                    {
                        myProcess.StartInfo.UseShellExecute = false;
                        myProcess.StartInfo.FileName = app.app_exec_path;
                        myProcess.StartInfo.CreateNoWindow = true;
                        myProcess.Start();
                    }
                    catch (Exception e)
                    {
                        LoggerUtil.WriteLog(typeof(Main), e.ToString());

                        MessageBox.Show(e.ToString());
                    }
                }

            }
           

        }

        private void toolStripButtonCatalog_Click(object sender, EventArgs e)
        {
            ManageCatalogForm form = new ManageCatalogForm();
            form.ShowDialog();
            this.loadAllCatalog();
        }

        private void toolStripButtonApp_Click(object sender, EventArgs e)
        {
            ManageAppForm form = new ManageAppForm();
            form.ShowDialog();
            if (currentCatalogId != -1)
            {
                this.loadAllAppsByCatalogId(currentCatalogId);
            }
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            setSpliterDistance();
        }
    }
}
