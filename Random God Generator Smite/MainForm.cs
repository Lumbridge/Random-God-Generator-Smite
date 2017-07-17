using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Net;

using Random_God_Generator_Smite.Classes;

namespace Random_God_Generator_Smite
{
    public partial class MainForm : Form
    {
        #region Lists
        Random r = new Random();

        List<God> Gods = new List<God>();

        List<string> contents = new List<string>();
        List<List<string>> tableHeadings;
        List<List<string>> tableContents;

        List<God> Assassins = new List<God>();
        List<God> Guardians = new List<God>();
        List<God> Hunters = new List<God>();
        List<God> Mages = new List<God>();
        List<God> Warriors = new List<God>();
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void downloadWebpage()
        {
            WebClient webClient = new WebClient();
            string page = webClient.DownloadString("http://smite.gamepedia.com/List_of_gods");

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(page);

            doc.OptionFixNestedTags = true;

            tableHeadings = doc.DocumentNode.SelectSingleNode("//table")
                .Descendants("tr")
                .Skip(0)
                .Where(tr => tr.Elements("th").Count() > 1)
                .Select(tr => tr.Elements("th").Select(th => th.InnerText.Trim()).ToList())
                .ToList();

            tableContents = doc.DocumentNode.SelectSingleNode("//table")
                .Descendants("tr")
                .Skip(0)
                .Where(tr => tr.Elements("td").Count() > 1)
                .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToList())
                .ToList();
        }

        private void addPageDataToLists()
        {
            downloadWebpage();

            // adding all table contents to a list "contents"
            foreach (List<string> list in tableContents)
            {
                foreach (string items in list)
                {
                    contents.Add(items);
                }
            }

            for(int i = 0; i < contents.Count; i += 9)
            {
                Gods.Add(new God()
                {
                    Name = contents[i + 1],
                    Pantheon = contents[i + 2],
                    AttackType = contents[i + 3],
                    PowerType = contents[i + 4],
                    Class = contents[i + 5],
                    FavourCost = contents[i + 6],
                    GemCost = contents[i + 7],
                    ReleaseDate = contents[i + 8]
                });
            }
        }

        private void populateClassLists()
        {
            foreach (var god in Gods)
            {
                switch(god.Class)
                {
                    case "Assassin":
                        Assassins.Add(god);
                        break;
                    case "Guardian":
                        Guardians.Add(god);
                        break;
                    case "Hunter":
                        Hunters.Add(god);
                        break;
                    case "Mage":
                        Mages.Add(god);
                        break;
                    case "Warrior":
                        Warriors.Add(god);
                        break;
                    default:
                        MessageBox.Show("Unknown Class Detected; Continue or wait for an update.");
                        break;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 1. Scrape God Names + Class
            // 2. Add them to list
            // 3. Populate combo box with class selection / all gods
            // 4. Choose random god button selects random index from whichever list is selected in combo box

            godClassSelectionComboBox.SelectedIndex = 0;

            addPageDataToLists();
            populateClassLists();
        }

        private void generateRandomGodButton_Click(object sender, EventArgs e)
        {
            switch (godClassSelectionComboBox.Text)
            {
                case "Any Class":
                    generatedGodLabel.Text = Gods[r.Next(Gods.Count - 1)].Name;
                    break;
                case "Assassin":
                    generatedGodLabel.Text = Assassins[r.Next(Assassins.Count - 1)].Name;
                    break;
                case "Guardian":
                    generatedGodLabel.Text = Guardians[r.Next(Guardians.Count - 1)].Name;
                    break;
                case "Hunter":
                    generatedGodLabel.Text = Hunters[r.Next(Hunters.Count - 1)].Name;
                    break;
                case "Mage":
                    generatedGodLabel.Text = Mages[r.Next(Mages.Count - 1)].Name;
                    break;
                case "Warrior":
                    generatedGodLabel.Text = Warriors[r.Next(Warriors.Count - 1)].Name;
                    break;
                default:
                    MessageBox.Show("Invalid Class Selection.");
                    break;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program doesn't need to update for new god releases, it will automatically add new gods to the generator.");
        }
    }
}
