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
    public partial class ManageAppForm : Form
    {
        public ManageAppForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddAppForm form = new AddAppForm();
            form.ShowDialog();
            LoadAllApps();

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
                    foreach (var id in ids)
                    {
                        var app = entities.Apps.Where(p => p.Id == id).FirstOrDefault();

                        entities.Apps.Remove(app);
                    }
                    entities.SaveChanges();
                }
            }
            LoadAllApps();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageAppForm_Load(object sender, EventArgs e)
        {
            LoadAllApps();
        }
        private void LoadAllApps()
        {
            using (AppManageEntities entities = new AppManageEntities())
            {
                var query = from q in entities.Apps
                            join p in entities.Catalog on q.app_catalogId equals p.Id
                            select new
                            {
                                Id = q.Id,
                                app_name = q.app_name,
                                app_exec_path = q.app_exec_path,
                                app_image = q.app_image,
                                app_catalogId = p.catalog_name
                            };


                this.dataGridView1.DataSource = query.ToList();


            }
        }

    }
}
