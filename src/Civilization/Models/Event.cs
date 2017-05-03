using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Civilization.Models
{
    [Table("Events")]
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }

        public Event(string name, string description, int id = 0)
        {
            Name = name;
            Description = description;
            Id = id;
        }

        public Event() { }
    }
}
