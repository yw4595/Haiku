using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Author: Yanzhi Wang
 * 
 * Purpose: This class represents the main form of the Haiku Generator application. It provides a user interface for generating haiku poems based on user-selected settings, and allows the user to view and copy the generated haikus. 
 * 
 */

namespace Haiku
{
    // The following code defines a partial class named MainForm which inherits from the Form class.
    public partial class MainForm : Form
    {
        // The following lines declare several private instance variables.
        // moveCounter: tracks the number of move attempts made by the user.
        // maxMoveAttempts: represents the maximum number of moves allowed.
        // random: an instance of the Random class used for generating random numbers.
        // moveCount: tracks the number of times the user has moved the form.
        // originalLocation: stores the original location of the form.
        // generateButtonClicks: tracks the number of times the generateButton has been clicked.
        private int moveCounter = 0;
        private const int maxMoveAttempts = 5;
        private readonly Random random = new Random();
        private int moveCount = 0;
        private Point originalLocation;
        private int generateButtonClicks = 0;

       
    // The following method is the constructor for the MainForm class. It initializes the component and sets the initial values of the instance variables.
    public MainForm()
        {
            InitializeComponent();
        }

        // The following method updates the text displayed in the haikuTextBox.
        // It takes a string argument named haiku and sets the Text property of the haikuTextBox to that string.
        public void UpdateHaikuTextBox(string haiku)
        {
            haikuTextBox.Text = haiku;
        }

        // The following method is a property that returns the haikuTextBox.
        // It provides access to the haikuTextBox instance variable.
        public TextBox HaikuTextBox
        {
            get { return haikuTextBox; }
        }

        // The following method generates a haiku poem based on the specified style, syllables per line, and number of lines.
        // It takes three integer arguments:
        // 1. haikuStyle: an integer representing the style of the haiku poem.
        // 2. syllablesPerLine: an integer representing the number of syllables per line.
        // 3. numLines: an integer representing the number of lines in the haiku poem.
        // The method returns a string that represents the generated haiku.
        public string GenerateHaiku(string haikuStyle, int syllablesPerLine, int numLines)
        {
            // Code to generate a haiku poem with the specified style, syllables per line, and number of lines.
            // This is where you would connect to the website and retrieve a haiku poem based on the selected settings.
            // For this example, we'll just generate a random haiku poem.

            // These are two arrays of strings containing traditional and modern haiku poems.
            string[] traditionalHaikus = new string[]
            {
        "An old silent pond... A frog jumps into the pond— Splash! Silence again.",
        "Autumn moonlight— A worm digs silently Into the chestnut.",
        "Winter solitude— In a world of one color The sound of wind.",
        "In the cicada's cry No sign can foretell How soon it must die.",
        "Winter seclusion— Listening, that evening, To the rain in the mountain.",
            };

            string[] modernHaikus = new string[]
            {
        "The light of a candle Is transferred to another candle— Spring twilight.",
        "I write, erase, rewrite Erase again, and then A poppy blooms.",
        "Over the wintry Forest, winds howl in rage With no leaves to blow.",
        "Love between us is Speech and breath. Loving you is A long river running.",
        "The lamp once out Cool stars enter The window frame.",
            };

            string[] haikus = haikuStyle == "Traditional" ? traditionalHaikus : modernHaikus;

            Random rnd = new Random();
            string[] selectedHaiku = new string[numLines];
            for (int i = 0; i < numLines; i++)
            {
                selectedHaiku[i] = haikus[rnd.Next(haikus.Length)];
            }

            return string.Join(Environment.NewLine, selectedHaiku);
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // Define arrays of words for each line of the haiku
            string[] line1Words = { "Autumn", "Pumpkin", "Leaves", "Chilly", "Breeze" };
            string[] line2Words = { "Darkness", "Shadows", "Midnight", "Mystery", "Whispers" };
            string[] line3Words = { "Sorrow", "Loneliness", "Broken", "Cry", "Despair" };

            // Choose a random word from each array
            Random rand = new Random();
            string line1 = line1Words[rand.Next(line1Words.Length)];
            string line2 = line2Words[rand.Next(line2Words.Length)];
            string line3 = line3Words[rand.Next(line3Words.Length)];

            // Display the bad haiku in the haikuTextBox
            haikuTextBox.Text = $"{line1}\r \n{line2}\r \n{line3}";
            // Store original location


            {
                // Increment the number of times the "Generate" button has been clicked
                generateButtonClicks++;

                // If the "Generate" button has been clicked less than or equal to 5 times
                if (generateButtonClicks <= 5)
                {
                    // Create a new instance of the Random class
                    Random random = new Random();

                    
                // Generate random x and y coordinates for the "Generate" button within the form's client area
                int x = random.Next(0, this.ClientSize.Width - generateButton.Width);
                    int y = random.Next(0, this.ClientSize.Height - generateButton.Height);

                    // Set the location of the "Generate" button to the generated x and y coordinates
                    generateButton.Location = new Point(x, y);
                }
                else
                {
                    generateButton.Location = originalLocation;
                    generateButtonClicks = 0;
                    // perform haiku generation here
                }
            }
            {
                // Change the background color to a random solid color
                Random rnd = new Random();
                int r = rnd.Next(256);
                int g = rnd.Next(256);
                int b = rnd.Next(256);
                this.BackColor = Color.FromArgb(r, g, b);
            }

     
        
    }





        // This method sets the original location of the generateButton to be used in the Reset button method later on
        private void MainForm_Load(object sender, EventArgs e)
        {
            originalLocation = generateButton.Location;
        }

        
    // This method is triggered when the settingsButton is clicked
    // It creates a new instance of the SettingsForm class and displays it
    private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
        }

    }
}
