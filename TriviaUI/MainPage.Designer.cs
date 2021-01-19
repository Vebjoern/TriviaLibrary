
namespace TriviaUI
{
    partial class MainPage
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
            this.Header1 = new System.Windows.Forms.Label();
            this.TriviaListBox = new System.Windows.Forms.ListBox();
            this.ImportNewTriviaButton = new System.Windows.Forms.Button();
            this.AddNewTriviaButton = new System.Windows.Forms.Button();
            this.EditTriviaButton = new System.Windows.Forms.Button();
            this.ExportTriviaButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header1
            // 
            this.Header1.AutoSize = true;
            this.Header1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header1.Location = new System.Drawing.Point(12, 9);
            this.Header1.Name = "Header1";
            this.Header1.Size = new System.Drawing.Size(128, 30);
            this.Header1.TabIndex = 0;
            this.Header1.Text = "Trivia Library";
            // 
            // TriviaListBox
            // 
            this.TriviaListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriviaListBox.FormattingEnabled = true;
            this.TriviaListBox.ItemHeight = 21;
            this.TriviaListBox.Location = new System.Drawing.Point(15, 70);
            this.TriviaListBox.Name = "TriviaListBox";
            this.TriviaListBox.Size = new System.Drawing.Size(250, 235);
            this.TriviaListBox.TabIndex = 1;
            // 
            // ImportNewTriviaButton
            // 
            this.ImportNewTriviaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportNewTriviaButton.Location = new System.Drawing.Point(15, 350);
            this.ImportNewTriviaButton.Name = "ImportNewTriviaButton";
            this.ImportNewTriviaButton.Size = new System.Drawing.Size(164, 33);
            this.ImportNewTriviaButton.TabIndex = 2;
            this.ImportNewTriviaButton.Text = "Import new trivia...";
            this.ImportNewTriviaButton.UseVisualStyleBackColor = true;
            // 
            // AddNewTriviaButton
            // 
            this.AddNewTriviaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewTriviaButton.Location = new System.Drawing.Point(15, 311);
            this.AddNewTriviaButton.Name = "AddNewTriviaButton";
            this.AddNewTriviaButton.Size = new System.Drawing.Size(164, 33);
            this.AddNewTriviaButton.TabIndex = 4;
            this.AddNewTriviaButton.Text = "Add new trivia...";
            this.AddNewTriviaButton.UseVisualStyleBackColor = true;
            this.AddNewTriviaButton.Click += new System.EventHandler(this.AddNewTriviaButton_Click);
            // 
            // EditTriviaButton
            // 
            this.EditTriviaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTriviaButton.Location = new System.Drawing.Point(271, 70);
            this.EditTriviaButton.Name = "EditTriviaButton";
            this.EditTriviaButton.Size = new System.Drawing.Size(87, 34);
            this.EditTriviaButton.TabIndex = 5;
            this.EditTriviaButton.Text = "Edit";
            this.EditTriviaButton.UseVisualStyleBackColor = true;
            // 
            // ExportTriviaButton
            // 
            this.ExportTriviaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportTriviaButton.Location = new System.Drawing.Point(271, 110);
            this.ExportTriviaButton.Name = "ExportTriviaButton";
            this.ExportTriviaButton.Size = new System.Drawing.Size(87, 34);
            this.ExportTriviaButton.TabIndex = 5;
            this.ExportTriviaButton.Text = "Export";
            this.ExportTriviaButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(271, 150);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(87, 34);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ExportTriviaButton);
            this.Controls.Add(this.EditTriviaButton);
            this.Controls.Add(this.AddNewTriviaButton);
            this.Controls.Add(this.ImportNewTriviaButton);
            this.Controls.Add(this.TriviaListBox);
            this.Controls.Add(this.Header1);
            this.Name = "MainPage";
            this.Text = "Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header1;
        private System.Windows.Forms.ListBox TriviaListBox;
        private System.Windows.Forms.Button ImportNewTriviaButton;
        private System.Windows.Forms.Button AddNewTriviaButton;
        private System.Windows.Forms.Button EditTriviaButton;
        private System.Windows.Forms.Button ExportTriviaButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

