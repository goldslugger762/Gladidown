namespace etozhestkapec
{
    partial class debugmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(debugmenu));
            this.lvl1 = new System.Windows.Forms.Button();
            this.lvl2 = new System.Windows.Forms.Button();
            this.lvl3 = new System.Windows.Forms.Button();
            this.winscren = new System.Windows.Forms.Button();
            this.unlockendl = new System.Windows.Forms.Button();
            this.endpllock = new System.Windows.Forms.Button();
            this.exitbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvl1
            // 
            this.lvl1.Location = new System.Drawing.Point(29, 29);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(75, 23);
            this.lvl1.TabIndex = 0;
            this.lvl1.Text = "lvl1";
            this.lvl1.UseVisualStyleBackColor = true;
            this.lvl1.Click += new System.EventHandler(this.lvl1_Click);
            // 
            // lvl2
            // 
            this.lvl2.Location = new System.Drawing.Point(163, 29);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(75, 23);
            this.lvl2.TabIndex = 1;
            this.lvl2.Text = "lvl2";
            this.lvl2.UseVisualStyleBackColor = true;
            this.lvl2.Click += new System.EventHandler(this.lvl2_Click);
            // 
            // lvl3
            // 
            this.lvl3.Location = new System.Drawing.Point(301, 29);
            this.lvl3.Name = "lvl3";
            this.lvl3.Size = new System.Drawing.Size(75, 23);
            this.lvl3.TabIndex = 2;
            this.lvl3.Text = "lvl3";
            this.lvl3.UseVisualStyleBackColor = true;
            this.lvl3.Click += new System.EventHandler(this.lvl3_Click);
            // 
            // winscren
            // 
            this.winscren.Location = new System.Drawing.Point(429, 29);
            this.winscren.Name = "winscren";
            this.winscren.Size = new System.Drawing.Size(75, 23);
            this.winscren.TabIndex = 3;
            this.winscren.Text = "win";
            this.winscren.UseVisualStyleBackColor = true;
            this.winscren.Click += new System.EventHandler(this.winscren_Click);
            // 
            // unlockendl
            // 
            this.unlockendl.Location = new System.Drawing.Point(29, 149);
            this.unlockendl.Name = "unlockendl";
            this.unlockendl.Size = new System.Drawing.Size(75, 23);
            this.unlockendl.TabIndex = 4;
            this.unlockendl.Text = "endless+";
            this.unlockendl.UseVisualStyleBackColor = true;
            this.unlockendl.Click += new System.EventHandler(this.unlockendl_Click);
            // 
            // endpllock
            // 
            this.endpllock.Location = new System.Drawing.Point(152, 137);
            this.endpllock.Name = "endpllock";
            this.endpllock.Size = new System.Drawing.Size(75, 47);
            this.endpllock.TabIndex = 5;
            this.endpllock.Text = "endless+ lock";
            this.endpllock.UseVisualStyleBackColor = true;
            this.endpllock.Click += new System.EventHandler(this.endpllock_Click);
            // 
            // exitbt
            // 
            this.exitbt.Location = new System.Drawing.Point(429, 373);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(75, 47);
            this.exitbt.TabIndex = 6;
            this.exitbt.Text = "exit";
            this.exitbt.UseVisualStyleBackColor = true;
            this.exitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // debugmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.exitbt);
            this.Controls.Add(this.endpllock);
            this.Controls.Add(this.unlockendl);
            this.Controls.Add(this.winscren);
            this.Controls.Add(this.lvl3);
            this.Controls.Add(this.lvl2);
            this.Controls.Add(this.lvl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "debugmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "debugmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lvl1;
        private System.Windows.Forms.Button lvl2;
        private System.Windows.Forms.Button lvl3;
        private System.Windows.Forms.Button winscren;
        private System.Windows.Forms.Button unlockendl;
        private System.Windows.Forms.Button endpllock;
        private System.Windows.Forms.Button exitbt;
    }
}