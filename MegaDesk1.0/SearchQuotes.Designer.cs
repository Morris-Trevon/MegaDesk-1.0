namespace MegaDesk1._0
{
    partial class SearchQuotes
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
            this.backQuoteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchResults = new System.Windows.Forms.TextBox();
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backQuoteButton
            // 
            this.backQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backQuoteButton.Location = new System.Drawing.Point(12, 400);
            this.backQuoteButton.Name = "backQuoteButton";
            this.backQuoteButton.Size = new System.Drawing.Size(121, 38);
            this.backQuoteButton.TabIndex = 9;
            this.backQuoteButton.Text = "<- Main Menu";
            this.backQuoteButton.UseVisualStyleBackColor = true;
            this.backQuoteButton.Click += new System.EventHandler(this.BackQuoteButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mega Desk Search Quotes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchResults
            // 
            this.searchResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchResults.Location = new System.Drawing.Point(38, 144);
            this.searchResults.Multiline = true;
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(722, 222);
            this.searchResults.TabIndex = 11;
            // 
            // searchQuery
            // 
            this.searchQuery.Location = new System.Drawing.Point(212, 101);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(156, 20);
            this.searchQuery.TabIndex = 12;
            this.searchQuery.TextChanged += new System.EventHandler(this.SearchQuery_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search For Material:";
            // 
            // submitSearch
            // 
            this.submitSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitSearch.Location = new System.Drawing.Point(390, 100);
            this.submitSearch.Name = "submitSearch";
            this.submitSearch.Size = new System.Drawing.Size(75, 23);
            this.submitSearch.TabIndex = 14;
            this.submitSearch.Text = "Submit";
            this.submitSearch.UseVisualStyleBackColor = true;
            this.submitSearch.Click += new System.EventHandler(this.SubmitSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(40, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Oak, Rosewood, Veneer, Laminate, and Pine";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchQuery);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backQuoteButton);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchAllQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backQuoteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchResults;
        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitSearch;
        private System.Windows.Forms.Label label3;
    }
}