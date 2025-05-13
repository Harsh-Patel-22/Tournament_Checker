using TrackerLibrary;
using TrackerLibrary.Data;
using TrackerLibrary.Model;

namespace TrackerUI;

public partial class CreatePrizeForm : Form {
    public CreatePrizeForm() {
        InitializeComponent();
    }

    private void createPrizeButton_Click(object sender, EventArgs e) {
        if(ValidateForm()) {
            PrizeModel pm = new PrizeModel(
                placeNumberTextBox.Text,
                prizeNameTextBox.Text, 
                prizeAmountTextBox.Text, 
                pricePercentageTextBox.Text
                );
            
            foreach(IDataConnection dbConnection in GlobalConfig.connections) {
                dbConnection.CreatePrize(pm);

                placeNumberTextBox.Text = "";
                prizeNameTextBox.Text = "";
                prizeAmountTextBox.Text = "0";
                pricePercentageTextBox.Text = "0";
            }
        }
        else {
            MessageBox.Show("Please enter valid details.");
        }
    }
    
    private bool ValidateForm() {
        bool returnValue = true;

        int placeNumber = 0;
        if(!int.TryParse(placeNumberTextBox.Text, out placeNumber)) {
            returnValue = false;
        }
        if(placeNumber <= 0) {
            returnValue = false;
        }
        
        Decimal prizeAmount = 0;
        if(!decimal.TryParse(prizeAmountTextBox.Text, out prizeAmount)) {
            returnValue = false;
        }
        
        float prizePercentage = 0;
        if(!float.TryParse(pricePercentageTextBox.Text, out prizePercentage)) {
            returnValue = false;
        }
        
        if(prizePercentage < 0 || prizeAmount < 0) {
            returnValue = false;
        }
        
        if(prizePercentage == 0 && prizeAmount ==0) {
            returnValue = false;
        }
        
        if(prizePercentage > 100) {
            returnValue = false;
        }
        return returnValue;
    }
}