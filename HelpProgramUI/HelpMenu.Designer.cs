namespace HelpProgramUI
{
    partial class HelpMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newUpdateButton = new Button();
            viewUpdatesButton = new Button();
            generateTaskButton = new Button();
            SuspendLayout();
            // 
            // newUpdateButton
            // 
            newUpdateButton.BackColor = Color.MistyRose;
            newUpdateButton.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            newUpdateButton.Location = new Point(32, 32);
            newUpdateButton.Margin = new Padding(4, 4, 4, 4);
            newUpdateButton.Name = "newUpdateButton";
            newUpdateButton.Size = new Size(655, 70);
            newUpdateButton.TabIndex = 0;
            newUpdateButton.Text = "New Diary Entry";
            newUpdateButton.UseVisualStyleBackColor = false;
            // 
            // viewUpdatesButton
            // 
            viewUpdatesButton.BackColor = Color.MistyRose;
            viewUpdatesButton.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            viewUpdatesButton.Location = new Point(32, 138);
            viewUpdatesButton.Margin = new Padding(4);
            viewUpdatesButton.Name = "viewUpdatesButton";
            viewUpdatesButton.Size = new Size(655, 70);
            viewUpdatesButton.TabIndex = 1;
            viewUpdatesButton.Text = "View Entries";
            viewUpdatesButton.UseVisualStyleBackColor = false;
            // 
            // generateTaskButton
            // 
            generateTaskButton.BackColor = Color.MistyRose;
            generateTaskButton.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            generateTaskButton.Location = new Point(32, 244);
            generateTaskButton.Margin = new Padding(4);
            generateTaskButton.Name = "generateTaskButton";
            generateTaskButton.Size = new Size(655, 70);
            generateTaskButton.TabIndex = 2;
            generateTaskButton.Text = "Generate a Task";
            generateTaskButton.UseVisualStyleBackColor = false;
            // 
            // HelpMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(745, 386);
            Controls.Add(generateTaskButton);
            Controls.Add(viewUpdatesButton);
            Controls.Add(newUpdateButton);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "HelpMenu";
            Text = "Self Help Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button newUpdateButton;
        private Button viewUpdatesButton;
        private Button generateTaskButton;
    }
}