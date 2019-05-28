namespace Bomber_man_Game
{
    partial class frmBomberMan
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
            this.btnMMNewGame = new System.Windows.Forms.Button();
            this.btnMMHighScore = new System.Windows.Forms.Button();
            this.btnMMSettings = new System.Windows.Forms.Button();
            this.btnMMAbout = new System.Windows.Forms.Button();
            this.btnMMCredits = new System.Windows.Forms.Button();
            this.btnNGOnePlayerMode = new System.Windows.Forms.Button();
            this.btnNGTwoPlayerMode = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNGGameDifficulty = new System.Windows.Forms.Button();
            this.btnNGBack = new System.Windows.Forms.Button();
            this.lstboxNGGamemodeSelect = new System.Windows.Forms.ListBox();
            this.lstboxNGLevelSelect = new System.Windows.Forms.ListBox();
            this.btnNGStart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMMNewGame
            // 
            this.btnMMNewGame.Location = new System.Drawing.Point(12, 647);
            this.btnMMNewGame.Name = "btnMMNewGame";
            this.btnMMNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnMMNewGame.TabIndex = 0;
            this.btnMMNewGame.Text = "New game";
            this.btnMMNewGame.UseVisualStyleBackColor = true;
            this.btnMMNewGame.Click += new System.EventHandler(this.btnMMNewGame_Click);
            // 
            // btnMMHighScore
            // 
            this.btnMMHighScore.Location = new System.Drawing.Point(93, 647);
            this.btnMMHighScore.Name = "btnMMHighScore";
            this.btnMMHighScore.Size = new System.Drawing.Size(75, 23);
            this.btnMMHighScore.TabIndex = 1;
            this.btnMMHighScore.Text = "High score";
            this.btnMMHighScore.UseVisualStyleBackColor = true;
            this.btnMMHighScore.Click += new System.EventHandler(this.btnMMHighScore_Click);
            // 
            // btnMMSettings
            // 
            this.btnMMSettings.Location = new System.Drawing.Point(174, 647);
            this.btnMMSettings.Name = "btnMMSettings";
            this.btnMMSettings.Size = new System.Drawing.Size(75, 23);
            this.btnMMSettings.TabIndex = 2;
            this.btnMMSettings.Text = "Settings";
            this.btnMMSettings.UseVisualStyleBackColor = true;
            this.btnMMSettings.Click += new System.EventHandler(this.btnMMSettings_Click);
            // 
            // btnMMAbout
            // 
            this.btnMMAbout.Location = new System.Drawing.Point(255, 647);
            this.btnMMAbout.Name = "btnMMAbout";
            this.btnMMAbout.Size = new System.Drawing.Size(75, 23);
            this.btnMMAbout.TabIndex = 3;
            this.btnMMAbout.Text = "About";
            this.btnMMAbout.UseVisualStyleBackColor = true;
            this.btnMMAbout.Click += new System.EventHandler(this.btnMMAbout_Click);
            // 
            // btnMMCredits
            // 
            this.btnMMCredits.Location = new System.Drawing.Point(336, 647);
            this.btnMMCredits.Name = "btnMMCredits";
            this.btnMMCredits.Size = new System.Drawing.Size(75, 23);
            this.btnMMCredits.TabIndex = 4;
            this.btnMMCredits.Text = "Credits";
            this.btnMMCredits.UseVisualStyleBackColor = true;
            // 
            // btnNGOnePlayerMode
            // 
            this.btnNGOnePlayerMode.BackgroundImage = global::Bomber_man_Game.Properties.Resources.Single_Player;
            this.btnNGOnePlayerMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNGOnePlayerMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNGOnePlayerMode.ForeColor = System.Drawing.Color.DarkRed;
            this.btnNGOnePlayerMode.Location = new System.Drawing.Point(13, 13);
            this.btnNGOnePlayerMode.Name = "btnNGOnePlayerMode";
            this.btnNGOnePlayerMode.Size = new System.Drawing.Size(75, 23);
            this.btnNGOnePlayerMode.TabIndex = 6;
            this.btnNGOnePlayerMode.Text = "Single Player";
            this.btnNGOnePlayerMode.UseVisualStyleBackColor = true;
            this.btnNGOnePlayerMode.Visible = false;
            this.btnNGOnePlayerMode.Click += new System.EventHandler(this.btnNGOnePlayerMode_Click);
            // 
            // btnNGTwoPlayerMode
            // 
            this.btnNGTwoPlayerMode.BackgroundImage = global::Bomber_man_Game.Properties.Resources.Two_Players;
            this.btnNGTwoPlayerMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNGTwoPlayerMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNGTwoPlayerMode.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnNGTwoPlayerMode.Location = new System.Drawing.Point(93, 12);
            this.btnNGTwoPlayerMode.Name = "btnNGTwoPlayerMode";
            this.btnNGTwoPlayerMode.Size = new System.Drawing.Size(75, 23);
            this.btnNGTwoPlayerMode.TabIndex = 7;
            this.btnNGTwoPlayerMode.Text = "Two players";
            this.btnNGTwoPlayerMode.UseVisualStyleBackColor = true;
            this.btnNGTwoPlayerMode.Visible = false;
            this.btnNGTwoPlayerMode.Click += new System.EventHandler(this.btnNGTwoPlayerMode_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.btnNGStart);
            this.pnlBackground.Controls.Add(this.btnNGBack);
            this.pnlBackground.Controls.Add(this.btnNGGameDifficulty);
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.lstboxNGLevelSelect);
            this.pnlBackground.Controls.Add(this.lstboxNGGamemodeSelect);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1592, 866);
            this.pnlBackground.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Game difficulty";
            this.label1.Visible = false;
            // 
            // btnNGGameDifficulty
            // 
            this.btnNGGameDifficulty.Location = new System.Drawing.Point(13, 128);
            this.btnNGGameDifficulty.Name = "btnNGGameDifficulty";
            this.btnNGGameDifficulty.Size = new System.Drawing.Size(75, 23);
            this.btnNGGameDifficulty.TabIndex = 9;
            this.btnNGGameDifficulty.Text = "Easy";
            this.btnNGGameDifficulty.UseVisualStyleBackColor = true;
            this.btnNGGameDifficulty.Visible = false;
            this.btnNGGameDifficulty.Click += new System.EventHandler(this.btnNGGameDifficulty_Click);
            // 
            // btnNGBack
            // 
            this.btnNGBack.Location = new System.Drawing.Point(12, 157);
            this.btnNGBack.Name = "btnNGBack";
            this.btnNGBack.Size = new System.Drawing.Size(75, 23);
            this.btnNGBack.TabIndex = 8;
            this.btnNGBack.Text = "Back";
            this.btnNGBack.UseVisualStyleBackColor = true;
            this.btnNGBack.Visible = false;
            this.btnNGBack.Click += new System.EventHandler(this.btnNGBack_Click);
            // 
            // lstboxNGGamemodeSelect
            // 
            this.lstboxNGGamemodeSelect.FormattingEnabled = true;
            this.lstboxNGGamemodeSelect.Location = new System.Drawing.Point(221, 114);
            this.lstboxNGGamemodeSelect.Name = "lstboxNGGamemodeSelect";
            this.lstboxNGGamemodeSelect.Size = new System.Drawing.Size(120, 95);
            this.lstboxNGGamemodeSelect.TabIndex = 7;
            this.lstboxNGGamemodeSelect.Visible = false;
            // 
            // lstboxNGLevelSelect
            // 
            this.lstboxNGLevelSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstboxNGLevelSelect.FormattingEnabled = true;
            this.lstboxNGLevelSelect.Location = new System.Drawing.Point(94, 114);
            this.lstboxNGLevelSelect.Name = "lstboxNGLevelSelect";
            this.lstboxNGLevelSelect.Size = new System.Drawing.Size(120, 93);
            this.lstboxNGLevelSelect.TabIndex = 6;
            this.lstboxNGLevelSelect.Visible = false;
            // 
            // btnNGStart
            // 
            this.btnNGStart.Location = new System.Drawing.Point(13, 186);
            this.btnNGStart.Name = "btnNGStart";
            this.btnNGStart.Size = new System.Drawing.Size(75, 23);
            this.btnNGStart.TabIndex = 0;
            this.btnNGStart.Text = "Start";
            this.btnNGStart.UseVisualStyleBackColor = true;
            this.btnNGStart.Visible = false;
            this.btnNGStart.Click += new System.EventHandler(this.btnNGStart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmBomberMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bomber_man_Game.Properties.Resources.mountainTheme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1592, 866);
            this.Controls.Add(this.btnNGOnePlayerMode);
            this.Controls.Add(this.btnNGTwoPlayerMode);
            this.Controls.Add(this.btnMMCredits);
            this.Controls.Add(this.btnMMAbout);
            this.Controls.Add(this.btnMMSettings);
            this.Controls.Add(this.btnMMHighScore);
            this.Controls.Add(this.btnMMNewGame);
            this.Controls.Add(this.pnlBackground);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Name = "frmBomberMan";
            this.Text = "Bomber Man";
            this.Load += new System.EventHandler(this.frmBomberMan_Load);
            this.Resize += new System.EventHandler(this.frmBomberMan_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMMNewGame;
        private System.Windows.Forms.Button btnMMHighScore;
        private System.Windows.Forms.Button btnMMSettings;
        private System.Windows.Forms.Button btnMMAbout;
        private System.Windows.Forms.Button btnMMCredits;
        private System.Windows.Forms.Button btnNGOnePlayerMode;
        private System.Windows.Forms.Button btnNGTwoPlayerMode;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Button btnNGStart;
        private System.Windows.Forms.ListBox lstboxNGGamemodeSelect;
        private System.Windows.Forms.ListBox lstboxNGLevelSelect;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNGBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNGGameDifficulty;



    }
}

