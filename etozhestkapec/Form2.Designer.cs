namespace etozhestkapec
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.playbutton = new System.Windows.Forms.Button();
            this.myHero = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.upravlenie = new System.Windows.Forms.Button();
            this.endlessmode = new System.Windows.Forms.Button();
            this.endlessplus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.playbutton.Location = new System.Drawing.Point(401, 51);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(129, 33);
            this.playbutton.TabIndex = 0;
            this.playbutton.Text = "Играть";
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // myHero
            // 
            this.myHero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.myHero.Location = new System.Drawing.Point(401, 151);
            this.myHero.Name = "myHero";
            this.myHero.Size = new System.Drawing.Size(129, 33);
            this.myHero.TabIndex = 1;
            this.myHero.Text = "Мой Герой";
            this.myHero.UseVisualStyleBackColor = false;
            this.myHero.Click += new System.EventHandler(this.myHero_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitbutton.Location = new System.Drawing.Point(401, 334);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(129, 33);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "Выход";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // upravlenie
            // 
            this.upravlenie.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.upravlenie.Location = new System.Drawing.Point(401, 245);
            this.upravlenie.Name = "upravlenie";
            this.upravlenie.Size = new System.Drawing.Size(129, 33);
            this.upravlenie.TabIndex = 3;
            this.upravlenie.Text = "Управление";
            this.upravlenie.UseVisualStyleBackColor = false;
            this.upravlenie.Click += new System.EventHandler(this.upravlenie_Click);
            // 
            // endlessmode
            // 
            this.endlessmode.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.endlessmode.Location = new System.Drawing.Point(607, 51);
            this.endlessmode.Name = "endlessmode";
            this.endlessmode.Size = new System.Drawing.Size(129, 33);
            this.endlessmode.TabIndex = 4;
            this.endlessmode.Text = "Бесконечный режим";
            this.endlessmode.UseVisualStyleBackColor = false;
            this.endlessmode.Click += new System.EventHandler(this.endlessmode_Click);
            // 
            // endlessplus
            // 
            this.endlessplus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.endlessplus.Location = new System.Drawing.Point(607, 151);
            this.endlessplus.Name = "endlessplus";
            this.endlessplus.Size = new System.Drawing.Size(129, 33);
            this.endlessplus.TabIndex = 5;
            this.endlessplus.Text = "Бесконечный режим +";
            this.endlessplus.UseVisualStyleBackColor = false;
            this.endlessplus.Visible = false;
            this.endlessplus.Click += new System.EventHandler(this.endlessplus_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::etozhestkapec.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.endlessplus);
            this.Controls.Add(this.endlessmode);
            this.Controls.Add(this.upravlenie);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.myHero);
            this.Controls.Add(this.playbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gladidown\' menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Button myHero;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button upravlenie;
        private System.Windows.Forms.Button endlessmode;
        private System.Windows.Forms.Button endlessplus;
    }
}