using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace T_TemporisV
{ public class Level
    {
        private int level;
        private List<int> cardIds = new List<int>();

        public List<int> CardIds
        {
            get => cardIds;
            set => cardIds = value;
        }

        public int value
        {
            get => level;
            set => level = value;
        }

        public Level(int level)
        {
            this.level = level;
        }

        public override string ToString()
        {
            return "Level: " + level.ToString() + ", [" + String.Join(", ", cardIds) + "]";
        }
    }
}