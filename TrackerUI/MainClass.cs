namespace TrackerUI;

public class MainClass {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        TrackerLibrary.GlobalConfig.InitialiseConnections(true, true);
        ApplicationConfiguration.Initialize();
        Application.Run(new CreatePrizeForm());
    }
}
