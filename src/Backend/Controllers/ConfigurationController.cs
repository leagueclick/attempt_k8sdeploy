using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ConfigurationController> _logger;
        IConfiguration _configuration;

        public ConfigurationController(ILogger<ConfigurationController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public Dictionary<string, string> Get()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            result.Add("ASPNETCORE_ENVIRONMENT", _configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT"));
            result.Add("WeatherAddress", _configuration.GetValue<string>("WeatherAddress"));
            result.Add("DatabaseSettings:DbName", _configuration.GetValue<string>("DatabaseSettings:DbName"));
            result.Add("DatabaseSettings:ConnectionString", _configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            result.Add("DatabaseSettings:Encryption", _configuration.GetValue<string>("DatabaseSettings:Encryption"));

            return result;
        }

    }
}
