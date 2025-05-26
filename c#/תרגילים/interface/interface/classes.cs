using System;
using System.Net.Security;

public class BattleRobot : IPowerable , IMovable ,IAttackable
{
   public bool IsOn { get; set; }
   public void TurnOn() { IsOn = true; }
   public void TurnOff() { IsOn = false; }

   public void MoveTo(string location) { Console.WriteLine($"move to {location}"); }

   public int Health { get; set; }
   public void TakeDamage(int amount) {  Health -= amount; }
   public void Heal(int amount) {Health += amount; }
}


