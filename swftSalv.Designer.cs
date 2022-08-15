namespace SpaceShipInvaders
{
    partial class swftSalv
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(swftSalv));
            this.tmrMovePic = new System.Windows.Forms.Timer(this.components);
            this.tmrProjectileDispatch = new System.Windows.Forms.Timer(this.components);
            this.lblLevelRound = new System.Windows.Forms.Label();
            this.tmrLabelColourTransition = new System.Windows.Forms.Timer(this.components);
            this.listProjectileImages = new System.Windows.Forms.ImageList(this.components);
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblSwiftSalvation = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picDiagonalProjectile3 = new System.Windows.Forms.PictureBox();
            this.picDiagonalProjectile2 = new System.Windows.Forms.PictureBox();
            this.picProjectile2 = new System.Windows.Forms.PictureBox();
            this.picProjectile3 = new System.Windows.Forms.PictureBox();
            this.picProjectile4 = new System.Windows.Forms.PictureBox();
            this.picProjectile5 = new System.Windows.Forms.PictureBox();
            this.picProjectile6 = new System.Windows.Forms.PictureBox();
            this.picProjectile7 = new System.Windows.Forms.PictureBox();
            this.picProjectile8 = new System.Windows.Forms.PictureBox();
            this.picProjectile9 = new System.Windows.Forms.PictureBox();
            this.picProjectile10 = new System.Windows.Forms.PictureBox();
            this.picProjectile11 = new System.Windows.Forms.PictureBox();
            this.picDiagonalProjectile1 = new System.Windows.Forms.PictureBox();
            this.picProjectile1 = new System.Windows.Forms.PictureBox();
            this.picSpaceShip = new System.Windows.Forms.PictureBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiagonalProjectile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiagonalProjectile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiagonalProjectile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceShip)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMovePic
            // 
            this.tmrMovePic.Interval = 1;
            this.tmrMovePic.Tick += new System.EventHandler(this.movePic_Tick);
            // 
            // tmrProjectileDispatch
            // 
            this.tmrProjectileDispatch.Interval = 200;
            this.tmrProjectileDispatch.Tick += new System.EventHandler(this.ProjectileDispatch);
            // 
            // lblLevelRound
            // 
            this.lblLevelRound.AutoSize = true;
            this.lblLevelRound.Location = new System.Drawing.Point(1, 30);
            this.lblLevelRound.Name = "lblLevelRound";
            this.lblLevelRound.Size = new System.Drawing.Size(0, 13);
            this.lblLevelRound.TabIndex = 13;
            // 
            // tmrLabelColourTransition
            // 
            this.tmrLabelColourTransition.Enabled = true;
            this.tmrLabelColourTransition.Interval = 10;
            this.tmrLabelColourTransition.Tick += new System.EventHandler(this.tmrLabelColourTransition_Tick);
            // 
            // listProjectileImages
            // 
            this.listProjectileImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listProjectileImages.ImageStream")));
            this.listProjectileImages.TransparentColor = System.Drawing.Color.Transparent;
            this.listProjectileImages.Images.SetKeyName(0, "Alien SpaceShipPNG.png");
            this.listProjectileImages.Images.SetKeyName(1, "iceball.png");
            this.listProjectileImages.Images.SetKeyName(2, "FireballPNG.png");
            this.listProjectileImages.Images.SetKeyName(3, "asteroidPNG.png");
            this.listProjectileImages.Images.SetKeyName(4, "space satellitePNG.png");
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(1, 626);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 20);
            this.lblLevel.TabIndex = 14;
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.White;
            this.lblRound.Location = new System.Drawing.Point(712, 626);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(0, 20);
            this.lblRound.TabIndex = 15;
            // 
            // lblSwiftSalvation
            // 
            this.lblSwiftSalvation.AutoSize = true;
            this.lblSwiftSalvation.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwiftSalvation.Location = new System.Drawing.Point(58, 53);
            this.lblSwiftSalvation.Name = "lblSwiftSalvation";
            this.lblSwiftSalvation.Size = new System.Drawing.Size(687, 108);
            this.lblSwiftSalvation.TabIndex = 20;
            this.lblSwiftSalvation.Text = "Swift Salvation";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(270, 235);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(259, 95);
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 22;
            this.menuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToPlayToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // picDiagonalProjectile3
            // 
            this.picDiagonalProjectile3.Location = new System.Drawing.Point(1, 359);
            this.picDiagonalProjectile3.Name = "picDiagonalProjectile3";
            this.picDiagonalProjectile3.Size = new System.Drawing.Size(67, 58);
            this.picDiagonalProjectile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDiagonalProjectile3.TabIndex = 19;
            this.picDiagonalProjectile3.TabStop = false;
            // 
            // picDiagonalProjectile2
            // 
            this.picDiagonalProjectile2.Location = new System.Drawing.Point(728, 359);
            this.picDiagonalProjectile2.Name = "picDiagonalProjectile2";
            this.picDiagonalProjectile2.Size = new System.Drawing.Size(67, 58);
            this.picDiagonalProjectile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDiagonalProjectile2.TabIndex = 18;
            this.picDiagonalProjectile2.TabStop = false;
            // 
            // picProjectile2
            // 
            this.picProjectile2.Location = new System.Drawing.Point(74, 3);
            this.picProjectile2.Name = "picProjectile2";
            this.picProjectile2.Size = new System.Drawing.Size(67, 58);
            this.picProjectile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile2.TabIndex = 12;
            this.picProjectile2.TabStop = false;
            // 
            // picProjectile3
            // 
            this.picProjectile3.Location = new System.Drawing.Point(147, 3);
            this.picProjectile3.Name = "picProjectile3";
            this.picProjectile3.Size = new System.Drawing.Size(67, 58);
            this.picProjectile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile3.TabIndex = 11;
            this.picProjectile3.TabStop = false;
            // 
            // picProjectile4
            // 
            this.picProjectile4.Location = new System.Drawing.Point(220, 3);
            this.picProjectile4.Name = "picProjectile4";
            this.picProjectile4.Size = new System.Drawing.Size(67, 58);
            this.picProjectile4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile4.TabIndex = 10;
            this.picProjectile4.TabStop = false;
            // 
            // picProjectile5
            // 
            this.picProjectile5.Location = new System.Drawing.Point(293, 3);
            this.picProjectile5.Name = "picProjectile5";
            this.picProjectile5.Size = new System.Drawing.Size(67, 58);
            this.picProjectile5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile5.TabIndex = 9;
            this.picProjectile5.TabStop = false;
            // 
            // picProjectile6
            // 
            this.picProjectile6.Location = new System.Drawing.Point(363, 3);
            this.picProjectile6.Name = "picProjectile6";
            this.picProjectile6.Size = new System.Drawing.Size(67, 58);
            this.picProjectile6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile6.TabIndex = 8;
            this.picProjectile6.TabStop = false;
            // 
            // picProjectile7
            // 
            this.picProjectile7.Location = new System.Drawing.Point(436, 3);
            this.picProjectile7.Name = "picProjectile7";
            this.picProjectile7.Size = new System.Drawing.Size(67, 58);
            this.picProjectile7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile7.TabIndex = 7;
            this.picProjectile7.TabStop = false;
            // 
            // picProjectile8
            // 
            this.picProjectile8.Location = new System.Drawing.Point(509, 3);
            this.picProjectile8.Name = "picProjectile8";
            this.picProjectile8.Size = new System.Drawing.Size(67, 58);
            this.picProjectile8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile8.TabIndex = 6;
            this.picProjectile8.TabStop = false;
            // 
            // picProjectile9
            // 
            this.picProjectile9.Location = new System.Drawing.Point(582, 3);
            this.picProjectile9.Name = "picProjectile9";
            this.picProjectile9.Size = new System.Drawing.Size(67, 58);
            this.picProjectile9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile9.TabIndex = 5;
            this.picProjectile9.TabStop = false;
            // 
            // picProjectile10
            // 
            this.picProjectile10.Location = new System.Drawing.Point(655, 3);
            this.picProjectile10.Name = "picProjectile10";
            this.picProjectile10.Size = new System.Drawing.Size(67, 58);
            this.picProjectile10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile10.TabIndex = 4;
            this.picProjectile10.TabStop = false;
            // 
            // picProjectile11
            // 
            this.picProjectile11.Location = new System.Drawing.Point(728, 3);
            this.picProjectile11.Name = "picProjectile11";
            this.picProjectile11.Size = new System.Drawing.Size(67, 58);
            this.picProjectile11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile11.TabIndex = 3;
            this.picProjectile11.TabStop = false;
            // 
            // picDiagonalProjectile1
            // 
            this.picDiagonalProjectile1.Image = global::SpaceShipInvaders.Properties.Resources.comet;
            this.picDiagonalProjectile1.Location = new System.Drawing.Point(699, 3);
            this.picDiagonalProjectile1.Name = "picDiagonalProjectile1";
            this.picDiagonalProjectile1.Size = new System.Drawing.Size(96, 65);
            this.picDiagonalProjectile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDiagonalProjectile1.TabIndex = 2;
            this.picDiagonalProjectile1.TabStop = false;
            // 
            // picProjectile1
            // 
            this.picProjectile1.Location = new System.Drawing.Point(1, 3);
            this.picProjectile1.Name = "picProjectile1";
            this.picProjectile1.Size = new System.Drawing.Size(67, 58);
            this.picProjectile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProjectile1.TabIndex = 1;
            this.picProjectile1.TabStop = false;
            // 
            // picSpaceShip
            // 
            this.picSpaceShip.Image = global::SpaceShipInvaders.Properties.Resources.SpaceShip;
            this.picSpaceShip.Location = new System.Drawing.Point(363, 565);
            this.picSpaceShip.Name = "picSpaceShip";
            this.picSpaceShip.Size = new System.Drawing.Size(90, 81);
            this.picSpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpaceShip.TabIndex = 0;
            this.picSpaceShip.TabStop = false;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemp.Location = new System.Drawing.Point(13, 153);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 13);
            this.lblTemp.TabIndex = 23;
            // 
            // swftSalv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSwiftSalvation);
            this.Controls.Add(this.picDiagonalProjectile3);
            this.Controls.Add(this.picDiagonalProjectile2);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblLevelRound);
            this.Controls.Add(this.picProjectile2);
            this.Controls.Add(this.picProjectile3);
            this.Controls.Add(this.picProjectile4);
            this.Controls.Add(this.picProjectile5);
            this.Controls.Add(this.picProjectile6);
            this.Controls.Add(this.picProjectile7);
            this.Controls.Add(this.picProjectile8);
            this.Controls.Add(this.picProjectile9);
            this.Controls.Add(this.picProjectile10);
            this.Controls.Add(this.picProjectile11);
            this.Controls.Add(this.picDiagonalProjectile1);
            this.Controls.Add(this.picProjectile1);
            this.Controls.Add(this.picSpaceShip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "swftSalv";
            this.Text = "Swift Salvation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.evntKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.evntKeyUp);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDiagonalProjectile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiagonalProjectile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiagonalProjectile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProjectile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picSpaceShip;
        private System.Windows.Forms.Timer tmrMovePic;
        private System.Windows.Forms.PictureBox picProjectile1;
        private System.Windows.Forms.Timer tmrProjectileDispatch;
        private System.Windows.Forms.PictureBox picDiagonalProjectile1;
        private System.Windows.Forms.PictureBox picProjectile11;
        private System.Windows.Forms.PictureBox picProjectile10;
        private System.Windows.Forms.PictureBox picProjectile9;
        private System.Windows.Forms.PictureBox picProjectile8;
        private System.Windows.Forms.PictureBox picProjectile7;
        private System.Windows.Forms.PictureBox picProjectile6;
        private System.Windows.Forms.PictureBox picProjectile5;
        private System.Windows.Forms.PictureBox picProjectile4;
        private System.Windows.Forms.PictureBox picProjectile3;
        private System.Windows.Forms.PictureBox picProjectile2;
        private System.Windows.Forms.Label lblLevelRound;
        private System.Windows.Forms.Timer tmrLabelColourTransition;
        private System.Windows.Forms.ImageList listProjectileImages;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.PictureBox picDiagonalProjectile2;
        private System.Windows.Forms.PictureBox picDiagonalProjectile3;
        private System.Windows.Forms.Label lblSwiftSalvation;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.Label lblTemp;
    }
}

