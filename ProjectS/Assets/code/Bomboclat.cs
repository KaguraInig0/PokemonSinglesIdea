using System;

public class Bomboclat : Creatures
{
  private double Defense;
  private double SpAttack;
  private double SpDefense;
  private double Health;
  private double Speed;

  public double getAttack() {return Attack;}
  public double getDefense() {return Defense;}



  static void Main(string[] args)
  {

      Creatures Bomboclat = new Creatures();

      Bomboclat.Attack = 5;
      Bomboclat.Defense = 10;

      double attackValue = Bomboclat.getAttack();
      double defenseValue = Bomboclat.getDefense();


      Console.WriteLine("Attack: " + attackValue);
      Console.WriteLine("Defense: " + defenseValue);



  }


}
