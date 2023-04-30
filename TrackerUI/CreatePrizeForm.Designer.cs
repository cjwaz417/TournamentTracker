namespace TrackerUI
{
    partial class CreatePrizeForm
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
            CreatePrizeLabel = new Label();
            PLaceNumberText = new TextBox();
            PlaceNumberLabel = new Label();
            PrizeAmountText = new TextBox();
            PrizeAmountLabel = new Label();
            PlaceNameValue = new TextBox();
            PLaceNameLabel = new Label();
            PrizePercentageText = new TextBox();
            PrizePercentageLabel = new Label();
            orLabel = new Label();
            CreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // CreatePrizeLabel
            // 
            CreatePrizeLabel.AutoSize = true;
            CreatePrizeLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreatePrizeLabel.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeLabel.Location = new Point(16, 9);
            CreatePrizeLabel.Margin = new Padding(7, 0, 7, 0);
            CreatePrizeLabel.Name = "CreatePrizeLabel";
            CreatePrizeLabel.Size = new Size(209, 50);
            CreatePrizeLabel.TabIndex = 12;
            CreatePrizeLabel.Text = "Create Prize";
            // 
            // PLaceNumberText
            // 
            PLaceNumberText.Location = new Point(177, 99);
            PLaceNumberText.Margin = new Padding(5, 6, 5, 6);
            PLaceNumberText.Name = "PLaceNumberText";
            PLaceNumberText.Size = new Size(235, 35);
            PLaceNumberText.TabIndex = 14;
            // 
            // PlaceNumberLabel
            // 
            PlaceNumberLabel.AutoSize = true;
            PlaceNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PlaceNumberLabel.Location = new Point(16, 104);
            PlaceNumberLabel.Margin = new Padding(7, 0, 7, 0);
            PlaceNumberLabel.Name = "PlaceNumberLabel";
            PlaceNumberLabel.Size = new Size(149, 30);
            PlaceNumberLabel.TabIndex = 13;
            PlaceNumberLabel.Text = "Place Number:";
            // 
            // PrizeAmountText
            // 
            PrizeAmountText.Location = new Point(177, 241);
            PrizeAmountText.Margin = new Padding(5, 6, 5, 6);
            PrizeAmountText.Name = "PrizeAmountText";
            PrizeAmountText.Size = new Size(235, 35);
            PrizeAmountText.TabIndex = 16;
            PrizeAmountText.Text = "0";
            // 
            // PrizeAmountLabel
            // 
            PrizeAmountLabel.AutoSize = true;
            PrizeAmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PrizeAmountLabel.Location = new Point(16, 246);
            PrizeAmountLabel.Margin = new Padding(7, 0, 7, 0);
            PrizeAmountLabel.Name = "PrizeAmountLabel";
            PrizeAmountLabel.Size = new Size(144, 30);
            PrizeAmountLabel.TabIndex = 15;
            PrizeAmountLabel.Text = "Prize Amount:";
            // 
            // PlaceNameValue
            // 
            PlaceNameValue.Location = new Point(177, 170);
            PlaceNameValue.Margin = new Padding(5, 6, 5, 6);
            PlaceNameValue.Name = "PlaceNameValue";
            PlaceNameValue.Size = new Size(235, 35);
            PlaceNameValue.TabIndex = 18;
            // 
            // PLaceNameLabel
            // 
            PLaceNameLabel.AutoSize = true;
            PLaceNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PLaceNameLabel.Location = new Point(16, 175);
            PLaceNameLabel.Margin = new Padding(7, 0, 7, 0);
            PLaceNameLabel.Name = "PLaceNameLabel";
            PLaceNameLabel.Size = new Size(129, 30);
            PLaceNameLabel.TabIndex = 17;
            PLaceNameLabel.Text = "Place Name:";
            // 
            // PrizePercentageText
            // 
            PrizePercentageText.Location = new Point(177, 346);
            PrizePercentageText.Margin = new Padding(5, 6, 5, 6);
            PrizePercentageText.Name = "PrizePercentageText";
            PrizePercentageText.Size = new Size(235, 35);
            PrizePercentageText.TabIndex = 20;
            PrizePercentageText.Text = "0";
            // 
            // PrizePercentageLabel
            // 
            PrizePercentageLabel.AutoSize = true;
            PrizePercentageLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PrizePercentageLabel.Location = new Point(16, 351);
            PrizePercentageLabel.Margin = new Padding(7, 0, 7, 0);
            PrizePercentageLabel.Name = "PrizePercentageLabel";
            PrizePercentageLabel.Size = new Size(138, 30);
            PrizePercentageLabel.TabIndex = 19;
            PrizePercentageLabel.Text = "Prize Percent:";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.Location = new Point(142, 297);
            orLabel.Margin = new Padding(7, 0, 7, 0);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(60, 30);
            orLabel.TabIndex = 21;
            orLabel.Text = "~or~";
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreatePrizeButton.Location = new Point(81, 450);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(276, 85);
            CreatePrizeButton.TabIndex = 26;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += CreatePrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 593);
            Controls.Add(CreatePrizeButton);
            Controls.Add(orLabel);
            Controls.Add(PrizePercentageText);
            Controls.Add(PrizePercentageLabel);
            Controls.Add(PlaceNameValue);
            Controls.Add(PLaceNameLabel);
            Controls.Add(PrizeAmountText);
            Controls.Add(PrizeAmountLabel);
            Controls.Add(PLaceNumberText);
            Controls.Add(PlaceNumberLabel);
            Controls.Add(CreatePrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrizeLabel;
        private TextBox PLaceNumberText;
        private Label PlaceNumberLabel;
        private TextBox PrizeAmountText;
        private Label PrizeAmountLabel;
        private TextBox PlaceNameValue;
        private Label PLaceNameLabel;
        private TextBox PrizePercentageText;
        private Label PrizePercentageLabel;
        private Label orLabel;
        private Button CreatePrizeButton;
    }
}