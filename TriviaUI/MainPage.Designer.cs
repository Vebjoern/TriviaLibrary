
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
            this.TriviaListBox = new System.Windows.Forms.ListBox();
            this.ImportNewTriviaButton = new System.Windows.Forms.Button();
            this.addNewTriviaButton = new System.Windows.Forms.Button();
            this.EditTriviaButton = new System.Windows.Forms.Button();
            this.ExportTriviaButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addNewTriviaTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.ImportNewTriviaButton.Location = new System.Drawing.Point(12, 31);
            this.ImportNewTriviaButton.Name = "ImportNewTriviaButton";
            this.ImportNewTriviaButton.Size = new System.Drawing.Size(164, 33);
            this.ImportNewTriviaButton.TabIndex = 2;
            this.ImportNewTriviaButton.Text = "Import new trivia...";
            this.ImportNewTriviaButton.UseVisualStyleBackColor = true;
            // 
            // addNewTriviaButton
            // 
            this.addNewTriviaButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTriviaButton.Location = new System.Drawing.Point(271, 386);
            this.addNewTriviaButton.Name = "addNewTriviaButton";
            this.addNewTriviaButton.Size = new System.Drawing.Size(164, 33);
            this.addNewTriviaButton.TabIndex = 4;
            this.addNewTriviaButton.Text = "Add new trivia";
            this.addNewTriviaButton.UseVisualStyleBackColor = true;
            this.addNewTriviaButton.Click += new System.EventHandler(this.AddNewTriviaButton_Click);
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
            this.EditTriviaButton.Click += new System.EventHandler(this.EditTriviaButton_Click);
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
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addNewTriviaTextbox
            // 
            this.addNewTriviaTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewTriviaTextbox.Location = new System.Drawing.Point(12, 389);
            this.addNewTriviaTextbox.Name = "addNewTriviaTextbox";
            this.addNewTriviaTextbox.Size = new System.Drawing.Size(253, 29);
            this.addNewTriviaTextbox.TabIndex = 8;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.addNewTriviaTextbox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.ExportTriviaButton);
            this.Controls.Add(this.EditTriviaButton);
            this.Controls.Add(this.addNewTriviaButton);
            this.Controls.Add(this.ImportNewTriviaButton);
            this.Controls.Add(this.TriviaListBox);
            this.Name = "MainPage";
            this.Text = "Trivia Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox TriviaListBox;
        private System.Windows.Forms.Button ImportNewTriviaButton;
        private System.Windows.Forms.Button addNewTriviaButton;
        private System.Windows.Forms.Button EditTriviaButton;
        private System.Windows.Forms.Button ExportTriviaButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox addNewTriviaTextbox;
    }
}

