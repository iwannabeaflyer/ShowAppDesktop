namespace ShowAppDesktop
{
    partial class ConfirmScreen
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
            this.button_Yes = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.label_Confirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Yes
            // 
            this.button_Yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button_Yes.Location = new System.Drawing.Point(45, 97);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.Size = new System.Drawing.Size(146, 85);
            this.button_Yes.TabIndex = 0;
            this.button_Yes.Text = "Yes";
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_Yes_Click);
            // 
            // button_No
            // 
            this.button_No.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_No.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button_No.Location = new System.Drawing.Point(263, 97);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(146, 85);
            this.button_No.TabIndex = 1;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // label_Confirm
            // 
            this.label_Confirm.AutoSize = true;
            this.label_Confirm.Location = new System.Drawing.Point(195, 38);
            this.label_Confirm.Name = "label_Confirm";
            this.label_Confirm.Size = new System.Drawing.Size(62, 13);
            this.label_Confirm.TabIndex = 2;
            this.label_Confirm.Text = "Confirm text";
            // 
            // ConfirmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 231);
            this.Controls.Add(this.label_Confirm);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfirmScreen";
            this.Text = "Confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Yes;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Label label_Confirm;
    }
}