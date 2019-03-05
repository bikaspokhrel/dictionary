namespace dictionary
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
            this.btnLoadWords = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInputWord = new System.Windows.Forms.TextBox();
            this.lbxWords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnLoadWords
            // 
            this.btnLoadWords.Location = new System.Drawing.Point(103, 47);
            this.btnLoadWords.Name = "btnLoadWords";
            this.btnLoadWords.Size = new System.Drawing.Size(117, 76);
            this.btnLoadWords.TabIndex = 0;
            this.btnLoadWords.Text = "Load Words";
            this.btnLoadWords.UseVisualStyleBackColor = true;
            this.btnLoadWords.Click += new System.EventHandler(this.btnLoadWords_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(103, 211);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(194, 68);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(103, 137);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(167, 22);
            this.txtInputWord.TabIndex = 2;
            // 
            // lbxWords
            // 
            this.lbxWords.FormattingEnabled = true;
            this.lbxWords.ItemHeight = 16;
            this.lbxWords.Location = new System.Drawing.Point(487, 34);
            this.lbxWords.Name = "lbxWords";
            this.lbxWords.Size = new System.Drawing.Size(260, 324);
            this.lbxWords.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxWords);
            this.Controls.Add(this.txtInputWord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLoadWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadWords;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.ListBox lbxWords;
    }
}

