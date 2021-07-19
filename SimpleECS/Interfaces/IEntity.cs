using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Interfaces
{
    public interface IEntity
    {
        public int ID { get; set; }

        public ICollection<IComponent> Components { get; set; }
    }
}
