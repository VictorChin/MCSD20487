namespace LinqDemos
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
            this.varButton = new System.Windows.Forms.Button();
            this.GenericsButton = new System.Windows.Forms.Button();
            this.DelegateButton = new System.Windows.Forms.Button();
            this.LinqExtensionMethodsButton = new System.Windows.Forms.Button();
            this.LinqToEntitiesButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LinqToXmlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 460);
            this.listBox1.TabIndex = 0;
            // 
            // varButton
            // 
            this.varButton.Location = new System.Drawing.Point(366, 12);
            this.varButton.Name = "varButton";
            this.varButton.Size = new System.Drawing.Size(143, 38);
            this.varButton.TabIndex = 1;
            this.varButton.Text = "var";
            this.varButton.UseVisualStyleBackColor = true;
            this.varButton.Click += new System.EventHandler(this.varButton_Click);
            // 
            // GenericsButton
            // 
            this.GenericsButton.Location = new System.Drawing.Point(366, 56);
            this.GenericsButton.Name = "GenericsButton";
            this.GenericsButton.Size = new System.Drawing.Size(143, 38);
            this.GenericsButton.TabIndex = 2;
            this.GenericsButton.Text = "Generics";
            this.GenericsButton.UseVisualStyleBackColor = true;
            this.GenericsButton.Click += new System.EventHandler(this.GenericsButton_Click);
            // 
            // DelegateButton
            // 
            this.DelegateButton.Location = new System.Drawing.Point(366, 100);
            this.DelegateButton.Name = "DelegateButton";
            this.DelegateButton.Size = new System.Drawing.Size(143, 38);
            this.DelegateButton.TabIndex = 3;
            this.DelegateButton.Text = "Delegate";
            this.DelegateButton.UseVisualStyleBackColor = true;
            this.DelegateButton.Click += new System.EventHandler(this.DelegateButton_Click);
            // 
            // LinqExtensionMethodsButton
            // 
            this.LinqExtensionMethodsButton.Location = new System.Drawing.Point(366, 144);
            this.LinqExtensionMethodsButton.Name = "LinqExtensionMethodsButton";
            this.LinqExtensionMethodsButton.Size = new System.Drawing.Size(237, 38);
            this.LinqExtensionMethodsButton.TabIndex = 4;
            this.LinqExtensionMethodsButton.Text = "LINQ extension methods";
            this.LinqExtensionMethodsButton.UseVisualStyleBackColor = true;
            this.LinqExtensionMethodsButton.Click += new System.EventHandler(this.LinqExtensionMethodsButton_Click);
            // 
            // LinqToEntitiesButton
            // 
            this.LinqToEntitiesButton.Location = new System.Drawing.Point(366, 188);
            this.LinqToEntitiesButton.Name = "LinqToEntitiesButton";
            this.LinqToEntitiesButton.Size = new System.Drawing.Size(237, 38);
            this.LinqToEntitiesButton.TabIndex = 5;
            this.LinqToEntitiesButton.Text = "LINQ to Entities";
            this.LinqToEntitiesButton.UseVisualStyleBackColor = true;
            this.LinqToEntitiesButton.Click += new System.EventHandler(this.LinqToEntitiesButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 232);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 240);
            this.textBox1.TabIndex = 6;
            // 
            // LinqToXmlButton
            // 
            this.LinqToXmlButton.Location = new System.Drawing.Point(187, 222);
            this.LinqToXmlButton.Name = "LinqToXmlButton";
            this.LinqToXmlButton.Size = new System.Drawing.Size(237, 38);
            this.LinqToXmlButton.TabIndex = 7;
            this.LinqToXmlButton.Text = "LINQ to XML";
            this.LinqToXmlButton.UseVisualStyleBackColor = true;
            this.LinqToXmlButton.Click += new System.EventHandler(this.LinqToXmlButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 482);
            this.Controls.Add(this.LinqToXmlButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LinqToEntitiesButton);
            this.Controls.Add(this.LinqExtensionMethodsButton);
            this.Controls.Add(this.DelegateButton);
            this.Controls.Add(this.GenericsButton);
            this.Controls.Add(this.varButton);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button varButton;
        private System.Windows.Forms.Button GenericsButton;
        private System.Windows.Forms.Button DelegateButton;
        private System.Windows.Forms.Button LinqExtensionMethodsButton;
        private System.Windows.Forms.Button LinqToEntitiesButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LinqToXmlButton;
    }
}

