using L03.Models;
using L03.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace L03.Controllers
{
    public class HeroesController : Controller
    {
        private readonly IHeroesRepository _heroesRepository;
        public HeroesController(IHeroesRepository heroesRepository) {
            _heroesRepository = heroesRepository;
        }   
        public IActionResult Index()
        {
            var heroes = _heroesRepository.GetHeroes(); 

            return View(heroes);
        }

      
    }
}
