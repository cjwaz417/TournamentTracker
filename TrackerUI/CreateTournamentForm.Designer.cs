namespace TrackerUI
{
    partial class CreateTournamentForm
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
            HeaderLabel = new Label();
            TournamentNameValue = new TextBox();
            TournamentNameLabel = new Label();
            entryFeeText = new TextBox();
            entryFeeLabel = new Label();
            AddTeamDropDown = new ComboBox();
            addTeamLabel = new Label();
            CreateNewTeamLink = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeButton = new Button();
            TournamentPlayersListBox = new ListBox();
            TournamentPlayersLabel = new Label();
            DeleteSelectedPlayersButton = new Button();
            DeleteSelectedPrizeButton = new Button();
            PrizesLabel = new Label();
            PrizesListBox = new ListBox();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = SystemColors.MenuHighlight;
            HeaderLabel.Location = new Point(4, 19);
            HeaderLabel.Margin = new Padding(4, 0, 4, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(317, 50);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            TournamentNameValue.Location = new Point(33, 122);
            TournamentNameValue.Name = "TournamentNameValue";
            TournamentNameValue.Size = new Size(297, 35);
            TournamentNameValue.TabIndex = 10;
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Location = new Point(33, 78);
            TournamentNameLabel.Margin = new Padding(4, 0, 4, 0);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(186, 30);
            TournamentNameLabel.TabIndex = 9;
            TournamentNameLabel.Text = "Tournament Name";
            TournamentNameLabel.Click += teamOneScoreLabel_Click;
            // 
            // entryFeeText
            // 
            entryFeeText.Location = new Point(143, 187);
            entryFeeText.Name = "entryFeeText";
            entryFeeText.Size = new Size(105, 35);
            entryFeeText.TabIndex = 12;
            entryFeeText.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Location = new Point(33, 187);
            entryFeeLabel.Margin = new Padding(4, 0, 4, 0);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(103, 30);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee:";
            // 
            // AddTeamDropDown
            // 
            AddTeamDropDown.FormattingEnabled = true;
            AddTeamDropDown.Location = new Point(33, 297);
            AddTeamDropDown.Name = "AddTeamDropDown";
            AddTeamDropDown.Size = new Size(297, 38);
            AddTeamDropDown.TabIndex = 14;
            AddTeamDropDown.SelectedIndexChanged += RondDropDown_SelectedIndexChanged;
            // 
            // addTeamLabel
            // 
            addTeamLabel.AutoSize = true;
            addTeamLabel.Location = new Point(33, 260);
            addTeamLabel.Margin = new Padding(4, 0, 4, 0);
            addTeamLabel.Name = "addTeamLabel";
            addTeamLabel.Size = new Size(123, 30);
            addTeamLabel.TabIndex = 13;
            addTeamLabel.Text = "Select Team";
            addTeamLabel.Click += addTeamLabel_Click;
            // 
            // CreateNewTeamLink
            // 
            CreateNewTeamLink.AutoSize = true;
            CreateNewTeamLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateNewTeamLink.Location = new Point(199, 269);
            CreateNewTeamLink.Name = "CreateNewTeamLink";
            CreateNewTeamLink.Size = new Size(131, 21);
            CreateNewTeamLink.TabIndex = 15;
            CreateNewTeamLink.TabStop = true;
            CreateNewTeamLink.Text = "Create New Team";
            // 
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AddTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddTeamButton.FlatStyle = FlatStyle.Flat;
            AddTeamButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddTeamButton.Location = new Point(86, 341);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(191, 44);
            AddTeamButton.TabIndex = 16;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            AddTeamButton.Click += AddTeamButton_Click;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreatePrizeButton.Location = new Point(86, 429);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(191, 44);
            CreatePrizeButton.TabIndex = 17;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            TournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentPlayersListBox.FormattingEnabled = true;
            TournamentPlayersListBox.ItemHeight = 30;
            TournamentPlayersListBox.Location = new Point(384, 126);
            TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            TournamentPlayersListBox.Size = new Size(346, 152);
            TournamentPlayersListBox.TabIndex = 18;
            // 
            // TournamentPlayersLabel
            // 
            TournamentPlayersLabel.AutoSize = true;
            TournamentPlayersLabel.Location = new Point(384, 89);
            TournamentPlayersLabel.Margin = new Padding(4, 0, 4, 0);
            TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            TournamentPlayersLabel.Size = new Size(135, 30);
            TournamentPlayersLabel.TabIndex = 19;
            TournamentPlayersLabel.Text = "Team/Players";
            // 
            // DeleteSelectedPlayersButton
            // 
            DeleteSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteSelectedPlayersButton.Location = new Point(747, 153);
            DeleteSelectedPlayersButton.Name = "DeleteSelectedPlayersButton";
            DeleteSelectedPlayersButton.Size = new Size(143, 98);
            DeleteSelectedPlayersButton.TabIndex = 20;
            DeleteSelectedPlayersButton.Text = "Delete Selected";
            DeleteSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            DeleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteSelectedPrizeButton.Location = new Point(747, 397);
            DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            DeleteSelectedPrizeButton.Size = new Size(138, 109);
            DeleteSelectedPrizeButton.TabIndex = 23;
            DeleteSelectedPrizeButton.Text = "Delete Selected";
            DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Location = new Point(384, 328);
            PrizesLabel.Margin = new Padding(4, 0, 4, 0);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(197, 30);
            PrizesLabel.TabIndex = 22;
            PrizesLabel.Text = "Tournament/Players";
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 30;
            PrizesListBox.Location = new Point(384, 365);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(346, 152);
            PrizesListBox.TabIndex = 21;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTournamentButton.Location = new Point(305, 574);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(276, 85);
            CreateTournamentButton.TabIndex = 24;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(962, 753);
            Controls.Add(CreateTournamentButton);
            Controls.Add(DeleteSelectedPrizeButton);
            Controls.Add(PrizesLabel);
            Controls.Add(PrizesListBox);
            Controls.Add(DeleteSelectedPlayersButton);
            Controls.Add(TournamentPlayersLabel);
            Controls.Add(TournamentPlayersListBox);
            Controls.Add(CreatePrizeButton);
            Controls.Add(AddTeamButton);
            Controls.Add(CreateNewTeamLink);
            Controls.Add(AddTeamDropDown);
            Controls.Add(addTeamLabel);
            Controls.Add(entryFeeText);
            Controls.Add(entryFeeLabel);
            Controls.Add(TournamentNameValue);
            Controls.Add(TournamentNameLabel);
            Controls.Add(HeaderLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private TextBox TournamentNameValue;
        private Label TournamentNameLabel;
        private TextBox entryFeeText;
        private Label entryFeeLabel;
        private ComboBox AddTeamDropDown;
        private Label addTeamLabel;
        private LinkLabel CreateNewTeamLink;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private ListBox TournamentPlayersListBox;
        private Label TournamentPlayersLabel;
        private Button DeleteSelectedPlayersButton;
        private Button DeleteSelectedPrizeButton;
        private Label PrizesLabel;
        private ListBox PrizesListBox;
        private Button CreateTournamentButton;
    }
}