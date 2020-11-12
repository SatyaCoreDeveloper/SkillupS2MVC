using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCSharp
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public int Credit { get; set; }
        public string  Name { get; set; }
    }
}
