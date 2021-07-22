using SimpleECS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Factories
{
    public interface IEntityFactory
    {
        public IEntity CreateEntity();
    }
}
