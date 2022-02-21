using API.Entities;

namespace API.Executors
{
    public class PredictionExecutor : IPredictionExecutor
    {
        public Prediction GetPrediction(string model, string team1, string team2)
        {
            return new Prediction
            {
                Id = Guid.NewGuid(),
                Model = model,
                Team1 = team1,
                Team2 = team2,
                Team1Win = 0.51,
                Team2Win = 0.49,
                PredictedDate = DateTimeOffset.UtcNow
            };
        }
    }
}
