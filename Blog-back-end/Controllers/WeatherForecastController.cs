using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure;
using Infrastructure.GenericRepositories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blog_back_end.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly BlogContext context;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,BlogContext context)
        {
            _logger = logger;
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            GenericRepository<Post> genericRepository = new GenericRepository<Post>(context);
            var find = await genericRepository.FindByCondition(p => p.Title.Contains("he"));

            var c = genericRepository.GetAll().Where(p => p.Title == "lol");
            c = c.Where(p => p.Id == 1);
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = find.Title
            })
            .ToArray();
        }
    }
}
