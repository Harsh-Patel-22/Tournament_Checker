namespace TrackerLibrary.Model;

public class PrizeModel {
    public int ID { get; set; }
    public int PlaceNumber { get; set; }
    public string PlaceName { get; set; }
    public decimal PrizeAmount { get; set; }
    public float PrizePercentage { get; set; }

    public PrizeModel() {
        
    }

    public PrizeModel(string placeNumber, string placeName, string prizeAmount,  string prizePercentage) {
        PlaceName = placeName;
        
        int.TryParse(placeNumber, out int place);
        PlaceNumber = place;
        
        decimal.TryParse(prizeAmount, out Decimal amount);
        PrizeAmount = amount;
        
        float.TryParse(prizePercentage, out float percentage);
        PrizePercentage = percentage;
    }
}