namespace HorseBetting
{
    partial class frmBetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBetting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRace = new System.Windows.Forms.Button();
            this.betbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maxlbl = new System.Windows.Forms.Label();
            this.Punter3desc = new System.Windows.Forms.Label();
            this.Punter2desc = new System.Windows.Forms.Label();
            this.Punter1desc = new System.Windows.Forms.Label();
            this.HorseNo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PunterName = new System.Windows.Forms.Label();
            this.numBucks = new System.Windows.Forms.NumericUpDown();
            this.Punter3 = new System.Windows.Forms.RadioButton();
            this.Punter2 = new System.Windows.Forms.RadioButton();
            this.Punter1 = new System.Windows.Forms.RadioButton();
            this.Horse1 = new System.Windows.Forms.PictureBox();
            this.Horse4 = new System.Windows.Forms.PictureBox();
            this.Horse3 = new System.Windows.Forms.PictureBox();
            this.Horse2 = new System.Windows.Forms.PictureBox();
            this.Track = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBucks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.betbtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maxlbl);
            this.groupBox1.Controls.Add(this.Punter3desc);
            this.groupBox1.Controls.Add(this.Punter2desc);
            this.groupBox1.Controls.Add(this.Punter1desc);
            this.groupBox1.Controls.Add(this.HorseNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PunterName);
            this.groupBox1.Controls.Add(this.numBucks);
            this.groupBox1.Controls.Add(this.Punter3);
            this.groupBox1.Controls.Add(this.Punter2);
            this.groupBox1.Controls.Add(this.Punter1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(8, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRace.Location = new System.Drawing.Point(436, 183);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(89, 33);
            this.btnRace.TabIndex = 21;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // betbtn
            // 
            this.betbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.betbtn.Location = new System.Drawing.Point(330, 183);
            this.betbtn.Name = "betbtn";
            this.betbtn.Size = new System.Drawing.Size(89, 33);
            this.betbtn.TabIndex = 20;
            this.betbtn.Text = "Bet";
            this.betbtn.UseVisualStyleBackColor = false;
            this.betbtn.Click += new System.EventHandler(this.betbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(65, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "bets";
            // 
            // maxlbl
            // 
            this.maxlbl.AutoSize = true;
            this.maxlbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxlbl.ForeColor = System.Drawing.Color.Maroon;
            this.maxlbl.Location = new System.Drawing.Point(10, 21);
            this.maxlbl.Name = "maxlbl";
            this.maxlbl.Size = new System.Drawing.Size(147, 19);
            this.maxlbl.TabIndex = 18;
            this.maxlbl.Text = "Maximum Bet Length";
            this.maxlbl.UseWaitCursor = true;
            this.maxlbl.Click += new System.EventHandler(this.maxlbl_Click);
            // 
            // Punter3desc
            // 
            this.Punter3desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Punter3desc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punter3desc.ForeColor = System.Drawing.Color.Maroon;
            this.Punter3desc.Location = new System.Drawing.Point(211, 110);
            this.Punter3desc.Name = "Punter3desc";
            this.Punter3desc.Size = new System.Drawing.Size(327, 25);
            this.Punter3desc.TabIndex = 17;
            this.Punter3desc.Text = "Minimum Bet Length";
            // 
            // Punter2desc
            // 
            this.Punter2desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Punter2desc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punter2desc.ForeColor = System.Drawing.Color.Maroon;
            this.Punter2desc.Location = new System.Drawing.Point(211, 78);
            this.Punter2desc.Name = "Punter2desc";
            this.Punter2desc.Size = new System.Drawing.Size(327, 25);
            this.Punter2desc.TabIndex = 16;
            this.Punter2desc.Text = "Minimum Bet Length";
            // 
            // Punter1desc
            // 
            this.Punter1desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Punter1desc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punter1desc.ForeColor = System.Drawing.Color.Maroon;
            this.Punter1desc.Location = new System.Drawing.Point(211, 47);
            this.Punter1desc.Name = "Punter1desc";
            this.Punter1desc.Size = new System.Drawing.Size(327, 25);
            this.Punter1desc.TabIndex = 15;
            this.Punter1desc.Text = "Minimum Bet Length";
            // 
            // HorseNo
            // 
            this.HorseNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HorseNo.Location = new System.Drawing.Point(357, 145);
            this.HorseNo.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.HorseNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HorseNo.Name = "HorseNo";
            this.HorseNo.Size = new System.Drawing.Size(63, 27);
            this.HorseNo.TabIndex = 13;
            this.HorseNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(182, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "dollars on Horse number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // PunterName
            // 
            this.PunterName.AutoSize = true;
            this.PunterName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PunterName.ForeColor = System.Drawing.Color.Maroon;
            this.PunterName.Location = new System.Drawing.Point(12, 147);
            this.PunterName.Name = "PunterName";
            this.PunterName.Size = new System.Drawing.Size(31, 19);
            this.PunterName.TabIndex = 8;
            this.PunterName.Text = "Bet";
            // 
            // numBucks
            // 
            this.numBucks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBucks.Location = new System.Drawing.Point(112, 145);
            this.numBucks.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBucks.Name = "numBucks";
            this.numBucks.Size = new System.Drawing.Size(63, 27);
            this.numBucks.TabIndex = 1;
            this.numBucks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Punter3
            // 
            this.Punter3.AutoSize = true;
            this.Punter3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punter3.ForeColor = System.Drawing.Color.Maroon;
            this.Punter3.Location = new System.Drawing.Point(13, 111);
            this.Punter3.Name = "Punter3";
            this.Punter3.Size = new System.Drawing.Size(111, 23);
            this.Punter3.TabIndex = 6;
            this.Punter3.TabStop = true;
            this.Punter3.Text = "radioButton3";
            this.Punter3.UseVisualStyleBackColor = true;
            this.Punter3.CheckedChanged += new System.EventHandler(this.Punter3_CheckedChanged);
            // 
            // Punter2
            // 
            this.Punter2.AutoSize = true;
            this.Punter2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punter2.ForeColor = System.Drawing.Color.Maroon;
            this.Punter2.Location = new System.Drawing.Point(13, 80);
            this.Punter2.Name = "Punter2";
            this.Punter2.Size = new System.Drawing.Size(111, 23);
            this.Punter2.TabIndex = 5;
            this.Punter2.TabStop = true;
            this.Punter2.Text = "radioButton2";
            this.Punter2.UseVisualStyleBackColor = true;
            this.Punter2.CheckedChanged += new System.EventHandler(this.Punter2_CheckedChanged);
            // 
            // Punter1
            // 
            this.Punter1.AutoSize = true;
            this.Punter1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punter1.ForeColor = System.Drawing.Color.Maroon;
            this.Punter1.Location = new System.Drawing.Point(13, 49);
            this.Punter1.Name = "Punter1";
            this.Punter1.Size = new System.Drawing.Size(111, 23);
            this.Punter1.TabIndex = 4;
            this.Punter1.TabStop = true;
            this.Punter1.Text = "radioButton1";
            this.Punter1.UseVisualStyleBackColor = true;
            this.Punter1.CheckedChanged += new System.EventHandler(this.Punter1_CheckedChanged);
            // 
            // Horse1
            // 
            this.Horse1.BackColor = System.Drawing.Color.White;
            this.Horse1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Horse1.BackgroundImage")));
            this.Horse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Horse1.ErrorImage = null;
            this.Horse1.Image = global::HorseBetting.Properties.Resources.horse1;
            this.Horse1.Location = new System.Drawing.Point(18, 12);
            this.Horse1.Name = "Horse1";
            this.Horse1.Size = new System.Drawing.Size(89, 55);
            this.Horse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse1.TabIndex = 22;
            this.Horse1.TabStop = false;
            // 
            // Horse4
            // 
            this.Horse4.BackColor = System.Drawing.Color.White;
            this.Horse4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Horse4.BackgroundImage")));
            this.Horse4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Horse4.ErrorImage = null;
            this.Horse4.Image = global::HorseBetting.Properties.Resources.horse4;
            this.Horse4.Location = new System.Drawing.Point(17, 211);
            this.Horse4.Name = "Horse4";
            this.Horse4.Size = new System.Drawing.Size(89, 46);
            this.Horse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse4.TabIndex = 21;
            this.Horse4.TabStop = false;
            // 
            // Horse3
            // 
            this.Horse3.BackColor = System.Drawing.Color.White;
            this.Horse3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Horse3.BackgroundImage")));
            this.Horse3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Horse3.ErrorImage = null;
            this.Horse3.Image = global::HorseBetting.Properties.Resources.horse3;
            this.Horse3.Location = new System.Drawing.Point(17, 140);
            this.Horse3.Name = "Horse3";
            this.Horse3.Size = new System.Drawing.Size(88, 58);
            this.Horse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse3.TabIndex = 20;
            this.Horse3.TabStop = false;
            this.Horse3.Click += new System.EventHandler(this.Horse3_Click);
            // 
            // Horse2
            // 
            this.Horse2.BackColor = System.Drawing.Color.White;
            this.Horse2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Horse2.BackgroundImage")));
            this.Horse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Horse2.ErrorImage = null;
            this.Horse2.Image = global::HorseBetting.Properties.Resources.horse2;
            this.Horse2.Location = new System.Drawing.Point(19, 74);
            this.Horse2.Name = "Horse2";
            this.Horse2.Size = new System.Drawing.Size(88, 55);
            this.Horse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horse2.TabIndex = 19;
            this.Horse2.TabStop = false;
            // 
            // Track
            // 
            this.Track.BackgroundImage = global::HorseBetting.Properties.Resources.bg;
            this.Track.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Track.Location = new System.Drawing.Point(7, 12);
            this.Track.Name = "Track";
            this.Track.Size = new System.Drawing.Size(544, 251);
            this.Track.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Track.TabIndex = 18;
            this.Track.TabStop = false;
            // 
            // frmBetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 493);
            this.Controls.Add(this.Horse1);
            this.Controls.Add(this.Horse4);
            this.Controls.Add(this.Horse3);
            this.Controls.Add(this.Horse2);
            this.Controls.Add(this.Track);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.Name = "frmBetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horse Betting";
            this.Load += new System.EventHandler(this.frmBetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBucks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horse2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numBucks;
        private System.Windows.Forms.RadioButton Punter3;
        private System.Windows.Forms.RadioButton Punter2;
        private System.Windows.Forms.RadioButton Punter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PunterName;
        private System.Windows.Forms.NumericUpDown HorseNo;
        private System.Windows.Forms.Label Punter3desc;
        private System.Windows.Forms.Label Punter2desc;
        private System.Windows.Forms.Label Punter1desc;
        private System.Windows.Forms.PictureBox Track;
        private System.Windows.Forms.PictureBox Horse4;
        private System.Windows.Forms.PictureBox Horse3;
        private System.Windows.Forms.Label maxlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Horse2;
        private System.Windows.Forms.PictureBox Horse1;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button betbtn;
    }
}

