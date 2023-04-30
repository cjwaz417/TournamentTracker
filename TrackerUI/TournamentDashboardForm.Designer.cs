namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            TournamentDashboardLabel = new Label();
            LoadExistingTournamentDropDown = new ComboBox();
            LoadExistingTournamentLabel = new Label();
            LoadTournamentButton = new Button();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            TournamentDashboardLabel.AutoSize = true;
            TournamentDashboardLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentDashboardLabel.ForeColor = SystemColors.MenuHighlight;
            TournamentDashboardLabel.Location = new Point(122, 9);
            TournamentDashboardLabel.Margin = new Padding(7, 0, 7, 0);
            TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            TournamentDashboardLabel.Size = new Size(385, 50);
            TournamentDashboardLabel.TabIndex = 13;
            TournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentDropDown
            // 
            LoadExistingTournamentDropDown.FormattingEnabled = true;
            LoadExistingTournamentDropDown.Location = new Point(61, 121);
            LoadExistingTournamentDropDown.Margin = new Padding(5, 6, 5, 6);
            LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            LoadExistingTournamentDropDown.Size = new Size(506, 38);
            LoadExistingTournamentDropDown.TabIndex = 20;
            // 
            // LoadExistingTournamentLabel
            // 
            LoadExistingTournamentLabel.AutoSize = true;
            LoadExistingTournamentLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoadExistingTournamentLabel.Location = new Point(188, 85);
            LoadExistingTournamentLabel.Margin = new Padding(7, 0, 7, 0);
            LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            LoadExistingTournamentLabel.Size = new Size(252, 30);
            LoadExistingTournamentLabel.TabIndex = 19;
            LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            LoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            LoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            LoadTournamentButton.FlatStyle = FlatStyle.Flat;
            LoadTournamentButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoadTournamentButton.Location = new Point(192, 171);
            LoadTournamentButton.Margin = new Padding(5, 6, 5, 6);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(244, 54);
            LoadTournamentButton.TabIndex = 21;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateTournamentButton.Location = new Point(151, 256);
            CreateTournamentButton.Margin = new Padding(5, 6, 5, 6);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(327, 88);
            CreateTournamentButton.TabIndex = 22;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(679, 392);
            Controls.Add(CreateTournamentButton);
            Controls.Add(LoadTournamentButton);
            Controls.Add(LoadExistingTournamentDropDown);
            Controls.Add(LoadExistingTournamentLabel);
            Controls.Add(TournamentDashboardLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentDashboardLabel;
        private ComboBox LoadExistingTournamentDropDown;
        private Label LoadExistingTournamentLabel;
        private Button LoadTournamentButton;
        private Button CreateTournamentButton;
    }
}