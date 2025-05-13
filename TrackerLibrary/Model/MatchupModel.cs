namespace TrackerLibrary.Model;

public class MatchupModel {
    public List<MatchupEntryModel> MatchupEntryModels { get; set; }
    public TeamModel Winner { get; set; }
    public int MatchupRound { get; set; }
}