using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpgDIO.src.Entities
{
  public class Wizard : Knight
  {
    public Wizard(string name, string heroType, int level) : base(name, heroType, level)
    {
        this.name = name;
        this.heroType = heroType;
        this.level = level;
    }
    public override string Attack()
    {
      return $"{this.name} attacked by casting magic!";
    }

    public string Attack(int bonus){

        if(bonus > 6){
            return $"{this.name} attacked by casting magic with a big bonus of {bonus}!";
        }
        else{
            return $"{this.name} attacked by casting magic with weak force with a bonus of {bonus}!";
        }
        
    }
  }
}