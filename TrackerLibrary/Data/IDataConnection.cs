using TrackerLibrary.Model;

namespace TrackerLibrary.Data;

public interface IDataConnection {
    PrizeModel CreatePrize(PrizeModel model);
}