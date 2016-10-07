namespace EFDemo
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
            this.GetCustomersInCityButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.GetProductsThatCostLessThanButton = new System.Windows.Forms.Button();
            this.TSQL = new System.Windows.Forms.TextBox();
            this.GetCustomersInCityUsingESQLButton = new System.Windows.Forms.Button();
            this.GetCustomersInCityUsingTSQLButton = new System.Windows.Forms.Button();
            this.EditorButton = new System.Windows.Forms.Button();
            this.LoadingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetCustomersInCityButton
            // 
            this.GetCustomersInCityButton.Location = new System.Drawing.Point(344, 12);
            this.GetCustomersInCityButton.Name = "GetCustomersInCityButton";
            this.GetCustomersInCityButton.Size = new System.Drawing.Size(212, 43);
            this.GetCustomersInCityButton.TabIndex = 0;
            this.GetCustomersInCityButton.Text = "Get Customers In City";
            this.GetCustomersInCityButton.UseVisualStyleBackColor = true;
            this.GetCustomersInCityButton.Click += new System.EventHandler(this.GetCustomersInCityButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 460);
            this.listBox1.TabIndex = 1;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(345, 62);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(164, 29);
            this.CityTextBox.TabIndex = 2;
            this.CityTextBox.Text = "London";
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(345, 169);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(164, 29);
            this.UnitPriceTextBox.TabIndex = 4;
            this.UnitPriceTextBox.Text = "50";
            // 
            // GetProductsThatCostLessThanButton
            // 
            this.GetProductsThatCostLessThanButton.Location = new System.Drawing.Point(344, 119);
            this.GetProductsThatCostLessThanButton.Name = "GetProductsThatCostLessThanButton";
            this.GetProductsThatCostLessThanButton.Size = new System.Drawing.Size(315, 43);
            this.GetProductsThatCostLessThanButton.TabIndex = 3;
            this.GetProductsThatCostLessThanButton.Text = "Get Products That Cost Less Than";
            this.GetProductsThatCostLessThanButton.UseVisualStyleBackColor = true;
            this.GetProductsThatCostLessThanButton.Click += new System.EventHandler(this.GetProductsThatCostLessThanButton_Click);
            // 
            // TSQL
            // 
            this.TSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSQL.Location = new System.Drawing.Point(345, 240);
            this.TSQL.Multiline = true;
            this.TSQL.Name = "TSQL";
            this.TSQL.Size = new System.Drawing.Size(565, 232);
            this.TSQL.TabIndex = 5;
            // 
            // GetCustomersInCityUsingESQLButton
            // 
            this.GetCustomersInCityUsingESQLButton.Location = new System.Drawing.Point(577, 12);
            this.GetCustomersInCityUsingESQLButton.Name = "GetCustomersInCityUsingESQLButton";
            this.GetCustomersInCityUsingESQLButton.Size = new System.Drawing.Size(333, 43);
            this.GetCustomersInCityUsingESQLButton.TabIndex = 6;
            this.GetCustomersInCityUsingESQLButton.Text = "Get Customers In City (using E-SQL)";
            this.GetCustomersInCityUsingESQLButton.UseVisualStyleBackColor = true;
            this.GetCustomersInCityUsingESQLButton.Click += new System.EventHandler(this.GetCustomersInCityUsingESQLButton_Click);
            // 
            // GetCustomersInCityUsingTSQLButton
            // 
            this.GetCustomersInCityUsingTSQLButton.Location = new System.Drawing.Point(577, 56);
            this.GetCustomersInCityUsingTSQLButton.Name = "GetCustomersInCityUsingTSQLButton";
            this.GetCustomersInCityUsingTSQLButton.Size = new System.Drawing.Size(333, 43);
            this.GetCustomersInCityUsingTSQLButton.TabIndex = 7;
            this.GetCustomersInCityUsingTSQLButton.Text = "Get Customers In City (using T-SQL)";
            this.GetCustomersInCityUsingTSQLButton.UseVisualStyleBackColor = true;
            this.GetCustomersInCityUsingTSQLButton.Click += new System.EventHandler(this.GetCustomersInCityUsingTSQLButton_Click);
            // 
            // EditorButton
            // 
            this.EditorButton.Location = new System.Drawing.Point(727, 130);
            this.EditorButton.Name = "EditorButton";
            this.EditorButton.Size = new System.Drawing.Size(152, 43);
            this.EditorButton.TabIndex = 8;
            this.EditorButton.Text = "Editor";
            this.EditorButton.UseVisualStyleBackColor = true;
            this.EditorButton.Click += new System.EventHandler(this.EditorButton_Click);
            // 
            // LoadingButton
            // 
            this.LoadingButton.Location = new System.Drawing.Point(727, 179);
            this.LoadingButton.Name = "LoadingButton";
            this.LoadingButton.Size = new System.Drawing.Size(152, 43);
            this.LoadingButton.TabIndex = 9;
            this.LoadingButton.Text = "Loading";
            this.LoadingButton.UseVisualStyleBackColor = true;
            this.LoadingButton.Click += new System.EventHandler(this.LoadingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 482);
            this.Controls.Add(this.LoadingButton);
            this.Controls.Add(this.EditorButton);
            this.Controls.Add(this.GetCustomersInCityUsingTSQLButton);
            this.Controls.Add(this.GetCustomersInCityUsingESQLButton);
            this.Controls.Add(this.TSQL);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.GetProductsThatCostLessThanButton);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GetCustomersInCityButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetCustomersInCityButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.Button GetProductsThatCostLessThanButton;
        private System.Windows.Forms.TextBox TSQL;
        private System.Windows.Forms.Button GetCustomersInCityUsingESQLButton;
        private System.Windows.Forms.Button GetCustomersInCityUsingTSQLButton;
        private System.Windows.Forms.Button EditorButton;
        private System.Windows.Forms.Button LoadingButton;
    }
}

