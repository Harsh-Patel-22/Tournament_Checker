using System.ComponentModel;

namespace TrackerUI;

partial class TournamentViewForm {
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
        tournamentLabel = new System.Windows.Forms.Label();
        tournamentName = new System.Windows.Forms.Label();
        roundLabel = new System.Windows.Forms.Label();
        roundComboBox = new System.Windows.Forms.ComboBox();
        unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
        matchupListBox = new System.Windows.Forms.ListBox();
        teamOneNameLabel = new System.Windows.Forms.Label();
        teamOneScoreLabel = new System.Windows.Forms.Label();
        teamOneScoreValue = new System.Windows.Forms.TextBox();
        teamTwoScoreValue = new System.Windows.Forms.TextBox();
        teamTwoScoreLabel = new System.Windows.Forms.Label();
        teamTwoNameLabel = new System.Windows.Forms.Label();
        vsLabel = new System.Windows.Forms.Label();
        scoreButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // tournamentLabel
        // 
        tournamentLabel.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        tournamentLabel.Location = new System.Drawing.Point(45, 23);
        tournamentLabel.Name = "tournamentLabel";
        tournamentLabel.Size = new System.Drawing.Size(288, 57);
        tournamentLabel.TabIndex = 0;
        tournamentLabel.Text = "Tournament:";
        // 
        // tournamentName
        // 
        tournamentName.Cursor = System.Windows.Forms.Cursors.Default;
        tournamentName.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        tournamentName.Location = new System.Drawing.Point(323, 23);
        tournamentName.Name = "tournamentName";
        tournamentName.Size = new System.Drawing.Size(182, 57);
        tournamentName.TabIndex = 1;
        tournamentName.Text = "<none>\r\n";
        // 
        // roundLabel
        // 
        roundLabel.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        roundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        roundLabel.Location = new System.Drawing.Point(45, 92);
        roundLabel.Name = "roundLabel";
        roundLabel.Size = new System.Drawing.Size(121, 39);
        roundLabel.TabIndex = 2;
        roundLabel.Text = "Round";
        roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // roundComboBox
        // 
        roundComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
        roundComboBox.FormattingEnabled = true;
        roundComboBox.Location = new System.Drawing.Point(184, 100);
        roundComboBox.Name = "roundComboBox";
        roundComboBox.Size = new System.Drawing.Size(222, 28);
        roundComboBox.TabIndex = 3;
        // 
        // unplayedOnlyCheckBox
        // 
        unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        unplayedOnlyCheckBox.ForeColor = System.Drawing.SystemColors.Highlight;
        unplayedOnlyCheckBox.Location = new System.Drawing.Point(184, 149);
        unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
        unplayedOnlyCheckBox.Size = new System.Drawing.Size(222, 33);
        unplayedOnlyCheckBox.TabIndex = 4;
        unplayedOnlyCheckBox.Text = "Unplayed Only";
        unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
        // 
        // matchupListBox
        // 
        matchupListBox.Font = new System.Drawing.Font("Segoe UI", 12F);
        matchupListBox.FormattingEnabled = true;
        matchupListBox.Location = new System.Drawing.Point(66, 203);
        matchupListBox.Name = "matchupListBox";
        matchupListBox.Size = new System.Drawing.Size(340, 228);
        matchupListBox.TabIndex = 5;
        // 
        // teamOneNameLabel
        // 
        teamOneNameLabel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        teamOneNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        teamOneNameLabel.Location = new System.Drawing.Point(505, 203);
        teamOneNameLabel.Name = "teamOneNameLabel";
        teamOneNameLabel.Size = new System.Drawing.Size(161, 37);
        teamOneNameLabel.TabIndex = 6;
        teamOneNameLabel.Text = "<team one>";
        teamOneNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // teamOneScoreLabel
        // 
        teamOneScoreLabel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        teamOneScoreLabel.Location = new System.Drawing.Point(480, 240);
        teamOneScoreLabel.Name = "teamOneScoreLabel";
        teamOneScoreLabel.Size = new System.Drawing.Size(74, 37);
        teamOneScoreLabel.TabIndex = 7;
        teamOneScoreLabel.Text = "Score";
        // 
        // teamOneScoreValue
        // 
        teamOneScoreValue.Location = new System.Drawing.Point(560, 243);
        teamOneScoreValue.Name = "teamOneScoreValue";
        teamOneScoreValue.Size = new System.Drawing.Size(119, 27);
        teamOneScoreValue.TabIndex = 8;
        // 
        // teamTwoScoreValue
        // 
        teamTwoScoreValue.Location = new System.Drawing.Point(560, 395);
        teamTwoScoreValue.Name = "teamTwoScoreValue";
        teamTwoScoreValue.Size = new System.Drawing.Size(119, 27);
        teamTwoScoreValue.TabIndex = 11;
        // 
        // teamTwoScoreLabel
        // 
        teamTwoScoreLabel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        teamTwoScoreLabel.Location = new System.Drawing.Point(480, 392);
        teamTwoScoreLabel.Name = "teamTwoScoreLabel";
        teamTwoScoreLabel.Size = new System.Drawing.Size(74, 37);
        teamTwoScoreLabel.TabIndex = 10;
        teamTwoScoreLabel.Text = "Score";
        // 
        // teamTwoNameLabel
        // 
        teamTwoNameLabel.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        teamTwoNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        teamTwoNameLabel.Location = new System.Drawing.Point(505, 355);
        teamTwoNameLabel.Name = "teamTwoNameLabel";
        teamTwoNameLabel.Size = new System.Drawing.Size(161, 37);
        teamTwoNameLabel.TabIndex = 9;
        teamTwoNameLabel.Text = "<team one>";
        teamTwoNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // vsLabel
        // 
        vsLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
        vsLabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
        vsLabel.Location = new System.Drawing.Point(547, 303);
        vsLabel.Name = "vsLabel";
        vsLabel.Size = new System.Drawing.Size(87, 35);
        vsLabel.TabIndex = 12;
        vsLabel.Text = "~VS~";
        vsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // scoreButton
        // 
        scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        scoreButton.ForeColor = System.Drawing.SystemColors.Highlight;
        scoreButton.Location = new System.Drawing.Point(327, 463);
        scoreButton.Name = "scoreButton";
        scoreButton.Size = new System.Drawing.Size(178, 46);
        scoreButton.TabIndex = 13;
        scoreButton.Text = "SCORE!";
        scoreButton.UseVisualStyleBackColor = true;
        // 
        // TournamentViewForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 524);
        Controls.Add(scoreButton);
        Controls.Add(vsLabel);
        Controls.Add(teamTwoScoreValue);
        Controls.Add(teamTwoScoreLabel);
        Controls.Add(teamTwoNameLabel);
        Controls.Add(teamOneScoreValue);
        Controls.Add(teamOneScoreLabel);
        Controls.Add(teamOneNameLabel);
        Controls.Add(matchupListBox);
        Controls.Add(unplayedOnlyCheckBox);
        Controls.Add(roundComboBox);
        Controls.Add(roundLabel);
        Controls.Add(tournamentName);
        Controls.Add(tournamentLabel);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Text = "View Tournament";
        Load += TournamentViewForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button scoreButton;

    private System.Windows.Forms.TextBox teamOneScoreValue;
    private System.Windows.Forms.Label teamTwoScoreLabel;
    private System.Windows.Forms.Label teamTwoNameLabel;
    private System.Windows.Forms.Label vsLabel;

    private System.Windows.Forms.TextBox teamTwoScoreValue;

    private System.Windows.Forms.Label teamOneScoreLabel;

    private System.Windows.Forms.ListBox matchupListBox;
    private System.Windows.Forms.Label teamOneNameLabel;

    private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;

    private System.Windows.Forms.ComboBox roundComboBox;

    private System.Windows.Forms.Label tournamentName;

    private System.Windows.Forms.Label roundLabel;

    private System.Windows.Forms.Label tournamentLabel;

    #endregion
}