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


        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Set all text box to empty
            textBoxMovieTittle.Text = "";
            textBoxYear.Text = "";
            textBoxDirector.Text = "";
            textBoxRottenTScore.Text = "";
            textBoxBoxOfficeE.Text = "";
            listBoxGenre.SelectedValue = 0;

        }
        int year = 0;
        int RottenTScore = 0;
        double TotalEarned = 0;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Vaidation checks for Txt fields year,Director,Gerne,textBoxRottenTScore, To
            if (textBoxMovieTittle.Text == "")
                MessageBox.Show("Pleae enter a movie tittle");
            else if (!int.TryParse(textBoxYear.Text, out year))
                MessageBox.Show("Please enter a year");
            else if (textBoxDirector.Text == "")
                MessageBox.Show("Please enter a Director");
            else if (listBoxGenre.SelectedIndex == 0)
                MessageBox.Show("Please select a Genre from the list");
            else if (!int.TryParse(textBoxRottenTScore.Text, out RottenTScore))
                MessageBox.Show("Please enter a RT score");
            else if (!double.TryParse(textBoxBoxOfficeE.Text, out TotalEarned))
                MessageBox.Show("Please enter the movies total Box office Earrings (If the movie lost money state the amount lost like '-1000000'");
            else 
            {
                //Retrieve the connection string from the App.Config file
                ConnectionStringSettings csOurDb = ConfigurationManager.ConnectionStrings[configOurDb];
                string csciClassConnex = csOurDb?.ConnectionString;
                if (!(csOurDb is null) && (csciClassConnex.Length > 0))
                {
                    //Connection string exists - now let's try to connect!
                    SqlConnection dbConnex = null;
                    bool keepMoving = true;

                    try
                    {
                        //Attempt the open!
                        dbConnex = new SqlConnection(csciClassConnex);
                        dbConnex.Open();
                    }
                    catch
                    {
                        //The open failed
                        keepMoving = false;
                        ShowError($"Unable to open connection to the database using string:\n{csciClassConnex}");
                    }

                    if (keepMoving)
                    {
                        //Create the query string
                        SqlCommand query = new SqlCommand(databaseQuery, dbConnex);

                        SqlDataReader dataReader = null;

                        try
                        {
                            //Execute the query string
                            dataReader = query.ExecuteReader();
                        }
                        catch
                        {
                            keepMoving = false;
                            ShowError($"Unable to perform the query {databaseQuery}");
                        }
                    }

        }
    }
}
