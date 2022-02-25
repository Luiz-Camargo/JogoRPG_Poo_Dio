using System;
using GFT_JogoRPG.src.Entities;

class Program
{
  static void Main(string[] args)
  {
      Knight arus = new Knight("Arus", 23, "Knight");
      Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
      Ninja fodden = new Ninja("Fodden", 50, "Ninja");
      Villain baltazar = new Villain("Baltazar", 100, "Villain");
      
      Console.WriteLine(arus.Attack());
      Console.WriteLine(jennica.Attack(6, "pontos de ataque!"));
      Console.WriteLine(fodden.Attack(10, "pontos de ataque!"));
      Console.WriteLine(baltazar.Attack(4));
  }
}