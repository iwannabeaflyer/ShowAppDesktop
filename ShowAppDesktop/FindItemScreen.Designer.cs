namespace ShowAppDesktop
{
    partial class FindItemScreen
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
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_Search = new System.Windows.Forms.Label();
            this.button_Open = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(383, 12);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxItems.Size = new System.Drawing.Size(203, 420);
            this.listBoxItems.TabIndex = 0;
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(145, 363);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 1;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(263, 363);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 23);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(145, 87);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(145, 161);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(79, 90);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(60, 13);
            this.label_Search.TabIndex = 5;
            this.label_Search.Text = "Search List";
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(39, 363);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 6;
            this.button_Open.Text = "Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // FindItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.listBoxItems);
            this.Name = "FindItemScreen";
            this.Text = "FindItemScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTextBox;
        public System.Windows.Forms.Button button_Open;
        public System.Windows.Forms.Button button_Edit;
        public System.Windows.Forms.Button button_Close;
        public System.Windows.Forms.Button button_Search;
        public System.Windows.Forms.Label label_Search;
        public System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}