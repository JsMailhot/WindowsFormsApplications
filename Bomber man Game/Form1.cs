using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomber_man_Game.Properties;

/* Created by:
 * Justin S Mailhot
 * Date: 4/18/2015
 */

//Main Menu: Features of the main menu
/*  Exit
*Exits the program ( Only Function ).*/
/*  High Score
*	Top ten tab
*Displays every player's nickname and score who is in the top ten
*Displays top ten scores in each level and gamemode
*	Top One Hundred tab
*Displays every player’s nickname and score who is in the top one hundred
*Displays top one hundred scores in each level and gamemode
*	Everyone tab
*Displays every player’s nickname and score who has played the game
*Displays every score in each level and gamemode
/*  Credits
*Shows information about the game, designers and developer.
*Give credit to images and sources used.*/
/*  Settings
*	Volume:Music
*Adjusts the volume of the music when settings are saved.
*	Volume:Game
*Adjusts the in game volume when the settings are saved.
*	Controls:Player1
*Able to set the controls for player one including but not limited to.
*1. Move up, down, left and right.
*2. Place bombs.
*3. Detonate bombs.
*Controls may not overlap with each other or the other players controls.
*	Controls:Player2
*Able to set the controls for player two including but not limited to.
*1. Move up, down, left, and right.
*2. Place bombs.
*3. Detonate bombs.
*Controls may not overlap each other or the other players controls.
*	Resolution
*Adjusts the resolution the game is set in, this includes but is not limited to
*1. 1366x895
*2. 1920x1250
*3. 1280x830
*4. 1440x930
*5. 1580x1020
*6. 1600x900
*7. 1280x720
*8. 1080x720
*	Themes
*Forest theme
*Ocean theme
*Mountain theme
*Desert theme */
/*  New Game
*	One player mode
*Allows one player to select their skin and nametag
*Allows one player to play against one to three bots or alone
*Allows one player to change the difficulty of the bots
*Allows one player to select the skin of the AI
*	Two player mode
*Allows two player to select their skins and nametags
*Allows two players to play against one to two bots or one v one
*Allows one player to change the difficulty of the bots
*Allows one player to select the skin of the AI
*	Level select
*Blocks and blocks
*Tetris
*Empty
*Classic
*	Gamemode select
*Endless
*Classic
*Deathwish
*Zombies ( endless deathwish) */

namespace Bomber_man_Game
{

    public partial class frmBomberMan : Form
    {
        public frmBomberMan()
        {
            InitializeComponent();

        }
        // pre-requisites that are shared
        bool singlePlayer = false;
        bool twoPlayer = false;
        // end of pre-requisites
        public Bitmap themeGet()
        {
            int intToTheme = Properties.Settings.Default.backgroundImage;
            switch(intToTheme)
            {
                case 0:
                    return Resources.forestTheme;
                case 1:
                    return Resources.oceanTheme;
                case 2:
                    return Resources.mountainTheme;
                case 3:
                    return Resources.desertTheme;
            }
            return Resources.forestTheme;
        }
        List<string> Levels = new List<string>();
        List<string> Gamemodes = new List<string>();

        public void frmBomberMan_Load(object sender, EventArgs e)
        {
            
            // Sets the background image for the form, as well as the height and width
            this.BackgroundImage = themeGet();
            this.Width = Properties.Settings.Default.formWidth;
            this.Height = Properties.Settings.Default.formHeight;
            
            pnlBackground.BackgroundImage = this.BackgroundImage;
            // Creates and sets the location of buttons based on the size of the canvas
            buttonMake(btnMMNewGame, "New Game", this.Width / 8, this.Height / 20, 1);
            btnMMNewGame.Location = new Point( this.Width / 2 - btnMMNewGame.Width / 2, this.Height / 2 - btnMMNewGame.Height * 2);
            // font is changed to fit inside the
            btnMMNewGame.Font = new Font(btnMMNewGame.Text , btnMMNewGame.Width / 12, FontStyle.Regular);
            
            buttonMake(btnMMHighScore, "High Score", this.Width / 8, this.Height / 20, 2);
            btnMMHighScore.Location = new Point( this.Width / 2 - btnMMHighScore.Width / 2, this.Height / 2 - btnMMHighScore.Height);
            btnMMHighScore.Font = new Font(btnMMHighScore.Text, btnMMHighScore.Width / 12, FontStyle.Regular);

            buttonMake(btnMMSettings, "Settings", this.Width / 8, this.Height / 20, 3);
            btnMMSettings.Location = new Point( this.Width / 2 - btnMMSettings.Width / 2, this.Height / 2);
            btnMMSettings.Font = new Font(btnMMSettings.Text, btnMMSettings.Width / 12, FontStyle.Regular);

            buttonMake(btnMMAbout, "About", this.Width / 8, this.Height / 20, 4);
            btnMMAbout.Location = new Point(this.Width / 2 - btnMMAbout.Width / 2, this.Height / 2 + btnMMAbout.Height);
            btnMMAbout.Font = new Font(btnMMAbout.Text, btnMMAbout.Width / 12, FontStyle.Regular);

            buttonMake(btnMMCredits, "Credits", this.Width / 8, this.Height / 20, 5);
            btnMMCredits.Location = new Point( this.Width / 2 - btnMMCredits.Width / 2, this.Height / 2 + btnMMCredits.Height * 2);
            btnMMCredits.Font = new Font(btnMMCredits.Text, btnMMCredits.Width / 12, FontStyle.Regular);

            // buttons for chosing number of human players in the game
            buttonMake(btnNGOnePlayerMode, "Single Player", this.Width / 2, this.Height, 1);
            btnNGOnePlayerMode.Location = new Point(-5, -5);

            buttonMake(btnNGTwoPlayerMode, "Two Players", this.Width / 2, this.Height, 2);
            btnNGTwoPlayerMode.Location = new Point(this.Width / 2 - 10, -5);
            
            lstboxNGGamemodeSelect.Size = new Size(this.Width / 10, this.Width / 6);
            lstboxNGGamemodeSelect.Location = new Point(60, 60);

            lstboxNGLevelSelect.Size = new Size(this.Width / 10, this.Width / 6);
            lstboxNGLevelSelect.Location = new Point(60, lstboxNGGamemodeSelect.Location.X +
                lstboxNGGamemodeSelect.Width + lstboxNGGamemodeSelect.Location.X + 60);
        }
        public static void buttonMake (Button button, string name,double sizeX,double sizeY, Int32 tab)
        {
            // sets the text of the button
            button.Text = name;
            // changes the size of the button
            button.Size = new Size(Convert.ToInt32(sizeX),Convert.ToInt32(sizeY));
            // changes the tab order of the button
            button.TabIndex = tab;
        }


