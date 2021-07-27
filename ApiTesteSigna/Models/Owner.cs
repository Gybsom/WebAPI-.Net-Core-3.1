using System;
using System.Collections.Generic;

#nullable disable

namespace ApiTesteSigna.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Cats = new HashSet<Cat>();
            Dogs = new HashSet<Dog>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Cat> Cats { get; set; }
        public virtual ICollection<Dog> Dogs { get; set; }
    }
}
