using System.Collections;
using System.Collections.Generic;

namespace SimpleECS.Interfaces
{
    public interface IComponentStorage<T> : IEnumerable<T>, IEnumerable where T : IComponent
    {
        void Add(T component);
        void Remove(T component);
    }
}
