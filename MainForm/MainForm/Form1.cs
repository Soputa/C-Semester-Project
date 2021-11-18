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
           // FAbout aboutForm = new FAbout();
            //Showing the form as a dialog blocks execution until the form is closed (perfect)
           //aboutForm.ShowDialog();
        }

        private void deleteMovieToolStripMenuItem_Click(object sender, EventArgs e)

        {   //Need to create a delete form
            //Open a new deleteForm = new FDelete();
            //deleteForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Always start by binding the movie list with the datagridview
            dataGridViewMovies.DataSource = masterMovieList;

            DbOps.RefreshMovies(masterMovieList);
        }
    }
}
