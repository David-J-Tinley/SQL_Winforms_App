namespace SqlWinformsApp
{
    partial class Form1
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
            this.Text_Content = new System.Windows.Forms.RichTextBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_Content
            // 
            this.Text_Content.Location = new System.Drawing.Point(12, 91);
            this.Text_Content.Name = "Text_Content";
            this.Text_Content.Size = new System.Drawing.Size(776, 271);
            this.Text_Content.TabIndex = 0;
            this.Text_Content.Text = "";
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(12, 31);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(158, 38);
            this.Connect_Button.TabIndex = 1;
            this.Connect_Button.Text = "Connect to Database";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Text_Content);
            this.Name = "Form1";
            this.Text = "SQL Connection to Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Text_Content;
        private System.Windows.Forms.Button Connect_Button;
    }
}

