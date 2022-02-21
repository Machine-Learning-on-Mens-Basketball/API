using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public record PredictionDto
    {
        public Guid Id { get; init; }

        [Required]
        public string Model { get; init; }

        [Required]
        public string Team1 { get; init; }

        [Required]
        public string Team2 { get; init; }

        public double Team1Win { get; init; }

        public double Team2Win { get; init; }

        public DateTimeOffset PredictedDate { get; init; }
    }
}
