using Microsoft.AspNetCore.Mvc;
using API.Executors;
using API.Dtos;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PredictionController : ControllerBase
    {
        private readonly IPredictionExecutor executor;

        public PredictionController(IPredictionExecutor executor)
        {
            this.executor = executor;
        }

        [HttpGet("Model/{model}/Team1/{team1}/Team2/{team2}")]
        public PredictionDto MakePrediction(string model, string team1, string team2)
        {
            return executor.GetPrediction(model, team1, team2).AsDto();
        }
    }
}
