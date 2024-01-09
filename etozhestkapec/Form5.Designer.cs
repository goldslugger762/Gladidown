namespace etozhestkapec
{
    partial class Form5
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.txtammo = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.Label();
            this.txthealth = new System.Windows.Forms.Label();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.umerlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtammo
            // 
            this.txtammo.AutoSize = true;
            this.txtammo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtammo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtammo.Location = new System.Drawing.Point(434, 14);
            this.txtammo.Name = "txtammo";
            this.txtammo.Size = new System.Drawing.Size(100, 25);
            this.txtammo.TabIndex = 0;
            this.txtammo.Text = "Ammo: 0";
            this.txtammo.Click += new System.EventHandler(this.txtammo_Click);
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtscore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtscore.Location = new System.Drawing.Point(1408, 19);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(110, 25);
            this.txtscore.TabIndex = 1;
            this.txtscore.Text = "Corpses: 0";
            // 
            // txthealth
            // 
            this.txthealth.AutoSize = true;
            this.txthealth.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txthealth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txthealth.Location = new System.Drawing.Point(628, 19);
            this.txthealth.Name = "txthealth";
            this.txthealth.Size = new System.Drawing.Size(80, 18);
            this.txthealth.TabIndex = 2;
            this.txthealth.Text = "Still alive?";
            this.txthealth.Click += new System.EventHandler(this.txthealth_Click);
            // 
            // healthbar
            // 
            this.healthbar.Location = new System.Drawing.Point(714, 14);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(374, 23);
            this.healthbar.TabIndex = 3;
            this.healthbar.Value = 100;
            this.healthbar.Click += new System.EventHandler(this.healthbar_Click);
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::etozhestkapec.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(881, 716);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(36, 51);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // umerlabel
            // 
            this.umerlabel.BackColor = System.Drawing.Color.Transparent;
            this.umerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.umerlabel.ForeColor = System.Drawing.Color.Red;
            this.umerlabel.Location = new System.Drawing.Point(790, 410);
            this.umerlabel.Name = "umerlabel";
            this.umerlabel.Size = new System.Drawing.Size(304, 140);
            this.umerlabel.TabIndex = 9;
            this.umerlabel.Text = "Ты умер!\r\nНажми Enter для рестарта.\r\n";
            this.umerlabel.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BackgroundImage = global::etozhestkapec.Properties.Resources.arena;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1884, 961);
            this.Controls.Add(this.umerlabel);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.txthealth);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtammo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gladidown\' Level 2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownIs);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpIs);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtammo;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Label txthealth;
        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label umerlabel;
    }
}

