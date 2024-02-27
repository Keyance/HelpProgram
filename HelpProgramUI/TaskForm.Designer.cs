namespace HelpProgramUI
{
    partial class TaskForm
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
            doneButton = new Button();
            skipButton = new Button();
            taskInstructionValue = new TextBox();
            taskStatusDropBox = new ComboBox();
            taskStatusLabel = new Label();
            taskFeelingValue = new TextBox();
            taskFeelingLabel = new Label();
            SuspendLayout();
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.MistyRose;
            doneButton.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            doneButton.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            doneButton.FlatStyle = FlatStyle.Flat;
            doneButton.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            doneButton.Location = new Point(101, 539);
            doneButton.Margin = new Padding(4);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(355, 70);
            doneButton.TabIndex = 2;
            doneButton.Text = "Done!";
            doneButton.UseVisualStyleBackColor = false;
            // 
            // skipButton
            // 
            skipButton.BackColor = Color.MistyRose;
            skipButton.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            skipButton.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            skipButton.FlatStyle = FlatStyle.Flat;
            skipButton.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            skipButton.Location = new Point(595, 539);
            skipButton.Margin = new Padding(4);
            skipButton.Name = "skipButton";
            skipButton.Size = new Size(355, 70);
            skipButton.TabIndex = 3;
            skipButton.Text = "Skip!";
            skipButton.UseVisualStyleBackColor = false;
            // 
            // taskInstructionValue
            // 
            taskInstructionValue.Location = new Point(33, 24);
            taskInstructionValue.Multiline = true;
            taskInstructionValue.Name = "taskInstructionValue";
            taskInstructionValue.ReadOnly = true;
            taskInstructionValue.Size = new Size(979, 158);
            taskInstructionValue.TabIndex = 4;
            // 
            // taskStatusDropBox
            // 
            taskStatusDropBox.FormattingEnabled = true;
            taskStatusDropBox.Location = new Point(33, 253);
            taskStatusDropBox.Name = "taskStatusDropBox";
            taskStatusDropBox.Size = new Size(503, 36);
            taskStatusDropBox.TabIndex = 7;
            // 
            // taskStatusLabel
            // 
            taskStatusLabel.AutoSize = true;
            taskStatusLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            taskStatusLabel.ForeColor = Color.DarkRed;
            taskStatusLabel.Location = new Point(33, 202);
            taskStatusLabel.Name = "taskStatusLabel";
            taskStatusLabel.Size = new Size(204, 38);
            taskStatusLabel.TabIndex = 6;
            taskStatusLabel.Text = "How did it go?";
            // 
            // taskFeelingValue
            // 
            taskFeelingValue.Location = new Point(33, 356);
            taskFeelingValue.Multiline = true;
            taskFeelingValue.Name = "taskFeelingValue";
            taskFeelingValue.Size = new Size(979, 158);
            taskFeelingValue.TabIndex = 9;
            // 
            // taskFeelingLabel
            // 
            taskFeelingLabel.AutoSize = true;
            taskFeelingLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            taskFeelingLabel.ForeColor = Color.DarkRed;
            taskFeelingLabel.Location = new Point(33, 305);
            taskFeelingLabel.Name = "taskFeelingLabel";
            taskFeelingLabel.Size = new Size(350, 38);
            taskFeelingLabel.TabIndex = 8;
            taskFeelingLabel.Text = "How did it make you feel?";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1051, 641);
            Controls.Add(taskFeelingValue);
            Controls.Add(taskFeelingLabel);
            Controls.Add(taskStatusDropBox);
            Controls.Add(taskStatusLabel);
            Controls.Add(taskInstructionValue);
            Controls.Add(skipButton);
            Controls.Add(doneButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "TaskForm";
            Text = "Task !";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button doneButton;
        private Button skipButton;
        private TextBox taskInstructionValue;
        private ComboBox taskStatusDropBox;
        private Label taskStatusLabel;
        private TextBox taskFeelingValue;
        private Label taskFeelingLabel;
    }
}