        private void btnMMSettings_Click(object sender, EventArgs e)
        {
            // creates a new instance of the form for settings
            frmGameSettings newSettings = new frmGameSettings();
            // shows the form
            newSettings.Show();
            // sets focus on the form and brings it to the front
            newSettings.BringToFront();
        }

        private void btnMMNewGame_Click(object sender, EventArgs e)
        {
            // shows the buttons for the single and two player mode
            btnNGGameDifficulty.Visible = true;
            btnNGBack.Visible = true;
            btnNGStart.Visible = true;

            // Shows the list boxes for the new game
            lstboxNGGamemodeSelect.Visible = true;
            lstboxNGLevelSelect.Visible = true;

            // Shows the labels in the new game
            label1.Visible = true;

            // Hides the main menu buttons
            btnMMNewGame.Visible = false;
            btnMMHighScore.Visible = false;
            btnMMSettings.Visible = false;
            btnMMAbout.Visible = false;
            btnMMCredits.Visible = false;

            // shows the buttons for one and two player selection
            btnNGOnePlayerMode.Visible = true;
            btnNGTwoPlayerMode.Visible = true;
        }

        private void btnMMAbout_Click(object sender, EventArgs e)
        {
            // creates a new instance of the form for about
            frmAbout about = new frmAbout();
            // shows the form
            about.Show();
            // sets the focus on the form and brings it to the front
            about.BringToFront();
        }

        private void btnNGOnePlayerMode_Click(object sender, EventArgs e)
        {
            // sets singleplayer to true
            singlePlayer = true;
            twoPlayer = false;
            //  hides the buttons for chosing between one or two player
            btnNGOnePlayerMode.Visible = false;
            btnNGTwoPlayerMode.Visible = false;

        }

        private void btnNGTwoPlayerMode_Click(object sender, EventArgs e)
        {
            // sets two player to true
            singlePlayer = false;
            twoPlayer = true;
            // hides the buttons for chosing between one or two player
            btnNGOnePlayerMode.Visible = false;
            btnNGTwoPlayerMode.Visible = false;



        }
        // new game menu start game button
        private void btnNGStart_Click(object sender, EventArgs e)
        {

        }
        // new game menu back button
        private void btnNGBack_Click(object sender, EventArgs e)
        {
            // returns the main menu buttons to visible
            btnMMNewGame.Visible = true;
            btnMMHighScore.Visible = true;
            btnMMSettings.Visible = true;
            btnMMAbout.Visible = true;
            btnMMCredits.Visible = true;
            // sets the new game menu to not visible
            label1.Visible = false;
            pnlBackground.SendToBack();
            lstboxNGLevelSelect.Visible = false;
            lstboxNGGamemodeSelect.Visible = false;
            btnNGGameDifficulty.Visible = false;
            btnNGStart.Visible = false;
            btnNGBack.Visible = false;
        }
        // Main menu high score menu
        private void btnMMHighScore_Click(object sender, EventArgs e)
        {

        }

        private void btnNGGameDifficulty_Click(object sender, EventArgs e)
        {
            if(btnNGGameDifficulty.Text == "Easy")
            {
                btnNGGameDifficulty.Text = "Medium";
                return;
            } else if (btnNGGameDifficulty.Text == "Medium")
            {
                btnNGGameDifficulty.Text = "Hard";
                return;
            }else
            {
                btnNGGameDifficulty.Text = "Easy";
                return;
            }
        }

    }

    public class player
    {
        public int currentHitPoints { get; set; }
        public int maximumHitPoints { get; set; }
        public int currentScore { get; set; }

    }
    public class newGame
    {
       
    }
}

/* Current problems
 * 
 * 
 * In the settings form, finding how to relate the themes
 * in the resource folder to the strings in the lstboxthemes
 * and how to change background and newgame based on selected.
 * 
 * In general, how to access properties of one form from another
 * Or how to access the properties of one form from another.
*/