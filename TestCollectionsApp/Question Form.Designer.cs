namespace TestCollectionsApp
{
    partial class Question_Form
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
            this.questionInfoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // questionInfoTextBox
            // 
            this.questionInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionInfoTextBox.Location = new System.Drawing.Point(13, 13);
            this.questionInfoTextBox.Multiline = true;
            this.questionInfoTextBox.Name = "questionInfoTextBox";
            this.questionInfoTextBox.ReadOnly = true;
            this.questionInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.questionInfoTextBox.Size = new System.Drawing.Size(652, 600);
            this.questionInfoTextBox.TabIndex = 0;
            // 
            // Question_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 625);
            this.Controls.Add(this.questionInfoTextBox);
            this.Name = "Question_Form";
            this.Text = "Question Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionInfoTextBox;
    }
}