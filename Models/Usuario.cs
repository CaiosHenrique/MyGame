namespace Models
{
    public class Usuario
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public Personagem personagem { get; set; }
    }
}