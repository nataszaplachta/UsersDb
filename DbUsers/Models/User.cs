using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbUsers.Models
{
    public class User
    {
        public int UserId { get; set;
        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public ICollection<Group> Groups { get; set; }

    }
}
