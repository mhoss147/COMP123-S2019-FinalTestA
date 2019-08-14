using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * Student Name: Mohammad S Hossain
 * Student ID: 300763479
 * Description: This is the HeroGenerator form
 */
namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        Random random = new Random();

        public HeroGenerator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for Back button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }
        /// <summary>
        ///  This is the event handler for Next button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
            if (MainTabControl.SelectedIndex ==3)
            {
                //FirstNameDataLabel.Text = Program.heroGenerator.Identity.FirstName;
            }

        }
        /// <summary>
        /// This is the event handler for the GenerateNameButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();

        }

        private string GetRandomItemFromFileList(string _fileName)
        {
            //Populate a list with file content
            List<string> _listFromFile = File.ReadAllLines(_fileName).ToList();

            //Get number of list items
            int _listLength = _listFromFile.Count;

            //Populate _result with a random item from list
            string _result = _listFromFile[random.Next(_listLength)];

            return _result;
        }

        private void HeroGenerator_Load(object sender, EventArgs e)
        {
            GenerateNames();
            GenerateRandomAbilities();
            GenerateRandomPowers();

        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            GenerateRandomAbilities();
        }

        private void GenerateRandomPowers()
        {
            PowerLabel1.Text = LoadPowers();
            PowerLabel2.Text = LoadPowers();
            PowerLabel3.Text = LoadPowers();
            PowerLabel4.Text = LoadPowers();

        }

        private string LoadPowers()
        {
            //getting power file
            string _powerFile = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Data\powers.txt"));
            string _power = GetRandomItemFromFileList(_powerFile);
            return _power;
        }

        private void GenerateRandomAbilities()
        {
            Program.HeroGenerator.Fighting = random.Next(10, 50).ToString();
            Program.HeroGenerator.Agility = random.Next(10, 50).ToString();
            Program.HeroGenerator.Strength = random.Next(10, 50).ToString();
            Program.HeroGenerator.Endurance = random.Next(10, 50).ToString();
            Program.HeroGenerator.Reason = random.Next(10, 50).ToString();
            Program.HeroGenerator.Intuition = random.Next(10, 50).ToString();
            Program.HeroGenerator.Psyche = random.Next(10, 50).ToString();
            Program.HeroGenerator.Popularity = random.Next(10, 50).ToString();

        }
        /// <summary>
        /// This is the shared event handler for the saveMenuStripButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }
        private void GenerateNames()
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Identity_Click(object sender, EventArgs e)
        {

        }

       
    }
}
