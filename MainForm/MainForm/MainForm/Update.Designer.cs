
namespace MainForm
{
    partial class Update
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
            this.comboBox1Genre = new System.Windows.Forms.ComboBox();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.labelYearReleased = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRottenTomatoscore = new System.Windows.Forms.Label();
            this.labelTotalEarnings = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxMovieTitle = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxRottenTScore = new System.Windows.Forms.TextBox();
            this.textBoxBoxOfficeE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1Genre
            // 
            this.comboBox1Genre.FormattingEnabled = true;
            this.comboBox1Genre.Location = new System.Drawing.Point(172, 133);
            this.comboBox1Genre.Name = "comboBox1Genre";
            this.comboBox1Genre.Size = new System.Drawing.Size(121, 21);
            this.comboBox1Genre.TabIndex = 0;
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.AutoSize = true;
            this.labelMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovieTitle.Location = new System.Drawing.Point(79, 35);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(87, 20);
            this.labelMovieTitle.TabIndex = 1;
            this.labelMovieTitle.Text = "Movie Title:";
            // 
            // labelYearReleased
            // 
            this.labelYearReleased.AutoSize = true;
            this.labelYearReleased.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearReleased.Location = new System.Drawing.Point(47, 67);
            this.labelYearReleased.Name = "labelYearReleased";
            this.labelYearReleased.Size = new System.Drawing.Size(119, 20);
            this.labelYearReleased.TabIndex = 2;
            this.labelYearReleased.Text = "Year Released:";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirector.Location = new System.Drawing.Point(100, 100);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(69, 20);
            this.labelDirector.TabIndex = 3;
            this.labelDirector.Text = "Director:";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(108, 134);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(58, 20);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Genre:";
            // 
            // labelRottenTomatoscore
            // 
            this.labelRottenTomatoscore.AutoSize = true;
            this.labelRottenTomatoscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRottenTomatoscore.Location = new System.Drawing.Point(6, 194);
            this.labelRottenTomatoscore.Name = "labelRottenTomatoscore";
            this.labelRottenTomatoscore.Size = new System.Drawing.Size(163, 20);
            this.labelRottenTomatoscore.TabIndex = 5;
            this.labelRottenTomatoscore.Text = "Rotten Tomato score:";
            // 
            // labelTotalEarnings
            // 
            this.labelTotalEarnings.AutoSize = true;
            this.labelTotalEarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEarnings.Location = new System.Drawing.Point(51, 259);
            this.labelTotalEarnings.Name = "labelTotalEarnings";
            this.labelTotalEarnings.Size = new System.Drawing.Size(115, 20);
            this.labelTotalEarnings.TabIndex = 6;
            this.labelTotalEarnings.Text = "Total Earnings:";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(485, 28);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(80, 32);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(60, 323);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(87, 33);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(284, 323);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(93, 33);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(468, 323);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(97, 33);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxMovieTitle
            // 
            this.textBoxMovieTitle.Location = new System.Drawing.Point(172, 35);
            this.textBoxMovieTitle.Name = "textBoxMovieTitle";
            this.textBoxMovieTitle.Size = new System.Drawing.Size(280, 20);
            this.textBoxMovieTitle.TabIndex = 11;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(172, 67);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(36, 20);
            this.textBoxYear.TabIndex = 12;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(172, 100);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(280, 20);
            this.textBoxDirector.TabIndex = 13;
            // 
            // textBoxRottenTScore
            // 
            this.textBoxRottenTScore.Location = new System.Drawing.Point(172, 196);
            this.textBoxRottenTScore.Name = "textBoxRottenTScore";
            this.textBoxRottenTScore.Size = new System.Drawing.Size(56, 20);
            this.textBoxRottenTScore.TabIndex = 14;
            // 
            // textBoxBoxOfficeE
            // 
            this.textBoxBoxOfficeE.Location = new System.Drawing.Point(172, 261);
            this.textBoxBoxOfficeE.Name = "textBoxBoxOfficeE";
            this.textBoxBoxOfficeE.Size = new System.Drawing.Size(100, 20);
            this.textBoxBoxOfficeE.TabIndex = 15;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBoxOfficeE);
            this.Controls.Add(this.textBoxRottenTScore);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxMovieTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelTotalEarnings);
            this.Controls.Add(this.labelRottenTomatoscore);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelYearReleased);
            this.Controls.Add(this.labelMovieTitle);
            this.Controls.Add(this.comboBox1Genre);
            this.Name = "Update";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1Genre;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Label labelYearReleased;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelRottenTomatoscore;
        private System.Windows.Forms.Label labelTotalEarnings;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxMovieTitle;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxRottenTScore;
        private System.Windows.Forms.TextBox textBoxBoxOfficeE;
    }
}