using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.Text.RegularExpressions;

namespace Random_God_Generator_Smite
{
    public partial class Form1 : Form
    {
        #region Global Lists
        Random rng = new Random();

        List<string> contents = new List<string>();
        List<string> godNames = new List<string>();
        List<string> godPantheon = new List<string>();
        List<string> godAttackType = new List<string>();
        List<string> godPowerType = new List<string>();
        List<string> godClass = new List<string>();
        List<string> godFavorCost = new List<string>();
        List<string> godGemsCost = new List<string>();
        List<string> godReleaseDate = new List<string>();
        List<string> sgGodCodes = new List<string>();
        List<List<string>> tableHeadings;
        List<List<string>> tableContents;

        List<string> hunter = new List<string>();
        List<string> warrior = new List<string>();
        List<string> mage = new List<string>();
        List<string> guardian = new List<string>();
        List<string> assassin = new List<string>();

        string selectedClass;
        #endregion

        public Form1()
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
            // add god names to list 1n+9
            for (int i = 1; i < contents.Count; i += 9)
            {
                godNames.Add(contents[i]);
            }
            // add pantheons to list 2n+9
            for (int i = 2; i < contents.Count; i += 9)
            {
                godPantheon.Add(contents[i]);
            }
            // add attack type to list 3n+9
            for (int i = 3; i < contents.Count; i += 9)
            {
                godAttackType.Add(contents[i]);
            }
            // add power type to list 4n+9
            for (int i = 4; i < contents.Count; i += 9)
            {
                godPowerType.Add(contents[i]);
            }
            // add class to list 5n+9
            for (int i = 5; i < contents.Count; i += 9)
            {
                godClass.Add(contents[i]);
            }
            // add favor cost to list 6n+9
            for (int i = 6; i < contents.Count; i += 9)
            {
                godFavorCost.Add(contents[i]);
            }
            // add gems cost to list 7n+9
            for (int i = 7; i < contents.Count; i += 9)
            {
                godGemsCost.Add(contents[i]);
            }
            // add release date to list 8n+9
            for (int i = 8; i < contents.Count; i += 9)
            {
                godReleaseDate.Add(contents[i]);
            }
        }

        private void populateClassLists()
        {
            int counter = 0;

            foreach (string gclass in godClass)
            {
                if (gclass == "Hunter")
                {
                    hunter.Add(godNames[counter]);
                    counter++;
                }
                else if (gclass == "Mage")
                {
                    mage.Add(godNames[counter]);
                    counter++;
                }
                else if (gclass == "Assassin")
                {
                    assassin.Add(godNames[counter]);
                    counter++;
                }
                else if (gclass == "Guardian")
                {
                    guardian.Add(godNames[counter]);
                    counter++;
                }
                else if(gclass == "Warrior")
                {
                    warrior.Add(godNames[counter]);
                    counter++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
            if (godClassSelectionComboBox.Text == "Any Class")
            {
                generatedGodLabel.Text = godNames[rng.Next(godNames.Count)];
            }
            else if (godClassSelectionComboBox.Text == "Mage")
            {
                generatedGodLabel.Text = mage[rng.Next(mage.Count)];
            }
            else if (godClassSelectionComboBox.Text == "Hunter")
            {
                generatedGodLabel.Text = hunter[rng.Next(hunter.Count)];
            }
            else if (godClassSelectionComboBox.Text == "Guardian")
            {
                generatedGodLabel.Text = guardian[rng.Next(guardian.Count)];
            }
            else if (godClassSelectionComboBox.Text == "Assassin")
            {
                generatedGodLabel.Text = assassin[rng.Next(assassin.Count)];
            }
            else if (godClassSelectionComboBox.Text == "Warrior")
            {
                generatedGodLabel.Text = warrior[rng.Next(warrior.Count)];
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program doesn't need to update for new god releases, it will automatically add new gods to the generator.");
        }
    }
}
