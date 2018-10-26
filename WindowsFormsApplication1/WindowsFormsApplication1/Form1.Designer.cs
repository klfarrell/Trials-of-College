namespace WindowsFormsApplication1
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
            this.button2 = new System.Windows.Forms.Button();
            this.gameNameText = new System.Windows.Forms.TextBox();
            this.playerNumText = new System.Windows.Forms.TextBox();
            this.statsButton = new System.Windows.Forms.Button();
            this.playerStatsText = new System.Windows.Forms.TextBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.playerNumLabel = new System.Windows.Forms.Label();
            this.playerStatsLabel = new System.Windows.Forms.Label();
            this.closeStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create New Game:";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.saveButtonClicked);
            // 
            // gameNameText
            // 
            this.gameNameText.AllowDrop = true;
            this.gameNameText.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gameNameText.Location = new System.Drawing.Point(256, 39);
            this.gameNameText.Name = "gameNameText";
            this.gameNameText.Size = new System.Drawing.Size(200, 22);
            this.gameNameText.TabIndex = 1;
            // 
            // playerNumText
            // 
            this.playerNumText.AllowDrop = true;
            this.playerNumText.Cursor = System.Windows.Forms.Cursors.Cross;
            this.playerNumText.Location = new System.Drawing.Point(256, 131);
            this.playerNumText.Name = "playerNumText";
            this.playerNumText.Size = new System.Drawing.Size(200, 22);
            this.playerNumText.TabIndex = 1;
            // 
            // statsButton
            // 
            this.statsButton.Location = new System.Drawing.Point(63, 107);
            this.statsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(141, 70);
            this.statsButton.TabIndex = 1;
            this.statsButton.Text = "View Player Stats";
            this.statsButton.UseVisualStyleBackColor = true;
            this.statsButton.Click += new System.EventHandler(this.viewPlayerStats);
            // 
            // playerStatsText
            // 
            this.playerStatsText.AllowDrop = true;
            this.playerStatsText.Cursor = System.Windows.Forms.Cursors.Cross;
            this.playerStatsText.Location = new System.Drawing.Point(490, 39);
            this.playerStatsText.Multiline = true;
            this.playerStatsText.Name = "playerStatsText";
            this.playerStatsText.Size = new System.Drawing.Size(200, 200);
            this.playerStatsText.TabIndex = 1;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.Location = new System.Drawing.Point(253, 13);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(100, 23);
            this.gameNameLabel.TabIndex = 3;
            this.gameNameLabel.Text = "Game Name:";
            // 
            // playerNumLabel
            // 
            this.playerNumLabel.Location = new System.Drawing.Point(253, 105);
            this.playerNumLabel.Name = "playerNumLabel";
            this.playerNumLabel.Size = new System.Drawing.Size(149, 23);
            this.playerNumLabel.TabIndex = 3;
            this.playerNumLabel.Text = "Number of Players:";
            // 
            // playerStatsLabel
            // 
            this.playerStatsLabel.Location = new System.Drawing.Point(487, 13);
            this.playerStatsLabel.Name = "playerStatsLabel";
            this.playerStatsLabel.Size = new System.Drawing.Size(100, 23);
            this.playerStatsLabel.TabIndex = 2;
            this.playerStatsLabel.Text = "Player Stats:";
            // 
            // closeStats
            // 
            this.closeStats.Location = new System.Drawing.Point(63, 193);
            this.closeStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeStats.Name = "closeStats";
            this.closeStats.Size = new System.Drawing.Size(141, 70);
            this.closeStats.TabIndex = 1;
            this.closeStats.Text = "Close Stats";
            this.closeStats.UseVisualStyleBackColor = true;
            this.closeStats.Click += new System.EventHandler(this.closeStatsClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gameNameText);
            this.Controls.Add(this.playerNumText);
            this.Controls.Add(this.statsButton);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.playerNumLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "The Trials of College: A Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.TextBox gameNameText;
        private System.Windows.Forms.TextBox playerStatsText;
        private System.Windows.Forms.TextBox playerNumText;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Label playerNumLabel;
        private System.Windows.Forms.Label playerStatsLabel;
        private System.Windows.Forms.Button closeStats;
    }
}

