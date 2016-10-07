namespace C1.ClientUsingServiceReference
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
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.EndpointsComboBox = new System.Windows.Forms.ComboBox();
            this.EndpointTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.StateLabel = new System.Windows.Forms.Label();
            this.SayHelloTextBox = new System.Windows.Forms.TextBox();
            this.SayHelloButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(12, 148);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(100, 29);
            this.ATextBox.TabIndex = 5;
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(118, 148);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(100, 29);
            this.BTextBox.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 183);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 36);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(118, 183);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(100, 36);
            this.MultiplyButton.TabIndex = 9;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(224, 151);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(79, 24);
            this.AnswerLabel.TabIndex = 7;
            this.AnswerLabel.Text = "Answer:";
            // 
            // EndpointsComboBox
            // 
            this.EndpointsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndpointsComboBox.FormattingEnabled = true;
            this.EndpointsComboBox.Location = new System.Drawing.Point(12, 38);
            this.EndpointsComboBox.Name = "EndpointsComboBox";
            this.EndpointsComboBox.Size = new System.Drawing.Size(171, 32);
            this.EndpointsComboBox.TabIndex = 1;
            this.EndpointsComboBox.SelectedIndexChanged += new System.EventHandler(this.EndpointsComboBox_SelectedIndexChanged);
            // 
            // EndpointTextBox
            // 
            this.EndpointTextBox.Location = new System.Drawing.Point(12, 76);
            this.EndpointTextBox.Name = "EndpointTextBox";
            this.EndpointTextBox.ReadOnly = true;
            this.EndpointTextBox.Size = new System.Drawing.Size(387, 29);
            this.EndpointTextBox.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(295, 34);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 36);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(189, 35);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(100, 36);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(12, 9);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(120, 24);
            this.StateLabel.TabIndex = 0;
            this.StateLabel.Text = "State: Closed";
            // 
            // SayHelloTextBox
            // 
            this.SayHelloTextBox.Location = new System.Drawing.Point(12, 227);
            this.SayHelloTextBox.Name = "SayHelloTextBox";
            this.SayHelloTextBox.ReadOnly = true;
            this.SayHelloTextBox.Size = new System.Drawing.Size(387, 29);
            this.SayHelloTextBox.TabIndex = 11;
            // 
            // SayHelloButton
            // 
            this.SayHelloButton.Location = new System.Drawing.Point(224, 183);
            this.SayHelloButton.Name = "SayHelloButton";
            this.SayHelloButton.Size = new System.Drawing.Size(100, 36);
            this.SayHelloButton.TabIndex = 10;
            this.SayHelloButton.Text = "Say Hello";
            this.SayHelloButton.UseVisualStyleBackColor = true;
            this.SayHelloButton.Click += new System.EventHandler(this.SayHelloButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 268);
            this.Controls.Add(this.SayHelloButton);
            this.Controls.Add(this.SayHelloTextBox);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.EndpointTextBox);
            this.Controls.Add(this.EndpointsComboBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.ATextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.ComboBox EndpointsComboBox;
        private System.Windows.Forms.TextBox EndpointTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.TextBox SayHelloTextBox;
        private System.Windows.Forms.Button SayHelloButton;
    }
}

