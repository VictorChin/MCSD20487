namespace Exercise06_ClientUsingWsdl
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
            this.NamesListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.TotalCharsButton = new System.Windows.Forms.Button();
            this.CharsLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.FactorialButton = new System.Windows.Forms.Button();
            this.FactorialLabel = new System.Windows.Forms.Label();
            this.PersonNameTextBox = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.HowManyDaysOldButton = new System.Windows.Forms.Button();
            this.DaysOldLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NamesListBox
            // 
            this.NamesListBox.FormattingEnabled = true;
            this.NamesListBox.ItemHeight = 24;
            this.NamesListBox.Items.AddRange(new object[] {
            "Alice",
            "Bob",
            "Charlie"});
            this.NamesListBox.Location = new System.Drawing.Point(12, 12);
            this.NamesListBox.Name = "NamesListBox";
            this.NamesListBox.Size = new System.Drawing.Size(214, 148);
            this.NamesListBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 166);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(214, 29);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Text = "Dave";
            // 
            // AddToListButton
            // 
            this.AddToListButton.Location = new System.Drawing.Point(12, 201);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(113, 38);
            this.AddToListButton.TabIndex = 2;
            this.AddToListButton.Text = "Add to List";
            this.AddToListButton.UseVisualStyleBackColor = true;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // TotalCharsButton
            // 
            this.TotalCharsButton.Location = new System.Drawing.Point(12, 245);
            this.TotalCharsButton.Name = "TotalCharsButton";
            this.TotalCharsButton.Size = new System.Drawing.Size(214, 40);
            this.TotalCharsButton.TabIndex = 3;
            this.TotalCharsButton.Text = "How many characters?";
            this.TotalCharsButton.UseVisualStyleBackColor = true;
            this.TotalCharsButton.Click += new System.EventHandler(this.TotalCharsButton_Click);
            // 
            // CharsLabel
            // 
            this.CharsLabel.AutoSize = true;
            this.CharsLabel.Location = new System.Drawing.Point(12, 295);
            this.CharsLabel.Name = "CharsLabel";
            this.CharsLabel.Size = new System.Drawing.Size(412, 24);
            this.CharsLabel.TabIndex = 4;
            this.CharsLabel.Text = "There are 15 total characters in the list of names.";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(131, 201);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(95, 38);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(267, 12);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(46, 29);
            this.NumberTextBox.TabIndex = 6;
            this.NumberTextBox.Text = "5";
            // 
            // FactorialButton
            // 
            this.FactorialButton.Location = new System.Drawing.Point(267, 48);
            this.FactorialButton.Name = "FactorialButton";
            this.FactorialButton.Size = new System.Drawing.Size(107, 38);
            this.FactorialButton.TabIndex = 7;
            this.FactorialButton.Text = "Factorial";
            this.FactorialButton.UseVisualStyleBackColor = true;
            this.FactorialButton.Click += new System.EventHandler(this.FactorialButton_Click);
            // 
            // FactorialLabel
            // 
            this.FactorialLabel.AutoSize = true;
            this.FactorialLabel.Location = new System.Drawing.Point(267, 93);
            this.FactorialLabel.Name = "FactorialLabel";
            this.FactorialLabel.Size = new System.Drawing.Size(205, 24);
            this.FactorialLabel.TabIndex = 8;
            this.FactorialLabel.Text = "The factorial of 5 is 120.";
            // 
            // PersonNameTextBox
            // 
            this.PersonNameTextBox.Location = new System.Drawing.Point(535, 12);
            this.PersonNameTextBox.Name = "PersonNameTextBox";
            this.PersonNameTextBox.Size = new System.Drawing.Size(100, 29);
            this.PersonNameTextBox.TabIndex = 9;
            this.PersonNameTextBox.Text = "Bob";
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(535, 47);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(204, 29);
            this.DOB.TabIndex = 10;
            // 
            // HowManyDaysOldButton
            // 
            this.HowManyDaysOldButton.Location = new System.Drawing.Point(535, 82);
            this.HowManyDaysOldButton.Name = "HowManyDaysOldButton";
            this.HowManyDaysOldButton.Size = new System.Drawing.Size(204, 35);
            this.HowManyDaysOldButton.TabIndex = 11;
            this.HowManyDaysOldButton.Text = "How many days old?";
            this.HowManyDaysOldButton.UseVisualStyleBackColor = true;
            this.HowManyDaysOldButton.Click += new System.EventHandler(this.HowManyDaysOldButton_Click);
            // 
            // DaysOldLabel
            // 
            this.DaysOldLabel.AutoSize = true;
            this.DaysOldLabel.Location = new System.Drawing.Point(541, 127);
            this.DaysOldLabel.Name = "DaysOldLabel";
            this.DaysOldLabel.Size = new System.Drawing.Size(157, 24);
            this.DaysOldLabel.TabIndex = 12;
            this.DaysOldLabel.Text = "Bob is 0 days old.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 335);
            this.Controls.Add(this.DaysOldLabel);
            this.Controls.Add(this.HowManyDaysOldButton);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.PersonNameTextBox);
            this.Controls.Add(this.FactorialLabel);
            this.Controls.Add(this.FactorialButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.CharsLabel);
            this.Controls.Add(this.TotalCharsButton);
            this.Controls.Add(this.AddToListButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NamesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Client to WCF Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NamesListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddToListButton;
        private System.Windows.Forms.Button TotalCharsButton;
        private System.Windows.Forms.Label CharsLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button FactorialButton;
        private System.Windows.Forms.Label FactorialLabel;
        private System.Windows.Forms.TextBox PersonNameTextBox;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Button HowManyDaysOldButton;
        private System.Windows.Forms.Label DaysOldLabel;
    }
}

