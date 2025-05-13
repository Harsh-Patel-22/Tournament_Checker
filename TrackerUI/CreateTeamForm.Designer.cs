using System.ComponentModel;

namespace TrackerUI;

partial class CreateTeamForm {
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
        createTeamLabel = new System.Windows.Forms.Label();
        teamNameLabel = new System.Windows.Forms.Label();
        teamNameTextBox = new System.Windows.Forms.TextBox();
        selectTeamMemberLabel = new System.Windows.Forms.Label();
        addMemberButtton = new System.Windows.Forms.Button();
        addNewMemberLabel = new System.Windows.Forms.Label();
        firstNameLabel = new System.Windows.Forms.Label();
        lastNameLabel = new System.Windows.Forms.Label();
        emailLabel = new System.Windows.Forms.Label();
        phoneLabel = new System.Windows.Forms.Label();
        firstNameTextBox = new System.Windows.Forms.TextBox();
        lastNameTextBox = new System.Windows.Forms.TextBox();
        emailTextBox = new System.Windows.Forms.TextBox();
        phoneTextBox = new System.Windows.Forms.TextBox();
        createMemberButton = new System.Windows.Forms.Button();
        createTeamButton = new System.Windows.Forms.Button();
        teamMembersListBox = new System.Windows.Forms.ListBox();
        teamMemberDeleteSelectedButton = new System.Windows.Forms.Button();
        selectTeamMemberComboBox = new System.Windows.Forms.ComboBox();
        SuspendLayout();
        // 
        // createTeamLabel
        // 
        createTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        createTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        createTeamLabel.Location = new System.Drawing.Point(21, 24);
        createTeamLabel.Name = "createTeamLabel";
        createTeamLabel.Size = new System.Drawing.Size(223, 43);
        createTeamLabel.TabIndex = 0;
        createTeamLabel.Text = "Create Team";
        // 
        // teamNameLabel
        // 
        teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        teamNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        teamNameLabel.Location = new System.Drawing.Point(21, 85);
        teamNameLabel.Name = "teamNameLabel";
        teamNameLabel.Size = new System.Drawing.Size(223, 43);
        teamNameLabel.TabIndex = 0;
        teamNameLabel.Text = "Team Name";
        // 
        // teamNameTextBox
        // 
        teamNameTextBox.Location = new System.Drawing.Point(31, 120);
        teamNameTextBox.Name = "teamNameTextBox";
        teamNameTextBox.Size = new System.Drawing.Size(248, 27);
        teamNameTextBox.TabIndex = 1;
        // 
        // selectTeamMemberLabel
        // 
        selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        selectTeamMemberLabel.Location = new System.Drawing.Point(23, 174);
        selectTeamMemberLabel.Name = "selectTeamMemberLabel";
        selectTeamMemberLabel.Size = new System.Drawing.Size(223, 43);
        selectTeamMemberLabel.TabIndex = 0;
        selectTeamMemberLabel.Text = "Select Team Member";
        // 
        // addMemberButtton
        // 
        addMemberButtton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        addMemberButtton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        addMemberButtton.ForeColor = System.Drawing.SystemColors.Highlight;
        addMemberButtton.Location = new System.Drawing.Point(83, 255);
        addMemberButtton.Name = "addMemberButtton";
        addMemberButtton.Size = new System.Drawing.Size(148, 39);
        addMemberButtton.TabIndex = 2;
        addMemberButtton.Text = "Add Member";
        addMemberButtton.UseVisualStyleBackColor = false;
        // 
        // addNewMemberLabel
        // 
        addNewMemberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        addNewMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        addNewMemberLabel.Location = new System.Drawing.Point(31, 315);
        addNewMemberLabel.Name = "addNewMemberLabel";
        addNewMemberLabel.Size = new System.Drawing.Size(223, 43);
        addNewMemberLabel.TabIndex = 0;
        addNewMemberLabel.Text = "Add New Member";
        // 
        // firstNameLabel
        // 
        firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        firstNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        firstNameLabel.Location = new System.Drawing.Point(31, 358);
        firstNameLabel.Name = "firstNameLabel";
        firstNameLabel.Size = new System.Drawing.Size(223, 43);
        firstNameLabel.TabIndex = 0;
        firstNameLabel.Text = "First Name";
        // 
        // lastNameLabel
        // 
        lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lastNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        lastNameLabel.Location = new System.Drawing.Point(31, 391);
        lastNameLabel.Name = "lastNameLabel";
        lastNameLabel.Size = new System.Drawing.Size(223, 43);
        lastNameLabel.TabIndex = 0;
        lastNameLabel.Text = "Last Name";
        // 
        // emailLabel
        // 
        emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        emailLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        emailLabel.Location = new System.Drawing.Point(31, 424);
        emailLabel.Name = "emailLabel";
        emailLabel.Size = new System.Drawing.Size(223, 43);
        emailLabel.TabIndex = 0;
        emailLabel.Text = "Email";
        // 
        // phoneLabel
        // 
        phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        phoneLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        phoneLabel.Location = new System.Drawing.Point(31, 457);
        phoneLabel.Name = "phoneLabel";
        phoneLabel.Size = new System.Drawing.Size(223, 43);
        phoneLabel.TabIndex = 0;
        phoneLabel.Text = "Phone";
        // 
        // firstNameTextBox
        // 
        firstNameTextBox.Location = new System.Drawing.Point(166, 361);
        firstNameTextBox.Name = "firstNameTextBox";
        firstNameTextBox.Size = new System.Drawing.Size(141, 27);
        firstNameTextBox.TabIndex = 3;
        // 
        // lastNameTextBox
        // 
        lastNameTextBox.Location = new System.Drawing.Point(166, 394);
        lastNameTextBox.Name = "lastNameTextBox";
        lastNameTextBox.Size = new System.Drawing.Size(141, 27);
        lastNameTextBox.TabIndex = 3;
        // 
        // emailTextBox
        // 
        emailTextBox.Location = new System.Drawing.Point(166, 427);
        emailTextBox.Name = "emailTextBox";
        emailTextBox.Size = new System.Drawing.Size(141, 27);
        emailTextBox.TabIndex = 3;
        // 
        // phoneTextBox
        // 
        phoneTextBox.Location = new System.Drawing.Point(166, 458);
        phoneTextBox.Name = "phoneTextBox";
        phoneTextBox.Size = new System.Drawing.Size(141, 27);
        phoneTextBox.TabIndex = 3;
        // 
        // createMemberButton
        // 
        createMemberButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        createMemberButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        createMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
        createMemberButton.Location = new System.Drawing.Point(83, 503);
        createMemberButton.Name = "createMemberButton";
        createMemberButton.Size = new System.Drawing.Size(148, 39);
        createMemberButton.TabIndex = 2;
        createMemberButton.Text = "Create Member";
        createMemberButton.UseVisualStyleBackColor = false;
        // 
        // createTeamButton
        // 
        createTeamButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        createTeamButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        createTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
        createTeamButton.Location = new System.Drawing.Point(261, 560);
        createTeamButton.Name = "createTeamButton";
        createTeamButton.Size = new System.Drawing.Size(207, 59);
        createTeamButton.TabIndex = 2;
        createTeamButton.Text = "Create Team";
        createTeamButton.UseVisualStyleBackColor = false;
        // 
        // teamMembersListBox
        // 
        teamMembersListBox.FormattingEnabled = true;
        teamMembersListBox.Location = new System.Drawing.Point(357, 120);
        teamMembersListBox.Name = "teamMembersListBox";
        teamMembersListBox.Size = new System.Drawing.Size(281, 424);
        teamMembersListBox.TabIndex = 4;
        // 
        // teamMemberDeleteSelectedButton
        // 
        teamMemberDeleteSelectedButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        teamMemberDeleteSelectedButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        teamMemberDeleteSelectedButton.ForeColor = System.Drawing.SystemColors.Highlight;
        teamMemberDeleteSelectedButton.Location = new System.Drawing.Point(655, 120);
        teamMemberDeleteSelectedButton.Name = "teamMemberDeleteSelectedButton";
        teamMemberDeleteSelectedButton.Size = new System.Drawing.Size(126, 73);
        teamMemberDeleteSelectedButton.TabIndex = 2;
        teamMemberDeleteSelectedButton.Text = "Delete Selected";
        teamMemberDeleteSelectedButton.UseVisualStyleBackColor = false;
        // 
        // selectTeamMemberComboBox
        // 
        selectTeamMemberComboBox.FormattingEnabled = true;
        selectTeamMemberComboBox.Location = new System.Drawing.Point(30, 210);
        selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
        selectTeamMemberComboBox.Size = new System.Drawing.Size(248, 28);
        selectTeamMemberComboBox.TabIndex = 5;
        // 
        // CreateTeam
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(799, 638);
        Controls.Add(selectTeamMemberComboBox);
        Controls.Add(teamMembersListBox);
        Controls.Add(phoneTextBox);
        Controls.Add(emailTextBox);
        Controls.Add(lastNameTextBox);
        Controls.Add(firstNameTextBox);
        Controls.Add(createTeamButton);
        Controls.Add(teamMemberDeleteSelectedButton);
        Controls.Add(createMemberButton);
        Controls.Add(addMemberButtton);
        Controls.Add(selectTeamMemberLabel);
        Controls.Add(teamNameTextBox);
        Controls.Add(phoneLabel);
        Controls.Add(emailLabel);
        Controls.Add(lastNameLabel);
        Controls.Add(firstNameLabel);
        Controls.Add(addNewMemberLabel);
        Controls.Add(teamNameLabel);
        Controls.Add(createTeamLabel);
        Text = "Create Team";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button createMemberButton;
    private System.Windows.Forms.Button createTeamButton;
    private System.Windows.Forms.ListBox teamMembersListBox;
    private System.Windows.Forms.Button teamMemberDeleteSelectedButton;
    private System.Windows.Forms.ComboBox selectTeamMemberComboBox;

    private System.Windows.Forms.Label addNewMemberLabel;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.Label phoneLabel;
    private System.Windows.Forms.TextBox firstNameTextBox;
    private System.Windows.Forms.TextBox lastNameTextBox;
    private System.Windows.Forms.TextBox emailTextBox;
    private System.Windows.Forms.TextBox phoneTextBox;

    private System.Windows.Forms.Label teamNameLabel;
    private System.Windows.Forms.TextBox teamNameTextBox;
    private System.Windows.Forms.Label selectTeamMemberLabel;
    private System.Windows.Forms.TextBox selectTeamMemberTextBox;
    private System.Windows.Forms.Button addMemberButtton;

    private System.Windows.Forms.Label createTeamLabel;

    #endregion
}