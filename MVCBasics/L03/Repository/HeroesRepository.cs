using L03.Models;
using System.Text.Json;

namespace L03.Repository
{
    public class HeroesRepository:IHeroesRepository
    {

        private readonly IWebHostEnvironment _env;

        public HeroesRepository(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IList<HeroesModel> GetHeroes()
        {

            string jsonFilePath = Path.Combine(_env.WebRootPath, "files/data.json");

            List<HeroesModel> heroes;

            using (StreamReader reader = new StreamReader(jsonFilePath))
            {
                string json = reader.ReadToEnd();
                heroes = JsonSerializer.Deserialize<List<HeroesModel>>(json);

                return heroes;
            }
        }
    }
}
