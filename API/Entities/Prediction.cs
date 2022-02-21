using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public record Prediction
    {
        public Guid Id { get; init; }
        public string Model { get; init; }
        public string Team1 { get; init; }
        public string Team2 { get; init; }
        public double Team1Win { get; init; }
        public double Team2Win { get; init; }
        public DateTimeOffset PredictedDate { get; init; }
    }
}
