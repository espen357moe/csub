namespace csub
{
    partial class HighscoreList
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
            this.highscore = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.points = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.avslutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highscore
            // 
            this.highscore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.highscore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.points});
            this.highscore.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.highscore.Location = new System.Drawing.Point(16, 15);
            this.highscore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(561, 346);
            this.highscore.TabIndex = 0;
            this.highscore.UseCompatibleStateImageBehavior = false;
            this.highscore.View = System.Windows.Forms.View.Details;
            this.highscore.SelectedIndexChanged += new System.EventHandler(this.highscore_SelectedIndexChanged);
            // 
            // avslutt
            // 
            this.avslutt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.avslutt.Location = new System.Drawing.Point(211, 393);
            this.avslutt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.avslutt.Name = "avslutt";
            this.avslutt.Size = new System.Drawing.Size(175, 37);
            this.avslutt.TabIndex = 1;
            this.avslutt.Text = "Avslutt";
            this.avslutt.UseVisualStyleBackColor = true;
            this.avslutt.Click += new System.EventHandler(this.avslutt_Click);
            // 
            // HighscoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 444);
            this.Controls.Add(this.avslutt);
            this.Controls.Add(this.highscore);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HighscoreList";
            this.Text = "Highscore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView highscore;
        private System.Windows.Forms.Button avslutt;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader points;
    }
}