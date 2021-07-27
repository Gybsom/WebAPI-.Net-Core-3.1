using System;
using System.Collections.Generic;

#nullable disable

namespace ApiTesteSigna.Models
{
    public partial class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; }
    }
}
