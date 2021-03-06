using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; //Required also adding an assembly reference to the project
using System.Data.SqlClient; //Required for ADO.NET SQL Connections

namespace MainForm
{
    public partial class Add : Form
    {

        
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            LoadDropDownItems();

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
        //TotalEarned
        //textBoxBoxOfficeE
        int year = 0;
        int RottenTScore = 0;
        double dTotalEarned = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {

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

            else
            {   // If the movie donesn't exist, try to add it 
                Movie newMovie = new Movie();
                newMovie.Title = textBoxMovieTitle.Text;
                newMovie.Year = year;
                newMovie.Director = textBoxDirector.Text;
                newMovie.Genre = comboBox1Genre.SelectedIndex + 1;
                if (textBoxRottenTScore.Text.Length > 0)
                    newMovie.RottenTomatoesScore = RottenTScore;
                if (textBoxBoxOfficeE.Text.Length > 0)
                    newMovie.TotalEarned = dTotalEarned;

                bool success = DbOps.AddMovieToDatabase(newMovie);

                if(success)
                {
                    MessageBox.Show("Movie was successful added");
                    textBoxMovieTitle.Text = "";
                    textBoxYear.Text = "";
                    textBoxDirector.Text = "";
                    textBoxRottenTScore.Text = "";
                    textBoxBoxOfficeE.Text = "";
                    comboBox1Genre.SelectedValue = -1;


                }
            }

            
        }



        private void LoadDropDownItems()
        {


            //Load up the combo box
            comboBox1Genre.Items.Clear();
            foreach (string genre in Movie.genres)
                if (genre.Length > 0)
                    comboBox1Genre.Items.Add(genre);
        }
    }

}
