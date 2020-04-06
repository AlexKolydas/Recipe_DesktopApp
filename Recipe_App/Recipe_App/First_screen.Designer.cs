namespace Recipe_App
{
    partial class First_screen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.recipe_label = new System.Windows.Forms.Label();
            this.applicationLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.showlistButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.showlistButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.recipe_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.applicationLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1087, 539);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // recipe_label
            // 
            this.recipe_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recipe_label.AutoSize = true;
            this.recipe_label.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipe_label.ForeColor = System.Drawing.Color.DarkGreen;
            this.recipe_label.Location = new System.Drawing.Point(428, 50);
            this.recipe_label.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.recipe_label.Name = "recipe_label";
            this.recipe_label.Size = new System.Drawing.Size(112, 30);
            this.recipe_label.TabIndex = 0;
            this.recipe_label.Text = "Recipe";
            // 
            // applicationLabel
            // 
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.applicationLabel.Location = new System.Drawing.Point(546, 50);
            this.applicationLabel.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(185, 30);
            this.applicationLabel.TabIndex = 1;
            this.applicationLabel.Text = "Application";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(433, 272);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 55);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showlistButton
            // 
            this.showlistButton.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showlistButton.Location = new System.Drawing.Point(553, 272);
            this.showlistButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.showlistButton.Name = "showlistButton";
            this.showlistButton.Size = new System.Drawing.Size(100, 55);
            this.showlistButton.TabIndex = 3;
            this.showlistButton.Text = "Show List";
            this.showlistButton.UseVisualStyleBackColor = true;
            this.showlistButton.Click += new System.EventHandler(this.showlistButton_Click);
            // 
            // First_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1084, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "First_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipe App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label recipe_label;
        private System.Windows.Forms.Label applicationLabel;
        private System.Windows.Forms.Button showlistButton;
        private System.Windows.Forms.Button addButton;
    }
}