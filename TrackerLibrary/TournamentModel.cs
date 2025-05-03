namespace TrackerLibrary;

public class TournamentModel {
    public string TournamentName { get; set; }
    public decimal EntryFee { get; set; }
    public List<TeamModel> EnteredTeams { get; set; }
    public List<PrizeModel> Prizes { get; set; }
    public List<List<MatchupModel>> Rounds { get; set; }

    public TournamentModel() {
        EnteredTeams = new List<TeamModel>();
        Prizes = new List<PrizeModel>();
        Rounds = new List<List<MatchupModel>>();
    }
}