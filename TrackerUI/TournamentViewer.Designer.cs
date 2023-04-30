namespace TrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderLabel = new Label();
            tournamentNameLabel = new Label();
            roundLabel = new Label();
            RondDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            MatchupListBox = new ListBox();
            teamOneNameLabel = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreText = new TextBox();
            teamTwoScoreText = new TextBox();
            teanmTwoScoreLabel = new Label();
            teamTwoNameLabel = new Label();
            VsLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = SystemColors.MenuHighlight;
            HeaderLabel.Location = new Point(13, 11);
            HeaderLabel.Margin = new Padding(4, 0, 4, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(214, 50);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(235, 11);
            tournamentNameLabel.Margin = new Padding(4, 0, 4, 0);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(150, 50);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "<none>";
            tournamentNameLabel.Click += label1_Click_1;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(24, 101);
            roundLabel.Margin = new Padding(4, 0, 4, 0);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // RondDropDown
            // 
            RondDropDown.FormattingEnabled = true;
            RondDropDown.Location = new Point(125, 93);
            RondDropDown.Name = "RondDropDown";
            RondDropDown.Size = new Size(255, 45);
            RondDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.Location = new Point(125, 155);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(209, 41);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            MatchupListBox.BorderStyle = BorderStyle.FixedSingle;
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.ItemHeight = 37;
            MatchupListBox.Location = new Point(25, 226);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(388, 335);
            MatchupListBox.TabIndex = 5;
            // 
            // teamOneNameLabel
            // 
            teamOneNameLabel.AutoSize = true;
            teamOneNameLabel.Location = new Point(443, 226);
            teamOneNameLabel.Margin = new Padding(4, 0, 4, 0);
            teamOneNameLabel.Name = "teamOneNameLabel";
            teamOneNameLabel.Size = new Size(141, 37);
            teamOneNameLabel.TabIndex = 6;
            teamOneNameLabel.Text = "Team One:";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(443, 288);
            teamOneScoreLabel.Margin = new Padding(4, 0, 4, 0);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(88, 37);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score:";
            // 
            // teamOneScoreText
            // 
            teamOneScoreText.Location = new Point(528, 282);
            teamOneScoreText.Name = "teamOneScoreText";
            teamOneScoreText.Size = new Size(131, 43);
            teamOneScoreText.TabIndex = 8;
            // 
            // teamTwoScoreText
            // 
            teamTwoScoreText.Location = new Point(528, 479);
            teamTwoScoreText.Name = "teamTwoScoreText";
            teamTwoScoreText.Size = new Size(131, 43);
            teamTwoScoreText.TabIndex = 11;
            // 
            // teanmTwoScoreLabel
            // 
            teanmTwoScoreLabel.AutoSize = true;
            teanmTwoScoreLabel.Location = new Point(443, 485);
            teanmTwoScoreLabel.Margin = new Padding(4, 0, 4, 0);
            teanmTwoScoreLabel.Name = "teanmTwoScoreLabel";
            teanmTwoScoreLabel.Size = new Size(88, 37);
            teanmTwoScoreLabel.TabIndex = 10;
            teanmTwoScoreLabel.Text = "Score:";
            // 
            // teamTwoNameLabel
            // 
            teamTwoNameLabel.AutoSize = true;
            teamTwoNameLabel.Location = new Point(443, 423);
            teamTwoNameLabel.Margin = new Padding(4, 0, 4, 0);
            teamTwoNameLabel.Name = "teamTwoNameLabel";
            teamTwoNameLabel.Size = new Size(141, 37);
            teamTwoNameLabel.TabIndex = 9;
            teamTwoNameLabel.Text = "Team Two:";
            // 
            // VsLabel
            // 
            VsLabel.AutoSize = true;
            VsLabel.Location = new Point(493, 365);
            VsLabel.Margin = new Padding(4, 0, 4, 0);
            VsLabel.Name = "VsLabel";
            VsLabel.Size = new Size(77, 37);
            VsLabel.TabIndex = 12;
            VsLabel.Text = "~vs~";
            VsLabel.Click += label1_Click_2;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.Location = new Point(696, 365);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(133, 51);
            scoreButton.TabIndex = 14;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 604);
            Controls.Add(scoreButton);
            Controls.Add(VsLabel);
            Controls.Add(teamTwoScoreText);
            Controls.Add(teanmTwoScoreLabel);
            Controls.Add(teamTwoNameLabel);
            Controls.Add(teamOneScoreText);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneNameLabel);
            Controls.Add(MatchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(RondDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(6, 7, 6, 7);
            Name = "TournamentViewer";
            Text = "Tournament Viewer";
            Load += TournamentViewer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label tournamentNameLabel;
        private Label roundLabel;
        private ComboBox RondDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox MatchupListBox;
        private Label teamOneNameLabel;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreText;
        private TextBox teamTwoScoreText;
        private Label teanmTwoScoreLabel;
        private Label teamTwoNameLabel;
        private Label VsLabel;
        private Button scoreButton;
    }
}