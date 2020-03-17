namespace ShowAppDesktop
{
    partial class MainScreen
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
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Quit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.Location = new System.Drawing.Point(367, 48);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(49, 13);
            this.welcomeMessage.TabIndex = 0;
            this.welcomeMessage.Text = "welcome";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(74, 82);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(74, 111);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 2;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(74, 140);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 3;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(74, 169);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(74, 198);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(74, 227);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 23);
            this.button_Load.TabIndex = 6;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.Location = new System.Drawing.Point(74, 256);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(75, 23);
            this.button_Settings.TabIndex = 7;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_Quit
            // 
            this.button_Quit.Location = new System.Drawing.Point(74, 285);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(75, 23);
            this.button_Quit.TabIndex = 8;
            this.button_Quit.Text = "Quit";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "The Rising of the Shield Hero",
            "One Punch Man"});
            this.listBox1.Location = new System.Drawing.Point(610, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 381);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Quit);
            this.Controls.Add(this.button_Settings);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.welcomeMessage);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.ListBox listBox1;
    }
}