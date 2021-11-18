using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Movie
    {
        public static List<string> genres = new List<string>
        {
            "", //0 -Not specified
            "Animation", //1
            "Action", //2
            "Comedy", //3
            "Drama", //4
            "Horror", //5
            "Mystrey", //6
            "Romance", //7
            "Science Fiction" , //8
            "Western" //9
            };
            //Core Get/Set Properties 

            public int Id { get; set; }
            
            public string Title { get; set; }
            
            public int Year { get; set; }
            
            public string Director { get; set; }

            public int Genre { get; set; }

            public int RottenTomatoesScore { get; set; }

            public double TotalEarned { get; set; }


            public Movie()
            {
                Id = -1;
                Title = "";
                Year = 0;
                Director = "";
                Genre = -0;
                RottenTomatoesScore = -1; // -1 indicates a null
                TotalEarned = -1; //-1 null
            }
            
            /*Alternate property with getter just for Genre description
           // public string GenreText
            {
                //get {if ((Genre =>) &&)(Genre < genres.Count)} return genres
            }

           // public string Ro
            
            //public string TotalEarnedText
            {

            }
           */
        
    }
}
