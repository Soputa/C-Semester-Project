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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            //To modify this content, paste these lines into a text file and save it as .rtf.
            //Then modify the file in a text editor and save again as .rtf. Replace the lines below.
            //To create a new file, just use a text editor and save the content as .rtf.
            //Note: Line breaks need to be retained, and the use of @ "verbatim" is important to ensure
            //       that backslashes aren't treated as escape characters.
            /*RichTextInfo.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Calibri;}}" + "\n" +
                                @"{\colortbl ;\red0\green176\blue80;\red0\green0\blue255;}" + "\n" +
                                @"{\*\generator Riched20 10.0.19041}\viewkind4\uc1 " + "\n" +
                                @"\pard\sa200\sl276\slmult1\qc\cf1\b\f0\fs32\lang9 Todd's Movie App\cf0\b0\fs22\par" + "\n" +
                                @"April 2021\par" + "\n" +
                                @"{{\field{\*\fldinst{HYPERLINK http://google.com }}{\fldrslt{http://google.com\ul0\cf0}}}}\f0\fs22\par" + "\n" +
                                @"}";
            */
        }
    }
}
