namespace Bomber_man_Game
{
    partial class frmGameSettings
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
            this.tbarMusic = new System.Windows.Forms.TrackBar();
            this.tbarGame = new System.Windows.Forms.TrackBar();
            this.btnP1Controls = new System.Windows.Forms.Button();
            this.btnP2Controls = new System.Windows.Forms.Button();
            this.lstboxResolutions = new System.Windows.Forms.ListBox();
            this.lstboxThemes = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCurrentResolution = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarGame)).BeginInit();
            this.SuspendLayout();
            // 
            // tbarMusic
            // 
            this.tbarMusic.Location = new System.Drawing.Point(12, 29);
            this.tbarMusic.Maximum = 100;
            this.tbarMusic.Name = "tbarMusic";
            this.tbarMusic.Size = new System.Drawing.Size(120, 45);
            this.tbarMusic.TabIndex = 0;
            // 
            // tbarGame
            // 
            this.tbarGame.Location = new System.Drawing.Point(12, 93);
            this.tbarGame.Maximum = 100;
            this.tbarGame.Name = "tbarGame";
            this.tbarGame.Size = new System.Drawing.Size(119, 45);
            this.tbarGame.TabIndex = 1;
            // 
            // btnP1Controls
            // 
            this.btnP1Controls.Location = new System.Drawing.Point(10, 144);
            this.btnP1Controls.Name = "btnP1Controls";
            this.btnP1Controls.Size = new System.Drawing.Size(121, 25);
            this.btnP1Controls.TabIndex = 2;
            this.btnP1Controls.Text = "Player 1 Controls";
            this.btnP1Controls.UseVisualStyleBackColor = true;
            // 
            // btnP2Controls
            // 
            this.btnP2Controls.Location = new System.Drawing.Point(10, 173);
            this.btnP2Controls.Name = "btnP2Controls";
            this.btnP2Controls.Size = new System.Drawing.Size(121, 25);
            this.btnP2Controls.TabIndex = 3;
            this.btnP2Controls.Text = "Player 2 Controls";
            this.btnP2Controls.UseVisualStyleBackColor = true;
            // 
            // lstboxResolutions
            // 
            this.lstboxResolutions.FormattingEnabled = true;
            this.lstboxResolutions.Location = new System.Drawing.Point(13, 211);
            this.lstboxResolutions.Name = "lstboxResolutions";
            this.lstboxResolutions.Size = new System.Drawing.Size(120, 212);
            this.lstboxResolutions.TabIndex = 4;
            // 
            // lstboxThemes
            // 
            this.lstboxThemes.FormattingEnabled = true;
            this.lstboxThemes.Location = new System.Drawing.Point(152, 211);
            this.lstboxThemes.Name = "lstboxThemes";
            this.lstboxThemes.Size = new System.Drawing.Size(120, 212);
            this.lstboxThemes.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Music Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Game Volume";
            // 
            // lblCurrentResolution
            // 
            this.lblCurrentResolution.AutoSize = true;
            this.lblCurrentResolution.Location = new System.Drawing.Point(13, 432);
            this.lblCurrentResolution.Name = "lblCurrentResolution";
            this.lblCurrentResolution.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentResolution.TabIndex = 9;
            // 
            // frmGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 462);
            this.Controls.Add(this.lblCurrentResolution);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstboxThemes);
            this.Controls.Add(this.lstboxResolutions);
            this.Controls.Add(this.btnP2Controls);
            this.Controls.Add(this.btnP1Controls);
            this.Controls.Add(this.tbarGame);
            this.Controls.Add(this.tbarMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameSettings";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.frmGameSettings_Load);
            this.Resize += new System.EventHandler(this.frmGameSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbarMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbarMusic;
        private System.Windows.Forms.TrackBar tbarGame;
        private System.Windows.Forms.Button btnP1Controls;
        private System.Windows.Forms.Button btnP2Controls;
        private System.Windows.Forms.ListBox lstboxResolutions;
        private System.Windows.Forms.ListBox lstboxThemes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCurrentResolution;
    }
}