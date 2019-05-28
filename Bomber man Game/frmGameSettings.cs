using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bomber_man_Game;
using Bomber_man_Game.Properties;
using System.IO;

namespace Bomber_man_Game
{

    public partial class frmGameSettings : Form
    {
        // makes it easy to add the resolutions to the list
        string[] strAraResolutions = { "1366x895", "1920x1250", "1280x830", "1440x930", "1580x1020", "1600x900", "1280x720", "1080x720" };
        public frmGameSettings()
        {
            InitializeComponent();
        }
        // list that holds the resolutions
        List<string> listResolutions = new List<string>();
        // list that holds the themes
        List<string> Themes = new List<string>();
        private void frmGameSettings_Load(object sender, EventArgs e)
        {
            // adds the resolutions to the list
            foreach(string resolitoin in strAraResolutions)
            {
                listResolutions.Add(resolitoin);
            }
            // creates a seperator for the resolution X and Y
            char seperator = 'x';
            // check each value in the list
            foreach(string Resolution in listResolutions)
            {
                // adds the resolution to the list box
                lstboxResolutions.Items.Add(Resolution);
                // creates a string array to seperate the X and Y of the resolution
                string[] strAraCurrentRes = new string[2];
                strAraCurrentRes = Resolution.Split(seperator);
                // if the X value of the main form and the Y value of the main form are equal
                if (Properties.Settings.Default.formWidth == Convert.ToInt32(strAraCurrentRes[0]) 
                    && Properties.Settings.Default.formHeight == Convert.ToInt32(strAraCurrentRes[1]))
                {
                    // highlight the resolution that is being added to the list
                    lstboxResolutions.SelectedIndex = lstboxResolutions.FindString(Resolution);
                }
            }
            // adds the themes to the list
            Themes.Add("Forest Theme");
            Themes.Add("Ocean Theme");
            Themes.Add("Mountain Theme");
            Themes.Add("Desert Theme");
            // adds the themes to the list box
            foreach (string Theme in Themes)
            {
                lstboxThemes.Items.Add(Theme);
            }
            
            }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // creates a string array to seperate the X and Y of the resolution
            string[] strCurrentRes = new string[2];
            strCurrentRes = lstboxResolutions.SelectedItem.ToString().Split('x');
            // sets the size of the main form to the selected resolution
            Properties.Settings.Default.formWidth = Convert.ToInt32(strCurrentRes[0]);
            Properties.Settings.Default.formHeight = Convert.ToInt32(strCurrentRes[1]);
            // sets the background properties textfile
            Properties.Settings.Default.backgroundImage = lstboxThemes.SelectedIndex;
            // saves these settings
            Properties.Settings.Default.Save();
            Application.Restart();
        }
    }
}
