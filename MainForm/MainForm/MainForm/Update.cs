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
        }


        private void LoadDropDownItems()
        {


            //Load up the combo box
            comboBoxGenre.Items.Clear();
            foreach (string genre in Movie.genres)
                if (genre.Length > 0)
                    comboBoxGenre.Items.Add(genre);
        }

        private void Update_Load(object sender, EventArgs e)
        {
            LoadDropDownItems();
        }
    }
}
