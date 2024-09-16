using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeros.Models
{
    public class Heros
    {
        public string Name { get; set; }
        public string HeroName { get; set; }

        public override string ToString()
        {
            return $"{HeroName} - {Name}";
        }
        public Heros(string name, string heroName)
        {
            Name = name ;
            HeroName = heroName ;
        }
        public Heros()
        {
            
        }
    }
}
