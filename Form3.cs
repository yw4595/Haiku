using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Media;

/**

Author: Yanzhi Wang

Purpose: This class represents a form that allows the user to adjust application settings.

Restrictions: None

Known Errors: None
*/

namespace Haiku
{
    public partial class AboutForm : Form
    {
        private Random rnd = new Random();

        public AboutForm()
        {
            InitializeComponent();
        }



        /**

This method generates a short paragraph about a person, containing their name, birthplace, and favorite hobby.
*/
        private void aboutgenerateButton_Click(object sender, EventArgs e)
        {
            // Use GetRandomCity(), GetRandomName(), and GetRandomInterest() to create a string array with four lines of text.
            string[] lines = {
$"Their name is {GetRandomCity()},",
$"Born in {rnd.Next(1950, 2010)},",
$"Grew up in {GetRandomCity()},",
$"Loves {GetRandomInterest()} more than anything."
};

            // Set the text of the aboutLabel to the concatenated string with line breaks between each line of text.
            aboutLabel.Text = string.Join("\n", lines);

            // Randomly adjust the font size and style of the aboutLabel text.
            aboutLabel.Font = new Font(aboutLabel.Font.FontFamily, rnd.Next(8, 24), (FontStyle)rnd.Next(0, 6));

            // Start a timer to move the form randomly.
            timer1.Start();
        }

        /**

This method returns a randomly selected city from a predefined list of cities.
*/
        private string GetRandomCity()
        {
            string[] cities = { "New York", "Tokyo", "Paris", "London", "Beijing", "Moscow" };
            return cities[rnd.Next(cities.Length)];
        }
        /**

This method returns a randomly selected name from a predefined list of names.
*/
        private string GetRandomName()
        {
            string[] names = { "Wang", "Cristiano", "Paris", "Paul", "Kevin", "Nairobi" };
            return names[rnd.Next(names.Length)];
        }
        /**

This method returns a randomly selected interest from a predefined list of interests.
*/
        private string GetRandomInterest()
        {
            string[] interests = { "coding", "playing video games", "reading books", "traveling", "watching movies" };
            return interests[rnd.Next(interests.Length)];
        }

        /**

Purpose: This method is called when the timer1 object generates a Tick event. It moves the SettingsForm

css
Copy code
     randomly within the form's client area and changes the background color to a random one.
@param sender: The object that raised the event.

@param e: The event arguments.
*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = this.Location.X + rnd.Next(-5, 5);
            int y = this.Location.Y + rnd.Next(-5, 5);
            this.Location = new Point(x, y);
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }


    }
}
