using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Random_God_Generator_Smite.Classes;
using static Random_God_Generator_Smite.Classes.Common;
using static Random_God_Generator_Smite.Classes.ParseMethods;


namespace Random_God_Generator_Smite
{
    public partial class MainForm : Form
    {
        Random r = new Random();

        List<God> GodList = new List<God>();
        List<List<string>> SmiteWikiGodTable = new List<List<string>>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 1. Scrape God Names + Class
            // 2. Add them to list
            // 3. Populate combo box with class selection / all gods
            // 4. Choose random god button selects random index from whichever list is selected in combo box

            godClassSelectionComboBox.SelectedIndex = 0;

            // add the unparsed data to a list
            SmiteWikiGodTable = GetSmiteWikiGodTable();
            // parse the data and map relevant data to a god object
            GodList = SmiteWikiGodTableToList(SmiteWikiGodTable);
            // parse each god's skins and skin links
            //GodList = ParseAllGodSkinNamesAndLinks(GodList);
        }
        
        private void generateRandomGodButton_Click(object sender, EventArgs e)
        {
            // when generate button is clicked we check if a specific class is picked
            switch(godClassSelectionComboBox.Text)
            {
                case "Any Class":
                    {
                        God RandomGod = GodList[r.Next(GodList.Count - 1)];
                        generatedGodLabel.Text = RandomGod.Name;
                        break;
                    }
                default:
                    {
                        God RandomGod = GodList[r.Next(GodList.Count - 1)];

                        while (godClassSelectionComboBox.Text != RandomGod.Class)
                            RandomGod = GodList[r.Next(GodList.Count - 1)];

                        generatedGodLabel.Text = RandomGod.Name;

                        break;
                    }
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program doesn't need to update for new god releases, it will automatically add new gods to the generator.");
        }
    }
}
