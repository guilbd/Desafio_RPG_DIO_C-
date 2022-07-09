using rpgDIO.src.Entities;

namespace rpgDIO;
class Program
{
  static void Main(string[] args)
  {
    Knight hero = new Knight("Arus", "Warrior", 20);
    Knight opponent = new Knight("Maleficus", "Mage", 10);
    Wizard wizard = new Wizard("Jenica", "White Wizard", 15);
    Wizard wizard = new Wizard("Topapa", "Black Wizard", 10);
    Ninja ninja = new Ninja("Sasuke", "Ninja", 15);

    Console.WriteLine(hero);
    Console.WriteLine(hero.Attack());
    System.Console.WriteLine(opponent);
    System.Console.WriteLine(wizard.Attack());
    System.Console.WriteLine(wizard.Attack(10));
    System.Console.WriteLine(wizard.Attack(5));
    System.Console.WriteLine(ninja.Attack());
  }
}








