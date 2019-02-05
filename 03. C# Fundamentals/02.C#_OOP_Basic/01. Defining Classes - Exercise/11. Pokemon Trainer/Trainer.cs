using System.Collections.Generic;

namespace _11._Pokemon_Trainer
{
    public class Trainer
    {
        private int id;
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(int id)
        {
            this.Id = id;
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
