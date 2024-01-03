using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Player
    {
        private string name;
        private int position;

        public Player(string name)
        {
            this.name = name;
            this.position = 0; // Initial position
        }

        public void Move(int spaces)
        {
            position = (position + spaces) % 40; // Modulo 40 to wrap around the board
        }

        public string GetName()
        {
            return name;
        }
    }
}
