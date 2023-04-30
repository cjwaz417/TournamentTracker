namespace TrackerUI
{
    partial class CreateTeamForm
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
            GroupBox AddNewMemberGroupBox;
            CreateMemberButton = new Button();
            CellText = new TextBox();
            CellLabel = new Label();
            EmailText = new TextBox();
            EmaiLabel = new Label();
            LastNameText = new TextBox();
            LastNameLabel = new Label();
            FirstNameText = new TextBox();
            FirstNameLabel = new Label();
            TeamNameValue = new TextBox();
            TeamNameLabel = new Label();
            CreateTeamLabel = new Label();
            AddMemberButton = new Button();
            SelectTeamMemverDropDown = new ComboBox();
            SelectTeamMemberLabel = new Label();
            TeamMembersListBox = new ListBox();
            RenoveSelectedMemberButton = new Button();
            CreateTeamButton = new Button();
            AddNewMemberGroupBox = new GroupBox();
            AddNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddNewMemberGroupBox
            // 
            AddNewMemberGroupBox.Controls.Add(CreateMemberButton);
            AddNewMemberGroupBox.Controls.Add(CellText);
            AddNewMemberGroupBox.Controls.Add(CellLabel);
            AddNewMemberGroupBox.Controls.Add(EmailText);
            AddNewMemberGroupBox.Controls.Add(EmaiLabel);
            AddNewMemberGroupBox.Controls.Add(LastNameText);
            AddNewMemberGroupBox.Controls.Add(LastNameLabel);
            AddNewMemberGroupBox.Controls.Add(FirstNameText);
            AddNewMemberGroupBox.Controls.Add(FirstNameLabel);
            AddNewMemberGroupBox.Location = new Point(39, 430);
            AddNewMemberGroupBox.Margin = new Padding(5, 6, 5, 6);
            AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            AddNewMemberGroupBox.Padding = new Padding(5, 6, 5, 6);
            AddNewMemberGroupBox.Size = new Size(403, 363);
            AddNewMemberGroupBox.TabIndex = 20;
            AddNewMemberGroupBox.TabStop = false;
            AddNewMemberGroupBox.Text = "Add New Member";
            AddNewMemberGroupBox.Enter += AddNewMemberGroupBox_Enter;
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.FlatAppearance.BorderColor = Color.Silver;
            CreateMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateMemberButton.FlatStyle = FlatStyle.Flat;
            CreateMemberButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateMemberButton.Location = new Point(69, 290);
            CreateMemberButton.Margin = new Padding(5, 6, 5, 6);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new Size(217, 61);
            CreateMemberButton.TabIndex = 20;
            CreateMemberButton.Text = "Create Member";
            CreateMemberButton.UseVisualStyleBackColor = true;
            CreateMemberButton.Click += CreateMemberButton_Click;
            // 
            // CellText
            // 
            CellText.Location = new Point(69, 241);
            CellText.Margin = new Padding(5, 6, 5, 6);
            CellText.Name = "CellText";
            CellText.Size = new Size(235, 35);
            CellText.TabIndex = 16;
            // 
            // CellLabel
            // 
            CellLabel.AutoSize = true;
            CellLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CellLabel.Location = new Point(1, 241);
            CellLabel.Margin = new Padding(7, 0, 7, 0);
            CellLabel.Name = "CellLabel";
            CellLabel.Size = new Size(52, 30);
            CellLabel.TabIndex = 15;
            CellLabel.Text = "Cell:";
            // 
            // EmailText
            // 
            EmailText.Location = new Point(68, 168);
            EmailText.Margin = new Padding(5, 6, 5, 6);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(235, 35);
            EmailText.TabIndex = 14;
            // 
            // EmaiLabel
            // 
            EmaiLabel.AutoSize = true;
            EmaiLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmaiLabel.Location = new Point(0, 168);
            EmaiLabel.Margin = new Padding(7, 0, 7, 0);
            EmaiLabel.Name = "EmaiLabel";
            EmaiLabel.Size = new Size(68, 30);
            EmaiLabel.TabIndex = 13;
            EmaiLabel.Text = "Email:";
            // 
            // LastNameText
            // 
            LastNameText.Location = new Point(68, 112);
            LastNameText.Margin = new Padding(5, 6, 5, 6);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(235, 35);
            LastNameText.TabIndex = 12;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(0, 112);
            LastNameLabel.Margin = new Padding(7, 0, 7, 0);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(55, 30);
            LastNameLabel.TabIndex = 11;
            LastNameLabel.Text = "Last:";
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(68, 52);
            FirstNameText.Margin = new Padding(5, 6, 5, 6);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(235, 35);
            FirstNameText.TabIndex = 10;
            FirstNameText.TextChanged += teamOneScoreText_TextChanged;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(0, 52);
            FirstNameLabel.Margin = new Padding(7, 0, 7, 0);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(56, 30);
            FirstNameLabel.TabIndex = 9;
            FirstNameLabel.Text = "First:";
            FirstNameLabel.Click += FirstNameLabel_Click;
            // 
            // TeamNameValue
            // 
            TeamNameValue.Location = new Point(6, 143);
            TeamNameValue.Margin = new Padding(5, 6, 5, 6);
            TeamNameValue.Name = "TeamNameValue";
            TeamNameValue.Size = new Size(506, 35);
            TeamNameValue.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            TeamNameLabel.AutoSize = true;
            TeamNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TeamNameLabel.Location = new Point(6, 86);
            TeamNameLabel.Margin = new Padding(7, 0, 7, 0);
            TeamNameLabel.Name = "TeamNameLabel";
            TeamNameLabel.Size = new Size(124, 30);
            TeamNameLabel.TabIndex = 12;
            TeamNameLabel.Text = "Team Name";
            // 
            // CreateTeamLabel
            // 
            CreateTeamLabel.AutoSize = true;
            CreateTeamLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTeamLabel.ForeColor = SystemColors.MenuHighlight;
            CreateTeamLabel.Location = new Point(-7, 18);
            CreateTeamLabel.Margin = new Padding(7, 0, 7, 0);
            CreateTeamLabel.Name = "CreateTeamLabel";
            CreateTeamLabel.Size = new Size(213, 50);
            CreateTeamLabel.TabIndex = 11;
            CreateTeamLabel.Text = "Create Team";
            // 
            // AddMemberButton
            // 
            AddMemberButton.FlatAppearance.BorderColor = Color.Silver;
            AddMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AddMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddMemberButton.FlatStyle = FlatStyle.Flat;
            AddMemberButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddMemberButton.Location = new Point(87, 330);
            AddMemberButton.Margin = new Padding(5, 6, 5, 6);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(327, 88);
            AddMemberButton.TabIndex = 19;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += AddTeamButton_Click;
            // 
            // SelectTeamMemverDropDown
            // 
            SelectTeamMemverDropDown.FormattingEnabled = true;
            SelectTeamMemverDropDown.Location = new Point(6, 262);
            SelectTeamMemverDropDown.Margin = new Padding(5, 6, 5, 6);
            SelectTeamMemverDropDown.Name = "SelectTeamMemverDropDown";
            SelectTeamMemverDropDown.Size = new Size(506, 38);
            SelectTeamMemverDropDown.TabIndex = 18;
            SelectTeamMemverDropDown.SelectedIndexChanged += AddTeamDropDown_SelectedIndexChanged;
            // 
            // SelectTeamMemberLabel
            // 
            SelectTeamMemberLabel.AutoSize = true;
            SelectTeamMemberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SelectTeamMemberLabel.Location = new Point(6, 205);
            SelectTeamMemberLabel.Margin = new Padding(7, 0, 7, 0);
            SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            SelectTeamMemberLabel.Size = new Size(207, 30);
            SelectTeamMemberLabel.TabIndex = 17;
            SelectTeamMemberLabel.Text = "Select Team Member";
            SelectTeamMemberLabel.Click += addTeamLabel_Click;
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 30;
            TeamMembersListBox.Location = new Point(597, 102);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(359, 694);
            TeamMembersListBox.TabIndex = 21;
            TeamMembersListBox.SelectedIndexChanged += TeamMembersListBox_SelectedIndexChanged;
            // 
            // RenoveSelectedMemberButton
            // 
            RenoveSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            RenoveSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            RenoveSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            RenoveSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            RenoveSelectedMemberButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            RenoveSelectedMemberButton.Location = new Point(996, 341);
            RenoveSelectedMemberButton.Name = "RenoveSelectedMemberButton";
            RenoveSelectedMemberButton.Size = new Size(143, 98);
            RenoveSelectedMemberButton.TabIndex = 22;
            RenoveSelectedMemberButton.Text = "Remove Selected";
            RenoveSelectedMemberButton.UseVisualStyleBackColor = true;
            RenoveSelectedMemberButton.Click += RenoveSelectedMemberButton_Click;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTeamButton.FlatStyle = FlatStyle.Flat;
            CreateTeamButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTeamButton.Location = new Point(397, 806);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(276, 85);
            CreateTeamButton.TabIndex = 25;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            CreateTeamButton.Click += CreateTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1202, 903);
            Controls.Add(CreateTeamButton);
            Controls.Add(RenoveSelectedMemberButton);
            Controls.Add(TeamMembersListBox);
            Controls.Add(AddNewMemberGroupBox);
            Controls.Add(AddMemberButton);
            Controls.Add(SelectTeamMemverDropDown);
            Controls.Add(SelectTeamMemberLabel);
            Controls.Add(TeamNameValue);
            Controls.Add(TeamNameLabel);
            Controls.Add(CreateTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            AddNewMemberGroupBox.ResumeLayout(false);
            AddNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TeamNameValue;
        private Label TeamNameLabel;
        private Label CreateTeamLabel;
        private Button AddMemberButton;
        private ComboBox SelectTeamMemverDropDown;
        private Label SelectTeamMemberLabel;
        private TextBox FirstNameText;
        private Label FirstNameLabel;
        private Button CreateMemberButton;
        private TextBox CellText;
        private Label CellLabel;
        private TextBox EmailText;
        private Label EmaiLabel;
        private TextBox LastNameText;
        private Label LastNameLabel;
        private ListBox TeamMembersListBox;
        private Button RenoveSelectedMemberButton;
        private Button CreateTeamButton;
    }
}