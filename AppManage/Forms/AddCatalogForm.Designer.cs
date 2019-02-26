namespace AppManage
{
    partial class AddCatalogForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.catalogNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.catalogDescText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openImage = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "分类名称";
            // 
            // catalogNameText
            // 
            this.catalogNameText.Location = new System.Drawing.Point(133, 56);
            this.catalogNameText.Multiline = true;
            this.catalogNameText.Name = "catalogNameText";
            this.catalogNameText.Size = new System.Drawing.Size(176, 25);
            this.catalogNameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "分类说明";
            // 
            // catalogDescText
            // 
            this.catalogDescText.Location = new System.Drawing.Point(133, 113);
            this.catalogDescText.Multiline = true;
            this.catalogDescText.Name = "catalogDescText";
            this.catalogDescText.Size = new System.Drawing.Size(176, 25);
            this.catalogDescText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "分类图标";
            // 
            // openImage
            // 
            this.openImage.Location = new System.Drawing.Point(331, 269);
            this.openImage.Name = "openImage";
            this.openImage.Size = new System.Drawing.Size(75, 23);
            this.openImage.TabIndex = 3;
            this.openImage.Text = "选择图片";
            this.openImage.UseVisualStyleBackColor = true;
            this.openImage.Click += new System.EventHandler(this.openImage_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(331, 402);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 3;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(133, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AddCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.openImage);
            this.Controls.Add(this.catalogDescText);
            this.Controls.Add(this.catalogNameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加分类";
            this.Load += new System.EventHandler(this.AddCatalogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox catalogNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox catalogDescText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openImage;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}