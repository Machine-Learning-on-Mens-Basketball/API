using API.Dtos;
using API.Entities;

namespace API
{
    public static class Extensions
    {
        public static PredictionDto AsDto(this Prediction prediction)
        {
            return new PredictionDto
            {
                Id = prediction.Id,
                Model = prediction.Model,
                Team1 = prediction.Team1,
                Team2 = prediction.Team2,
                Team1Win = prediction.Team1Win,
                Team2Win = prediction.Team2Win,
                PredictedDate = prediction.PredictedDate
            };
        }
    }
}
