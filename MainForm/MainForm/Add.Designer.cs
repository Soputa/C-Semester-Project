
namespace MainForm
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAddMovieScreen = new System.Windows.Forms.Label();
            this.labelMovieTittle = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRottenTomatoesScore = new System.Windows.Forms.Label();
            this.labelBoxOfficeE = new System.Windows.Forms.Label();
            this.groupBoxAddBtn = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxMovieTittle = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.listBoxGenre = new System.Windows.Forms.ListBox();
            this.textBoxRottenTScore = new System.Windows.Forms.TextBox();
            this.textBoxBoxOfficeE = new System.Windows.Forms.TextBox();
            this.groupBoxAddBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAddMovieScreen
            // 
            this.labelAddMovieScreen.AutoSize = true;
            this.labelAddMovieScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddMovieScreen.Location = new System.Drawing.Point(12, 34);
            this.labelAddMovieScreen.Name = "labelAddMovieScreen";
            this.labelAddMovieScreen.Size = new System.Drawing.Size(226, 29);
            this.labelAddMovieScreen.TabIndex = 0;
            this.labelAddMovieScreen.Text = "Add Movie Screen";
            // 
            // labelMovieTittle
            // 
            this.labelMovieTittle.AutoSize = true;
            this.labelMovieTittle.Location = new System.Drawing.Point(28, 91);
            this.labelMovieTittle.Name = "labelMovieTittle";
            this.labelMovieTittle.Size = new System.Drawing.Size(62, 13);
            this.labelMovieTittle.TabIndex = 1;
            this.labelMovieTittle.Text = "Movie Title:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(51, 146);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year:";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(43, 204);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(47, 13);
            this.labelDirector.TabIndex = 3;
            this.labelDirector.Text = "Director:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(51, 267);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(39, 13);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Genre:";
            // 
            // labelRottenTomatoesScore
            // 
            this.labelRottenTomatoesScore.AutoSize = true;
            this.labelRottenTomatoesScore.Location = new System.Drawing.Point(97, 320);
            this.labelRottenTomatoesScore.Name = "labelRottenTomatoesScore";
            this.labelRottenTomatoesScore.Size = new System.Drawing.Size(123, 13);
            this.labelRottenTomatoesScore.TabIndex = 5;
            this.labelRottenTomatoesScore.Text = "Rotten Tomatoes Score:";
            // 
            // labelBoxOfficeE
            // 
            this.labelBoxOfficeE.AutoSize = true;
            this.labelBoxOfficeE.Location = new System.Drawing.Point(293, 320);
            this.labelBoxOfficeE.Name = "labelBoxOfficeE";
            this.labelBoxOfficeE.Size = new System.Drawing.Size(103, 13);
            this.labelBoxOfficeE.TabIndex = 6;
            this.labelBoxOfficeE.Text = "Box Office Earnings:";
            // 
            // groupBoxAddBtn
            // 
            this.groupBoxAddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxAddBtn.Controls.Add(this.buttonClose);
            this.groupBoxAddBtn.Controls.Add(this.buttonClear);
            this.groupBoxAddBtn.Controls.Add(this.buttonAdd);
            this.groupBoxAddBtn.Location = new System.Drawing.Point(12, 375);
            this.groupBoxAddBtn.Name = "groupBoxAddBtn";
            this.groupBoxAddBtn.Size = new System.Drawing.Size(776, 63);
            this.groupBoxAddBtn.TabIndex = 10;
            this.groupBoxAddBtn.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(107, 29);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(149, 19);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(117, 29);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(617, 19);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(144, 29);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMovieTittle
            // 
            this.textBoxMovieTittle.Location = new System.Drawing.Point(106, 91);
            this.textBoxMovieTittle.Name = "textBoxMovieTittle";
            this.textBoxMovieTittle.Size = new System.Drawing.Size(279, 20);
            this.textBoxMovieTittle.TabIndex = 11;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(106, 146);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 12;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(106, 201);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(204, 20);
            this.textBoxDirector.TabIndex = 13;
            // 
            // listBoxGenre
            // 
            this.listBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxGenre.FormattingEnabled = true;
            this.listBoxGenre.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystrey",
            "Romance",
            "Science Fiction",
            "Western"});
            this.listBoxGenre.Location = new System.Drawing.Point(100, 263);
            this.listBoxGenre.Name = "listBoxGenre";
            this.listBoxGenre.Size = new System.Drawing.Size(178, 28);
            this.listBoxGenre.TabIndex = 14;
            // 
            // textBoxRottenTScore
            // 
            this.textBoxRottenTScore.Location = new System.Drawing.Point(226, 313);
            this.textBoxRottenTScore.Name = "textBoxRottenTScore";
            this.textBoxRottenTScore.Size = new System.Drawing.Size(52, 20);
            this.textBoxRottenTScore.TabIndex = 15;
            // 
            // textBoxBoxOfficeE
            // 
            this.textBoxBoxOfficeE.Location = new System.Drawing.Point(405, 317);
            this.textBoxBoxOfficeE.Name = "textBoxBoxOfficeE";
            this.textBoxBoxOfficeE.Size = new System.Drawing.Size(128, 20);
            this.textBoxBoxOfficeE.TabIndex = 16;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBoxOfficeE);
            this.Controls.Add(this.textBoxRottenTScore);
            this.Controls.Add(this.listBoxGenre);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMovieTittle);
            this.Controls.Add(this.groupBoxAddBtn);
            this.Controls.Add(this.labelBoxOfficeE);
            this.Controls.Add(this.labelRottenTomatoesScore);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelMovieTittle);
            this.Controls.Add(this.labelAddMovieScreen);
            this.Name = "Add";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.Add_Load);
            this.groupBoxAddBtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddMovieScreen;
        private System.Windows.Forms.Label labelMovieTittle;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelRottenTomatoesScore;
        private System.Windows.Forms.Label labelBoxOfficeE;
        private System.Windows.Forms.GroupBox groupBoxAddBtn;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxMovieTittle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.ListBox listBoxGenre;
        private System.Windows.Forms.TextBox textBoxRottenTScore;
        private System.Windows.Forms.TextBox textBoxBoxOfficeE;
    }
}