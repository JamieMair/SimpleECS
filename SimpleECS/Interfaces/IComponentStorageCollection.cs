using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleECS.Interfaces
{
    public interface IComponentStorageCollection
    {
        public IComponentStorage<T> GetStorage<T>() where T : IComponent;
        public void AddStorage<T>(IComponentStorage<T> storage) where T : IComponent;
    }
}
