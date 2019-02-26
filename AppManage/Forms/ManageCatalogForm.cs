using AppManage.modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppManage.Forms
{
    public partial class ManageCatalogForm : Form
    {
        public ManageCatalogForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddCatalogForm form = new AddCatalogForm();
            form.ShowDialog();
            loadAllCatalogForm();

        }

        private void toolStripButtonDel_Click(object sender, EventArgs e)
        {
            var rows = this.dataGridView1.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("选中行后再删除");
                return;
            }
            else
            {
                var ids = new List<int>();
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    ids.Add(int.Parse(row.Cells["Id"].Value.ToString()));
                }

                using (AppManageEntities entities = new AppManageEntities())
                {
                    foreach(var id in ids)
                    {
                        var log=entities.Catalog.Where(p => p.Id == id).FirstOrDefault();

                        entities.Catalog.Remove(log);
                    }
                    entities.SaveChanges();
                }
            }
            loadAllCatalogForm();


        }

        private void ManageCatalogForm_Load(object sender, EventArgs e)
        {
            loadAllCatalogForm();
        }

        //获取所有的目录
        private void loadAllCatalogForm()
        {
            using (AppManageEntities entities = new AppManageEntities())
            {
                List<Catalog> catalogs = entities.Catalog.ToList();
                this.dataGridView1.DataSource = catalogs;
            }
        }
    }
}
