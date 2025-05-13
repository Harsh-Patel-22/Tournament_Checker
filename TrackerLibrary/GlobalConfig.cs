using TrackerLibrary.Data;

namespace TrackerLibrary;

public static class GlobalConfig {
    public static List<IDataConnection> connections { get; private set; } = new List<IDataConnection>(2);
    
    public static void InitialiseConnections(bool mysqlDatabase, bool text) {
        if(mysqlDatabase) {
            SQLConnector sql = new SQLConnector();
            connections.Add(sql);
        }
        if(text) {
            TextConnector textObj = new TextConnector();
            connections.Add(textObj);
        }
    }
}