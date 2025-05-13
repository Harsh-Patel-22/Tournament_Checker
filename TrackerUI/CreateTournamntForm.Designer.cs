using System.ComponentModel;

namespace TrackerUI;

partial class CreateTournamntForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        createTournamentLabel = new System.Windows.Forms.Label();
        tournamentNameLabel = new System.Windows.Forms.Label();
        tournamentNameTextBox = new System.Windows.Forms.TextBox();
        entryFeeLabel = new System.Windows.Forms.Label();
        entryFeeTextBox = new System.Windows.Forms.TextBox();
        selectTeamLabel = new System.Windows.Forms.Label();
        selectTeamComboBox = new System.Windows.Forms.ComboBox();
        addTeamButton = new System.Windows.Forms.Button();
        createPrizeButton = new System.Windows.Forms.Button();
        teamPlayersLabel = new System.Windows.Forms.Label();
        playersListBox = new System.Windows.Forms.ListBox();
        label7 = new System.Windows.Forms.Label();
        prizesListBox = new System.Windows.Forms.ListBox();
        teamDeleteSelectedButton = new System.Windows.Forms.Button();
        prizesDeleteSelectedButton = new System.Windows.Forms.Button();
        createTournamentButton = new System.Windows.Forms.Button();
        createNewLinkLabel = new System.Windows.Forms.LinkLabel();
        SuspendLayout();
        // 
        // createTournamentLabel
        // 
        createTournamentLabel.BackColor = System.Drawing.SystemColors.Control;
        createTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        createTournamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        createTournamentLabel.Location = new System.Drawing.Point(19, 21);
        createTournamentLabel.Name = "createTournamentLabel";
        createTournamentLabel.Size = new System.Drawing.Size(267, 37);
        createTournamentLabel.TabIndex = 0;
        createTournamentLabel.Text = "Create Tournament";
        // 
        // tournamentNameLabel
        // 
        tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        tournamentNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        tournamentNameLabel.Location = new System.Drawing.Point(19, 81);
        tournamentNameLabel.Name = "tournamentNameLabel";
        tournamentNameLabel.Size = new System.Drawing.Size(267, 37);
        tournamentNameLabel.TabIndex = 0;
        tournamentNameLabel.Text = "Tournament Name";
        // 
        // tournamentNameTextBox
        // 
        tournamentNameTextBox.Location = new System.Drawing.Point(19, 121);
        tournamentNameTextBox.Name = "tournamentNameTextBox";
        tournamentNameTextBox.Size = new System.Drawing.Size(254, 27);
        tournamentNameTextBox.TabIndex = 1;
        // 
        // entryFeeLabel
        // 
        entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        entryFeeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        entryFeeLabel.Location = new System.Drawing.Point(19, 170);
        entryFeeLabel.Name = "entryFeeLabel";
        entryFeeLabel.Size = new System.Drawing.Size(106, 37);
        entryFeeLabel.TabIndex = 0;
        entryFeeLabel.Text = "Entry Fee";
        // 
        // entryFeeTextBox
        // 
        entryFeeTextBox.Location = new System.Drawing.Point(153, 170);
        entryFeeTextBox.Name = "entryFeeTextBox";
        entryFeeTextBox.Size = new System.Drawing.Size(119, 27);
        entryFeeTextBox.TabIndex = 2;
        // 
        // selectTeamLabel
        // 
        selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        selectTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        selectTeamLabel.Location = new System.Drawing.Point(13, 289);
        selectTeamLabel.Name = "selectTeamLabel";
        selectTeamLabel.Size = new System.Drawing.Size(133, 37);
        selectTeamLabel.TabIndex = 0;
        selectTeamLabel.Text = "Select Team";
        // 
        // selectTeamComboBox
        // 
        selectTeamComboBox.FormattingEnabled = true;
        selectTeamComboBox.Location = new System.Drawing.Point(17, 323);
        selectTeamComboBox.Name = "selectTeamComboBox";
        selectTeamComboBox.Size = new System.Drawing.Size(250, 28);
        selectTeamComboBox.TabIndex = 3;
        // 
        // addTeamButton
        // 
        addTeamButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        addTeamButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        addTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
        addTeamButton.Location = new System.Drawing.Point(89, 367);
        addTeamButton.Name = "addTeamButton";
        addTeamButton.Size = new System.Drawing.Size(104, 36);
        addTeamButton.TabIndex = 4;
        addTeamButton.Text = "Add Team";
        addTeamButton.UseVisualStyleBackColor = false;
        // 
        // createPrizeButton
        // 
        createPrizeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        createPrizeButton.ForeColor = System.Drawing.SystemColors.Highlight;
        createPrizeButton.Location = new System.Drawing.Point(89, 422);
        createPrizeButton.Name = "createPrizeButton";
        createPrizeButton.Size = new System.Drawing.Size(104, 36);
        createPrizeButton.TabIndex = 4;
        createPrizeButton.Text = "Create Prize";
        createPrizeButton.UseVisualStyleBackColor = false;
        // 
        // teamPlayersLabel
        // 
        teamPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        teamPlayersLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        teamPlayersLabel.Location = new System.Drawing.Point(364, 81);
        teamPlayersLabel.Name = "teamPlayersLabel";
        teamPlayersLabel.Size = new System.Drawing.Size(267, 37);
        teamPlayersLabel.TabIndex = 0;
        teamPlayersLabel.Text = "Teams / Players";
        // 
        // playersListBox
        // 
        playersListBox.FormattingEnabled = true;
        playersListBox.Location = new System.Drawing.Point(364, 112);
        playersListBox.Name = "playersListBox";
        playersListBox.Size = new System.Drawing.Size(302, 144);
        playersListBox.TabIndex = 5;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        label7.ForeColor = System.Drawing.SystemColors.Highlight;
        label7.Location = new System.Drawing.Point(364, 283);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(267, 37);
        label7.TabIndex = 0;
        label7.Text = "Prizes";
        // 
        // prizesListBox
        // 
        prizesListBox.FormattingEnabled = true;
        prizesListBox.Location = new System.Drawing.Point(364, 314);
        prizesListBox.Name = "prizesListBox";
        prizesListBox.Size = new System.Drawing.Size(302, 144);
        prizesListBox.TabIndex = 5;
        // 
        // teamDeleteSelectedButton
        // 
        teamDeleteSelectedButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        teamDeleteSelectedButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        teamDeleteSelectedButton.ForeColor = System.Drawing.SystemColors.Highlight;
        teamDeleteSelectedButton.Location = new System.Drawing.Point(684, 149);
        teamDeleteSelectedButton.Name = "teamDeleteSelectedButton";
        teamDeleteSelectedButton.Size = new System.Drawing.Size(104, 65);
        teamDeleteSelectedButton.TabIndex = 4;
        teamDeleteSelectedButton.Text = "Delete\r\nSelected";
        teamDeleteSelectedButton.UseVisualStyleBackColor = false;
        // 
        // prizesDeleteSelectedButton
        // 
        prizesDeleteSelectedButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        prizesDeleteSelectedButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        prizesDeleteSelectedButton.ForeColor = System.Drawing.SystemColors.Highlight;
        prizesDeleteSelectedButton.Location = new System.Drawing.Point(684, 348);
        prizesDeleteSelectedButton.Name = "prizesDeleteSelectedButton";
        prizesDeleteSelectedButton.Size = new System.Drawing.Size(104, 65);
        prizesDeleteSelectedButton.TabIndex = 4;
        prizesDeleteSelectedButton.Text = "Delete\r\nSelected";
        prizesDeleteSelectedButton.UseVisualStyleBackColor = false;
        // 
        // createTournamentButton
        // 
        createTournamentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        createTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
        createTournamentButton.Location = new System.Drawing.Point(258, 504);
        createTournamentButton.Name = "createTournamentButton";
        createTournamentButton.Size = new System.Drawing.Size(263, 65);
        createTournamentButton.TabIndex = 4;
        createTournamentButton.Text = "Create Tournament";
        createTournamentButton.UseVisualStyleBackColor = false;
        // 
        // createNewLinkLabel
        // 
        createNewLinkLabel.Location = new System.Drawing.Point(191, 293);
        createNewLinkLabel.Name = "createNewLinkLabel";
        createNewLinkLabel.Size = new System.Drawing.Size(82, 26);
        createNewLinkLabel.TabIndex = 6;
        createNewLinkLabel.TabStop = true;
        createNewLinkLabel.Text = "create new";
        // 
        // CreateTournamntForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 591);
        Controls.Add(createNewLinkLabel);
        Controls.Add(prizesListBox);
        Controls.Add(playersListBox);
        Controls.Add(createPrizeButton);
        Controls.Add(createTournamentButton);
        Controls.Add(prizesDeleteSelectedButton);
        Controls.Add(teamDeleteSelectedButton);
        Controls.Add(addTeamButton);
        Controls.Add(selectTeamComboBox);
        Controls.Add(entryFeeTextBox);
        Controls.Add(tournamentNameTextBox);
        Controls.Add(selectTeamLabel);
        Controls.Add(label7);
        Controls.Add(entryFeeLabel);
        Controls.Add(teamPlayersLabel);
        Controls.Add(tournamentNameLabel);
        Controls.Add(createTournamentLabel);
        Location = new System.Drawing.Point(19, 19);
        Text = "Create Tournament";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.LinkLabel createNewLinkLabel;

    private System.Windows.Forms.Button prizesDeleteSelectedButton;
    private System.Windows.Forms.TextBox entryFeeTextBox;
    private System.Windows.Forms.Button createTournamentButton;

    private System.Windows.Forms.Label teamPlayersLabel;
    private System.Windows.Forms.ListBox playersListBox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ListBox prizesListBox;
    private System.Windows.Forms.Label selectTeamLabel;
    private System.Windows.Forms.ComboBox selectTeamComboBox;
    private System.Windows.Forms.Button teamDeleteSelectedButton;

    private System.Windows.Forms.Button addTeamButton;
    private System.Windows.Forms.Button createPrizeButton;

    private System.Windows.Forms.Label tournamentNameLabel;
    private System.Windows.Forms.TextBox tournamentNameTextBox;
    private System.Windows.Forms.Label entryFeeLabel;

    private System.Windows.Forms.Label createTournamentLabel;

    #endregion
}