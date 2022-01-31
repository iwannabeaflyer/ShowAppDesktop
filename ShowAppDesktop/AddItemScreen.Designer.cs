namespace ShowAppDesktop
{
    partial class AddItemScreen
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
            this.button_Add = new System.Windows.Forms.Button();
            this.numericUpDown_RuntimeTotal = new System.Windows.Forms.NumericUpDown();
            this.label_RuntimeTotal = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.textBox_Edit = new System.Windows.Forms.TextBox();
            this.listBox_Genres = new System.Windows.Forms.ListBox();
            this.numericUpDown_RuntimeEpisode = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Score = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Episodes = new System.Windows.Forms.NumericUpDown();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_Ending = new System.Windows.Forms.Label();
            this.checkBox_Ending = new System.Windows.Forms.CheckBox();
            this.checkBox_Watched = new System.Windows.Forms.CheckBox();
            this.label_Watched = new System.Windows.Forms.Label();
            this.textBox_Notes = new System.Windows.Forms.TextBox();
            this.label_Notes = new System.Windows.Forms.Label();
            this.label_RuntimeEpisode = new System.Windows.Forms.Label();
            this.label_Score = new System.Windows.Forms.Label();
            this.label_Genres = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Episodes = new System.Windows.Forms.Label();
            this.textBox_AltName = new System.Windows.Forms.TextBox();
            this.label_AltName = new System.Windows.Forms.Label();
            this.textBox_EnName = new System.Windows.Forms.TextBox();
            this.label_EnName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RuntimeTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RuntimeEpisode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Episodes)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.Location = new System.Drawing.Point(11, 293);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 62;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // numericUpDown_RuntimeTotal
            // 
            this.numericUpDown_RuntimeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_RuntimeTotal.Location = new System.Drawing.Point(502, 377);
            this.numericUpDown_RuntimeTotal.Maximum = new decimal(new int[] {
            65537,
            0,
            0,
            0});
            this.numericUpDown_RuntimeTotal.Name = "numericUpDown_RuntimeTotal";
            this.numericUpDown_RuntimeTotal.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_RuntimeTotal.TabIndex = 61;
            // 
            // label_RuntimeTotal
            // 
            this.label_RuntimeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RuntimeTotal.Location = new System.Drawing.Point(346, 379);
            this.label_RuntimeTotal.Name = "label_RuntimeTotal";
            this.label_RuntimeTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_RuntimeTotal.Size = new System.Drawing.Size(150, 13);
            this.label_RuntimeTotal.TabIndex = 60;
            this.label_RuntimeTotal.Text = "Runtime in total";
            this.label_RuntimeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Delete
            // 
            this.button_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Delete.Location = new System.Drawing.Point(183, 293);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 59;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Edit.Location = new System.Drawing.Point(99, 293);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 58;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // textBox_Edit
            // 
            this.textBox_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Edit.Location = new System.Drawing.Point(100, 256);
            this.textBox_Edit.Name = "textBox_Edit";
            this.textBox_Edit.Size = new System.Drawing.Size(94, 20);
            this.textBox_Edit.TabIndex = 57;
            // 
            // listBox_Genres
            // 
            this.listBox_Genres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Genres.FormattingEnabled = true;
            this.listBox_Genres.Location = new System.Drawing.Point(100, 64);
            this.listBox_Genres.Name = "listBox_Genres";
            this.listBox_Genres.Size = new System.Drawing.Size(94, 186);
            this.listBox_Genres.TabIndex = 56;
            // 
            // numericUpDown_RuntimeEpisode
            // 
            this.numericUpDown_RuntimeEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_RuntimeEpisode.Location = new System.Drawing.Point(233, 377);
            this.numericUpDown_RuntimeEpisode.Maximum = new decimal(new int[] {
            65537,
            0,
            0,
            0});
            this.numericUpDown_RuntimeEpisode.Name = "numericUpDown_RuntimeEpisode";
            this.numericUpDown_RuntimeEpisode.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_RuntimeEpisode.TabIndex = 55;
            // 
            // numericUpDown_Score
            // 
            this.numericUpDown_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Score.Location = new System.Drawing.Point(502, 338);
            this.numericUpDown_Score.Name = "numericUpDown_Score";
            this.numericUpDown_Score.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Score.TabIndex = 54;
            // 
            // numericUpDown_Episodes
            // 
            this.numericUpDown_Episodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Episodes.Location = new System.Drawing.Point(233, 338);
            this.numericUpDown_Episodes.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_Episodes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Episodes.Name = "numericUpDown_Episodes";
            this.numericUpDown_Episodes.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_Episodes.TabIndex = 53;
            this.numericUpDown_Episodes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(488, 410);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 52;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(393, 410);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 51;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_Ending
            // 
            this.label_Ending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Ending.Location = new System.Drawing.Point(97, 413);
            this.label_Ending.Name = "label_Ending";
            this.label_Ending.Size = new System.Drawing.Size(60, 13);
            this.label_Ending.TabIndex = 50;
            this.label_Ending.Text = "ending";
            this.label_Ending.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox_Ending
            // 
            this.checkBox_Ending.AutoSize = true;
            this.checkBox_Ending.Location = new System.Drawing.Point(159, 415);
            this.checkBox_Ending.Name = "checkBox_Ending";
            this.checkBox_Ending.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Ending.TabIndex = 49;
            this.checkBox_Ending.UseVisualStyleBackColor = true;
            // 
            // checkBox_Watched
            // 
            this.checkBox_Watched.AutoSize = true;
            this.checkBox_Watched.Location = new System.Drawing.Point(71, 415);
            this.checkBox_Watched.Name = "checkBox_Watched";
            this.checkBox_Watched.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Watched.TabIndex = 48;
            this.checkBox_Watched.UseVisualStyleBackColor = true;
            // 
            // label_Watched
            // 
            this.label_Watched.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Watched.Location = new System.Drawing.Point(13, 415);
            this.label_Watched.Name = "label_Watched";
            this.label_Watched.Size = new System.Drawing.Size(60, 13);
            this.label_Watched.TabIndex = 47;
            this.label_Watched.Text = "watched";
            this.label_Watched.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Notes
            // 
            this.textBox_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Notes.Location = new System.Drawing.Point(246, 410);
            this.textBox_Notes.Multiline = true;
            this.textBox_Notes.Name = "textBox_Notes";
            this.textBox_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Notes.Size = new System.Drawing.Size(141, 20);
            this.textBox_Notes.TabIndex = 46;
            // 
            // label_Notes
            // 
            this.label_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Notes.Location = new System.Drawing.Point(180, 413);
            this.label_Notes.Name = "label_Notes";
            this.label_Notes.Size = new System.Drawing.Size(60, 13);
            this.label_Notes.TabIndex = 45;
            this.label_Notes.Text = "notes";
            this.label_Notes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_RuntimeEpisode
            // 
            this.label_RuntimeEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_RuntimeEpisode.Location = new System.Drawing.Point(77, 379);
            this.label_RuntimeEpisode.Name = "label_RuntimeEpisode";
            this.label_RuntimeEpisode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_RuntimeEpisode.Size = new System.Drawing.Size(150, 13);
            this.label_RuntimeEpisode.TabIndex = 44;
            this.label_RuntimeEpisode.Text = "Runtime per Episode";
            this.label_RuntimeEpisode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Score
            // 
            this.label_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Score.Location = new System.Drawing.Point(346, 340);
            this.label_Score.Name = "label_Score";
            this.label_Score.Size = new System.Drawing.Size(150, 13);
            this.label_Score.TabIndex = 43;
            this.label_Score.Text = "Score";
            this.label_Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Genres
            // 
            this.label_Genres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Genres.Location = new System.Drawing.Point(13, 67);
            this.label_Genres.Name = "label_Genres";
            this.label_Genres.Size = new System.Drawing.Size(81, 13);
            this.label_Genres.TabIndex = 42;
            this.label_Genres.Text = "genres";
            this.label_Genres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Description.Location = new System.Drawing.Point(312, 64);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Description.Size = new System.Drawing.Size(265, 252);
            this.textBox_Description.TabIndex = 41;
            // 
            // label_Description
            // 
            this.label_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Description.Location = new System.Drawing.Point(200, 67);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(106, 13);
            this.label_Description.TabIndex = 40;
            this.label_Description.Text = "description";
            this.label_Description.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Episodes
            // 
            this.label_Episodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Episodes.Location = new System.Drawing.Point(77, 340);
            this.label_Episodes.Name = "label_Episodes";
            this.label_Episodes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Episodes.Size = new System.Drawing.Size(150, 13);
            this.label_Episodes.TabIndex = 39;
            this.label_Episodes.Text = "Episodes";
            this.label_Episodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_AltName
            // 
            this.textBox_AltName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_AltName.Location = new System.Drawing.Point(100, 38);
            this.textBox_AltName.Multiline = true;
            this.textBox_AltName.Name = "textBox_AltName";
            this.textBox_AltName.Size = new System.Drawing.Size(477, 20);
            this.textBox_AltName.TabIndex = 38;
            // 
            // label_AltName
            // 
            this.label_AltName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AltName.Location = new System.Drawing.Point(17, 41);
            this.label_AltName.Name = "label_AltName";
            this.label_AltName.Size = new System.Drawing.Size(77, 13);
            this.label_AltName.TabIndex = 37;
            this.label_AltName.Text = "alternative";
            this.label_AltName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_EnName
            // 
            this.textBox_EnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_EnName.Location = new System.Drawing.Point(100, 12);
            this.textBox_EnName.Multiline = true;
            this.textBox_EnName.Name = "textBox_EnName";
            this.textBox_EnName.Size = new System.Drawing.Size(477, 20);
            this.textBox_EnName.TabIndex = 36;
            // 
            // label_EnName
            // 
            this.label_EnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_EnName.Location = new System.Drawing.Point(13, 15);
            this.label_EnName.Name = "label_EnName";
            this.label_EnName.Size = new System.Drawing.Size(81, 13);
            this.label_EnName.TabIndex = 35;
            this.label_EnName.Text = "english";
            this.label_EnName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 445);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.numericUpDown_RuntimeTotal);
            this.Controls.Add(this.label_RuntimeTotal);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.textBox_Edit);
            this.Controls.Add(this.listBox_Genres);
            this.Controls.Add(this.numericUpDown_RuntimeEpisode);
            this.Controls.Add(this.numericUpDown_Score);
            this.Controls.Add(this.numericUpDown_Episodes);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_Ending);
            this.Controls.Add(this.checkBox_Ending);
            this.Controls.Add(this.checkBox_Watched);
            this.Controls.Add(this.label_Watched);
            this.Controls.Add(this.textBox_Notes);
            this.Controls.Add(this.label_Notes);
            this.Controls.Add(this.label_RuntimeEpisode);
            this.Controls.Add(this.label_Score);
            this.Controls.Add(this.label_Genres);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Episodes);
            this.Controls.Add(this.textBox_AltName);
            this.Controls.Add(this.label_AltName);
            this.Controls.Add(this.textBox_EnName);
            this.Controls.Add(this.label_EnName);
            this.Name = "AddItemScreen";
            this.Text = "AddItemScreen";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RuntimeTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RuntimeEpisode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Episodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button_Add;
        public System.Windows.Forms.NumericUpDown numericUpDown_RuntimeTotal;
        public System.Windows.Forms.Label label_RuntimeTotal;
        public System.Windows.Forms.Button button_Delete;
        public System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.TextBox textBox_Edit;
        public System.Windows.Forms.ListBox listBox_Genres;
        public System.Windows.Forms.NumericUpDown numericUpDown_RuntimeEpisode;
        public System.Windows.Forms.NumericUpDown numericUpDown_Score;
        public System.Windows.Forms.NumericUpDown numericUpDown_Episodes;
        public System.Windows.Forms.Button button_Cancel;
        public System.Windows.Forms.Button button_Save;
        public System.Windows.Forms.Label label_Ending;
        public System.Windows.Forms.CheckBox checkBox_Ending;
        public System.Windows.Forms.CheckBox checkBox_Watched;
        public System.Windows.Forms.Label label_Watched;
        public System.Windows.Forms.TextBox textBox_Notes;
        public System.Windows.Forms.Label label_Notes;
        public System.Windows.Forms.Label label_RuntimeEpisode;
        public System.Windows.Forms.Label label_Score;
        public System.Windows.Forms.Label label_Genres;
        public System.Windows.Forms.TextBox textBox_Description;
        public System.Windows.Forms.Label label_Description;
        public System.Windows.Forms.Label label_Episodes;
        public System.Windows.Forms.TextBox textBox_AltName;
        public System.Windows.Forms.Label label_AltName;
        public System.Windows.Forms.TextBox textBox_EnName;
        public System.Windows.Forms.Label label_EnName;
    }
}