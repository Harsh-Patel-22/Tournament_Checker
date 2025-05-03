namespace TrackerLibrary;

public class MatchupEntryModel {
    public TeamModel TeamCompeting { get; set; }
    public float Score { get; set; }
    public MatchupModel ParentMatchup { get; set; }
}