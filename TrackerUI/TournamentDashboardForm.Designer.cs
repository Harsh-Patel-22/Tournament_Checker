using System.ComponentModel;

namespace TrackerUI;

partial class TournamentDashboardForm {
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
        tournamentDashboardLabel = new System.Windows.Forms.Label();
        loadExistingTournamentLabel = new System.Windows.Forms.Label();
        loadExistingTournamentComboBox = new System.Windows.Forms.ComboBox();
        loadTournamentButton = new System.Windows.Forms.Button();
        createTournamentButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // tournamentDashboardLabel
        // 
        tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        tournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        tournamentDashboardLabel.Location = new System.Drawing.Point(85, 35);
        tournamentDashboardLabel.Name = "tournamentDashboardLabel";
        tournamentDashboardLabel.Size = new System.Drawing.Size(295, 61);
        tournamentDashboardLabel.TabIndex = 0;
        tournamentDashboardLabel.Text = "Tournament Dashboard";
        // 
        // loadExistingTournamentLabel
        // 
        loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        loadExistingTournamentLabel.Location = new System.Drawing.Point(94, 96);
        loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
        loadExistingTournamentLabel.Size = new System.Drawing.Size(277, 32);
        loadExistingTournamentLabel.TabIndex = 0;
        loadExistingTournamentLabel.Text = "Load Existing Tournament";
        loadExistingTournamentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // loadExistingTournamentComboBox
        // 
        loadExistingTournamentComboBox.FormattingEnabled = true;
        loadExistingTournamentComboBox.Location = new System.Drawing.Point(81, 137);
        loadExistingTournamentComboBox.Name = "loadExistingTournamentComboBox";
        loadExistingTournamentComboBox.Size = new System.Drawing.Size(298, 28);
        loadExistingTournamentComboBox.TabIndex = 1;
        // 
        // loadTournamentButton
        // 
        loadTournamentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        loadTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        loadTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
        loadTournamentButton.Location = new System.Drawing.Point(122, 180);
        loadTournamentButton.Name = "loadTournamentButton";
        loadTournamentButton.Size = new System.Drawing.Size(232, 46);
        loadTournamentButton.TabIndex = 2;
        loadTournamentButton.Text = "Load Tournament";
        loadTournamentButton.UseVisualStyleBackColor = false;
        // 
        // createTournamentButton
        // 
        createTournamentButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        createTournamentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        createTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
        createTournamentButton.Location = new System.Drawing.Point(122, 256);
        createTournamentButton.Name = "createTournamentButton";
        createTournamentButton.Size = new System.Drawing.Size(232, 47);
        createTournamentButton.TabIndex = 2;
        createTournamentButton.Text = "Create Tournament";
        createTournamentButton.UseVisualStyleBackColor = false;
        // 
        // TournamentDashboardForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(482, 356);
        Controls.Add(createTournamentButton);
        Controls.Add(loadTournamentButton);
        Controls.Add(loadExistingTournamentComboBox);
        Controls.Add(loadExistingTournamentLabel);
        Controls.Add(tournamentDashboardLabel);
        Text = "Tournament Dashboard";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button createTournamentButton;

    private System.Windows.Forms.ComboBox loadExistingTournamentComboBox;
    private System.Windows.Forms.Button loadTournamentButton;

    private System.Windows.Forms.Label loadExistingTournamentLabel;

    private System.Windows.Forms.Label tournamentDashboardLabel;

    #endregion
}