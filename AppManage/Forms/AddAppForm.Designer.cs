namespace AppManage.Forms
{
    partial class AddAppForm
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
            this.appPathText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.chooseAppButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.appNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chooseIcnButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCatlog = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // appPathText
            // 
            this.appPathText.Location = new System.Drawing.Point(101, 51);
            this.appPathText.Multiline = true;
            this.appPathText.Name = "appPathText";
            this.appPathText.Size = new System.Drawing.Size(176, 25);
            this.appPathText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "启动程序";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(293, 477);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // chooseAppButton
            // 
            this.chooseAppButton.Location = new System.Drawing.Point(293, 51);
            this.chooseAppButton.Name = "chooseAppButton";
            this.chooseAppButton.Size = new System.Drawing.Size(87, 23);
            this.chooseAppButton.TabIndex = 5;
            this.chooseAppButton.Text = "选择启动程序";
            this.chooseAppButton.UseVisualStyleBackColor = true;
            this.chooseAppButton.Click += new System.EventHandler(this.chooseAppButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "应用名称";
            // 
            // appNameText
            // 
            this.appNameText.Location = new System.Drawing.Point(101, 110);
            this.appNameText.Multiline = true;
            this.appNameText.Name = "appNameText";
            this.appNameText.Size = new System.Drawing.Size(176, 25);
            this.appNameText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "应用图标";
            // 
            // chooseIcnButton
            // 
            this.chooseIcnButton.Location = new System.Drawing.Point(293, 243);
            this.chooseIcnButton.Name = "chooseIcnButton";
            this.chooseIcnButton.Size = new System.Drawing.Size(75, 23);
            this.chooseIcnButton.TabIndex = 5;
            this.chooseIcnButton.Text = "选择图标";
            this.chooseIcnButton.UseVisualStyleBackColor = true;
            this.chooseIcnButton.Click += new System.EventHandler(this.chooseIcnButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(101, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "所属目录";
            // 
            // comboBoxCatlog
            // 
            this.comboBoxCatlog.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxCatlog.FormattingEnabled = true;
            this.comboBoxCatlog.Location = new System.Drawing.Point(101, 374);
            this.comboBoxCatlog.Name = "comboBoxCatlog";
            this.comboBoxCatlog.Size = new System.Drawing.Size(176, 25);
            this.comboBoxCatlog.TabIndex = 7;
            // 
            // AddAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 528);
            this.Controls.Add(this.comboBoxCatlog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chooseIcnButton);
            this.Controls.Add(this.chooseAppButton);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.appNameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appPathText);
            this.Controls.Add(this.label1);
            this.Name = "AddAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加应用";
            this.Load += new System.EventHandler(this.AddApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox appPathText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button chooseAppButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox appNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button chooseIcnButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCatlog;
    }
}