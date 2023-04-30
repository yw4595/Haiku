using System;
using System.Drawing;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace Haiku
{
    public partial class SettingsForm : Form
    {
        private MainForm mainForm;

        Random rnd = new Random();
        private int errorCount = 0;
        public SettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            Random rnd = new Random();


        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void generateButton1_MouseHover(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, this.ClientSize.Width - generateButton1.Width);
            int y = rnd.Next(0, this.ClientSize.Height - generateButton1.Height);
            generateButton1.Location = new Point(x, y);
        }



        private void generateButton1_Click(object sender, EventArgs e)
        {
          

            // Determine the selected haiku style.
            string haikuStyle;
            if (styleComboBox.SelectedIndex == 0)
            {
                haikuStyle = "Traditional";
            }
            else
            {
                haikuStyle = "Modern";
            }

            // Determine the number of syllables per line.
            int syllablesPerLine = (int)syllablesPerLineNumericUpDown.Value;

            // Determine the number of lines.
            int numLines;
            if (numLinesCheckBox.Checked)
            {
                numLines = 4;
            }
            else
            {
                numLines = 3;
            }

            // Generate a new "haiku" with a random calculation result.
            string haiku = generateHaiku(haikuStyle, syllablesPerLine, numLines);

            // Display the "haiku" in the haikuTextBox.
            mainForm.HaikuTextBox.Text = haiku;

            // Change the color of the haikuTextBox.
            mainForm.HaikuTextBox.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            // Perform an incorrect calculation by modifying one of the values.
            if (rnd.Next(2) == 0) // 50% chance
            {
                if (rnd.Next(2) == 0) // 50% chance
                {
                    syllablesPerLineNumericUpDown.Value = rnd.Next(11, 21); // set num1 to a random value between 11 and 20
                }
                else
                {
                    syllablesPerLineNumericUpDown.Value = 0; // set num2 to 0 to cause division by zero
                }
            }

            // Close the settings form.
            this.Close();
        }

        private string generateHaiku(string haikuStyle, int syllablesPerLine, int numLines)
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 10);
            int num2 = rnd.Next(1, 10);
            string op = "+-*/"[rnd.Next(4)].ToString();
            int result;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                default: // "/"
                    while (num2 == 0) num2 = rnd.Next(1, 10); // avoid division by zero
                    result = num1 / num2;
                    break;
            }

            return $"{num1} {op} {num2} = {result}";
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            // Create a timer to display fake error messages
            Timer errorTimer = new Timer();
            errorTimer.Interval = 5000; // Every 5 seconds
            errorTimer.Tick += new EventHandler(ErrorTimer_Tick);
            errorTimer.Start();
        }



        //private int errorCount = 0;

        private int errorCounter = 0;

        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
            // Randomly display a fake error message, up to a maximum of 5 times
            if (rnd.Next(2) == 0 && errorCounter < 5)
            {
                MessageBox.Show("Cannot save settings. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorCounter++;
            }
        }





    }
}
