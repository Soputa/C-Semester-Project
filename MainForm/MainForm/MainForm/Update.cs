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
    public partial class Update : Form
    {

        
        public Update()
        {
            InitializeComponent();
            LoadDropDownItems();
        }

        public Update(string movieTitle)
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
            comboBox1Genre.Items.Clear();
            foreach (string genre in Movie.genres)
                if (genre.Length > 0)
                    comboBox1Genre.Items.Add(genre);
        }


        private void Update_Load(object sender, EventArgs e)
        {
            LoadDropDownItems();
            textBoxYear.Enabled = false;
            textBoxDirector.Enabled = false;
            comboBox1Genre.Enabled = false;
            textBoxRottenTScore.Enabled = false;
            textBoxBoxOfficeE.Enabled = false;
            buttonUpdate.Enabled = false;


        }

        int year = 0;
        int RottenTScore = 0;
        double dTotalEarned = 0;
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Only update once the movie has been found
            //Vaidation checks for Txt fields year,Director,Gerne,textBoxRottenTScore, To
            if (textBoxMovieTitle.Text == "")
                MessageBox.Show("Pleae enter a movie tittle");
            else if (!int.TryParse(textBoxYear.Text, out year))
                MessageBox.Show("Please enter a year");
            else if (textBoxDirector.Text == "")
                MessageBox.Show("Please enter a Director");
            else if (comboBox1Genre.SelectedIndex == -1)
                MessageBox.Show("Please select a Genre from the list");
            else if ((textBoxRottenTScore.Text.Length > 0) && (!int.TryParse(textBoxRottenTScore.Text, out RottenTScore)))
                MessageBox.Show("Please enter a RT score, it must be a valid number");
            else if ((textBoxBoxOfficeE.Text.Length > 0) && (!double.TryParse(textBoxBoxOfficeE.Text, out dTotalEarned)))
                MessageBox.Show("Please enter the movies total Box office Earrings (If the movie lost money state the amount lost like '-1000000'");
            else if (DbOps.FindMovieInDatabase(textBoxMovieTitle.Text))
                MessageBox.Show("That movie tittle already exist in the database.");
            else if ((textBoxMovieTitle.Text!= LastFoundMoive.Title) && (DbOps.FindMovieInDatabase(textBoxMovieTitle.Text)))
                MessageBox.Show("A movie with this title already exists in the database");
            else
            {
                //Attemp to update movie 
                Movie updateMovie = new Movie();
                //Keep the original ID from the found movie
                updateMovie.Id = LastFoundMoive.Id;
                //Add the the found content 
                updateMovie.Title = textBoxMovieTitle.Text;
                updateMovie.Year = year;
                updateMovie.Director = textBoxDirector.Text;
                updateMovie.Genre = comboBox1Genre.SelectedIndex + 1;
                if (textBoxRottenTScore.Text.Length > 0)
                    updateMovie.RottenTomatoesScore = RottenTScore;
                if (textBoxBoxOfficeE.Text.Length > 0)
                    updateMovie.TotalEarned = dTotalEarned;


                bool success = DbOps.UpdateMovieInDatabase(updateMovie);

                if (success)
                {
                    MessageBox.Show("Movie was successful updated");
                    textBoxMovieTitle.Text = "";
                    textBoxYear.Text = "";
                    textBoxDirector.Text = "";
                    textBoxRottenTScore.Text = "";
                    textBoxBoxOfficeE.Text = "";
                    comboBox1Genre.SelectedValue = -1;
                    textBoxYear.Enabled = false;
                    textBoxDirector.Enabled = false;
                    comboBox1Genre.Enabled = false;
                    textBoxRottenTScore.Enabled = false;
                    textBoxBoxOfficeE.Enabled = false;
                    buttonUpdate.Enabled = false;

                }

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Set all text box to empty
            textBoxMovieTitle.Text = "";
            textBoxYear.Text = "";
            textBoxDirector.Text = "";
            textBoxRottenTScore.Text = "";
            textBoxBoxOfficeE.Text = "";
            comboBox1Genre.SelectedValue = -1;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            SearchForMovie();
        }

        private void SearchForMovie()
        {
            textBoxYear.Enabled = false;
            textBoxDirector.Enabled = false;
            comboBox1Genre.Enabled = false;
            textBoxRottenTScore.Enabled = false;
            textBoxBoxOfficeE.Enabled = false;
            buttonUpdate.Enabled = false;
            textBoxYear.Clear();
            textBoxDirector.Clear();
            textBoxRottenTScore.Clear();
            textBoxBoxOfficeE.Clear();
            comboBox1Genre.SelectedIndex = -1;
            LastFoundMoive = new Movie();

            
            if(DbOps.FindMovieInDatabase(textBoxMovieTitle.Text, out LastFoundMoive))
            {
                //The movie was found populate the feilds with the data from the found movie
                textBoxYear.Text = $"{LastFoundMoive.Year}";
                textBoxDirector.Text = LastFoundMoive.Director;
                comboBox1Genre.SelectedIndex = LastFoundMoive.Genre - 1;
                textBoxRottenTScore.Text = LastFoundMoive.RottenTomatoesScoreText;
                if (LastFoundMoive.TotalEarned > 0)
                    textBoxBoxOfficeE.Text = $"{LastFoundMoive.TotalEarned}";
                else
                    textBoxBoxOfficeE.Text = "";

                //Now that we have comfirmed that the movie exist allow the user to make changes
                textBoxYear.Enabled = true;
                textBoxDirector.Enabled = true;
                comboBox1Genre.Enabled = true;
                textBoxRottenTScore.Enabled = true;
                textBoxBoxOfficeE.Enabled = true;
                buttonUpdate.Enabled = true;

            }
            else
            {
                //error message and 
                MessageBox.Show($"The movie tittle you searched wasn't found:\n{textBoxMovieTitle.Text}");
            }

        }

    }
}
