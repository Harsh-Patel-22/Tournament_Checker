namespace TrackerLibrary;

public class TeamModel {
    public List<PersonModel> TeamMembers { get; set; }
    public string TeamName { get; set; }

    public TeamModel() {
        TeamMembers = new List<PersonModel>();
    }
}