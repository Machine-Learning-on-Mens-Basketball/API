using API.Entities;

namespace API.Executors
{
    public interface IPredictionExecutor
    {
        Prediction GetPrediction(string model, string team1, string team2);
    }
}