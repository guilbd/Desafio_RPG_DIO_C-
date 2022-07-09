namespace rpgDIO.src.Entities;

public abstract class Hero
{

  public Hero(string name, string heroType, int level)
  {
    this.name = name;
    this.heroType = heroType;
    this.level = level;
  }
  

  public string name;

  public int level;

  public string heroType;

  public override string ToString()
  {
    return $"{this.name} is a {this.heroType} level {this.level}";
  }

  public virtual string Attack()
  {
    return $"{this.name} attacks with a sword!";
  }
}
