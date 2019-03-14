using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbUsers.Models
{
    public class User
    {
        public int Id { get; set;
        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public Group Group { get; set; }

    }
}
