using System.ComponentModel;

namespace TrackerUI;

partial class CreatePrizeForm {
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
        createPriceLabel = new System.Windows.Forms.Label();
        placeNumberLabel = new System.Windows.Forms.Label();
        placeNumberTextBox = new System.Windows.Forms.TextBox();
        priceNameLabel = new System.Windows.Forms.Label();
        prizeNameTextBox = new System.Windows.Forms.TextBox();
        priceAmountLabel = new System.Windows.Forms.Label();
        prizeAmountTextBox = new System.Windows.Forms.TextBox();
        prizePercentageLabel = new System.Windows.Forms.Label();
        pricePercentageTextBox = new System.Windows.Forms.TextBox();
        createPrizeButton = new System.Windows.Forms.Button();
        orLabel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // createPriceLabel
        // 
        createPriceLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
        createPriceLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        createPriceLabel.Location = new System.Drawing.Point(40, 42);
        createPriceLabel.Name = "createPriceLabel";
        createPriceLabel.Size = new System.Drawing.Size(313, 56);
        createPriceLabel.TabIndex = 0;
        createPriceLabel.Text = "Create Prize";
        // 
        // placeNumberLabel
        // 
        placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        placeNumberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        placeNumberLabel.Location = new System.Drawing.Point(40, 107);
        placeNumberLabel.Name = "placeNumberLabel";
        placeNumberLabel.Size = new System.Drawing.Size(169, 33);
        placeNumberLabel.TabIndex = 0;
        placeNumberLabel.Text = "Place Number";
        // 
        // placeNumberTextBox
        // 
        placeNumberTextBox.Location = new System.Drawing.Point(215, 113);
        placeNumberTextBox.Name = "placeNumberTextBox";
        placeNumberTextBox.Size = new System.Drawing.Size(189, 27);
        placeNumberTextBox.TabIndex = 1;
        // 
        // priceNameLabel
        // 
        priceNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        priceNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        priceNameLabel.Location = new System.Drawing.Point(40, 155);
        priceNameLabel.Name = "priceNameLabel";
        priceNameLabel.Size = new System.Drawing.Size(143, 33);
        priceNameLabel.TabIndex = 0;
        priceNameLabel.Text = "Prize Name";
        // 
        // prizeNameTextBox
        // 
        prizeNameTextBox.Location = new System.Drawing.Point(215, 161);
        prizeNameTextBox.Name = "prizeNameTextBox";
        prizeNameTextBox.Size = new System.Drawing.Size(189, 27);
        prizeNameTextBox.TabIndex = 1;
        // 
        // priceAmountLabel
        // 
        priceAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        priceAmountLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        priceAmountLabel.Location = new System.Drawing.Point(40, 204);
        priceAmountLabel.Name = "priceAmountLabel";
        priceAmountLabel.Size = new System.Drawing.Size(143, 33);
        priceAmountLabel.TabIndex = 0;
        priceAmountLabel.Text = "Prize Amount";
        // 
        // prizeAmountTextBox
        // 
        prizeAmountTextBox.Location = new System.Drawing.Point(215, 210);
        prizeAmountTextBox.Name = "prizeAmountTextBox";
        prizeAmountTextBox.Size = new System.Drawing.Size(189, 27);
        prizeAmountTextBox.TabIndex = 1;
        prizeAmountTextBox.Text = "0";
        // 
        // prizePercentageLabel
        // 
        prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        prizePercentageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        prizePercentageLabel.Location = new System.Drawing.Point(40, 311);
        prizePercentageLabel.Name = "prizePercentageLabel";
        prizePercentageLabel.Size = new System.Drawing.Size(174, 33);
        prizePercentageLabel.TabIndex = 0;
        prizePercentageLabel.Text = "Prize Percentage";
        // 
        // pricePercentageTextBox
        // 
        pricePercentageTextBox.Location = new System.Drawing.Point(215, 317);
        pricePercentageTextBox.Name = "pricePercentageTextBox";
        pricePercentageTextBox.Size = new System.Drawing.Size(189, 27);
        pricePercentageTextBox.TabIndex = 1;
        pricePercentageTextBox.Text = "0";
        // 
        // createPrizeButton
        // 
        createPrizeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        createPrizeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        createPrizeButton.ForeColor = System.Drawing.SystemColors.Highlight;
        createPrizeButton.Location = new System.Drawing.Point(130, 380);
        createPrizeButton.Name = "createPrizeButton";
        createPrizeButton.Size = new System.Drawing.Size(191, 53);
        createPrizeButton.TabIndex = 2;
        createPrizeButton.Text = "Create Price";
        createPrizeButton.UseVisualStyleBackColor = false;
        createPrizeButton.Click += createPrizeButton_Click;
        // 
        // orLabel
        // 
        orLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
        orLabel.ForeColor = System.Drawing.SystemColors.Highlight;
        orLabel.Location = new System.Drawing.Point(158, 258);
        orLabel.Name = "orLabel";
        orLabel.Size = new System.Drawing.Size(119, 33);
        orLabel.TabIndex = 0;
        orLabel.Text = "~or~";
        orLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // CreatePrizeForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(465, 450);
        Controls.Add(createPrizeButton);
        Controls.Add(pricePercentageTextBox);
        Controls.Add(prizePercentageLabel);
        Controls.Add(prizeAmountTextBox);
        Controls.Add(orLabel);
        Controls.Add(priceAmountLabel);
        Controls.Add(prizeNameTextBox);
        Controls.Add(priceNameLabel);
        Controls.Add(placeNumberTextBox);
        Controls.Add(placeNumberLabel);
        Controls.Add(createPriceLabel);
        Text = "Create Prize";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label placeNumberLabel;
    private System.Windows.Forms.TextBox placeNumberTextBox;
    private System.Windows.Forms.Label priceNameLabel;
    private System.Windows.Forms.TextBox prizeNameTextBox;
    private System.Windows.Forms.Label priceAmountLabel;
    private System.Windows.Forms.TextBox prizeAmountTextBox;
    private System.Windows.Forms.Label prizePercentageLabel;
    private System.Windows.Forms.TextBox pricePercentageTextBox;
    private System.Windows.Forms.Button createPrizeButton;
    private System.Windows.Forms.Label orLabel;

    private System.Windows.Forms.Label createPriceLabel;

    #endregion
}