namespace EFDemo
{
    partial class LoadingDemos
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.LazyLoadingEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.ExplicitLoadingEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.TSQL = new System.Windows.Forms.TextBox();
            this.EagerLoadingEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(537, 460);
            this.listBox1.TabIndex = 0;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(555, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(161, 50);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // LazyLoadingEnabledCheckBox
            // 
            this.LazyLoadingEnabledCheckBox.AutoSize = true;
            this.LazyLoadingEnabledCheckBox.Location = new System.Drawing.Point(555, 86);
            this.LazyLoadingEnabledCheckBox.Name = "LazyLoadingEnabledCheckBox";
            this.LazyLoadingEnabledCheckBox.Size = new System.Drawing.Size(216, 28);
            this.LazyLoadingEnabledCheckBox.TabIndex = 2;
            this.LazyLoadingEnabledCheckBox.Text = "Lazy Loading Enabled";
            this.LazyLoadingEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExplicitLoadingEnabledCheckBox
            // 
            this.ExplicitLoadingEnabledCheckBox.AutoSize = true;
            this.ExplicitLoadingEnabledCheckBox.Location = new System.Drawing.Point(555, 120);
            this.ExplicitLoadingEnabledCheckBox.Name = "ExplicitLoadingEnabledCheckBox";
            this.ExplicitLoadingEnabledCheckBox.Size = new System.Drawing.Size(238, 28);
            this.ExplicitLoadingEnabledCheckBox.TabIndex = 3;
            this.ExplicitLoadingEnabledCheckBox.Text = "Explicit Loading Enabled";
            this.ExplicitLoadingEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // TSQL
            // 
            this.TSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TSQL.Location = new System.Drawing.Point(555, 221);
            this.TSQL.Multiline = true;
            this.TSQL.Name = "TSQL";
            this.TSQL.Size = new System.Drawing.Size(351, 249);
            this.TSQL.TabIndex = 4;
            // 
            // EagerLoadingEnabledCheckBox
            // 
            this.EagerLoadingEnabledCheckBox.AutoSize = true;
            this.EagerLoadingEnabledCheckBox.Location = new System.Drawing.Point(555, 154);
            this.EagerLoadingEnabledCheckBox.Name = "EagerLoadingEnabledCheckBox";
            this.EagerLoadingEnabledCheckBox.Size = new System.Drawing.Size(229, 28);
            this.EagerLoadingEnabledCheckBox.TabIndex = 5;
            this.EagerLoadingEnabledCheckBox.Text = "Eager Loading Enabled";
            this.EagerLoadingEnabledCheckBox.UseVisualStyleBackColor = true;
            this.EagerLoadingEnabledCheckBox.CheckedChanged += new System.EventHandler(this.EagerLoadingEnabledCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 482);
            this.Controls.Add(this.EagerLoadingEnabledCheckBox);
            this.Controls.Add(this.TSQL);
            this.Controls.Add(this.ExplicitLoadingEnabledCheckBox);
            this.Controls.Add(this.LazyLoadingEnabledCheckBox);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.CheckBox LazyLoadingEnabledCheckBox;
        private System.Windows.Forms.CheckBox ExplicitLoadingEnabledCheckBox;
        private System.Windows.Forms.TextBox TSQL;
        private System.Windows.Forms.CheckBox EagerLoadingEnabledCheckBox;
    }
}

