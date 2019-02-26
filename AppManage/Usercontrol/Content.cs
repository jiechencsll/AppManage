using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppManage.Usercontrol
{
    public partial class Content : UserControl
    {
        public delegate void OnClickControl(Content content);

        public OnClickControl DoubleClickContrlDelegate { get; set; }

        public OnClickControl ClickContrlDelegate { get; set; }

        public String name
        {
            set
            {
                this.nameText.ReadOnly = true;
                this.nameText.Text = value;
            }
            get
            {
                return this.nameText.Text;
            }
        }

        public String backgroundImage
        {
            set
            {
                String imageFile = Directory.GetCurrentDirectory()  + value;
                if (File.Exists(imageFile))
                {
                    this.splitContainer1.Panel1.BackgroundImage = Image.FromFile(imageFile);
                }
            }
        }
        public String type;

        public Int32 Id;

        public Content()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void splitContainer1_DoubleClick(object sender, EventArgs e)
        {
            if (this.DoubleClickContrlDelegate != null)
            {
                DoubleClickContrlDelegate(this);
            }
        }

        private void nameText_DoubleClick(object sender, EventArgs e)
        {
            if (this.DoubleClickContrlDelegate != null)
            {
                DoubleClickContrlDelegate(this);
            }
        }

        private void splitContainer1_Panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.DoubleClickContrlDelegate != null)
            {
                DoubleClickContrlDelegate(this);
            }
        }

        private void nameText_Click(object sender, EventArgs e)
        {
            if (this.ClickContrlDelegate != null)
            {
                ClickContrlDelegate(this);
            }
        }

        private void splitContainer1_Click(object sender, EventArgs e)
        {
            if (this.ClickContrlDelegate != null)
            {
                ClickContrlDelegate(this);
            }
        }

        private void splitContainer1_Panel1_Click(object sender, EventArgs e)
        {
            if (this.ClickContrlDelegate != null)
            {
                ClickContrlDelegate(this);
            }
        }
    }
}
