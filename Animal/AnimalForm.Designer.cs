namespace Animal
{
    partial class AnimalForm
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
            this.lbanimal = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.cbanimal = new System.Windows.Forms.ComboBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btcreate = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.pnimage = new System.Windows.Forms.Panel();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.lbimage = new System.Windows.Forms.Label();
            this.pninfo = new System.Windows.Forms.Panel();
            this.tbinfo_food = new System.Windows.Forms.TextBox();
            this.tbinfo_ability = new System.Windows.Forms.TextBox();
            this.tbinfo_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbinfo = new System.Windows.Forms.Label();
            this.pnimage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.pninfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbanimal
            // 
            this.lbanimal.AutoSize = true;
            this.lbanimal.Location = new System.Drawing.Point(28, 22);
            this.lbanimal.Name = "lbanimal";
            this.lbanimal.Size = new System.Drawing.Size(48, 16);
            this.lbanimal.TabIndex = 0;
            this.lbanimal.Text = "Animal";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(31, 83);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 16);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Name";
            // 
            // cbanimal
            // 
            this.cbanimal.FormattingEnabled = true;
            this.cbanimal.Location = new System.Drawing.Point(111, 19);
            this.cbanimal.Name = "cbanimal";
            this.cbanimal.Size = new System.Drawing.Size(121, 24);
            this.cbanimal.TabIndex = 2;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(111, 76);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(121, 22);
            this.tbname.TabIndex = 3;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // btcreate
            // 
            this.btcreate.Location = new System.Drawing.Point(31, 351);
            this.btcreate.Name = "btcreate";
            this.btcreate.Size = new System.Drawing.Size(115, 47);
            this.btcreate.TabIndex = 4;
            this.btcreate.Text = "Create";
            this.btcreate.UseVisualStyleBackColor = true;
            this.btcreate.Click += new System.EventHandler(this.btcreate_Click);
            // 
            // btclose
            // 
            this.btclose.Location = new System.Drawing.Point(210, 351);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(115, 47);
            this.btclose.TabIndex = 5;
            this.btclose.Text = "Close";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // pnimage
            // 
            this.pnimage.Controls.Add(this.picbox);
            this.pnimage.Controls.Add(this.lbimage);
            this.pnimage.Location = new System.Drawing.Point(475, -3);
            this.pnimage.Name = "pnimage";
            this.pnimage.Size = new System.Drawing.Size(324, 261);
            this.pnimage.TabIndex = 6;
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox.Location = new System.Drawing.Point(58, 54);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(239, 185);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            this.picbox.Click += new System.EventHandler(this.picbox_Click);
            // 
            // lbimage
            // 
            this.lbimage.AutoSize = true;
            this.lbimage.Location = new System.Drawing.Point(20, 22);
            this.lbimage.Name = "lbimage";
            this.lbimage.Size = new System.Drawing.Size(45, 16);
            this.lbimage.TabIndex = 0;
            this.lbimage.Text = "Image";
            // 
            // pninfo
            // 
            this.pninfo.Controls.Add(this.tbinfo_food);
            this.pninfo.Controls.Add(this.tbinfo_ability);
            this.pninfo.Controls.Add(this.tbinfo_name);
            this.pninfo.Controls.Add(this.label3);
            this.pninfo.Controls.Add(this.label2);
            this.pninfo.Controls.Add(this.label1);
            this.pninfo.Controls.Add(this.lbinfo);
            this.pninfo.Location = new System.Drawing.Point(475, 255);
            this.pninfo.Name = "pninfo";
            this.pninfo.Size = new System.Drawing.Size(324, 265);
            this.pninfo.TabIndex = 7;
            // 
            // tbinfo_food
            // 
            this.tbinfo_food.Location = new System.Drawing.Point(147, 190);
            this.tbinfo_food.Name = "tbinfo_food";
            this.tbinfo_food.Size = new System.Drawing.Size(118, 22);
            this.tbinfo_food.TabIndex = 6;
            // 
            // tbinfo_ability
            // 
            this.tbinfo_ability.Location = new System.Drawing.Point(147, 138);
            this.tbinfo_ability.Name = "tbinfo_ability";
            this.tbinfo_ability.Size = new System.Drawing.Size(118, 22);
            this.tbinfo_ability.TabIndex = 5;
            // 
            // tbinfo_name
            // 
            this.tbinfo_name.Location = new System.Drawing.Point(147, 83);
            this.tbinfo_name.Name = "tbinfo_name";
            this.tbinfo_name.Size = new System.Drawing.Size(118, 22);
            this.tbinfo_name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "- Food:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "- Ability:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "- Name:";
            // 
            // lbinfo
            // 
            this.lbinfo.AutoSize = true;
            this.lbinfo.Location = new System.Drawing.Point(23, 25);
            this.lbinfo.Name = "lbinfo";
            this.lbinfo.Size = new System.Drawing.Size(28, 16);
            this.lbinfo.TabIndex = 0;
            this.lbinfo.Text = "Info";
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 519);
            this.Controls.Add(this.pninfo);
            this.Controls.Add(this.pnimage);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btcreate);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.cbanimal);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbanimal);
            this.Name = "AnimalForm";
            this.Text = "Animal";
            this.Load += new System.EventHandler(this.AnimalForm_Load);
            this.pnimage.ResumeLayout(false);
            this.pnimage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.pninfo.ResumeLayout(false);
            this.pninfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbanimal;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.ComboBox cbanimal;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btcreate;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Panel pnimage;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Label lbimage;
        private System.Windows.Forms.Panel pninfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.TextBox tbinfo_food;
        private System.Windows.Forms.TextBox tbinfo_ability;
        private System.Windows.Forms.TextBox tbinfo_name;
    }
}

