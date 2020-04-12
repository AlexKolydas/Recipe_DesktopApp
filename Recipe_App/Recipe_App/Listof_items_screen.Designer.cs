namespace Recipe_App
{
    partial class Listof_items_screen
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.foodListView = new System.Windows.Forms.ListView();
            this.dropDownSelectCategory = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(853, 411);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(91, 20);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Of Recipies!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.78338F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.21662F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.foodListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.searchTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dropDownSelectCategory, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.29947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.70053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(947, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // foodListView
            // 
            this.foodListView.AllowColumnReorder = true;
            this.foodListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodListView.BackColor = System.Drawing.Color.White;
            this.foodListView.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListView.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.foodListView.FullRowSelect = true;
            this.foodListView.GridLines = true;
            this.foodListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.foodListView.HideSelection = false;
            this.foodListView.Location = new System.Drawing.Point(3, 53);
            this.foodListView.MultiSelect = false;
            this.foodListView.Name = "foodListView";
            this.foodListView.ShowItemToolTips = true;
            this.foodListView.Size = new System.Drawing.Size(825, 352);
            this.foodListView.TabIndex = 2;
            this.foodListView.UseCompatibleStateImageBehavior = false;
            this.foodListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.foodListView_MouseDoubleClick);
            // 
            // dropDownSelectCategory
            // 
            this.dropDownSelectCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dropDownSelectCategory.FormattingEnabled = true;
            this.dropDownSelectCategory.Items.AddRange(new object[] {
            "All Food",
            "Food",
            "Sweets"});
            this.dropDownSelectCategory.Location = new System.Drawing.Point(355, 434);
            this.dropDownSelectCategory.Name = "dropDownSelectCategory";
            this.dropDownSelectCategory.Size = new System.Drawing.Size(121, 21);
            this.dropDownSelectCategory.TabIndex = 5;
            this.dropDownSelectCategory.SelectedIndexChanged += new System.EventHandler(this.dropDownSelectCategory_SelectedIndexChanged);
            // 
            // Listof_items_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(953, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Listof_items_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listof_items_screen";
            this.Load += new System.EventHandler(this.Listof_items_screen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView foodListView;
        private System.Windows.Forms.ComboBox dropDownSelectCategory;
    }
}