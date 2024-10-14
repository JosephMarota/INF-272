using L03.Models;
using System.Text.Json;

namespace L03.Repository
{
    public interface IHeroesRepository
    {
        IList<HeroesModel> GetHeroes();
    }
}
