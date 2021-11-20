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
    public partial class Form1 : Form
    {

        //This is the master list of movies kept for the source of our datagrid
        BindingList<Movie> masterMovieList = new BindingList<Movie>();
        //List<Movie> masterMovieList = new List<Movie>();
        public Form1()
        {
            InitializeComponent();
        }

        private void fielToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ask if the user wants to exit application
            DialogResult answer = MessageBox.Show("Are you sure you want to exit the application?", "Exit the application",MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
                Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create the new About form
           About aboutForm = new About();
            //Showing the form as a dialog blocks execution until the form is closed (perfect)
           aboutForm.ShowDialog();
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)

        {   //Create a delete form
            Delete_Form deleteForm = new Delete_Form();
            //This is a blocking line, you can't do anything until it is closed
            deleteForm.ShowDialog();
            //Refresh list if changes where made
            DbOps.RefreshMovies(masterMovieList);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Always start by binding the movie list with the datagridview
            dataGridViewMovies.DataSource = masterMovieList;

            //Hide ID 
            dataGridViewMovies.Columns["Id"].Visible = false;
            dataGridViewMovies.Columns["Genre"].Visible = false;
            dataGridViewMovies.Columns["TotalEarned"].Visible = false;
            dataGridViewMovies.Columns["RottenTomatoesScore"].Visible = false;

            //Rename the columns
            dataGridViewMovies.Columns["GenreText"].HeaderText = "Genre";
            dataGridViewMovies.Columns["TotalEarnedText"].HeaderText = "TotalEarned";
            dataGridViewMovies.Columns["RottenTomatoesScoreText"].HeaderText = "RottenTomatoesScore";
            DbOps.RefreshMovies(masterMovieList);
        }

        private void addMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add addForm = new Add();
            addForm.ShowDialog();

            DbOps.RefreshMovies(masterMovieList);

        }

        private void updateMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update updateForm = new Update();
            updateForm.ShowDialog();

            DbOps.RefreshMovies(masterMovieList);

        }
    }
}
