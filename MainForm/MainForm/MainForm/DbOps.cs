using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //Required also adding an assembly reference to the project
using System.Data.SqlClient; //Required for ADO.NET SQL Connections
using System.ComponentModel; //To allow for easy reference to BindingList
using System.Windows.Forms; //To allow for easy reference to the MessageBox class


namespace MainForm
{
    class DbOps
    {
        // The name of the connection string in App.config that has
        // our database connection string
        private const string configOurDb = "CSCI1630-DB";

        //The names of the fields in the Movies table
        // Id (int)
        // Title (string-50)
        // Year (int)
        // Director (string-50)
        // Genre (int)
        // RottenTomatoesScore (int)
        // TotalEarned (double) 

        //The query we'll use to refresh the list of available movies
        private const string databaseQuery = "SELECT Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM dbo.MOVIES ORDER BY Title";

        //The query we'll use to check if a movie exists already
        private const string databaseSingleMovieQuery = "SELECT Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM dbo.MOVIES WHERE Title=@movieTitle";

        //The command we'll use to insert a new movie into the table
        private const string databaseInsertCommand = "INSERT INTO dbo.MOVIES (Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned) VALUES (@title, @year, @director, @genre, @rotten, @earnings)";

        //The command we'll use to update an existing movie in the table
        private const string databaseUpdateCommand = "UPDATE dbo.MOVIES SET Title=@title, Year=@year, Director=@director, Genre=@genre, RottenTomatoesScore=@rotten, TotalEarned=@earnings WHERE Id=@id";

        //The command we'll use to delete an existing movie in the table
        private const string databaseDeleteCommand = "DELETE FROM dbo.MOVIES WHERE Id=@id";

        static private void ShowError(string errorToDisplay)
        {
            MessageBox.Show(errorToDisplay, "Database Error");
        }

