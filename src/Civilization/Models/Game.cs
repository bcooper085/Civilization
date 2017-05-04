using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Civilization.Models
{
    public class Game
    {
        public string Name { get; set; }
        public string Government { get; set; }
        public string Geography { get; set; }
        public int Id { get; set; }

        public Game(string name, string government, string geography, int id = 0)
        {
            Name = name;
            Government = government;
            Geography = geography;
            Id = id;
        }
    }
}
