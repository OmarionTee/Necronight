using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Necronight
{
    internal class Heart
    {
        
        public int CurrentHealth;
        public int MaxHealth;

        public Heart(int maxHealth) // Constructor that initializes the Max and Current health values to the provided maxHealth parameter
        {
            MaxHealth = maxHealth; // Sets the Max property to the value of maxHealth
            CurrentHealth = maxHealth; // Sets the Current property to the value of maxHealth, meaning the player starts with full health
        }

        public void TakeDamage(int amount) // Method that reduces the Current health by the specified amount of damage
        {
            CurrentHealth -= amount; // Subtracts the amount of damage from the Current health
            if (CurrentHealth < 0)
                CurrentHealth = 0;
        }

        public void Heal(int amount) // Method that increases the Current health by the specified amount of healing
        {
            CurrentHealth += amount; // Adds the amount of healing to the Current health
            if (CurrentHealth > MaxHealth)
                CurrentHealth = MaxHealth;
        }

        public bool IsDead()
        {
            return CurrentHealth <= 0; // Returns true if the Current health is less than or equal to 0, indicating that the player is dead
        }

    }
}
