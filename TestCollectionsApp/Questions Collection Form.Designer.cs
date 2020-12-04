namespace TestCollectionsApp
{
    partial class QuestionsCollection
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
            this.components = new System.ComponentModel.Container();
            this.questionSearchBar = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.searchQuestionButton = new System.Windows.Forms.Button();
            this.questionListBox = new System.Windows.Forms.ListBox();
            this.openSelectedQuestionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // questionSearchBar
            // 
            this.questionSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionSearchBar.Location = new System.Drawing.Point(13, 13);
            this.questionSearchBar.Name = "questionSearchBar";
            this.questionSearchBar.Size = new System.Drawing.Size(341, 31);
            this.questionSearchBar.TabIndex = 0;
            this.questionSearchBar.TextChanged += new System.EventHandler(this.QuestionSearchBar_TextChanged);
            // 
            // searchQuestionButton
            // 
            this.searchQuestionButton.Location = new System.Drawing.Point(361, 13);
            this.searchQuestionButton.Name = "searchQuestionButton";
            this.searchQuestionButton.Size = new System.Drawing.Size(110, 31);
            this.searchQuestionButton.TabIndex = 2;
            this.searchQuestionButton.Text = "Search Questions";
            this.searchQuestionButton.UseVisualStyleBackColor = true;
            this.searchQuestionButton.Click += new System.EventHandler(this.SearchQuestionButton_Click);
            // 
            // questionListBox
            // 
            this.questionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionListBox.FormattingEnabled = true;
            this.questionListBox.ItemHeight = 16;
            this.questionListBox.Location = new System.Drawing.Point(13, 51);
            this.questionListBox.Name = "questionListBox";
            this.questionListBox.Size = new System.Drawing.Size(692, 372);
            this.questionListBox.TabIndex = 1;
            // 
            // openSelectedQuestionButton
            // 
            this.openSelectedQuestionButton.Location = new System.Drawing.Point(487, 12);
            this.openSelectedQuestionButton.Name = "openSelectedQuestionButton";
            this.openSelectedQuestionButton.Size = new System.Drawing.Size(130, 32);
            this.openSelectedQuestionButton.TabIndex = 3;
            this.openSelectedQuestionButton.Text = "Open Selected";
            this.openSelectedQuestionButton.UseVisualStyleBackColor = true;
            this.openSelectedQuestionButton.Click += new System.EventHandler(this.openSelectedQuestionButton_Click);
            // 
            // QuestionsCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openSelectedQuestionButton);
            this.Controls.Add(this.searchQuestionButton);
            this.Controls.Add(this.questionListBox);
            this.Controls.Add(this.questionSearchBar);
            this.Name = "QuestionsCollection";
            this.Text = "Questions Collection";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox questionSearchBar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button searchQuestionButton;
        private System.Windows.Forms.ListBox questionListBox;
        private System.Windows.Forms.Button openSelectedQuestionButton;
    }
}

