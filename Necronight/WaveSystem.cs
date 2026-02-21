using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necronight
{
    internal class WaveSystem
    {

        public int WaveNumber = 1;
        public int Kills = 0;
        public int KillsToEnd = 15;
        public bool WaveCooldown = false;

        private DateTime cooldownEndTime;

        public void KillCounter() // Method to be called whenever a zombie is killed to increment the kill count and check if the wave should end
        {
            if (WaveCooldown) return;

            Kills++;

            if (Kills >= KillsToEnd)
            {
                StartCooldown();
            }
        }

        private void StartCooldown() // Start the cooldown to 15 seconds after a wave ends, during which no new zombies will spawn and the player can prepare for the next wave
        {
            WaveCooldown = true;
            cooldownEndTime = DateTime.Now.AddSeconds(15);
        }

        public void Update() // Update method to be called in the game loop to check if the cooldown has ended and start the next wave
        {
            if (WaveCooldown && DateTime.Now >= cooldownEndTime)
            {
                WaveNumber++;
                Kills = 0;
                WaveCooldown = false;
            }
        }
    }

}