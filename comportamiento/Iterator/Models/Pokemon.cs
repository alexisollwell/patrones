namespace Iterator.Models
{
    public class Pokemon
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;

        public string GetPokemonInfo()
        {
            return $"{Name.ToUpper()} ({Url})";
        }
    }
}
