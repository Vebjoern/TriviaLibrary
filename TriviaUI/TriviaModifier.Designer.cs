
namespace TriviaUI
{
    partial class TriviaModifier
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
            this.questionListBox = new System.Windows.Forms.ListBox();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.editQuestionButton = new System.Windows.Forms.Button();
            this.deleteQuestionButton = new System.Windows.Forms.Button();
            this.triviaNameLabel = new System.Windows.Forms.Label();
            this.triviaModifierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.triviaModifierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // questionListBox
            // 
            this.questionListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionListBox.FormattingEnabled = true;
            this.questionListBox.ItemHeight = 21;
            this.questionListBox.Location = new System.Drawing.Point(15, 70);
            this.questionListBox.Name = "questionListBox";
            this.questionListBox.Size = new System.Drawing.Size(250, 235);
            this.questionListBox.TabIndex = 0;
            // 
            // addNewQuestionButton
            // 
            this.addNewQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuestionButton.Location = new System.Drawing.Point(271, 70);
            this.addNewQuestionButton.Name = "addNewQuestionButton";
            this.addNewQuestionButton.Size = new System.Drawing.Size(87, 34);
            this.addNewQuestionButton.TabIndex = 6;
            this.addNewQuestionButton.Text = "Add new";
            this.addNewQuestionButton.UseVisualStyleBackColor = true;
            this.addNewQuestionButton.Click += new System.EventHandler(this.AddNewQuestionButton_Click);
            // 
            // editQuestionButton
            // 
            this.editQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuestionButton.Location = new System.Drawing.Point(271, 110);
            this.editQuestionButton.Name = "editQuestionButton";
            this.editQuestionButton.Size = new System.Drawing.Size(87, 34);
            this.editQuestionButton.TabIndex = 7;
            this.editQuestionButton.Text = "Edit";
            this.editQuestionButton.UseVisualStyleBackColor = true;
            // 
            // deleteQuestionButton
            // 
            this.deleteQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuestionButton.Location = new System.Drawing.Point(271, 150);
            this.deleteQuestionButton.Name = "deleteQuestionButton";
            this.deleteQuestionButton.Size = new System.Drawing.Size(87, 34);
            this.deleteQuestionButton.TabIndex = 8;
            this.deleteQuestionButton.Text = "Delete";
            this.deleteQuestionButton.UseVisualStyleBackColor = true;
            // 
            // triviaNameLabel
            // 
            this.triviaNameLabel.AutoSize = true;
            this.triviaNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.triviaModifierBindingSource, "TriviaName", true));
            this.triviaNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triviaNameLabel.Location = new System.Drawing.Point(13, 13);
            this.triviaNameLabel.Name = "triviaNameLabel";
            this.triviaNameLabel.Size = new System.Drawing.Size(0, 30);
            this.triviaNameLabel.TabIndex = 9;
            // 
            // triviaModifierBindingSource
            // 
            this.triviaModifierBindingSource.DataSource = typeof(TriviaUI.TriviaModifier);
            // 
            // TriviaModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.triviaNameLabel);
            this.Controls.Add(this.deleteQuestionButton);
            this.Controls.Add(this.editQuestionButton);
            this.Controls.Add(this.addNewQuestionButton);
            this.Controls.Add(this.questionListBox);
            this.Name = "TriviaModifier";
            this.Text = "Edit trivia";
            ((System.ComponentModel.ISupportInitialize)(this.triviaModifierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox questionListBox;
        private System.Windows.Forms.Button addNewQuestionButton;
        private System.Windows.Forms.Button editQuestionButton;
        private System.Windows.Forms.Button deleteQuestionButton;
        private System.Windows.Forms.Label triviaNameLabel;
        private System.Windows.Forms.BindingSource triviaModifierBindingSource;
    }
}