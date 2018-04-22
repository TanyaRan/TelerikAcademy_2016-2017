using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperGame
{
    public class Ranking
    {
        private string name;
        private int points;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                this.points = value;
            }
        }

        public Ranking()
        {
        }

        public Ranking(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }
    }
}
