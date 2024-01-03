using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Game
    {
        private List<Player> players;
        private int rounds;

        public Game(List<Player> players)
        {
            if (players.Count < 2 || players.Count > 8)
            {
                throw new ArgumentException("Number of players must be between 2 and 8.");
            }

            this.players = players.OrderBy(_ => Guid.NewGuid()).ToList(); // Initial random ordering
            this.rounds = 0;
        }

        public void Play()
        {
            for (int i = 0; i < 20; i++)
            {
                foreach (var player in players)
                {
                    int diceRoll = RollDice();
                    player.Move(diceRoll);
                }
                rounds++;
            }
        }

        public int GetTotalRounds()
        {
            return rounds;
        }

        public List<string> GetPlayerOrder()
        {
            return players.Select(player => player.GetName()).ToList();
        }

        private int RollDice()
        {
            // Simulate rolling a six-sided die
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
