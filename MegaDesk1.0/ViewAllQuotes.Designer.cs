namespace MegaDesk1._0
{
    partial class ViewAllQuotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.backQuoteButton = new System.Windows.Forms.Button();
            this.viewQueryButton = new System.Windows.Forms.Button();
            this.displayRecords = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mega Desk View Quotes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backQuoteButton
            // 
            this.backQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backQuoteButton.Location = new System.Drawing.Point(12, 400);
            this.backQuoteButton.Name = "backQuoteButton";
            this.backQuoteButton.Size = new System.Drawing.Size(121, 38);
            this.backQuoteButton.TabIndex = 8;
            this.backQuoteButton.Text = "<- Main Menu";
            this.backQuoteButton.UseVisualStyleBackColor = true;
            this.backQuoteButton.Click += new System.EventHandler(this.BackQuoteButton_Click);
            // 
            // viewQueryButton
            // 
            this.viewQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQueryButton.Location = new System.Drawing.Point(310, 401);
            this.viewQueryButton.Name = "viewQueryButton";
            this.viewQueryButton.Size = new System.Drawing.Size(151, 37);
            this.viewQueryButton.TabIndex = 9;
            this.viewQueryButton.Text = "Load Queries";
            this.viewQueryButton.UseVisualStyleBackColor = true;
            this.viewQueryButton.Click += new System.EventHandler(this.ViewQueryButton_Click);
            // 
            // displayRecords
            // 
            this.displayRecords.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.displayRecords.Location = new System.Drawing.Point(12, 82);
            this.displayRecords.Multiline = true;
            this.displayRecords.Name = "displayRecords";
            this.displayRecords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayRecords.Size = new System.Drawing.Size(810, 282);
            this.displayRecords.TabIndex = 10;
            this.displayRecords.TextChanged += new System.EventHandler(this.DisplayRecords_TextChanged);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.displayRecords);
            this.Controls.Add(this.viewQueryButton);
            this.Controls.Add(this.backQuoteButton);
            this.Controls.Add(this.label1);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backQuoteButton;
        private System.Windows.Forms.Button viewQueryButton;
        private System.Windows.Forms.TextBox displayRecords;
    }
}