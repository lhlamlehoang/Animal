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
            this.btcreate = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.pnimage = new System.Windows.Forms.Panel();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.pninfo = new System.Windows.Forms.Panel();
            this.lbinfo_food = new System.Windows.Forms.Label();
            this.lbinfo_ability = new System.Windows.Forms.Label();
            this.lbinfo_name = new System.Windows.Forms.Label();
            this.lbinfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lbname.Visible = false;
            // 
            // cbanimal
            // 
            this.cbanimal.FormattingEnabled = true;
            this.cbanimal.Location = new System.Drawing.Point(111, 19);
            this.cbanimal.Name = "cbanimal";
            this.cbanimal.Size = new System.Drawing.Size(121, 24);
            this.cbanimal.TabIndex = 2;
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
            // 
            // pninfo
            // 
            this.pninfo.Controls.Add(this.label3);
            this.pninfo.Controls.Add(this.label2);
            this.pninfo.Controls.Add(this.label1);
            this.pninfo.Controls.Add(this.lbinfo_food);
            this.pninfo.Controls.Add(this.lbinfo_ability);
            this.pninfo.Controls.Add(this.lbinfo_name);
            this.pninfo.Controls.Add(this.lbinfo);
            this.pninfo.Location = new System.Drawing.Point(475, 255);
            this.pninfo.Name = "pninfo";
            this.pninfo.Size = new System.Drawing.Size(324, 265);
            this.pninfo.TabIndex = 7;
            this.pninfo.Visible = false;
            // 
            // lbinfo_food
            // 
            this.lbinfo_food.AutoSize = true;
            this.lbinfo_food.Location = new System.Drawing.Point(176, 200);
            this.lbinfo_food.Name = "lbinfo_food";
            this.lbinfo_food.Size = new System.Drawing.Size(49, 16);
            this.lbinfo_food.TabIndex = 3;
            this.lbinfo_food.Text = "- Food:";
            // 
            // lbinfo_ability
            // 
            this.lbinfo_ability.AutoSize = true;
            this.lbinfo_ability.Location = new System.Drawing.Point(172, 148);
            this.lbinfo_ability.Name = "lbinfo_ability";
            this.lbinfo_ability.Size = new System.Drawing.Size(53, 16);
            this.lbinfo_ability.TabIndex = 2;
            this.lbinfo_ability.Text = "- Ability:";
            // 
            // lbinfo_name
            // 
            this.lbinfo_name.AutoSize = true;
            this.lbinfo_name.Location = new System.Drawing.Point(171, 96);
            this.lbinfo_name.Name = "lbinfo_name";
            this.lbinfo_name.Size = new System.Drawing.Size(54, 16);
            this.lbinfo_name.TabIndex = 1;
            this.lbinfo_name.Text = "- Name:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ability:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Food:";
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
            this.Controls.Add(this.cbanimal);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.lbanimal);
            this.Name = "AnimalForm";
            this.Text = "Animal";
            this.Load += new System.EventHandler(this.AnimalForm_Load);
            this.pnimage.ResumeLayout(false);
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
        private System.Windows.Forms.Button btcreate;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Panel pnimage;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.Panel pninfo;
        private System.Windows.Forms.Label lbinfo_food;
        private System.Windows.Forms.Label lbinfo_ability;
        private System.Windows.Forms.Label lbinfo_name;
        private System.Windows.Forms.Label lbinfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

