namespace Recipe_App
{
    partial class Add_item_screen
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addIngredientTextBox = new System.Windows.Forms.RichTextBox();
            this.addDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.dropdownCategory = new System.Windows.Forms.ComboBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.runAlwaysTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.titleTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Add Title"});
            this.titleTextBox.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.titleTextBox.Location = new System.Drawing.Point(183, 3);
            this.titleTextBox.Multiline = true;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(601, 46);
            this.titleTextBox.TabIndex = 0;
            this.titleTextBox.Text = "Add Title";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.addIngredientTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.addDescriptionTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dropdownCategory, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.addItemButton, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 72);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(968, 485);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(461, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Ingredients";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add Description";
            // 
            // addIngredientTextBox
            // 
            this.addIngredientTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addIngredientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngredientTextBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.addIngredientTextBox.Location = new System.Drawing.Point(3, 53);
            this.addIngredientTextBox.Name = "addIngredientTextBox";
            this.addIngredientTextBox.Size = new System.Drawing.Size(478, 400);
            this.addIngredientTextBox.TabIndex = 2;
            this.addIngredientTextBox.Text = "-\n-\n-\n-\n-";
            // 
            // addDescriptionTextBox
            // 
            this.addDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDescriptionTextBox.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.addDescriptionTextBox.Location = new System.Drawing.Point(487, 53);
            this.addDescriptionTextBox.Name = "addDescriptionTextBox";
            this.addDescriptionTextBox.Size = new System.Drawing.Size(478, 400);
            this.addDescriptionTextBox.TabIndex = 3;
            this.addDescriptionTextBox.Text = "";
            // 
            // dropdownCategory
            // 
            this.dropdownCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dropdownCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownCategory.FormattingEnabled = true;
            this.dropdownCategory.Location = new System.Drawing.Point(360, 461);
            this.dropdownCategory.Name = "dropdownCategory";
            this.dropdownCategory.Size = new System.Drawing.Size(121, 21);
            this.dropdownCategory.TabIndex = 4;
            this.dropdownCategory.SelectedIndexChanged += new System.EventHandler(this.dropdownCategory_SelectedIndexChanged);
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(890, 459);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 5;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // runAlwaysTimer
            // 
            this.runAlwaysTimer.Tick += new System.EventHandler(this.runAlwaysTimer_Tick);
            // 
            // Add_item_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 556);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Add_item_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_item_screen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox addIngredientTextBox;
        private System.Windows.Forms.RichTextBox addDescriptionTextBox;
        private System.Windows.Forms.ComboBox dropdownCategory;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Timer runAlwaysTimer;
    }
}