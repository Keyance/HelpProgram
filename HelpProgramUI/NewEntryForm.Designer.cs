namespace HelpProgramUI
{
    partial class NewEntryForm
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
            saveButton = new Button();
            diaryEntryLabel = new Label();
            diaryEntryValue = new TextBox();
            pickMoodLabel = new Label();
            moodDropBox = new ComboBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.MistyRose;
            saveButton.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            saveButton.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(274, 439);
            saveButton.Margin = new Padding(4);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(355, 70);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // diaryEntryLabel
            // 
            diaryEntryLabel.AutoSize = true;
            diaryEntryLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            diaryEntryLabel.ForeColor = Color.DarkRed;
            diaryEntryLabel.Location = new Point(29, 28);
            diaryEntryLabel.Name = "diaryEntryLabel";
            diaryEntryLabel.Size = new Size(320, 38);
            diaryEntryLabel.TabIndex = 2;
            diaryEntryLabel.Text = "How do you feel today?";
            // 
            // diaryEntryValue
            // 
            diaryEntryValue.Location = new Point(29, 79);
            diaryEntryValue.Multiline = true;
            diaryEntryValue.Name = "diaryEntryValue";
            diaryEntryValue.Size = new Size(845, 158);
            diaryEntryValue.TabIndex = 3;
            // 
            // pickMoodLabel
            // 
            pickMoodLabel.AutoSize = true;
            pickMoodLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            pickMoodLabel.ForeColor = Color.DarkRed;
            pickMoodLabel.Location = new Point(29, 267);
            pickMoodLabel.Name = "pickMoodLabel";
            pickMoodLabel.Size = new Size(326, 38);
            pickMoodLabel.TabIndex = 4;
            pickMoodLabel.Text = "Which mood are you in?";
            // 
            // moodDropBox
            // 
            moodDropBox.FormattingEnabled = true;
            moodDropBox.Location = new Point(29, 318);
            moodDropBox.Name = "moodDropBox";
            moodDropBox.Size = new Size(503, 36);
            moodDropBox.TabIndex = 5;
            // 
            // NewEntryForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(902, 538);
            Controls.Add(moodDropBox);
            Controls.Add(pickMoodLabel);
            Controls.Add(diaryEntryValue);
            Controls.Add(diaryEntryLabel);
            Controls.Add(saveButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "NewEntryForm";
            Text = "New Diary Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Label diaryEntryLabel;
        private TextBox diaryEntryValue;
        private Label pickMoodLabel;
        private ComboBox moodDropBox;
    }
}