        static public void RefreshMovies(BindingList<Movie> movieList)
        {
            //Start by clearing the list of movies
            movieList.Clear();

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

                    if (keepMoving)
                    {
                        //Loop while there are more results
                        while (dataReader.Read())
                        {
                            try
                            {
                                //Read the current result and transform it into
                                //a Movie object
                                Movie newMovie = new Movie();
                                newMovie.Id = Convert.ToInt32(dataReader["Id"]);
                                newMovie.Title = Convert.ToString(dataReader["Title"]);
                                newMovie.Year = Convert.ToInt32(dataReader["Year"]);
                                newMovie.Director = Convert.ToString(dataReader["Director"]);
                                newMovie.Genre = Convert.ToInt32(dataReader["Genre"]);
                                //Check for dbNull
                                if (dataReader["RottenTomatoesScore"] != DBNull.Value)
                                    newMovie.RottenTomatoesScore = Convert.ToInt32(dataReader["RottenTomatoesScore"]);
                                //Check for dbNull
                                if (dataReader["TotalEarned"] != DBNull.Value)
                                    newMovie.TotalEarned = Convert.ToDouble(dataReader["TotalEarned"]);
                                movieList.Add(newMovie);
                            }
                            catch
                            {
                                //An error occurred trying to convert this result
                                //into a Movie - tell the user, but continue with
                                //next query result when the user responds.
                                ShowError("Unknown error occurred reading a record.");
                            }
                        }

                        //Close the reader
                        dataReader.Close();

                    }

                    //Close the connection
                    dbConnex.Close();
                }
            }
            else
                //Entry didn't exist in App.config!
                ShowError($"Unable to retrieve the connection string for {configOurDb} from App.config.");
        }

        static public bool FindMovieInDatabase(string movieTitle)
        {
            //
            return FindMovieInDatabase(movieTitle, out Movie throwawayMovieObject);
        }

        static public bool FindMovieInDatabase(string movieTitle, out Movie foundMovie)

        {
            //Assume the movie isn't found esp if an error occurs
            bool retValue = false;
            foundMovie = new Movie();

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
                    SqlCommand query = new SqlCommand(databaseSingleMovieQuery, dbConnex);
                    query.Parameters.Add(new SqlParameter("movieTitle", movieTitle));

                    SqlDataReader dataReader = null;

                    try
                    {
                        //Execute the query string
                        dataReader = query.ExecuteReader();
                    }
                    catch
                    {
                        keepMoving = false;
                        ShowError($"Unable to perform the query {databaseSingleMovieQuery}");
                    }

                    if (keepMoving)
                    {
                        //Continue if there's at least 1 result
                        if (dataReader.Read())
                        {
                            //We found at least one record - try to copy the results into FoundMovie
                            try
                            {
                                //Read the first result and transform it into
                                //the foundMovie object
                                foundMovie.Id = Convert.ToInt32(dataReader["Id"]);
                                foundMovie.Title = Convert.ToString(dataReader["Title"]);
                                foundMovie.Year = Convert.ToInt32(dataReader["Year"]);
                                foundMovie.Director = Convert.ToString(dataReader["Director"]);
                                foundMovie.Genre = Convert.ToInt32(dataReader["Genre"]);
                                //Check for dbNull
                                if (dataReader["RottenTomatoesScore"] != DBNull.Value)
                                    foundMovie.RottenTomatoesScore = Convert.ToInt32(dataReader["RottenTomatoesScore"]);
                                //Check for dbNull
                                if (dataReader["TotalEarned"] != DBNull.Value)
                                    foundMovie.TotalEarned = Convert.ToDouble(dataReader["TotalEarned"]);
                                //We did it - return true!
                                retValue = true;
                            }
                            catch
                            {
                                //An error occurred trying to convert this result
                                //into a Movie - tell the user
                                ShowError("Unknown error occurred reading a record.");
                            }
                        }

                        //Close the reader
                        dataReader.Close();

                    }

                    //Close the connection
                    dbConnex.Close();
                }
            }
            else
                //Entry didn't exist in App.config!
                ShowError($"Unable to retrieve the connection string for {configOurDb} from App.config.");

            return retValue;
        }

        static public bool AddMovieToDatabase(Movie newMovie)
        {
            //Assume the movie isn't added esp if an error occurs
            bool retValue = false;

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
                    //Create the command string
                    SqlCommand query = new SqlCommand(databaseInsertCommand, dbConnex);
                    query.Parameters.Add(new SqlParameter("title", newMovie.Title));
                    query.Parameters.Add(new SqlParameter("year", newMovie.Year));
                    query.Parameters.Add(new SqlParameter("director", newMovie.Director));
                    query.Parameters.Add(new SqlParameter("genre", newMovie.Genre));
                    //Insert either the Rotten Tomatoes Score or DBNull if not specified
                    if (newMovie.RottenTomatoesScore >= 0)
                        query.Parameters.Add(new SqlParameter("rotten", newMovie.RottenTomatoesScore));
                    else
                        query.Parameters.Add(new SqlParameter("rotten", DBNull.Value));
                    //Insert either the TotalEarned or DBNull if not specified
                    if (newMovie.TotalEarned >= 0)
                        query.Parameters.Add(new SqlParameter("earnings", newMovie.TotalEarned));
                    else
                        query.Parameters.Add(new SqlParameter("earnings", DBNull.Value));

                    try
                    {
                        //Execute the command string
                        query.ExecuteNonQuery();
                        retValue = true;
                    }
                    catch
                    {
                        keepMoving = false;
                        ShowError($"Unable to perform the command {databaseInsertCommand}");
                    }

                    //Close the connection
                    dbConnex.Close();
                }
            }
            else
                //Entry didn't exist in App.config!
                ShowError($"Unable to retrieve the connection string for {configOurDb} from App.config.");

            return retValue;
        }

        static public bool UpdateMovieInDatabase(Movie existingMovie)
        { //Assume the movie isn't added esp if an error occurs
            bool retValue = false;

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
                    //Assume the movie isn't updated esp if an error occurs
                    SqlCommand query = new SqlCommand(databaseUpdateCommand, dbConnex);
                    query.Parameters.Add(new SqlParameter("title", existingMovie.Title));
                    query.Parameters.Add(new SqlParameter("year", existingMovie.Year));
                    query.Parameters.Add(new SqlParameter("director", existingMovie.Director));
                    query.Parameters.Add(new SqlParameter("genre", existingMovie.Genre));
                    if (existingMovie.RottenTomatoesScore >= 0)
                        query.Parameters.Add(new SqlParameter("rotten", existingMovie.RottenTomatoesScore));
                    else
                        query.Parameters.Add(new SqlParameter("rotten", DBNull.Value));
                    if (existingMovie.TotalEarned >= 0)
                        query.Parameters.Add(new SqlParameter("earnings", existingMovie.TotalEarned));
                    else
                        query.Parameters.Add(new SqlParameter("earnings", DBNull.Value));
                    query.Parameters.Add(new SqlParameter("id", existingMovie.Id));

                    try
                    {
                        //execute the command string
                        query.ExecuteNonQuery();
                        retValue = true;
                    }
                    catch
                    {
                        keepMoving = false;
                        ShowError($"Unable to perform the command {databaseInsertCommand}");
                    }

                    //Close the connection
                    dbConnex.Close();
                }
            }
            else
                //Entry didn't exist in App.config!
                ShowError($"Unable to retrieve the connection string for {configOurDb} from App.config.");

            return retValue;
        }
        //Implementation removed -----------------------------








        static public bool DeleteMovieFromDatabase(Movie existingMovie)
        {
            //This method assumes that the Id property of the existingMovie object
            //will be the record that needs deleted, and all other properties will
            //be ignored.
            //Assume the movie isn't added esp if an error occurs
            bool retValue = false;

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
                    //Create the command string
                    SqlCommand query = new SqlCommand(databaseDeleteCommand, dbConnex);
                    query.Parameters.Remove(new SqlParameter("title", newMovie.Title));
                    query.Parameters.Add(new SqlParameter("year", newMovie.Year));
                    query.Parameters.Add(new SqlParameter("director", newMovie.Director));
                    query.Parameters.Add(new SqlParameter("genre", newMovie.Genre));
                    //Insert either the Rotten Tomatoes Score or DBNull if not specified
                    if (newMovie.RottenTomatoesScore >= 0)
                        query.Parameters.Add(new SqlParameter("rotten", newMovie.RottenTomatoesScore));
                    else
                        query.Parameters.Add(new SqlParameter("rotten", DBNull.Value));
                    //Insert either the TotalEarned or DBNull if not specified
                    if (newMovie.TotalEarned >= 0)
                        query.Parameters.Add(new SqlParameter("earnings", newMovie.TotalEarned));
                    else
                        query.Parameters.Add(new SqlParameter("earnings", DBNull.Value));

                    try
                    {
                        //Execute the command string
                        query.ExecuteNonQuery();
                        retValue = true;
                    }
                    catch
                    {
                        keepMoving = false;
                        ShowError($"Unable to perform the command {databaseInsertCommand}");
                    }

                    //Close the connection
                    dbConnex.Close();
                }
            }
            else
                //Entry didn't exist in App.config!
                ShowError($"Unable to retrieve the connection string for {configOurDb} from App.config.");

            return retValue;
        }
    }
}
        
    

