namespace PcShutdownUI
{
    partial class Form1
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
            InitialiseShutdownButton = new Button();
            AbbordShutdownButton = new Button();
            MinutesTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // InitialiseShutdownButton
            // 
            InitialiseShutdownButton.Location = new Point(30, 101);
            InitialiseShutdownButton.Name = "InitialiseShutdownButton";
            InitialiseShutdownButton.Size = new Size(123, 23);
            InitialiseShutdownButton.TabIndex = 0;
            InitialiseShutdownButton.Text = "Initialise Shutdown";
            InitialiseShutdownButton.UseVisualStyleBackColor = true;
            InitialiseShutdownButton.MouseClick += InitialiseShutdownButton_MouseClick;
            // 
            // AbbordShutdownButton
            // 
            AbbordShutdownButton.Location = new Point(167, 101);
            AbbordShutdownButton.Name = "AbbordShutdownButton";
            AbbordShutdownButton.Size = new Size(75, 23);
            AbbordShutdownButton.TabIndex = 1;
            AbbordShutdownButton.Text = "Abbort";
            AbbordShutdownButton.UseVisualStyleBackColor = true;
            AbbordShutdownButton.MouseClick += AbbordShutdownButton_MouseClick;
            // 
            // MinutesTextBox
            // 
            MinutesTextBox.Location = new Point(124, 35);
            MinutesTextBox.MaxLength = 3;
            MinutesTextBox.Name = "MinutesTextBox";
            MinutesTextBox.Size = new Size(100, 23);
            MinutesTextBox.TabIndex = 2;
            MinutesTextBox.Text = "30";
            MinutesTextBox.KeyPress += MinutesTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 40);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "Minutes:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 190);
            Controls.Add(label1);
            Controls.Add(MinutesTextBox);
            Controls.Add(AbbordShutdownButton);
            Controls.Add(InitialiseShutdownButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "PCShutdownUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InitialiseShutdownButton;
        private Button AbbordShutdownButton;
        private TextBox MinutesTextBox;
        private Label label1;
    }
}
