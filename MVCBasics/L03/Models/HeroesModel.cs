namespace L03.Models
{
    public class HeroesModel
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public int? Age { get; set; }
        public string? Birthday { get; set; }
        public required string Height { get; set; }
        public required string Image { get; set; }
        public  bool Alive { get; set; }
    }
}
