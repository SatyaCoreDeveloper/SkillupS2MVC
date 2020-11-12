using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCSharp
{
    public class Student : IEntity
    {
        public Guid Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Credit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
