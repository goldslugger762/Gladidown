namespace etozhestkapec
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.yourscoretext = new System.Windows.Forms.Label();
            this.yourscore = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.yourspeed = new System.Windows.Forms.Label();
            this.yourspeedtxt = new System.Windows.Forms.Label();
            this.yourstones = new System.Windows.Forms.Label();
            this.yourstonestxt = new System.Windows.Forms.Label();
            this.yourhealth = new System.Windows.Forms.Label();
            this.yourheatlhtxt = new System.Windows.Forms.Label();
            this.speedprokachkabutton = new System.Windows.Forms.Button();
            this.stonesprokachkabutton = new System.Windows.Forms.Button();
            this.heatlhprokachkabutton = new System.Windows.Forms.Button();
            this.sbrosbutton = new System.Windows.Forms.Button();
            this.costskorost = new System.Windows.Forms.Label();
            this.costkamni = new System.Windows.Forms.Label();
            this.costhealth = new System.Windows.Forms.Label();
            this.sbrosendless = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yourscoretext
            // 
            this.yourscoretext.AutoSize = true;
            this.yourscoretext.BackColor = System.Drawing.Color.Transparent;
            this.yourscoretext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourscoretext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yourscoretext.Location = new System.Drawing.Point(736, 9);
            this.yourscoretext.Name = "yourscoretext";
            this.yourscoretext.Size = new System.Drawing.Size(116, 24);
            this.yourscoretext.TabIndex = 0;
            this.yourscoretext.Text = "Твои очки:";
            // 
            // yourscore
            // 
            this.yourscore.AutoSize = true;
            this.yourscore.BackColor = System.Drawing.Color.Gainsboro;
            this.yourscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourscore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yourscore.Location = new System.Drawing.Point(888, 9);
            this.yourscore.Name = "yourscore";
            this.yourscore.Size = new System.Drawing.Size(21, 24);
            this.yourscore.TabIndex = 1;
            this.yourscore.Text = "0";
            this.yourscore.Click += new System.EventHandler(this.yourscore_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(866, 414);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "Назад";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // yourspeed
            // 
            this.yourspeed.AutoSize = true;
            this.yourspeed.BackColor = System.Drawing.Color.Transparent;
            this.yourspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourspeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yourspeed.Location = new System.Drawing.Point(12, 51);
            this.yourspeed.Name = "yourspeed";
            this.yourspeed.Size = new System.Drawing.Size(217, 31);
            this.yourspeed.TabIndex = 3;
            this.yourspeed.Text = "Твоя скорость:";
            // 
            // yourspeedtxt
            // 
            this.yourspeedtxt.AutoSize = true;
            this.yourspeedtxt.BackColor = System.Drawing.Color.Gainsboro;
            this.yourspeedtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourspeedtxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yourspeedtxt.Location = new System.Drawing.Point(252, 58);
            this.yourspeedtxt.Name = "yourspeedtxt";
            this.yourspeedtxt.Size = new System.Drawing.Size(21, 24);
            this.yourspeedtxt.TabIndex = 4;
            this.yourspeedtxt.Text = "0";
            // 
            // yourstones
            // 
            this.yourstones.AutoSize = true;
            this.yourstones.BackColor = System.Drawing.Color.Transparent;
            this.yourstones.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourstones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yourstones.Location = new System.Drawing.Point(7, 176);
            this.yourstones.Name = "yourstones";
            this.yourstones.Size = new System.Drawing.Size(179, 31);
            this.yourstones.TabIndex = 5;
            this.yourstones.Text = "Твои камни:";
            // 
            // yourstonestxt
            // 
            this.yourstonestxt.AutoSize = true;
            this.yourstonestxt.BackColor = System.Drawing.Color.Gainsboro;
            this.yourstonestxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourstonestxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yourstonestxt.Location = new System.Drawing.Point(252, 176);
            this.yourstonestxt.Name = "yourstonestxt";
            this.yourstonestxt.Size = new System.Drawing.Size(21, 24);
            this.yourstonestxt.TabIndex = 6;
            this.yourstonestxt.Text = "0";
            // 
            // yourhealth
            // 
            this.yourhealth.AutoSize = true;
            this.yourhealth.BackColor = System.Drawing.Color.Transparent;
            this.yourhealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourhealth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yourhealth.Location = new System.Drawing.Point(7, 346);
            this.yourhealth.Name = "yourhealth";
            this.yourhealth.Size = new System.Drawing.Size(222, 31);
            this.yourhealth.TabIndex = 7;
            this.yourhealth.Text = "Твоё здоровье:";
            // 
            // yourheatlhtxt
            // 
            this.yourheatlhtxt.AutoSize = true;
            this.yourheatlhtxt.BackColor = System.Drawing.Color.Gainsboro;
            this.yourheatlhtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yourheatlhtxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yourheatlhtxt.Location = new System.Drawing.Point(252, 353);
            this.yourheatlhtxt.Name = "yourheatlhtxt";
            this.yourheatlhtxt.Size = new System.Drawing.Size(21, 24);
            this.yourheatlhtxt.TabIndex = 8;
            this.yourheatlhtxt.Text = "0";
            // 
            // speedprokachkabutton
            // 
            this.speedprokachkabutton.Location = new System.Drawing.Point(77, 104);
            this.speedprokachkabutton.Name = "speedprokachkabutton";
            this.speedprokachkabutton.Size = new System.Drawing.Size(114, 37);
            this.speedprokachkabutton.TabIndex = 9;
            this.speedprokachkabutton.Text = "Прокачать!";
            this.speedprokachkabutton.UseVisualStyleBackColor = true;
            this.speedprokachkabutton.Click += new System.EventHandler(this.speedprokachkabutton_Click);
            // 
            // stonesprokachkabutton
            // 
            this.stonesprokachkabutton.Location = new System.Drawing.Point(72, 227);
            this.stonesprokachkabutton.Name = "stonesprokachkabutton";
            this.stonesprokachkabutton.Size = new System.Drawing.Size(114, 37);
            this.stonesprokachkabutton.TabIndex = 10;
            this.stonesprokachkabutton.Text = "Прокачать!";
            this.stonesprokachkabutton.UseVisualStyleBackColor = true;
            this.stonesprokachkabutton.Click += new System.EventHandler(this.stonesprokachkabutton_Click);
            // 
            // heatlhprokachkabutton
            // 
            this.heatlhprokachkabutton.Location = new System.Drawing.Point(77, 400);
            this.heatlhprokachkabutton.Name = "heatlhprokachkabutton";
            this.heatlhprokachkabutton.Size = new System.Drawing.Size(114, 37);
            this.heatlhprokachkabutton.TabIndex = 11;
            this.heatlhprokachkabutton.Text = "Прокачать!";
            this.heatlhprokachkabutton.UseVisualStyleBackColor = true;
            this.heatlhprokachkabutton.Click += new System.EventHandler(this.heatlhprokachkabutton_Click);
            // 
            // sbrosbutton
            // 
            this.sbrosbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sbrosbutton.Location = new System.Drawing.Point(436, 393);
            this.sbrosbutton.Name = "sbrosbutton";
            this.sbrosbutton.Size = new System.Drawing.Size(116, 50);
            this.sbrosbutton.TabIndex = 12;
            this.sbrosbutton.Text = "Сброс";
            this.sbrosbutton.UseVisualStyleBackColor = true;
            this.sbrosbutton.Click += new System.EventHandler(this.sbrosbutton_Click);
            this.sbrosbutton.MouseEnter += new System.EventHandler(this.sbrosbutton_MouseEnter);
            this.sbrosbutton.MouseLeave += new System.EventHandler(this.sbrosbutton_MouseLeave_1);
            // 
            // costskorost
            // 
            this.costskorost.AutoSize = true;
            this.costskorost.BackColor = System.Drawing.SystemColors.HighlightText;
            this.costskorost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costskorost.Location = new System.Drawing.Point(292, 51);
            this.costskorost.Name = "costskorost";
            this.costskorost.Size = new System.Drawing.Size(332, 32);
            this.costskorost.TabIndex = 13;
            this.costskorost.Text = "Стоимость: 500 очков\r\nПовышает твою скорость на 5 единиц за уровень!";
            // 
            // costkamni
            // 
            this.costkamni.AutoSize = true;
            this.costkamni.BackColor = System.Drawing.SystemColors.HighlightText;
            this.costkamni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costkamni.Location = new System.Drawing.Point(292, 176);
            this.costkamni.Name = "costkamni";
            this.costkamni.Size = new System.Drawing.Size(471, 32);
            this.costkamni.TabIndex = 14;
            this.costkamni.Text = "Стоимость: 250 очков\r\nПовышает твоё стартовое количество камней на 5 единиц за ур" +
    "овень!";
            // 
            // costhealth
            // 
            this.costhealth.AutoSize = true;
            this.costhealth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.costhealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costhealth.Location = new System.Drawing.Point(292, 353);
            this.costhealth.Name = "costhealth";
            this.costhealth.Size = new System.Drawing.Size(599, 32);
            this.costhealth.TabIndex = 15;
            this.costhealth.Text = "Стоимость: 700 очков\r\nПовышает твоё максимальное количество жизней на 20 единиц з" +
    "а уровень! Живи дольше!";
            // 
            // sbrosendless
            // 
            this.sbrosendless.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sbrosendless.Location = new System.Drawing.Point(558, 420);
            this.sbrosendless.Name = "sbrosendless";
            this.sbrosendless.Size = new System.Drawing.Size(221, 23);
            this.sbrosendless.TabIndex = 16;
            this.sbrosendless.Text = "Сбросить бесконечный режим";
            this.sbrosendless.UseVisualStyleBackColor = true;
            this.sbrosendless.Click += new System.EventHandler(this.sbrosendless_Click);
            this.sbrosendless.MouseEnter += new System.EventHandler(this.sbrosendless_MouseEnter);
            this.sbrosendless.MouseLeave += new System.EventHandler(this.sbrosendless_MouseLeave);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.sbrosendless);
            this.Controls.Add(this.costhealth);
            this.Controls.Add(this.costkamni);
            this.Controls.Add(this.costskorost);
            this.Controls.Add(this.sbrosbutton);
            this.Controls.Add(this.heatlhprokachkabutton);
            this.Controls.Add(this.stonesprokachkabutton);
            this.Controls.Add(this.speedprokachkabutton);
            this.Controls.Add(this.yourheatlhtxt);
            this.Controls.Add(this.yourhealth);
            this.Controls.Add(this.yourstonestxt);
            this.Controls.Add(this.yourstones);
            this.Controls.Add(this.yourspeedtxt);
            this.Controls.Add(this.yourspeed);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.yourscore);
            this.Controls.Add(this.yourscoretext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gladidown\' Upgrade your warrior!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yourscoretext;
        private System.Windows.Forms.Label yourscore;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Label yourspeed;
        private System.Windows.Forms.Label yourspeedtxt;
        private System.Windows.Forms.Label yourstones;
        private System.Windows.Forms.Label yourstonestxt;
        private System.Windows.Forms.Label yourhealth;
        private System.Windows.Forms.Label yourheatlhtxt;
        private System.Windows.Forms.Button speedprokachkabutton;
        private System.Windows.Forms.Button stonesprokachkabutton;
        private System.Windows.Forms.Button heatlhprokachkabutton;
        private System.Windows.Forms.Button sbrosbutton;
        private System.Windows.Forms.Label costskorost;
        private System.Windows.Forms.Label costkamni;
        private System.Windows.Forms.Label costhealth;
        private System.Windows.Forms.Button sbrosendless;
    }
}