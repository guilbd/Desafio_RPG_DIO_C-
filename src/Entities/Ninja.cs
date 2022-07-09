using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpgDIO.src.Entities
{
    public class Ninja : Knight
    {
        public Ninja(string name, string heroType, int level) : base(name, heroType, level)
        {
            this.name = name;
            this.heroType = heroType;
            this.level = level;
        }
        public override string Attack()
        {
            return $"{this.name} attacked by throwing a knife!";
        }
    }
}