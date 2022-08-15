namespace SpaceShipInvaders
{
    partial class frmTicTacToe
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
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnY1 = new System.Windows.Forms.Button();
            this.btnY2 = new System.Windows.Forms.Button();
            this.btnY3 = new System.Windows.Forms.Button();
            this.btnZ1 = new System.Windows.Forms.Button();
            this.btnZ2 = new System.Windows.Forms.Button();
            this.btnZ3 = new System.Windows.Forms.Button();
            this.lblticTacToe = new System.Windows.Forms.Label();
            this.tmrfontColourChange = new System.Windows.Forms.Timer(this.components);
            this.lblXScore = new System.Windows.Forms.Label();
            this.lblOScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnX1
            // 
            this.btnX1.BackColor = System.Drawing.Color.Yellow;
            this.btnX1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnX1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX1.Location = new System.Drawing.Point(12, 84);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(100, 100);
            this.btnX1.TabIndex = 0;
            this.btnX1.UseVisualStyleBackColor = false;
            this.btnX1.Click += new System.EventHandler(this.clickEvent);
            // 
            // btnX2
            // 
            this.btnX2.BackColor = System.Drawing.Color.Yellow;
            this.btnX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnX2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX2.Location = new System.Drawing.Point(118, 84);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(100, 100);
            this.btnX2.TabIndex = 1;
            this.btnX2.UseVisualStyleBackColor = false;
            this.btnX2.Click += new System.EventHandler(this.clickEvent);
            // 
            // btnX3
            // 
            this.btnX3.BackColor = System.Drawing.Color.Yellow;
            this.btnX3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnX3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX3.Location = new System.Drawing.Point(224, 84);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(100, 100);
            this.btnX3.TabIndex = 2;
            this.btnX3.UseVisualStyleBackColor = false;
            this.btnX3.Click += new System.EventHandler(this.clickEvent);
            // 
            // btnY1
            // 
            this.btnY1.BackColor = System.Drawing.Color.Yellow;
            this.btnY1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnY1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY1.Location = new System.Drawing.Point(12, 190);
            this.btnY1.Name = "btnY1";
            this.btnY1.Size = new System.Drawing.Size(100, 100);
            this.btnY1.TabIndex = 3;
            this.btnY1.UseVisualStyleBackColor = false;
            this.btnY1.Click += new System.EventHandler(this.clickEvent);
            // 
            // btnY2
            // 
            this.btnY2.BackColor = System.Drawing.Color.Yellow;
            this.btnY2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnY2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY2.Location = new System.Drawing.Point(118, 190);
            this.btnY2.Name = "btnY2";
            this.btnY2.Size = new System.Drawing.Size(100, 100);
            this.btnY2.TabIndex = 4;
            this.btnY2.UseVisualStyleBackColor = false;
            this.btnY2.Click += new System.EventHandler(this.clickEvent);
            // 
            // btnY3
            // 
            this.btnY3.BackColor = System.Drawing.Color.Yellow;
            this.btnY3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnY3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnY3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY3.Location = new System.Drawing.Point(224, 190);
            this.btnY3.Name = "btnY3";
            this.btnY3.Size = new System.Drawing.Size(100, 100);
            this.btnY3.TabIndex = 5;
            this.btnY3.UseVisualStyleBackColor = false;
            this.btnY3.Click += new System.EventHandler(this.clickEvent);
            // 
            // btnZ1
            // 
            this.btnZ1.BackColor = System.Drawing.Color.Yellow;
            this.btnZ1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZ1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ1.Location = new System.Drawing.Point(12, 296);
            this.btnZ1.Name = "btnZ1";
            this.btnZ1.Size = new System.Drawing.Size(100, 100);
            this.btnZ1.TabIndex = 6;
            this.btnZ1.UseVisualStyleBackColor = false;
            this.btnZ1.Click += new System.EventHandler(this.clickEvent);
            // 
            // btnZ2
            // 
            this.btnZ2.BackColor = System.Drawing.Color.Yellow;
            this.btnZ2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZ2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ2.Location = new System.Drawing.Point(118, 296);
            this.btnZ2.Name = "btnZ2";
            this.btnZ2.Size = new System.Drawing.Size(100, 100);
            this.btnZ2.TabIndex = 7;
            this.btnZ2.UseVisualStyleBackColor = false;
            this.btnZ2.Click += new System.EventHandler(this.clickEvent);
            // 
            // btnZ3
            // 
            this.btnZ3.BackColor = System.Drawing.Color.Yellow;
            this.btnZ3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnZ3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZ3.Location = new System.Drawing.Point(224, 296);
            this.btnZ3.Name = "btnZ3";
            this.btnZ3.Size = new System.Drawing.Size(100, 100);
            this.btnZ3.TabIndex = 8;
            this.btnZ3.UseVisualStyleBackColor = false;
            this.btnZ3.Click += new System.EventHandler(this.clickEvent);
            // 
            // lblticTacToe
            // 
            this.lblticTacToe.AutoSize = true;
            this.lblticTacToe.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblticTacToe.Location = new System.Drawing.Point(74, 48);
            this.lblticTacToe.Name = "lblticTacToe";
            this.lblticTacToe.Size = new System.Drawing.Size(181, 33);
            this.lblticTacToe.TabIndex = 11;
            this.lblticTacToe.Text = "Tic Tac Toe";
            // 
            // tmrfontColourChange
            // 
            this.tmrfontColourChange.Enabled = true;
            this.tmrfontColourChange.Interval = 200;
            this.tmrfontColourChange.Tick += new System.EventHandler(this.tmrfontColourChange_Tick);
            // 
            // lblXScore
            // 
            this.lblXScore.AutoSize = true;
            this.lblXScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXScore.ForeColor = System.Drawing.Color.White;
            this.lblXScore.Location = new System.Drawing.Point(12, 411);
            this.lblXScore.Name = "lblXScore";
            this.lblXScore.Size = new System.Drawing.Size(0, 20);
            this.lblXScore.TabIndex = 12;
            // 
            // lblOScore
            // 
            this.lblOScore.AutoSize = true;
            this.lblOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOScore.ForeColor = System.Drawing.Color.White;
            this.lblOScore.Location = new System.Drawing.Point(234, 411);
            this.lblOScore.Name = "lblOScore";
            this.lblOScore.Size = new System.Drawing.Size(0, 20);
            this.lblOScore.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fix your circuit board in a game of:";
            // 
            // frmTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOScore);
            this.Controls.Add(this.lblXScore);
            this.Controls.Add(this.lblticTacToe);
            this.Controls.Add(this.btnZ3);
            this.Controls.Add(this.btnZ2);
            this.Controls.Add(this.btnZ1);
            this.Controls.Add(this.btnY3);
            this.Controls.Add(this.btnY2);
            this.Controls.Add(this.btnY1);
            this.Controls.Add(this.btnX3);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicTacToe";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Button btnX3;
        private System.Windows.Forms.Button btnY1;
        private System.Windows.Forms.Button btnY2;
        private System.Windows.Forms.Button btnY3;
        private System.Windows.Forms.Button btnZ1;
        private System.Windows.Forms.Button btnZ2;
        private System.Windows.Forms.Button btnZ3;
        private System.Windows.Forms.Label lblticTacToe;
        private System.Windows.Forms.Timer tmrfontColourChange;
        private System.Windows.Forms.Label lblXScore;
        private System.Windows.Forms.Label lblOScore;
        private System.Windows.Forms.Label label1;
    }
}