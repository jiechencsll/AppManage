using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppManage.modal;
using AppManage.Util;

namespace AppManage.Forms
{
    public partial class AddAppForm : Form
    {
        private String appPath;//启动程序目录

        private String appIconPath;//程序图标路径


        public AddAppForm()
        {
            InitializeComponent();
        }

        private void AddApp_Load(object sender, EventArgs e)
        {
            try
            {
                using (AppManageEntities entities = new AppManageEntities())
                {
                    List<Catalog> catalogs = entities.Catalog.ToList();
                    if (catalogs != null && catalogs.Count > 0)
                    {
                        this.comboBoxCatlog.ValueMember = "ID";
                        this.comboBoxCatlog.DisplayMember = "catalog_name";
                        this.comboBoxCatlog.DataSource = catalogs;
                        //this.comboBoxCatlog.DroppedDown = true;
                        

                    }

                }


            }catch(Exception ex)
            {
                LoggerUtil.WriteLog(typeof(AddAppForm), ex.ToString());
            }

        }

        private void chooseAppButton_Click(object sender, EventArgs e)
        {
            this.appPath = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "((*.exe)|*.exe|All files(*.*)|*.*";
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.appPathText.Text = openFile.FileName;
                this.appPath = openFile.FileName;
                this.appNameText.Text = Path.GetFileNameWithoutExtension(openFile.FileName);

            }
        }

        private void chooseIcnButton_Click(object sender, EventArgs e)
        {
            this.appIconPath = null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "(*.jpg,*.png,*.jpeg,*.bmp,*.gif)|*.jgp;*.png;*.jpeg;*.bmp;*.gif|All files(*.*)|*.*";
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(openFile.FileName);
                this.appIconPath = openFile.FileName;
                Console.WriteLine(openFile.FileName);
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {

                var imgPath = Directory.GetCurrentDirectory() + "\\appImage";
                if (!Directory.Exists(imgPath))
                {
                    Directory.CreateDirectory(imgPath);
                }
                if (appPath != null && !File.Exists(appPath))
                {
                    MessageBox.Show("启动程序不存在");
                    return;
                }
                if (appIconPath != null && !File.Exists(appIconPath))
                {
                    MessageBox.Show("图标不存在");
                    return;
                }

                String filename = null;
                if (appIconPath != null)
                {
                    filename=Path.GetFileName(appIconPath);
                    if (File.Exists(imgPath + "\\" + filename))
                    {
                        File.Delete(imgPath + "\\" + filename);
                    }
                    File.Copy(appIconPath, imgPath + "\\" + filename);
                }
               
                using (AppManageEntities entities = new AppManageEntities())
                {
                    String appName = this.appNameText.Text;
                    String appPath = this.appPath;
                    String appImage = filename;
                    Nullable<Int32> appCatalogId = this.comboBoxCatlog.SelectedValue.ToNullableInt32();
                    if (appName == "")
                    {
                        MessageBox.Show("请输入应用名称");
                        return;
                    }
                    if (appPath == "")
                    {
                        MessageBox.Show("请选择应用启动程序");
                        return;
                    }
                    if (appCatalogId ==null)
                    {
                        MessageBox.Show("请选择所属目录名称");
                        return;
                    }

                    Apps app = entities.Apps.FirstOrDefault(p => p.app_name == appName && p.app_catalogId == appCatalogId);
                    if (app == null)
                    {
                        Apps newApp = new Apps();
                        newApp.app_catalogId = appCatalogId;
                        newApp.app_exec_path = appPath;
                        newApp.app_image = appImage;
                        newApp.app_name = appName;
                        entities.Apps.Add(newApp);

                    }
                    else
                    {
                        app.app_exec_path = appPath;
                        app.app_image = appImage;

                        entities.Apps.Attach(app);

                    }
                    entities.SaveChanges();
                    this.Close();

                }

            }
            catch (Exception ex)
            {
                LoggerUtil.WriteLog(typeof(AddCatalogForm), ex.ToString());
                MessageBox.Show(ex.ToString());

            }

        }
    }
}
