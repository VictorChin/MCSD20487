namespace C6.ClientUsingWcfDataServices
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GetExpensiveProductsButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.LoadingCategoriesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExplicitlyLoadCheckBox = new System.Windows.Forms.CheckBox();
            this.EagerlyLoadCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.SendingRequestEvents = new System.Windows.Forms.ListBox();
            this.ODataUriTextBox = new System.Windows.Forms.TextBox();
            this.ClearEventsButton = new System.Windows.Forms.Button();
            this.ClearObjectsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(15, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 460);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(402, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "45";
            // 
            // GetExpensiveProductsButton
            // 
            this.GetExpensiveProductsButton.Location = new System.Drawing.Point(512, 9);
            this.GetExpensiveProductsButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GetExpensiveProductsButton.Name = "GetExpensiveProductsButton";
            this.GetExpensiveProductsButton.Size = new System.Drawing.Size(243, 42);
            this.GetExpensiveProductsButton.TabIndex = 2;
            this.GetExpensiveProductsButton.Text = "Get Expensive Products";
            this.GetExpensiveProductsButton.UseVisualStyleBackColor = true;
            this.GetExpensiveProductsButton.Click += new System.EventHandler(this.GetExpensiveProductsButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(306, 74);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(138, 42);
            this.AddProductButton.TabIndex = 4;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // LoadingCategoriesButton
            // 
            this.LoadingCategoriesButton.Location = new System.Drawing.Point(306, 145);
            this.LoadingCategoriesButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoadingCategoriesButton.Name = "LoadingCategoriesButton";
            this.LoadingCategoriesButton.Size = new System.Drawing.Size(199, 42);
            this.LoadingCategoriesButton.TabIndex = 5;
            this.LoadingCategoriesButton.Text = "Loading Categories";
            this.LoadingCategoriesButton.UseVisualStyleBackColor = true;
            this.LoadingCategoriesButton.Click += new System.EventHandler(this.LoadingCategoriesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unit Price";
            // 
            // ExplicitlyLoadCheckBox
            // 
            this.ExplicitlyLoadCheckBox.AutoSize = true;
            this.ExplicitlyLoadCheckBox.Location = new System.Drawing.Point(306, 197);
            this.ExplicitlyLoadCheckBox.Name = "ExplicitlyLoadCheckBox";
            this.ExplicitlyLoadCheckBox.Size = new System.Drawing.Size(155, 28);
            this.ExplicitlyLoadCheckBox.TabIndex = 7;
            this.ExplicitlyLoadCheckBox.Text = "Explictly Load?";
            this.ExplicitlyLoadCheckBox.UseVisualStyleBackColor = true;
            // 
            // EagerlyLoadCheckBox
            // 
            this.EagerlyLoadCheckBox.AutoSize = true;
            this.EagerlyLoadCheckBox.Location = new System.Drawing.Point(306, 231);
            this.EagerlyLoadCheckBox.Name = "EagerlyLoadCheckBox";
            this.EagerlyLoadCheckBox.Size = new System.Drawing.Size(150, 28);
            this.EagerlyLoadCheckBox.TabIndex = 8;
            this.EagerlyLoadCheckBox.Text = "Eagerly Load?";
            this.EagerlyLoadCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(456, 80);
            this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ProductNameTextBox.MaxLength = 40;
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(169, 29);
            this.ProductNameTextBox.TabIndex = 9;
            this.ProductNameTextBox.Text = "new product";
            // 
            // SendingRequestEvents
            // 
            this.SendingRequestEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendingRequestEvents.FormattingEnabled = true;
            this.SendingRequestEvents.ItemHeight = 16;
            this.SendingRequestEvents.Location = new System.Drawing.Point(305, 268);
            this.SendingRequestEvents.Margin = new System.Windows.Forms.Padding(6);
            this.SendingRequestEvents.Name = "SendingRequestEvents";
            this.SendingRequestEvents.Size = new System.Drawing.Size(449, 100);
            this.SendingRequestEvents.TabIndex = 10;
            this.SendingRequestEvents.SelectedIndexChanged += new System.EventHandler(this.SendingRequestEvents_SelectedIndexChanged);
            // 
            // ODataUriTextBox
            // 
            this.ODataUriTextBox.Location = new System.Drawing.Point(305, 377);
            this.ODataUriTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ODataUriTextBox.Multiline = true;
            this.ODataUriTextBox.Name = "ODataUriTextBox";
            this.ODataUriTextBox.ReadOnly = true;
            this.ODataUriTextBox.Size = new System.Drawing.Size(449, 90);
            this.ODataUriTextBox.TabIndex = 3;
            // 
            // ClearEventsButton
            // 
            this.ClearEventsButton.Location = new System.Drawing.Point(617, 223);
            this.ClearEventsButton.Margin = new System.Windows.Forms.Padding(6);
            this.ClearEventsButton.Name = "ClearEventsButton";
            this.ClearEventsButton.Size = new System.Drawing.Size(138, 42);
            this.ClearEventsButton.TabIndex = 11;
            this.ClearEventsButton.Text = "Clear Events";
            this.ClearEventsButton.UseVisualStyleBackColor = true;
            this.ClearEventsButton.Click += new System.EventHandler(this.ClearEventsButton_Click);
            // 
            // ClearObjectsButton
            // 
            this.ClearObjectsButton.Location = new System.Drawing.Point(617, 169);
            this.ClearObjectsButton.Margin = new System.Windows.Forms.Padding(6);
            this.ClearObjectsButton.Name = "ClearObjectsButton";
            this.ClearObjectsButton.Size = new System.Drawing.Size(138, 42);
            this.ClearObjectsButton.TabIndex = 12;
            this.ClearObjectsButton.Text = "Clear Objects";
            this.ClearObjectsButton.UseVisualStyleBackColor = true;
            this.ClearObjectsButton.Click += new System.EventHandler(this.ClearObjectsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 482);
            this.Controls.Add(this.ClearObjectsButton);
            this.Controls.Add(this.ClearEventsButton);
            this.Controls.Add(this.SendingRequestEvents);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.EagerlyLoadCheckBox);
            this.Controls.Add(this.ExplicitlyLoadCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadingCategoriesButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ODataUriTextBox);
            this.Controls.Add(this.GetExpensiveProductsButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GetExpensiveProductsButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button LoadingCategoriesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ExplicitlyLoadCheckBox;
        private System.Windows.Forms.CheckBox EagerlyLoadCheckBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.ListBox SendingRequestEvents;
        private System.Windows.Forms.TextBox ODataUriTextBox;
        private System.Windows.Forms.Button ClearEventsButton;
        private System.Windows.Forms.Button ClearObjectsButton;
    }
}

