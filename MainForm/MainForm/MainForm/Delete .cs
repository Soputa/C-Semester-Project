using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Delete_Form : Form
    {
        public Delete_Form()
        {
            InitializeComponent();
            LoadDropDownItems();

        }
        public Delete_Form(string movieTitle)
        {
            if (movieTitle.Length > 0)
            {
                textBoxMovieTitle.Text = movieTitle;
                SearchForMovie();
            }

        }

        private Movie LastFoundMoive = new Movie();


        private void LoadDropDownItems()
        {


            //Load up the combo box
            comboBoxGenre.Items.Clear();
            foreach (string genre in Movie.genres)
                if (genre.Length > 0)
                    comboBoxGenre.Items.Add(genre);
        }

        private void Delete_Form_Load(object sender, EventArgs e)
        {
            LoadDropDownItems();
            textBoxYear.Enabled = false;
            textBoxDirector.Enabled = false;
            comboBoxGenre.Enabled = false;
            textBoxRottenTScore.Enabled = false;
            textBoxBoxOfficeE.Enabled = false;
            buttonDelete.Enabled = false;
        }


        int year = 0;
        int RottenTScore = 0;
        double dTotalEarned = 0;

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Only update once the movie has been found
            //Vaidation checks for Txt fields year,Director,Gerne,textBoxRottenTScore, To
            if (textBoxMovieTitle.Text == "")
                MessageBox.Show("Pleae enter a movie tittle");
            else if (!int.TryParse(textBoxYear.Text, out year))
                MessageBox.Show("Please enter a year");
            else if (textBoxDirector.Text == "")
                MessageBox.Show("Please enter a Director");
            else if (comboBoxGenre.SelectedIndex == -1)
                MessageBox.Show("Please select a Genre from the list");
            else if ((textBoxRottenTScore.Text.Length > 0) && (!int.TryParse(textBoxRottenTScore.Text, out RottenTScore)))
                MessageBox.Show("Please enter a RT score, it must be a valid number");
            else if ((textBoxBoxOfficeE.Text.Length > 0) && (!double.TryParse(textBoxBoxOfficeE.Text, out dTotalEarned)))
                MessageBox.Show("Please enter the movies total Box office Earrings, if none please leave blank");
            //else if (DbOps.FindMovieInDatabase(textBoxMovieTitle.Text))
               // MessageBox.Show("That movie tittle already exist in the database.");
            //else if ((textBoxMovieTitle.Text != LastFoundMoive.Title) && (DbOps.FindMovieInDatabase(textBoxMovieTitle.Text)))
               // MessageBox.Show("A movie with this title already exists in the database");
            else
            {
                //Attemp to Delete movie 
                Movie deleteMovie = new Movie();
                //Keep the original ID from the found movie
                deleteMovie.Id = LastFoundMoive.Id;
                //Add the the found content 
                deleteMovie.Title = textBoxMovieTitle.Text;
                deleteMovie.Year = year;
                deleteMovie.Director = textBoxDirector.Text;
                deleteMovie.Genre = comboBoxGenre.SelectedIndex + 1;
                if (textBoxRottenTScore.Text.Length > 0)
                    deleteMovie.RottenTomatoesScore = RottenTScore;
                if (textBoxBoxOfficeE.Text.Length > 0)
                    deleteMovie.TotalEarned = dTotalEarned;


                bool success = DbOps.DeleteMovieFromDatabase(deleteMovie);

                if (success)
                {
                    MessageBox.Show("The Movie was successful Deleted");
                    textBoxMovieTitle.Text = "";
                    textBoxYear.Text = "";
                    textBoxDirector.Text = "";
                    textBoxRottenTScore.Text = "";
                    textBoxBoxOfficeE.Text = "";
                    comboBoxGenre.SelectedValue = -1;
                    textBoxYear.Enabled = false;
                    textBoxDirector.Enabled = false;
                    comboBoxGenre.Enabled = false;
                    textBoxRottenTScore.Enabled = false;
                    textBoxBoxOfficeE.Enabled = false;
                    buttonDelete.Enabled = false;

                }

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Set all text box to empty
            textBoxMovieTitle.Text = "";
            textBoxYear.Text = "";
            textBoxDirector.Text = "";
            textBoxRottenTScore.Text = "";
            textBoxBoxOfficeE.Text = "";
            comboBoxGenre.SelectedValue = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForMovie();
        }

        private void SearchForMovie()
        {
            textBoxYear.Enabled = false;
            textBoxDirector.Enabled = false;
            comboBoxGenre.Enabled = false;
            textBoxRottenTScore.Enabled = false;
            textBoxBoxOfficeE.Enabled = false;
            buttonDelete.Enabled = false;
            textBoxYear.Clear();
            textBoxDirector.Clear();
            textBoxRottenTScore.Clear();
            textBoxBoxOfficeE.Clear();
            comboBoxGenre.SelectedIndex = -1;
            LastFoundMoive = new Movie();


            if (DbOps.FindMovieInDatabase(textBoxMovieTitle.Text, out LastFoundMoive))
            {
                //The movie was found populate the feilds with the data from the found movie
                textBoxYear.Text = $"{LastFoundMoive.Year}";
                textBoxDirector.Text = LastFoundMoive.Director;
                comboBoxGenre.SelectedIndex = LastFoundMoive.Genre - 1;
                textBoxRottenTScore.Text = LastFoundMoive.RottenTomatoesScoreText;
                if (LastFoundMoive.TotalEarned > 0)
                    textBoxBoxOfficeE.Text = $"{LastFoundMoive.TotalEarned}";
                else
                    textBoxBoxOfficeE.Text = "";

                //Now that we have comfirmed that the movie exist allow the user to make changes
                textBoxYear.Enabled = false;
                textBoxDirector.Enabled = false;
                comboBoxGenre.Enabled = false;
                textBoxRottenTScore.Enabled = false;
                textBoxBoxOfficeE.Enabled = false;
                buttonDelete.Enabled = true;

            }
            else
            {
                //error message and 
                MessageBox.Show($"The movie tittle you searched wasn't found:\n{textBoxMovieTitle.Text}");
            }

        }
    }
}
