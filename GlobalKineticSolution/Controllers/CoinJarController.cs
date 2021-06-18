using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalKineticSolution.Contracts;
using GlobalKineticSolution.Types;


namespace GlobalKineticSolution.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinJarController : ControllerBase
    {
        private readonly ILogger<ICoinJar> _logger;

        private ICoinJar _coinjar;

        public CoinJarController(ILogger<ICoinJar> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public void AddCoin(ICoin coin)
        {
            _coinjar = new CoinJar();
            _coinjar.AddCoin(coin);
        }

        [HttpGet]
        public decimal GetTotal(ICoin coin)
        {
            _coinjar = new CoinJar();
            return _coinjar.GetTotalAmount();
        }

        [HttpPut]
        public void Clear()
        {
            _coinjar = new CoinJar();
            _coinjar.Reset();
        }
    }
}
